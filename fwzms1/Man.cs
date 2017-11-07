using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fwzms1
{
    class Man : Person
    {
        public override void Accetp(Action visitor)
        {
            visitor.GetManConclusion(this);
        }
    }
}
