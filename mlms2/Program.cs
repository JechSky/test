using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mlms2
{
    class Program
    {
        static void Main(string[] args)
        {
            //开店前的准备
            Barbecuer person = new Barbecuer();
            Command cmd1 = new BakeMuttonCommand(person);
            Command cmd2 = new BakeMuttonCommand(person);
            Command cmd3 = new BakeChickenWingCommand(person);
            Waiter waiter = new Waiter();

            //开门营业 顾客点菜
            waiter.SetOrder(cmd1);
            waiter.SetOrder(cmd2);
            waiter.SetOrder(cmd3);

            //点菜完毕，通知厨房
            waiter.Notify();

        }
    }
}
