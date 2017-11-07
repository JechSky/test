using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsqms
{
    //非终结符表达式：为文法中的非终结符实现解释操作。
    //对文法中每一条规则都需要一个具体的非终结符表达式类。
    class NonterminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            context.Output = context.Input + " fzd";
            Console.WriteLine("非终端解释器：" + context.Output);
        }
    }
}
