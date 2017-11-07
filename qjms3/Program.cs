using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qjms3
{
    class Program
    {
        static void Main(string[] args)
        {
            HandsetGame game = new HandsetGame();
            HandsetAddressList addressList = new HandsetAddressList();

            HandsetBrand hb = new HandsetBrandM();
            hb.SetHandsetSoft(game);
            hb.Run(hb);
            hb.SetHandsetSoft(addressList);
            hb.Run(hb);

            hb = new HandsetBrandN();
            hb.SetHandsetSoft(game);
            hb.Run(hb);
            hb.SetHandsetSoft(addressList);
            hb.Run(hb);

        }
    }
}
