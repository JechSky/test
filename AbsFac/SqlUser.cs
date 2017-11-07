using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsFac
{
    class SqlUser:IUser
    {
        public void Insert(User user)
        {
            Console.WriteLine("sql 添加一条记录："+user.Id+"  "+user.Name);
        }

        public User GetUser(int id)
        {
            Console.WriteLine("sql获取id="+id+"的记录");
            return new User();
        }


    }
}
