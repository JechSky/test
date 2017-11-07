using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zzlms
{
    //经理
    class CommonManager : Manager
    {
        public CommonManager(string name) : base(name)
        {
        }

        public override void RequestApplications(Request request)
        {
            if(request.RequestType.Equals("请假")&&request.Number<=2)
            {
                Console.WriteLine("{0}:{1} 数量：{2}被批准", name, request.RequestContent, request.Number);
            }
            else
            {
                if(supperior!=null)
                {
                    supperior.RequestApplications(request);
                }
            }

        }
    }
}
