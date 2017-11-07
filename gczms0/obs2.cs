using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gczms0
{
    class obs2 : Observer
    {
        public override string State { get; set; }
        Subject sub;

        public obs2(Subject sub)
        {
            this.sub = sub;
            State = "obs2做自己的事情";
            sub.AmiAt(this);
        }

        public override void Response()
        {
            State = sub.State;
            Console.WriteLine("obs2新状态："+ State);
        }
    }
}
