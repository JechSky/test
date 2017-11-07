using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ztms2
{
    class Work
    {
        State current;
        public Work()
        {
            //工作初始化为上午工作状态，即上午9点开始上班。
            current = new ForenoonState();
        }

        public double Hour { get; set; }

        public bool TaskFinished { get; set; }

        public void SetState (State s)
        {
            current = s;
        }

        public void WriteProgram()
        {
            current.WriteProgram(this);
        }

    }
}
