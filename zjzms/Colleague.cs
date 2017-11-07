using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zjzms
{
    abstract class Colleague
    {
        protected Mediator mediator;
        public Colleague(Mediator med)
        {
            this.mediator = med;
        }
        public abstract void Send(string msg);
        public abstract void Notify(string msg);
    }
}
