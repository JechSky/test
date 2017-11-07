using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fwzms
{
    class ConcreteVisitor2 : Visitor
    {
        public override void VisitConcreteElementA(ConcreteElementA element)
        {
            Console.WriteLine("{0}被{1}访问", element.GetType().Name, this.GetType().Name);
        }

        public override void VisitConcreteElementB(ConcreteElementB element)
        {
            Console.WriteLine("{0}被{1}访问", element.GetType().Name, this.GetType().Name);
        }
    }
}
