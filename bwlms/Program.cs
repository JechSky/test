using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bwlms
{
    class Program
    {
        static void Main(string[] args)
        {

            Originator o = new Originator();
            o.State = "On";
            o.State = "On1";
            o.Show();

            Caretaker c = new Caretaker();
            c.Memento = o.CreateMemento();
            o.State = "Off";
            o.State = "Off1";
            o.Show();

            o.SetMemento(c.Memento);
            o.Show();

        }
    }
}
