using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsDemo.FactoryMethodPattern
{
    public class LoggerFactory:ILoggerFactory
    {
        public ILogger FactoryMethod(LoggerType loggerType)
        {
            switch (loggerType)
            {
                case LoggerType.DatabaseLogger:
                    return new DatabaseLogManager();
                case LoggerType.FileLogger:
                    return new FileLogManager();
                case LoggerType.EmailLogger:
                    return new EmailLogManager();
                default:
                    break;
            }
            return null;
        }
    }
}
