using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xyms1
{
    class ConcreteFlyweight : Flyweight
    {
        string name;
        public ConcreteFlyweight(string name)
        {
            this.name = name;
        }
        public override void Use()
        {
            Console.WriteLine("具体分类：{0}", name);
        }
        
    }
}
