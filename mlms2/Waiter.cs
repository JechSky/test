using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mlms2
{
    class Waiter
    {
        //增加存放具体命令的容器
        IList<Command> orders = new List<Command>();

        //设置订单
        public void SetOrder(Command command)
        {
            if(command.ToString()== "mlms2.BakeChickenWingCommand")
            {
                Console.WriteLine("服务员：鸡翅没有了，请点别的烧烤。");
            }
            else
            {
                orders.Add(command);
                Console.WriteLine("增加订单：" + command.ToString() + " 时间：" + DateTime.Now.ToString());
            }
        }

        //取消订单
        public void CancelOrder(Command command)
        {
            orders.Remove(command);
            Console.WriteLine("取消订单：" + command.ToString() + " 时间：" + DateTime.Now.ToString());
        }

        //通知全部执行
        public void Notify()
        {
            foreach (Command item in orders)
            {
                item.ExcuteCommand();
            }
        }

    }
}
