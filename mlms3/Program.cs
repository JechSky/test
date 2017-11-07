using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mlms3
{
    class Program
    {
        static void Main(string[] args)
        {
            Barbecuer b = new Barbecuer();//命令接收者
            Command cmd1 = new BakeMuttonCommand(b);
            Command cmd2 = new BakeMuttonCommand(b);
            Command cmd3 = new BakeChickenWingCommand(b);

            Waiter w = new Waiter();
            w.SetOrder(cmd1);
            w.SetOrder(cmd2);
            w.SetOrder(cmd3);
            Console.WriteLine("点菜完毕，通知执行！");
            w.Notify();

        }
    }
}
