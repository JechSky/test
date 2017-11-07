using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itera1
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<string> a = new List<string>();
            a.Add("dd");
            a.Add("aa");

            //foreach (var item in a)
            //{
            //    Console.WriteLine(item);
            //}

            IEnumerator<string> e = a.GetEnumerator();
            while (e.MoveNext())
            {
                Console.WriteLine("{0}",e.Current);
            }

        }
    }
}
