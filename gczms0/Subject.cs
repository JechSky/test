using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gczms0
{
    abstract class Subject
    {
        public abstract string State { get; set; }
        public abstract void AmiAt(Observer obs);
    }
}
