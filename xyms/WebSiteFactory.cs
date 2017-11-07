using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xyms
{
    //网站工厂类
    class WebSiteFactory
    {
        Hashtable flyweights = new Hashtable();

        //获得网站分类
        public WebSite GetWebSiteCategory(string key)
        {
            if(!flyweights.ContainsKey(key))
            {
                flyweights.Add(key, new ConcreteWebSite(key));
            }
            return (WebSite)flyweights[key];
        }
        //获得网站分类总数
        public int GetWebSiteCount()
        {
            return flyweights.Count;
        }

    }
}
