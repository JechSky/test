using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ztms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("当前状态ConcreteStateA");
            Context c = new Context(new ConcreteStateA());
            c.Request();
            c.Request();
            c.Request();

        }
    }
}
