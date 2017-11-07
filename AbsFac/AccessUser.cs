using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsFac
{
    class AccessUser : IUser
    {
        public User GetUser(int id)
        {
            Console.WriteLine("access获取id="+id+"的记录");
            return null;
        }

        public void Insert(User user)
        {
            Console.WriteLine("access添加一条记录："+user.Id+"  "+user.Name);
        }
    }
}
