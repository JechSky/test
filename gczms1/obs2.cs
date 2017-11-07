using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gczms1
{
    class obs2 : Observer
    {
        string name;
        public obs2(Subject sub,string name)
        {
            this.name = name;
            sub.AmiAt(this);
        }

        public void Response()
        {
            Console.WriteLine(name + " obs2 response");
        }
    }
}
