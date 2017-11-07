using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bwlms2
{
    class GameRole
    { 
        //体力
        public int Vitality { get; set; }
        //攻击力
        public int Attack { get; set; }
        //防御力
        public int Defense { get; set; }

        public void StateDisplay()
        {
            Console.WriteLine("当前状态：");
            Console.WriteLine("体力：" + this.Vitality);
            Console.WriteLine("攻击力：" + this.Attack);
            Console.WriteLine("防御力：" + this.Defense);
            Console.WriteLine();
        }

        public void GetInitState()
        {
            this.Vitality = 100;
            this.Attack = 100;
            this.Defense = 100;
        }

        public void Fight()
        {
            this.Vitality = 0;
            this.Attack = 0;
            this.Defense = 0;
        }

        //保存角色状态
        public RoleStateMemento SaveState()
        {
            return new RoleStateMemento(Vitality, Attack, Defense);
        }

        //恢复角色状态
        public void RecoveryState(RoleStateMemento memento)
        {
            this.Vitality = memento.Vitality;
            this.Attack = memento.Attack;
            this.Defense = memento.Defense;
        }

    }
}
