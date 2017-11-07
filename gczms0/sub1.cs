using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gczms0
{
    class sub1 : Subject
    {
        List<Observer> list = new List<Observer>();

        public override string State { get; set; }

        public override void AmiAt(Observer obs)
        {
            list.Add(obs);
        }

        public void ShowObsState()
        {
            foreach (Observer item in list)
            {
                Console.WriteLine(item.State);
            }
        }

        public void Notify()
        {
            foreach (Observer item in list)
            {
                item.Response();
            }
        }

    }
}
