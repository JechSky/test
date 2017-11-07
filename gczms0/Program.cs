using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gczms0
{
    class Program
    {
        static void Main(string[] args)
        {
            sub1 s = new sub1();
            obs1 o1 = new obs1(s,"name1");
            obs2 o2 = new obs2(s);
            obs1 o3 = new obs1(s, "name3");

            s.ShowObsState();
            Console.WriteLine("\n update state \n");
            s.State = "new state";
            s.Notify();

        }
    }
}
