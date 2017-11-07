using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ddqms
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggregate aggres = new ConcreteAggregate();
            aggres[0] = "dd";
            aggres[1] = "aa";
            aggres[2] = "cc";

            Iterator it = new ConcreteIterator(aggres);
            while (!it.IsDone())
            {
                Console.WriteLine(it.CurrentItem());
                it.Next();
            }

        }
    }
}
