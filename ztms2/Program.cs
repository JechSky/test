using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ztms2
{
    class Program
    {
        static void Main(string[] args)
        {
            Work w = new Work();
            w.Hour = 9;
            w.WriteProgram();
            w.Hour = 10;
            w.WriteProgram();
            w.Hour = 12;
            w.WriteProgram();
            w.Hour = 13;
            w.WriteProgram();
            w.TaskFinished = true;
            w.Hour = 14;
            w.WriteProgram();
            w.Hour = 15;
            w.WriteProgram();
            w.Hour = 19;
            w.WriteProgram();
            
            w.Hour = 20;
            w.WriteProgram();
            w.Hour = 22;
            w.WriteProgram();
            w.Hour = 23;
            w.WriteProgram();

        }
    }
}
