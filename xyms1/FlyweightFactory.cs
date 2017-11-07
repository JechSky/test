using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xyms1
{
    //享元工厂
    class FlyweightFactory
    {
        Hashtable flyweights = new Hashtable();
        
        public Flyweight GetFlyweights(string key)
        {
            if(!flyweights.ContainsKey(key))
            {
                flyweights.Add(key, new ConcreteFlyweight(key));
            }
            return (Flyweight)flyweights[key];
        }

        public Flyweight GetFlyweight(string key)
        {
            return (Flyweight)flyweights[key];
        }

        public int GetCount()
        {
            return flyweights.Count;
        }

    }
}
