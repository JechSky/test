using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zjzms
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator me = new ConcreteMediator();

            ConcreteColleague1 col1 = new ConcreteColleague1(me);
            ConcreteColleague2 col2 = new ConcreteColleague2(me);
            me.Col1 = col1;
            me.Col2 = col2;

            col1.Send("dd");
            col2.Send("dda");

        }
    }
}
