﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qjms3
{
    class HandsetGame:HandsetSoft
    {
        public override void Run(HandsetBrand hb)
        {
            base.Run(hb);
            Console.WriteLine("运行手机游戏");
        }
    }
}
