using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text10
{
    class Program
    {
        static void Main(string[] args)
        {
            cjgl c = new cjgl();
            char commond = 'c';
            bool s = true;
            while (s)
            {
                Console.WriteLine("添加 t");
                Console.WriteLine("删除 s");
                Console.WriteLine("查询 c");
                Console.WriteLine("修改 x");
                Console.WriteLine("退出 q");
                try
                {
                    commond = Convert.ToChar(Console.ReadLine());
                    switch (commond)
                    {
                        case 't':
                            {
                                Console.WriteLine("输入姓名");
                                string sp = Console.ReadLine();
                                c.tj(sp);
                                break;
                            }
                        case 's':
                            {
                                Console.WriteLine("输入学号");
                                int id = Convert.ToInt32(Console.ReadLine());
                                c.sc(id);
                                break;
                            }
                        case 'c':
                            {
                                Console.WriteLine("输入学号");
                                int id = Convert.ToInt32(Console.ReadLine());
                                c.cx(id);
                                break;
                            }
                        case 'x':
                            {
                                Console.WriteLine("输入学号");
                                int id = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("输入姓名");
                                string name = Console.ReadLine();
                                c.xgxx(id, name);
                                break;
                            }
                        case 'q':
                            {
                                s = false; break;
                            }
                        default:
                            {
                                Console.WriteLine("输入不合法");
                                break;
                            }
                    }
                }
                catch (Exception w) { Console.WriteLine("输入不合法"); }
            }
        }
    
    }
}
