using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsFac1
{
    class AccessUser : IUser
    {
        public User GetUser(int id)
        {
            Console.WriteLine("access根据id="+id+" 获取一条user记录");
            return null;
        }

        public void Insert(User user)
        {
            Console.WriteLine("access添加一条user记录 " + user.Id + "  " + user.Name);
        }
    }
}
