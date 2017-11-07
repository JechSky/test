using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bwlms2
{
    class Program
    {
        static void Main(string[] args)
        {
            GameRole gr = new GameRole();
            gr.GetInitState();
            gr.StateDisplay();

            RoleStateCaretaker stateAdmin = new RoleStateCaretaker();
            stateAdmin.Memento = gr.SaveState();

            Console.WriteLine("战斗");
            gr.Fight();
            gr.StateDisplay();

            Console.WriteLine("恢复");
            gr.RecoveryState(stateAdmin.Memento);
            gr.StateDisplay();

        }
    }
}
