using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mlms1
{
    //服务员
    public class Waiter
    {
        Command command;
        //设置订单
        //服务员类，不用管用户想要什么烤肉，反正都是‘命令’，只管记录订单，然后通知‘烤肉串者’执行即可。
        public void SetOrder(Command command)
        {
            this.command = command;
        }

        //通知执行
        public void Notify()
        {
            command.ExcuteCommand();
        }

    }
}
