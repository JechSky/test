using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qjms1
{
    //手机游戏
    class HandsetGame : HandsetSoft
    {
        public override void Run(HandsetBrand brand)
        {
            Console.WriteLine(brand.GetType().Name + "：运行手机游戏");
        }
    }
}
