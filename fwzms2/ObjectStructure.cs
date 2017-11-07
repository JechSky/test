using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fwzms2
{
    class ObjectStructure
    {
        IList<Element> list = new List<Element>();

        public void Attach(Element el)
        {
            list.Add(el);
        }

        public void Detach(Element el)
        {
            list.Remove(el);
        }

        public void Accept(Visitor vis)
        {
            foreach (Element item in list)
            {
                item.Accept(vis);
            }
        }

    }
}
