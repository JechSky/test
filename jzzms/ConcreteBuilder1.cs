using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jzzms
{
    class ConcreteBuilder1 : Builder
    {
        Product pro = new Product();
        public override void BuilderPartA()
        {
            pro.Add("partA");
        }

        public override void BuilderPartB()
        {
            pro.Add("partB");
        }

        public override Product GetResult()
        {
            return pro;
        }
    }
}
