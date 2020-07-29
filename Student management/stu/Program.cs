using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stu
{
    class Program
    {
        static void Main(string[] args)
        {
            Manage m = new Manage();
            while (true)
            {
                Console.Clear();
                m.Menu();
                int i = Convert.ToInt32(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        m.Input();
                        Console.ReadKey();
                        break;
                    case 2:
                        m.Output();
                        Console.ReadKey();
                        break;
                    case 3:
                        m.Statistics();
                        Console.ReadKey();
                        break;
                    case 4:
                        m.Sort();
                        Console.ReadKey();
                        break;
                    case 5:
                        m.Seach();
                        Console.ReadKey();
                        break;
                    case 6:
                        m.Delete();
                        Console.ReadKey();
                        break;
                    case 7:
                        m.Rewrite();
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.WriteLine("\t******************制作者*********************");
                        Console.WriteLine("\t**                 高琪                    **");
                        Console.WriteLine("\t*********************************************");
                        Console.ReadKey();
                        break;
                    case 0:
                        Console.WriteLine("谢谢使用！");
                        Console.WriteLine("正在退出...");
                        Console.ReadKey();
                        return;
                    default:
                        Console.WriteLine("输入错误,请重新输入！");
                        Console.ReadKey();
                        break;
                }
            }            
        }
    }
}
