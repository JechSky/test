using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsqms
{
    //终结符表达式：实现与文法中的终结符相关联的解释操作。
    class TerminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            context.Output = context.Input.ToUpper();
            Console.WriteLine("终端解释器:"+ context.Output);
        }
    }
}
