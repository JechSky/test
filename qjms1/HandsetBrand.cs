using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qjms1
{
    //手机品牌类
    abstract class HandsetBrand
    {
        protected HandsetSoft soft;
        //设置手机软件
        //品牌需要关注软件，所以可在机器中安装软件（设置手机软件），以备运行。
        public void SetHandsetSoft(HandsetSoft soft)
        {
            this.soft = soft;
        }

        //运行
        public abstract void Run(HandsetBrand brand);

    }
}
