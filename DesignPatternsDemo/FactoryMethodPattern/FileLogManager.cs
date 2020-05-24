using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsDemo.FactoryMethodPattern
{
    public class FileLogManager:ILogger
    {
        public string Log(string message)
        {
            message = "File loglama işlemi: " + message;

            return message;
        }
    }
}
