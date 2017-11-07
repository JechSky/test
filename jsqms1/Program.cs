using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsqms1
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayContext context = new PlayContext();
            Console.WriteLine("name：");

            context.PlayText = " O 2 E 0.5 G 0.5 A 3 E 0.5 G 0.5 D 3 E ";

            Expression expression = null;

            try
            {
                while (context.PlayText.Length>0)
                {
                    string str = context.PlayText.Substring(0, 1);
                    switch (str)
                    {
                        //当首字段是O时，则表达式实例化为音阶。
                        case "O":
                            expression = new Scale();
                            break;
                        case "C":
                        case "D":
                        case "E":
                        case "F":
                        case "G":
                        case "A":
                        case "B":
                        case "P":
                            expression = new Note();//当首字母是CDP时，则实例化音符。
                            break;
                        default:
                            break;
                    }
                    expression.Interpret(context);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
