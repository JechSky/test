using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ztms
{
    class Context
    {
        State state;
        //定义Context的初始状态
        public Context(State state)
        {
            this.state = state;
        }
        //可读写的状态属性，用于读取当前状态和设置新状态。
        public State State
        {
            get { return state; }
            set
            {
                state = value;
                Console.WriteLine("切换的状态："+state.GetType().Name);
            }
        }
        //对请求做处理，并设置下一状态。
        public void Request()
        {
            state.Handle(this);
        }

    }
}
