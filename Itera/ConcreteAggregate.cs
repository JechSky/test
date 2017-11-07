using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itera
{
    class ConcreteAggregate:Aggregate
    {
        IList<object> items = new List<object>();

        public int Count
        {
            get { return items.Count; }
        }

        public object this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index, value); }
        }

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public Iterator CreateIteratorDesc()
        {
            return new ConcreteIteratorDesc(this);
        }
    }
}
