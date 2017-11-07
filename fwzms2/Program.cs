using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fwzms2
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectStructure os = new ObjectStructure();
            os.Attach(new ConcreteElementA());
            os.Attach(new ConcreteElementB());

            ConcreteVisitor v1 = new ConcreteVisitor(); ;
            ConcreteVisitor2 v2 = new ConcreteVisitor2();

            os.Accept(v1);
            os.Accept(v2);

        }
    }
}
