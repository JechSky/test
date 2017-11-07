using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itera1
{
    interface IEnumerator
    {
        object Current { get; }
        bool MoveNext();
        void Rest();
    }
}
