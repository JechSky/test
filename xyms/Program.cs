using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xyms
{
    class Program
    {
        static void Main(string[] args)
        {
            WebSiteFactory f = new WebSiteFactory();
            WebSite fx = f.GetWebSiteCategory("产品展示");
            fx.Use();

            WebSite fy = f.GetWebSiteCategory("产品展示");
            fy.Use();

            WebSite fz = f.GetWebSiteCategory("博客");
            fz.Use();

            WebSite fc = f.GetWebSiteCategory("ss");
            fc.Use();

            Console.WriteLine("网站分类总数为{0}", f.GetWebSiteCount());

        }
    }
}
