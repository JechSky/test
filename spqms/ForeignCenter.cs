﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spqms
{
    class ForeignCenter
    {
        public string Name { get; set; }

        public void 进攻()
        {
            Console.WriteLine("外籍中锋{0}进攻",Name);
        }

        public void 防守()
        {
            Console.WriteLine("外籍中锋{0}防守", Name);
        }


    }
}
