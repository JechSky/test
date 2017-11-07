using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fwzms1
{
    class Fail : Action
    {
        public override void GetManConclusion(Man element)
        {
            Console.WriteLine("{0}{1}时，man fail！", element.GetType().Name, this.GetType().Name);
        }

        public override void GetWomanConclusion(Woman element)
        {
            Console.WriteLine("{0}{1}时，woman fail！", element.GetType().Name, this.GetType().Name);
        }
    }
}
