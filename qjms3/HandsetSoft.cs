using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qjms3
{
    abstract class HandsetSoft
    {
        public virtual void Run(HandsetBrand hb)
        {
            Console.Write(hb.GetType().Name+"：");
        }
    }
}
