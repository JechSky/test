using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ztms2
{
    class EveningState : State
    {
        public override void WriteProgram(Work work)
        {
            if(work.TaskFinished)
            {
                work.SetState(new RestState());
                work.WriteProgram();
            }
            else
            {
                if(work.Hour<21)
                {
                    Console.WriteLine("当前时间：{0}点，加班哦，疲累之极。",work.Hour);
                }
                else
                {
                    work.SetState(new SleepingState());
                    work.WriteProgram();
                }
            }
        }
    }
}
