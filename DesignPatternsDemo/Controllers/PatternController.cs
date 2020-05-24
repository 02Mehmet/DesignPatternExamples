using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatternsDemo.DILifeCycle;
using DesignPatternsDemo.FactoryMethodPattern;
using DesignPatternsDemo.SingletonPattern;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatternsDemo.Controllers {
    [Route ("api/v1/pattern")]
    [ApiController]
    public class PatternController : ControllerBase {
        public ITransientService _transientService1;
        public ITransientService _transientService2;

        public IScopedService _scopedService1;
        public IScopedService _scopedService2;

        public ISingletonService _singletonService1;
        public ISingletonService _singletonService2;

        public ISingletonPatternService _singletonPatternService1;
        public ISingletonPatternService _singletonPatternService2;
        public ISingletonPatternService _singletonPatternService3;
        public ISingletonPatternService _singletonPatternService4;

        public PatternController (ITransientService transientService1, ITransientService transientService2,
            IScopedService scopedService1, IScopedService scopedService2,
            ISingletonService singletonService1, ISingletonService singletonService2,
            ISingletonPatternService singletonPatternService1, ISingletonPatternService singletonPatternService2, ISingletonPatternService singletonPatternService3, ISingletonPatternService singletonPatternService4) {
            _transientService1 = transientService1;
            _transientService2 = transientService2;

            _scopedService1 = scopedService1;
            _scopedService2 = scopedService2;

            _singletonService1 = singletonService1;
            _singletonService2 = singletonService2;

            _singletonPatternService1 = singletonPatternService1;
            _singletonPatternService2 = singletonPatternService2;
            _singletonPatternService3 = singletonPatternService3;
            _singletonPatternService4 = singletonPatternService4;
        }

        [HttpGet]
        [Route ("transient")]
        public Result Transient () {

            return new Result () {
                instance1 = _transientService1.GetID ().ToString (),
                    instance2 = _transientService1.GetID ().ToString (),
                    isEqual = _transientService1 == _transientService2,
                    methodName = "Transient"
            };
        }

        [HttpGet]
        [Route ("scoped")]
        public Result Scoped () {
            return new Result () {
                instance1 = _scopedService1.GetID ().ToString (),
                    instance2 = GetScope (),
                    isEqual = _scopedService1 == _scopedService2,
                    methodName = "Scoped"
            };
        }

        public string GetScope () {
            return _scopedService2.GetID ().ToString ();
        }

        [HttpGet]
        [Route ("singleton")]
        public Result Singleton () {
            return new Result () {
                instance1 = _singletonService1.GetID ().ToString (),
                    instance2 = _singletonService2.GetID ().ToString (),
                    isEqual = _singletonService1 == _singletonService2,
                    methodName = "Singleton"
            };
        }

        [HttpGet]
        [Route ("singletonpattern")]
        public Result SingletonPatter () {
            return new Result () {
                instance1 = _singletonPatternService1.GetCreationCount ().ToString (),
                instance2 = _singletonPatternService2.GetCreationCount ().ToString (),                  
                isEqual = _singletonPatternService1 == _singletonPatternService2,
                methodName = "SingletonPattern"
            };
        }

        [HttpGet]
        [Route ("factorymethodnpattern")]
        public string FactoryMethodPattern () {
            ILogger logger = new LoggerFactory ().FactoryMethod (LoggerType.FileLogger);

            return logger.Log ("system format exception");

        }

        [HttpGet]
        [Route ("test")]
        public int Test () {
            var a = 5;
            return a;
        }
    }
}