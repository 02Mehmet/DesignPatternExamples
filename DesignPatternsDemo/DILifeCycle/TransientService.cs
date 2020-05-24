using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsDemo.DILifeCycle
{
    public class TransientService : ITransientService
    {
        Guid id;
        public TransientService()
        {
            id = Guid.NewGuid();
        }

        public Guid GetID()
        {
            return id;
        }
    }
}
