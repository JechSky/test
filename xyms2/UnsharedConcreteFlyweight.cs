using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xyms2
{
    class UnsharedConcreteFlyweight : Flyweight
    {
        public override void Operation(int ex)
        {
            Console.WriteLine("不共享的具体Flyweight：" + ex);
        }
    }
}
