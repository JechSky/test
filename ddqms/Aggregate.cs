using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ddqms
{
    //聚集抽象类
    abstract class Aggregate
    {
        //创建迭代器
        public abstract Iterator CreateIterrator();
    }
}
