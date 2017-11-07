using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zzlms1
{
    class GeneralManager : Manager
    {
        public GeneralManager(string name) : base(name)
        {
        }

        public override void RequestApplications(Request req)
        {
            if (req.RequestType == "请假")
            {
                Console.WriteLine("{0}:{1} 数量{2}被批准！", name, req.RequestContent, req.Number);
            }
            else if(req.RequestType == "加薪"&&req.Number<=5000)
            {
                Console.WriteLine("{0}:{1} 数量{2}被批准！", name, req.RequestContent, req.Number);

            }
            else if (req.RequestType == "加薪" && req.Number > 5000)
            {
                Console.WriteLine("{0}:{1} 数量{2}再说吧！", name, req.RequestContent, req.Number);

            }
        }
    }
}
