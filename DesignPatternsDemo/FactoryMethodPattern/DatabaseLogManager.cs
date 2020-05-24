using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsDemo.FactoryMethodPattern
{
    public class DatabaseLogManager : ILogger
    {
        public string Log(string message)
        {
            message = "Database loglama işlemi: " + message;

            return message;
        }
    }
}
