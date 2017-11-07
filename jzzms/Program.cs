using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jzzms
{
    class Program
    {
        static void Main(string[] args)
        {
            Director dir = new Director();
            Builder b1 = new ConcreteBuilder1();
            ConcreteBuilder2 b2 = new ConcreteBuilder2();

            dir.Construct(b1);
            b1.GetResult().Show();

            b2.BuilderPartC();
            dir.Construct(b2);
            b2.GetResult().Show();

        }
    }
}
