using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zzlms
{
    class Program
    {
        static void Main(string[] args)
        {
            CommonManager jinli = new CommonManager("jinli");
            Majordomo zongjian = new Majordomo("zongjian");
            GeneralManager zhongjingli = new GeneralManager("zongjingli");

            jinli.SetSuperlior(zongjian);
            zongjian.SetSuperlior(zhongjingli);

            Request req = new Request()
            {
                RequestType = "请假",
                RequestContent = "小菜请假",
                Number = 1
            };
            jinli.RequestApplications(req);
            
            req = new Request()
            {
                RequestType = "请假",
                RequestContent = "小菜请假",
                Number =10
            };
            jinli.RequestApplications(req);

            req = new Request()
            {
                RequestType = "请假",
                RequestContent = "小菜请假",
                Number = 3
            };
            jinli.RequestApplications(req);

            req = new Request()
            {
                RequestType = "加薪",
                RequestContent = "小菜请求加薪",
                Number = 5000
            };
            jinli.RequestApplications(req);

            req = new Request()
            {
                RequestType = "加薪",
                RequestContent = "小菜请求加薪",
                Number = 10000
            };
            jinli.RequestApplications(req);

        }
    }
}
