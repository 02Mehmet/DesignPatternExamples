using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsDemo.SingletonPattern
{
    public class SingletonPatternService : ISingletonPatternService
    {
        public static int creationCount = 0;

        public static readonly SingletonPatternService _mySingletonServiceInstance = new SingletonPatternService();

        public SingletonPatternService()
        {
            creationCount++;
        }

        //public static SingletonPatternService GetInstance() => _mySingletonServiceInstance;

        public int GetCreationCount() => creationCount;
    }
}
