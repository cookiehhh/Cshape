using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text3
{
    class Program
    {
        static void Main(string[] args)
        {
            Shou();
            Console.WriteLine("请输入你的班级：");
            int clas = ReadInt();
            Console.WriteLine("你的班级为："+clas);
            Console.WriteLine("请输入你的年龄：");
            int age = ReadInt();
            Console.WriteLine("你的年龄为："+age);
            Console.WriteLine("请输入你班级的人数：");
            int sum = ReadInt();
            Console.WriteLine("你班级的人数为："+sum);
            

        }
        public static int ReadInt()
        {
            int number = 0;

            do
            {
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    return number;
                }
                catch
                {
                    Console.WriteLine("输入错误，请重新输入！");
                }
            } while (true);

        }
        public static void Shou()
        {
            Console.WriteLine("************************");
            Console.WriteLine("*    欢迎使用本系统    *");
            Console.WriteLine("************************");
        }
    }

}
