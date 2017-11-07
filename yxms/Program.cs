using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yxms
{
    class Program
    {
        static void Main(string[] args)
        {
            Resume re = new Resume("love god");
            re.SetPersonalInfo("女", "20");
            re.SetWorkExperience("1990-11-16", "company1");

            Resume re1 = re.Clone();
            re1.name = "lov";
            re1.SetPersonalInfo("男", "23");
            re1.Display();


        }
    }
}
