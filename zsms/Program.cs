using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zsms
{
    class Program
    {
        static void Main(string[] args)
        {
            Person per = new Person("jingjing");

            TShirts ts = new TShirts();
            BigTrouser bt = new BigTrouser();

            ts.setComponent(per);
            bt.setComponent(ts);
            bt.Show();

        }
    }
}
