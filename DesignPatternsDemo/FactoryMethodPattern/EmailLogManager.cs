using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsDemo.FactoryMethodPattern
{
    public class EmailLogManager:ILogger
    {
        public string Log(string message)
        {
            message = "Email loglama işlemi: " + message;

            return message;
        }
    }
}
