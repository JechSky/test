using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zzlms1
{
    class Program
    {
        static void Main(string[] args)
        {
            CommonManager jinli = new CommonManager("jinli");
            Majordomo zongjian = new Majordomo("zongjian");
            GeneralManager zongjingli = new GeneralManager("zongjingli");
            jinli.SetSuperior(zongjian);
            zongjian.SetSuperior(zongjingli);

            Request req = new Request()
            {
                RequestType = "请假",
                RequestContent = "不舒服要请假",
                Number=1
            };
            jinli.RequestApplications(req);

            req = new Request()
            {
                RequestType = "请假",
                RequestContent = "不舒服要请假",
                Number = 10
            };
            jinli.RequestApplications(req);

            req = new Request()
            {
                RequestType = "加薪",
                RequestContent = "工资太低要加薪",
                Number = 5000
            };
            zongjingli.RequestApplications(req);

            req = new Request()
            {
                RequestType = "加薪",
                RequestContent = "工资太低要加薪",
                Number = 10000
            };
            jinli.RequestApplications(req);


        }
    }
}
