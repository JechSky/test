using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qjms3
{
    abstract class HandsetBrand
    {
        protected HandsetSoft soft;
        public void SetHandsetSoft(HandsetSoft soft)
        {
            this.soft = soft;
        }
        public virtual void Run(HandsetBrand hb)
        {
            this.soft.Run(hb);
        }
    }
}
