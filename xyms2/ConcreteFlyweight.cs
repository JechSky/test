using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xyms2
{
    class ConcreteFlyweight : Flyweight
    {
        public override void Operation(int ex)
        {
            Console.WriteLine("具体Flyweight：" + ex);
        }
    }
}
