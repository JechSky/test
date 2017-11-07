using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsFac1
{
    class SqlUser : IUser
    {
        public User GetUser(int id)
        {
            Console.WriteLine("Sql根据id="+id+" 获取user记录");
            return null;
        }

        public void Insert(User user)
        {
            Console.WriteLine("Sql添加一条user记录 "+user.Id+"  "+user.Name);
        }
    }
}
