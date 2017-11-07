using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AbsFac1
{
    class DataBase
    {
        static readonly string dbName = ConfigurationManager.AppSettings["DB"];
        static string AssemblyName = "AbsFac1";

        public static IUser CreateUser()
        {
            string className = AssemblyName + "." +dbName+ "User";
            return (IUser)Assembly.Load(AssemblyName).CreateInstance(className);
        }

    }
}
