using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zjzms
{
    class ConcreteMediator : Mediator
    {
        ConcreteColleague1 col1;
        ConcreteColleague2 col2;

        public ConcreteColleague1 Col1 { set { col1 = value; } }
        public ConcreteColleague2 Col2 { set { col2 = value; } }

        public override void Send(string msg, Colleague col)
        {
            if (col1 == col)
            {
                col2.Notify(msg);
            }
            else
            {
                col1.Notify(msg);
            }
        }
    }
}
