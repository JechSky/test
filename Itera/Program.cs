using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itera
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggregate a = new ConcreteAggregate();
            a[0] = "ss";
            a[1] = "dd";

            Iterator i =a.CreateIterator();
            while (!i.IsDone())
            {
                Console.WriteLine(i.CurrentItem());
                i.Next();
            }
            Console.WriteLine("倒序：");
            //ConcreteIteratorDesc ides = new ConcreteIteratorDesc(a);
            Iterator ides = a.CreateIteratorDesc();
            while (!ides.IsDone())
            {
                Console.WriteLine(ides.CurrentItem());
                ides.Next();
            }
            

        }
    }
}
