using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fwzms
{
    //枚举它的元素，可以提供一个高层的接口以允许访问者访问它的元素。
    class ObjectStructure
    {
        IList<Element> elements = new List<Element>();
        public void Attach(Element element)
        {
            elements.Add(element);
        }
        public void Deatch(Element element)
        {
            elements.Remove(element);
        }
        public void Accept(Visitor visitor)
        {
            foreach (Element item in elements)
            {
                item.Accept(visitor);
            }
        }
    }
}
