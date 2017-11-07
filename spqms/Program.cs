using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spqms
{
    class Program
    {
        static void Main(string[] args)
        {
            Player f = new Forwards("巴蒂尔");
            f.Attack();

            Player g = new Guards("麦克格雷迪");
            g.Attack();

            Player p = new Translator("姚明");
            p.Attack();
            p.Defense();

        }
    }
}
