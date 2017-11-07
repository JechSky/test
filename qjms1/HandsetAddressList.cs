using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qjms1
{
    //手机通讯录
    class HandsetAddressList : HandsetSoft
    {
        public override void Run(HandsetBrand brand)
        {
            Console.WriteLine(brand.GetType().Name + "：运行手机通讯录");
        }
    }
}
