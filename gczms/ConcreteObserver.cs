using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gczms
{
    class ConcreteObserver : Observer
    {
        string name; 
        ConcreteSubject subject;
        public override string State { get; set; }

        public ConcreteObserver(ConcreteSubject subject,string name)
        {
            this.subject = subject;
            this.name = name;
            this.State = name + "做自己的事情";
        }
       
        public override void Update()
        {
            State = subject.SubjectState;
            Console.WriteLine("观察者{0}的新状态{1}", name, State);
        }

        //public ConcreteSubject Subject { get { return subject; } set { subject = value; } }

    }
}
