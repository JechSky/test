using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ddqms
{
    class ConcreteIteratorDesc : Iterator
    {
        ConcreteAggregate aggregate;
        int current = 0;

        public ConcreteIteratorDesc(ConcreteAggregate aggre)
        {
            this.aggregate = aggre;
            this.current = aggre.Count-1;
        }

        public override object CurrentItem()
        {
            return aggregate[current];
        }

        public override object First()
        {
            return aggregate[this.aggregate.Count-1];
        }

        public override bool IsDone()
        {
            return current < 0 ? true : false;
        }

        public override object Next()
        {
            object obj = null;
            current--;
            if (current >= 0)
            {
                obj = aggregate[current];
            }
            return obj;
        }

    }
}
