using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zzlms
{
    //总经理
    class GeneralManager : Manager
    {
        public GeneralManager(string name) : base(name)
        {
        }

        public override void RequestApplications(Request request)
        {
            if(request.RequestType.Equals("请假"))
            {
                Console.WriteLine("{0}：{1} 数量{2}被批准", name, request.RequestContent, request.Number);
            }
            else if(request.RequestType.Equals("加薪")&&request.Number<=5000)
            {
                Console.WriteLine("{0}：{1} 数量{2}被批准", name, request.RequestContent, request.Number);
            }
            else if(request.RequestType.Equals("加薪")&&request.Number>5000)
            {
                Console.WriteLine("{0}：{1} 数量{2}再说吧", name, request.RequestContent, request.Number);
            }
        }
    }
}
