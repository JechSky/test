using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bwlms2
{
    //角色状态存储箱
    class RoleStateMemento
    {
        //体力
        public int Vitality { get; set; }
        //攻击力
        public int Attack { get; set; }
        //防御力
        public int Defense { get; set; }

        public RoleStateMemento(int vit,int act,int def)
        {
            this.Vitality = vit;
            this.Attack = act;
            this.Defense = def;
        }

    }
}
