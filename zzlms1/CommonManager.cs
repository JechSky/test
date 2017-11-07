using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zzlms1
{
    class CommonManager : Manager
    {
        public CommonManager(string name) : base(name)
        {
        }

        public override void RequestApplications(Request req)
        {
            if(req.RequestType=="请假"&&req.Number<2)
            {
                Console.WriteLine("{0}:{1} 数量{2}被批准！",name,req.RequestContent,req.Number);
            }
            else
            {
                if(superior!=null)
                {
                    superior.RequestApplications(req);
                }
            }
        }
    }
}
