using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gczms
{
    abstract class Subject
    {
        IList<Observer> observers = new List<Observer>();
        public void Attach(Observer obs)
        {
            observers.Add(obs);
        }
        public void Detach(Observer obs)
        {
            observers.Remove(obs);
        }
        public void Notify()
        {
            foreach (Observer item in observers)
            {
                item.Update();
            }
        }

    }
}
