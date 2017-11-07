using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ddqms
{
    //具体迭代器类，继承Iterator
    class ConcreteIterator : Iterator
    {
        ConcreteAggregate aggregate;
        int current = 0;
        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
        }

        public override object CurrentItem()
        {
            return aggregate[current];
        }

        public override object First()
        {
            return aggregate[0];
        }

        public override bool IsDone()
        {
            return  current >= aggregate.Count ? true : false;
        }

        public override object Next()
        {
            object obj = null;
            current++;
            if(current<aggregate.Count)
            {
                obj = aggregate[current];
            }
            return obj;

        }
    }
}
