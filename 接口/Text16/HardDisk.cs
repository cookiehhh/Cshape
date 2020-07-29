﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text16
{
    class HardDisk:Disk,IUSB
    {
        /// <summary>
        /// 硬盘的存储空间
        /// </summary>
        private string content;

        public HardDisk(string brand):base(brand)
        {

        }

        public void Read()
        {
            Console.WriteLine("{0}读取数据{1}", Brand, content);
        }

        public void Write(string content)
        {
            this.content += content;
            Console.WriteLine("{0}存入数据{1}", Brand, content);
        }
    }
}
