using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fwzms1
{
    //人的抽象类
    abstract class Person
    {
        //接受
        public abstract void Accetp(Action visitor);
    }
}
