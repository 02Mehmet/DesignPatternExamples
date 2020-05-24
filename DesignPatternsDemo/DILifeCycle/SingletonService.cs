using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsDemo.DILifeCycle
{
    public class SingletonService : ISingletonService
    {
        Guid id;
        public SingletonService()
        {
            id = Guid.NewGuid();
        }

        public Guid GetID()
        {
            return id;
        }
    }
}
