using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fwzms1
{
    abstract class Action
    {
        public abstract void GetManConclusion(Man element);
        public abstract void GetWomanConclusion(Woman element);
    }
}
