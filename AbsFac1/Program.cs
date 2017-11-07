using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsFac1
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User() { Id = 1, Name = "te" };
            IUser iu = DataBase.CreateUser();
            iu.Insert(user);
            iu.GetUser(0); 

        }
    }
}
