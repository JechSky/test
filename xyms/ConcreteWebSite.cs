using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xyms
{
    //具体网站类
    class ConcreteWebSite : WebSite
    {
        string name = "";
        public ConcreteWebSite(string name)
        {
            this.name = name;
        }
        public override void Use()
        {
            Console.WriteLine("网站分类：" + name);
        }
    }
}
