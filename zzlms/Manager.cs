using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zzlms
{
    //管理者
    abstract class Manager
    {
        protected string name;
        //管理者的上级
        protected Manager supperior;

        public Manager(string name)
        {
            this.name = name;
        }
        //设置管理者的上级
        public void SetSuperlior(Manager manager)
        {
            this.supperior = manager;
        }
        //申请请求
        public abstract void RequestApplications(Request request);

    }
}
