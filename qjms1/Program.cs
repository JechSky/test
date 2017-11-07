using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qjms1
{
    class Program
    {
        static void Main(string[] args)
        {
            HandsetBrand handb;
            HandsetGame game=new HandsetGame();
            HandsetAddressList addressList = new HandsetAddressList();

            handb = new HandsetBrandM();
            handb.SetHandsetSoft(game);
            handb.Run(handb);

            handb.SetHandsetSoft(addressList);
            handb.Run(handb);

            handb = new HandsetBrandN();
            handb.SetHandsetSoft(game);
            handb.Run(handb);

            handb.SetHandsetSoft(addressList);
            handb.Run(handb);

        }
    }
}
