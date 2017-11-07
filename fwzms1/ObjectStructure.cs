using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fwzms1
{
    //对象结构
    class ObjectStructure
    {
        IList<Person> elements = new List<Person>();
        public void Attach(Person element)
        {
            elements.Add(element);
        }
        public void Detach(Person element)
        {
            elements.Remove(element);
        }
        public void Display(Action visitor)
        {
            foreach (Person item in elements)
            {
                item.Accetp(visitor);
            }
        }
    }
}
