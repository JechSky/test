using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spqms2
{
    class Program
    {
        static void Main(string[] args)
        {
            new Forwards(" ForwardsName").Attack();
            new Center(" CenterName").Attack();

            Player p = new Translator(" ForeignCenterName");
            p.Attack();
            p.Defense();

        }
    }
}
