using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xyms1
{
    class Program
    {
        static void Main(string[] args)
        {
            FlyweightFactory f = new FlyweightFactory();

            f.GetFlyweights("x").Use();
            f.GetFlyweights("y").Use();
            f.GetFlyweights("y").Use();
            f.GetFlyweights("z").Use();

            Console.WriteLine("分类总数：" + f.GetCount());

        }
    }
}
