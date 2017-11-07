using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zhms
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite root = new Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            Composite com = new Composite("Composite X");
            com.Add(new Leaf("Leaf XA"));
            com.Add(new Leaf("Leaf XB"));

            root.Add(com);

            Composite com2 = new Composite("Composite XY");
            com2.Add(new Leaf("Leaf XYA"));
            com2.Add(new Leaf("Leaf XYB"));
            com.Add(com2);
            root.Add(new Leaf("Leaf C"));

            Leaf leaf = new Leaf("Leaf D");
            root.Add(leaf);
            //root.Remove(leaf);

            root.Display(1);

        }
    }
}
