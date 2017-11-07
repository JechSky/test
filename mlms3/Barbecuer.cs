using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mlms3
{
    class Barbecuer//命令接收者
    {
        public void BakeMutton()
        {
            Console.WriteLine("烤肉串！");
        }
        public void BakeChickenWing()
        {
            Console.WriteLine("烤鸡翅！");
        }

    }
}
