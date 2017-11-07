using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ztms2
{
    class ForenoonState : State
    {
        public override void WriteProgram(Work work)
        {
            if(work.Hour<12)
            {
                Console.WriteLine("当前时间：{0}点 上午工作精神百倍",work.Hour);
            }
            else
            {
                work.SetState(new NoonState());
                work.WriteProgram();
            }
            
        }
    }
}
