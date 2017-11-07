using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spqms1
{
    class Adapter:Target
    {
        Adaptee adaptee = new Adaptee();
        public override void Request()
        {
            //这样就可以把表面上调用Request的方法变成实际调用SpecificRequest的方法。
            adaptee.SpecificRequest();
        }
    }
}
