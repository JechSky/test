using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlms
{
    class Program
    {
        static void Main(string[] args)
        {
            single s =single.GetInstance();
            single s1 = single.GetInstance();
            if(s==s1)
            { Console.WriteLine("same"); }

        }
    }

    class single
    {
        static single obj;
        static readonly object objlock = new object();
        private single() { }

        public static single GetInstance()
        {
            if(obj==null)
            {
                lock (objlock)
                {
                    if(obj==null)
                    {
                        obj = new single();
                    }

                }
            }
            return obj;
        }

    }
}
