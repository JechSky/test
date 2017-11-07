using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gczms1
{
    class Program
    {
        static void Main(string[] args)
        {
            sub1 s = new sub1();

            obs1 o1 = new obs1(s);
            obs2 o2 = new obs2(s, "name1");
            obs2 o3 = new obs2(s, "name2");
            
            s.Notify();

        }
    }
}
