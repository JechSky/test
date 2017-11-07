using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yxms
{
    class Resume
    {
        public string name;
        string sex;
        string age;
        string timeArea;
        string company;

        public Resume(string name)
        {
            this.name = name;
        }

        public void SetPersonalInfo(string sex,string age)
        {
            this.sex = sex;
            this.age = age;
        }

        public void SetWorkExperience(string timeArea,string company)
        {
            this.timeArea = timeArea;
            this.company = company;
        }

        public void Display()
        {
            Console.WriteLine("{0},{1},{2}", name, sex, age);
            Console.WriteLine("工作经历：时间：{0}  公司：{1}",this.timeArea,company);
        }

        public Resume Clone()
        {
            return (Resume)this.MemberwiseClone();
        }


    }
}
