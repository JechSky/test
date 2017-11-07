using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mlms
{
    //要求该命令执行这个请求
    class Invoker
    {
        Command command;
        public void SetCommand(Command command)
        {
            this.command = command;
        }
        
        public void ExecuteCommand()
        {
            command.Execute();
        }

    }
}
