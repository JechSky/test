using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zjzms1
{
    //联合国安全理事会
    class UnitedNationsSecurityCouncil:UnitedNations
    {
        USA col1;
        Iraq col2;
        public USA Col1 { set { col1 = value; } }
        public Iraq Col2 { set { col2 = value; } }

        public override void Deciare(string message, Country country)
        {
            if(country == col1)
            {
                col2.GetMessage(message);
            }
            else
            {
                col1.GetMessage(message);
            }
        }
    }
}
