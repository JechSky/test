using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mlms1
{
    class Program
    {
        static void Main(string[] args)
        {
            //开店前的准备
            Barbecuer person = new Barbecuer();
            Command bakeMuttonCommand1 = new BakeMuttonCommand(person);
            Command bakeMuttonCommand2 = new BakeMuttonCommand(person);
            Command bakeChickenWingCommand1 = new BakeChickenWingCommand(person);
            Waiter waiter = new Waiter();

            //开门营业
            waiter.SetOrder(bakeMuttonCommand1);
            waiter.Notify();
            waiter.SetOrder(bakeMuttonCommand2);
            waiter.Notify();
            waiter.SetOrder(bakeChickenWingCommand1);
            waiter.Notify();

        }
    }
}
