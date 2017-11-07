using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jzzms
{
    class ConcreteBuilder2 : Builder
    {
        Product pro = new Product();
        public override void BuilderPartA()
        {
            pro.Add("partX");
        }

        public override void BuilderPartB()
        {
            pro.Add("partY");
        }
        public void BuilderPartC()
        {
            pro.Add("partZ");
        }

        public override Product GetResult()
        {
            return pro;
        }
    }
}
