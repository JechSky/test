using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xyms2
{
    class FlyweightFactory
    {
        Hashtable ht = new Hashtable();

        public FlyweightFactory()
        {
            ht.Add("x", new ConcreteFlyweight());
            ht.Add("y", new ConcreteFlyweight());
            ht.Add("z", new ConcreteFlyweight());
        }
        public Flyweight GetFlyweight(string key)
        {
            return (Flyweight)ht[key];
        }

    }
}
