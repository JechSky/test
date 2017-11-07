using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gczms0
{
    class obs1 : Observer
    {
        public override string State { get; set; }
        string name;
        Subject sub;
        public obs1(Subject sub, string name)
        {
            this.sub = sub;
            this.name = name;
            State = name + "obs1做自己的事情";
            sub.AmiAt(this);
        }

        public override void Response()
        {
            State = sub.State;
            Console.WriteLine(name + "obs1新状态：" + State);
        }
    }
}
