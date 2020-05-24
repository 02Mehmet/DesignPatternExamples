using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsDemo.FactoryMethodPattern
{
    public enum LoggerType
    {
        None = 0,
        DatabaseLogger = 1,
        FileLogger = 2,
        EmailLogger = 3
    }
}
