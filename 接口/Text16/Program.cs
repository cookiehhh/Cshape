﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text16
{
    class Program
    {
        static void Main(string[] args)
        {
            UDisk u1 = new UDisk("金士顿32GB");
            HardDisk h1 = new HardDisk("索尼500GB");


            Computer c1 = new Computer("联想");
            c1.Start();
            c1.USB_1 = u1;
            c1.USB_1.Write("哔哩哔哩");
            c1.USB_1.Write("嘿嘿嘿");
            c1.USB_1.Read();

            Console.WriteLine();

            c1.USB_2 = h1;
            c1.USB_2.Write("小白");
            c1.USB_2.Write("略略略");
            c1.USB_2.Read();

            c1.End();

            Console.WriteLine();

            Computer c2 = new Computer("戴尔");
            c2.Start();
            c2.End();


            Console.ReadKey();
        }
    }
}
