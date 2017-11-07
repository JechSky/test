
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zhms1
{
    class ConcreteCompany : Company
    {
        List<Company> list = new List<Company>();
        public ConcreteCompany(string name) : base(name)
        {
        }

        public override void Add(Company c)
        {
            list.Add(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);
            foreach (Company item in list)
            {
                item.Display(depth + 2);
            }
        }

        public override void LineOfDuty()
        {
            foreach (Company item in list)
            {
                item.LineOfDuty();
            }
        }

        public override void Remove(Company c)
        {
            list.Remove(c);
        }
    }
}
