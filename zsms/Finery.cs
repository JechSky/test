using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zsms
{
    class Finery : Person
    {
        Person component;
        public void setComponent(Person component)
        {
            this.component = component;
        }
        public override void Show()
        {
            if(component!=null)
            {
                component.Show();
            }
        }

    }
}
