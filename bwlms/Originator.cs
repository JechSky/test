using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bwlms
{
    //发起人
    class Originator
    {
        public string State { get; set; }
        //创建备忘录，将当前需要保存的信息导入并实例化一个Memento对象
        public Memento CreateMemento()
        {
            return new Memento(State);
        }
        //恢复备忘录，将Memento导入并将相关数据恢复。
        public void SetMemento(Memento memento)
        {
            State = memento.State;
        }
        //显示
        public void Show()
        {
            Console.WriteLine("State=" + State);
        }

    }
}
