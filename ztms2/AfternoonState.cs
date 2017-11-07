using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ztms2
{
    class AfternoonState : State
    {
        public override void WriteProgram(Work work)
        {
            if(work.Hour<17)
            {
                Console.WriteLine("当前时间：{0}点，下午状态还不错，继续努力。",work.Hour);
            }
            else
            {
                work.SetState(new EveningState());
                work.WriteProgram();
            }
        }
    }
}
