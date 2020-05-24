using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsDemo.DILifeCycle
{
    public interface ISingletonService
    {
        Guid GetID();
    }
}
