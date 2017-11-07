using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gczms
{
    abstract class Observer
    {
        public abstract string State { get; set; }
        public abstract void Update();
    }
}
