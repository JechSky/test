using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bwlms1
{
    class Program
    {
        static void Main(string[] args)
        {
            //大战boss前
            GameRole role = new GameRole();
            role.GetInitState();
            role.StateDisplay();

            //保存进度
            GameRole backup = new GameRole();
            backup.Vitality = role.Vitality;
            backup.Attack = role.Attack;
            backup.Defense = role.Defense;

            //大战boss时，损耗严重
            Console.WriteLine("大战,损耗严重:");
            role.Fight();
            role.StateDisplay();

            //恢复之前状态
            Console.WriteLine("恢复之前状态:");
            role.Vitality = backup.Vitality;
            role.Attack = backup.Attack;
            role.Defense = backup.Defense;

            role.StateDisplay();

        }
    }
}
