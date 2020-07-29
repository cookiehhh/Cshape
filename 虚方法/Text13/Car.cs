using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text13
{
    class Car:CarType
    {
        public override void Cry()
        {
            base.Cry();
            Console.WriteLine("喵喵喵");
        }
        public void Monkey()
        {
            Console.WriteLine("我是-----Car类");
        }
    }
}
