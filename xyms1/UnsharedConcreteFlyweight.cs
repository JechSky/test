using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xyms1
{
    //不共享的Flyweight
    class UnsharedConcreteFlyweight : Flyweight
    { 
        public override void Use()
        {
            Console.WriteLine("不共享的Flyweight");
        }
    }
}
