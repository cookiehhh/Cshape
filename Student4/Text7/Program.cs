using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text7
{
    public struct Person
    {
        
        public string num;
        public string name;
        public string sex;
        public string date;
        public string number;
        public int yw;
        public int sx;
        public int yy;
        public int sum;
        public double aver;

    }
    class Program
    {
        public static int count = 1;
        Person[] p = new Person[50];
        int maxs=0, mins=0, maxa=0, mina=0;
        static void Main(string[] args)
        {           
            Program pr = new Program();
            
            while(true)
            {
                Console.Clear();
                pr.Menu();                           
                int i = Convert.ToInt32(Console.ReadLine());
                switch(i)
                {
                    case 1:
                        pr.Input();
                        break;
                    case 2:
                        pr.Output();
                        break;
                    case 3:
                        pr.Tj();
                        break;
                    case 4:
                        pr.Px();
                        break;
                    case 5:
                        pr.Seach();
                        break;
                    case 6:
                        pr.Delete();
                        break;
                    case 7:
                        pr.Rewrite();
                        break;
                    case 8:
                        Console.WriteLine("\t******************制作者*********************");
                        Console.WriteLine("\t**                                         **");
                        Console.WriteLine("\t**                                         **");
                        Console.WriteLine("\t*******************高琪**********************");
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
        public void Menu()
        {
            Console.WriteLine("***************************学生成绩管理系统菜单****************************");
            Console.WriteLine("0.退出  1.输入  2.显示  3.统计  4.排序  5.查询  6.删除  7.修改  8.制作者\n");
            Console.WriteLine("请输入您的选择(0 - 8):");
        }
        public void Input()
        {
            
            int i = 1;
            Console.Clear();
            while (true)
            {
                Console.WriteLine("********学生信息输入*********");
                Console.WriteLine("请输入第{0}个学生的信息",count);
                Console.WriteLine("学号：");
                p[i].num = Console.ReadLine();
                Console.WriteLine("姓名：");
                p[i].name = Console.ReadLine();
                Console.WriteLine("性别：");
                p[i].sex = Console.ReadLine();
                Console.WriteLine("出生日期：");
                p[i].date = Console.ReadLine();
                Console.WriteLine("联系方式：");
                p[i].number = Console.ReadLine();
                Console.WriteLine("语文：");
                p[i].yw = Convert.ToInt32( Console.ReadLine());
                Console.WriteLine("数学：");
                p[i].sx = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("英语：");
                p[i].yy = Convert.ToInt32(Console.ReadLine());
                p[i].sum = p[i].yw + p[i].sx + p[i].yy;
                p[i].aver = (p[i].yw + p[i].sx + p[i].yy)/3;
                ++count;
                i++;
                Console.Clear();
                Console.WriteLine("你要继续输入吗？（y/n）");
                string sign = Console.ReadLine();
                if (sign == "n")
                    break;
            }           
        }
        public void Output()
        {
            Console.WriteLine("******************************************学生信息显示**********************************************");
            for (int i = 1;i < count;i++)
            {
                Console.WriteLine("学号：" + p[i].num +"\t姓名：" + p[i].name + "\t性别：" + p[i].sex + "\t出生日期：" + p[i].date + "\t联系方式：" + p[i].number + "\t语文：" + p[i].yw + "\t数学：" + p[i].sx + "\t英语：" + p[i].yy + "\t总分：" + p[i].sum + "\t平均分：" + p[i].aver);
                
            }
            Console.ReadKey();
        }
        public void Tj()        //统计
        {
            for (int i = 1;i < count;i++)
            {
                if (p[i].sum > p[maxs].sum)
                {
                    maxs = i;
                }
            }
            for (int i = 0; i < count; i++)
            {
                if (p[i].sum < p[mins].sum)
                {
                    mins = i;
                }
            }
            for (int i = 1; i < count; i++)
            {
                if (p[i].aver > p[maxa].aver)
                {
                    maxa = i;
                }
            }
            for (int i = 0; i < count; i++)
            { 
                if (p[i].aver < p[mina].aver)
                {
                    mina = i;
                }
            }
            Console.WriteLine("总分最高："+ p[maxs].sum);
            //Console.WriteLine("总分最低："+ p[mins].sum);
            Console.WriteLine("平均分最高学生信息：");
            Console.WriteLine("学号：" + p[maxa].num + "\t姓名：" + p[maxa].name + "\t性别：" + p[maxa].sex + "\t出生日期：" + p[maxa].date + "\t联系方式：" + p[maxa].number + "\t语文：" + p[maxa].yw + "\t数学：" + p[maxa].sx + "\t英语：" + p[maxa].yy + "\t总分：" + p[maxa].sum + "\t平均分：" + p[maxa].aver);
            //Console.WriteLine("平均分最低学生信息：");
            //Console.WriteLine("学号：" + p[mina].num + "\t姓名：" + p[mina].name + "\t性别：" + p[mina].sex + "\t出生日期：" + p[mina].date + "\t联系方式：" + p[mina].number + "\t语文：" + p[mina].yw + "\t数学：" + p[mina].sx + "\t英语：" + p[mina].yy + "\t总分：" + p[mina].sum + "\t平均分：" + p[mina].aver);

            Console.ReadKey();
            

        }
        private void Seach()
        {
            while (true)
            {           
                Console.Clear();
                Console.WriteLine("********学生信息查询*********");
                Console.WriteLine("1.按学号查询");
                Console.WriteLine("2.按姓名查询");
                Console.WriteLine("0.返回主菜单");
                Console.WriteLine("请输入您的选择（0-2）");
                int m = Convert.ToInt32(Console.ReadLine());
                switch(m)
                {
                    case 1:
                    {
                        Console.WriteLine("请输入学生学号：");
                        string num = Console.ReadLine();
                        for (int i = 0; i < count; i++)
                        {
                            if (p[i].num == num)
                            {
                                    Console.WriteLine("学号：" + p[i].num + "\t姓名：" + p[i].name + "\t性别：" + p[i].sex + "\t出生日期：" + p[i].date + "\t联系方式：" + p[i].number + "\t语文：" + p[i].yw + "\t数学：" + p[i].sx + "\t英语：" + p[i].yy + "\t总分：" + p[i].sum + "\t平均分：" + p[i].aver);
                            }
                        }
                            Console.ReadKey();
                            break;
                    }
                    case 2:
                    {
                        Console.WriteLine("请输入学生姓名：");
                        string name = Console.ReadLine();
                        for (int i = 0; i < count; i++)
                        {
                            if(p[i].name == name)
                            {
                                    Console.WriteLine("学号：" + p[i].num + "\t姓名：" + p[i].name + "\t性别：" + p[i].sex + "\t出生日期：" + p[i].date + "\t联系方式：" + p[i].number + "\t语文：" + p[i].yw + "\t数学：" + p[i].sx + "\t英语：" + p[i].yy + "\t总分：" + p[i].sum + "\t平均分：" + p[i].aver);
                            }
                        }
                            Console.ReadKey();
                            break;
                    }
                    case 0:
                    {
                        Console.WriteLine("正在返回....");
                        Console.ReadKey();
                        return ;
                    }
                }
            }
        }
        public void Px()            //排序
        {            
                Person temp;
                
                    for (int i = 0;i < count;i++)
                    {
                        for (int j = 0; j < count - i -1; j++)
                        {
                            if (p[j].sum >  p[j + 1].sum)
                            {
                                temp = p[j + 1];
                                p[j + 1] = p[j];
                                p[j] = temp;
                            }
                        }
                    }
                    for (int i = 1;i < count;i++)
                    {
                        Console.WriteLine("学号：" + p[i].num + "\t姓名：" + p[i].name + "\t性别：" + p[i].sex + "\t出生日期：" + p[i].date + "\t联系方式：" + p[i].number + "\t语文：" + p[i].yw + "\t数学：" + p[i].sx + "\t英语：" + p[i].yy + "\t总分：" + p[i].sum + "\t平均分：" + p[i].aver);
                    }
            Console.ReadKey();
        }
        public void Delete()
        {
            int i;
            Console.WriteLine("请输入学生学号：");
            string num = Console.ReadLine();
            for (i = 0; i < count; i++)
            {
                if (p[i].num == num)
                {
                    Console.WriteLine("学号：" + p[i].num + "\t姓名：" + p[i].name + "\t性别：" + p[i].sex + "\t出生日期：" + p[i].date + "\t联系方式：" + p[i].number + "\t语文：" + p[i].yw + "\t数学：" + p[i].sx + "\t英语：" + p[i].yy + "\t总分：" + p[i].sum + "\t平均分：" + p[i].aver);
                    for (int k = i;k < count;k++)
                    {
                        p[k] = p[k + 1];
                    } 
                }                
            }            
            count--;
            Console.WriteLine("删除完毕！");
            Console.ReadKey();

        }
        public void Rewrite()
        {
            Console.WriteLine("请输入学生学号：");
            string num = Console.ReadLine();
            for (int i = 0; i < count; i++)
            {
                if (p[i].num == num)
                {
                    Console.WriteLine("请输入修改的信息：");
                    Console.WriteLine("学号：");
                    p[i].num = Console.ReadLine();
                    Console.WriteLine("姓名：");
                    p[i].name = Console.ReadLine();
                    Console.WriteLine("性别：");
                    p[i].sex = Console.ReadLine();
                    Console.WriteLine("出生日期：");
                    p[i].date = Console.ReadLine();
                    Console.WriteLine("联系方式：");
                    p[i].number = Console.ReadLine();
                    Console.WriteLine("语文：");
                    p[i].yw = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("数学：");
                    p[i].sx = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("英语：");
                    p[i].yy = Convert.ToInt32(Console.ReadLine());
                    p[i].sum = p[i].yw + p[i].sx + p[i].yy;
                    p[i].aver = (p[i].yw + p[i].sx + p[i].yy) / 3;
                }
            }
            Console.WriteLine("修改完毕！");
            Console.ReadKey();
        }
    }
}
