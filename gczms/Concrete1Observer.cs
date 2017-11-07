using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gczms
{
    class Concrete1Observer : Observer
    {
        ConcreteSubject subject;
        public override string State { get; set; }

        public Concrete1Observer(ConcreteSubject subject)
        {
            this.subject = subject;
            State = "obs1做自己的事情";
        }
        public override void Update()
        {
            State = subject.SubjectState;
            Console.WriteLine("新状态：" + State);
        }
    }
}
