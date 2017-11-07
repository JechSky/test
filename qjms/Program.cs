using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qjms
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction ab = new RefinedAbstraction();
            ab.SetImpementor(new ConcreteImplementorA());
            ab.Operation();

            ab.SetImpementor(new ConcreteImplementorB());
            ab.Operation();

        }
    }
}
