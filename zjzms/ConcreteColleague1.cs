﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zjzms
{
    class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(Mediator med) : base(med)
        {
        }
        public override void Send(string msg)
        {
            mediator.Send(msg, this);
        }
        public override void Notify(string msg)
        {
            Console.WriteLine("col1得到的消息：" + msg);
        }

    }
}
