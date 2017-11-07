using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gczms1
{
    class obs1 : Observer
    {
        public obs1(Subject sub)
        {
            sub.AmiAt(this);
        }
        public void Response()
        {
            Console.WriteLine("obs1 response");
        }
    }
}
