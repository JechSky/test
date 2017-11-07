using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xyms2
{
    class Program
    {
        static void Main(string[] args)
        {
            int ex = 10;

            FlyweightFactory f = new FlyweightFactory();
            Flyweight fx = f.GetFlyweight("x");
            fx.Operation(--ex);

            Flyweight fy = f.GetFlyweight("y");
            fy.Operation(--ex);

            UnsharedConcreteFlyweight uf = new UnsharedConcreteFlyweight();
            uf.Operation(ex);



        }
    }
}
