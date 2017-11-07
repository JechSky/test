using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gczms
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubject subject = new ConcreteSubject();

            ConcreteObserver obs1 = new ConcreteObserver(subject, "name1");
            Console.WriteLine(obs1.State);

            ConcreteObserver obs2 = new ConcreteObserver(subject, "name2");
            Console.WriteLine(obs2.State);

            Concrete1Observer obs3 = new Concrete1Observer(subject);
            Console.WriteLine(obs3.State);

            subject.Attach(obs1);
            subject.Attach(obs2);
            subject.Attach(obs3);

            Console.WriteLine("update state");
            subject.SubjectState = "dd";

            subject.Notify();

        }
    }
}
