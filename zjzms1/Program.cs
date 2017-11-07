using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zjzms1
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitedNationsSecurityCouncil unsc = new UnitedNationsSecurityCouncil();
            USA c1 = new USA(unsc);
            Iraq c2 = new Iraq(unsc);
            unsc.Col1 = c1;
            unsc.Col2 = c2;

            c1.Declare("不准研制核武器，否则要发动战争！");
            c2.Declare("我们没有核武器，也不怕侵略！");

        }
    }
}
