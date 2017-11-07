using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mlms3
{
    class Waiter
    {
        IList<Command> cmds = new List<Command>();
        public void SetOrder(Command cmd)
        {
            cmds.Add(cmd);
            Console.WriteLine("增加订单：" + cmd.ToString() + " 时间：" + DateTime.Now.ToString());
        }

        public void CancelOrder(Command cmd)
        {
            cmds.Remove(cmd);
            Console.WriteLine("取消订单：" + cmd.ToString() + " 时间：" + DateTime.Now.ToString());
        }

        public void Notify()
        {
            foreach (Command item in cmds)
            {
                item.ExcuteCommand();
            }
        }

    }
}
