using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text16
{
    class Computer
    {
        private string brand;

        public IUSB USB_1;
        public IUSB USB_2;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public Computer(string brand)
        {
            this.brand = brand;
        }
        
        public void Start()
        {
            Console.WriteLine("{0}品牌的电脑开机中....",brand);
        }

        public void End()
        {
            Console.WriteLine("{0}品牌的电脑关机中....",brand);
        }
    }
}
