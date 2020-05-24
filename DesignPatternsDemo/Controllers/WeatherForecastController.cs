using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatternsDemo.DILifeCycle;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DesignPatternsDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public IScopedService _scopedService1;
        public WeatherForecastController(IScopedService scopedService1)
        {
            _scopedService1=scopedService1;
        }
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        public WeatherForecastController()
        {
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }


        public string GetID()
        {
             return _scopedService1.GetID().ToString();
        }
    }
}
