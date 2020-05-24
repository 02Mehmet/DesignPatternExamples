using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsDemo.DILifeCycle
{
    public class ScopedService : IScopedService
    {
        Guid id;
        public ScopedService()
        {
            id = Guid.NewGuid();
        }

        public Guid GetID()
        {
            return id;
        }
    }
}
