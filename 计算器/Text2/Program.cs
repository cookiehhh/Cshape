using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text2
{
    class Program
    {
        static void Main(string[] args)
        {          
            Console.WriteLine("1.求和");
            Console.WriteLine("2.求差");
            Console.WriteLine("3.求积");
            Console.WriteLine("4.求商");
            Console.WriteLine("0.退出");

            while (true)
            {
                Console.WriteLine("请输入你的选择：");
                int i = Convert.ToInt32(Console.ReadLine());

                switch (i)
                {
                case 1:
                    Console.WriteLine("请输入两个数：");
                    int a1 = Convert.ToInt32(Console.ReadLine());
                    int b1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("{0}+{1}={2}",a1,b1,a1+b1);
                    break;
                case 2:
                    Console.WriteLine("请输入两个数：");
                    int a2 = Convert.ToInt32(Console.ReadLine());
                    int b2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("{0}-{1}={2}", a2, b2, a2 - b2);
                    break;
                case 3:
                    Console.WriteLine("请输入两个数：");
                    int a3 = Convert.ToInt32(Console.ReadLine());
                    int b3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("{0}*{1}={2}", a3, b3, a3 * b3);
                    break;
                case 4:
                    Console.WriteLine("请输入两个数：");
                    int a4 = Convert.ToInt32(Console.ReadLine());
                    int b4 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("{0}/{1}={2}", a4, b4, a4 / b4);
                    break;
                case 0:
                    Console.WriteLine("谢谢使用！");
                    Console.WriteLine("正在退出...");
                    Console.ReadKey();
                    return ;
                default:
                    Console.WriteLine("输入错误,请重新输入！");
                    break;
                }
            }
                
      

        }
    }
}
