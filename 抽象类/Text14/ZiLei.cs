using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text14
{
    class ZiLei : FuLei
    {
        public override void Hello()
        {
            Console.WriteLine("Hello！  子类");
        }

        public void Z()
        {
            Console.WriteLine("子类普通方法");
        }
    }
}
