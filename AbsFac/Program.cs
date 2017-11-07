using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsFac
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User() { Id = 1, Name = "user1" };
            IFactory ifa = new SqlFactory();
            IUser iu= ifa.CreateUser();
            iu.Insert(user);
            iu.GetUser(3);

            IUser iu1 = new AccessFactory().CreateUser();
            iu1.Insert(user);
            iu1.GetUser(6);

        }
    }
}
