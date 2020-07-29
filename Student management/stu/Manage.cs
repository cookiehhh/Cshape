using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stu
{
    /// <summary>
    /// 管理类
    /// </summary>
    class Manage
    {
        List<Student> listx = new List<Student>();
        List<Score> listc = new List<Score>();
        int count;  //学生人数
        /// <summary>
        /// 菜单
        /// </summary>
        public void Menu()
        {
            Console.WriteLine("***************************学生成绩管理系统菜单****************************");
            Console.WriteLine("0.退出  1.输入  2.显示  3.统计  4.排序  5.查询  6.删除  7.修改  8.制作者\n");
            Console.WriteLine("请输入您的选择(0 - 8):");
        }
        /// <summary>
        /// 输入
        /// </summary>       
        public void Input()
        {
            count = listx.Count();
            try
            {
                for (int i = count; ; i++)
                {
                    Student x = new Student();
                    Score c = new Score();
                    Console.WriteLine("请输入第{0}个学生的学号：", i + 1);
                    x.Num = Console.ReadLine();
                    Console.WriteLine("请输入第{0}个学生的姓名：", i + 1);
                    x.Name = Console.ReadLine();
                    Console.WriteLine("请输入第{0}个学生的性别：", i + 1);
                    x.Sex = Console.ReadLine();
                    Console.WriteLine("请输入第{0}个学生的语文成绩：", i + 1);
                    c.YuWen = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("请输入第{0}个学生的数学成绩：", i + 1);
                    c.ShuXue = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("请输入第{0}个学生的英语成绩：", i + 1);
                    c.YingYu = Convert.ToDouble(Console.ReadLine());
                    c.Sum = c.sum();
                    c.Aver = c.aver();
                    listx.Add(x);
                    listc.Add(c);
                    Console.WriteLine("是否继续输入学生信息？（y/n）");
                    string xuanze = Console.ReadLine();
                    if (xuanze == "n")
                    {
                        break;
                    }
                }
            }
            catch
            {
                Console.WriteLine("输入错误，请重新输入！");
            }
        }
        /// <summary>
        /// 输出
        /// </summary>
        public void Output()
        {
            count = listx.Count();
            if (count == 0)
            {
                Console.WriteLine("没有学生信息！");
                return;
            }
            for (int i = 0;i < count;i++)
            {
                Console.WriteLine("\t学号：{0}\t姓名：{1}\t性别：{2}\t语文：{3}\t数学：{4}\t英语：{5}\t总分：{6}\t平均分：{7}", listx[i].Num, listx[i].Name, listx[i].Sex, listc[i].YuWen, listc[i].ShuXue, listc[i].YingYu, listc[i].Sum, listc[i].Aver);
            }
        }
        /// <summary>
        /// 统计
        /// </summary>
        public void Statistics()
        {
            count = listx.Count();
            if (count == 0)
            {
                Console.WriteLine("没有学生信息！");
                return;
            }
            //int maxs = 1, mins = 1, maxa = 1, mina = 1;
            //for (int i = 0; i <= count; i++)
            //{
            //    if (listc[i].Sum > listc[maxs].Sum )
            //    {
            //        maxs = i;
            //        break;
            //    }
            //}
            //for (int i = 0; i <= count; i++)
            //{
            //    if (listc[i].Sum < listc[mins].Sum)
            //    {
            //        mins = i;
            //        break;
            //    }
            //}
            //for (int i = 0; i <= count; i++)
            //{
            //    if (listc[i].Aver > listc[maxa].Aver)
            //    {
            //        maxa = i;
            //        break;
            //    }
            //}
            //for (int i = 0; i <= count; i++)
            //{
            //    if (listc[mina].Aver > listc[i].Aver)
            //    {
            //        mina = i;
            //        break;
            //    }
            //}
            double maxs = listc.Max(delegate (Score s1) { return s1.Sum; });
            double maxa = listc.Max(delegate (Score s1) { return s1.Aver; });
            double mins = listc.Min(delegate (Score s1) { return s1.Sum; });
            double mina = listc.Min(delegate (Score s1) { return s1.Aver; });
            Console.WriteLine("\t总分最高：{0}， 总分最低：{1}，平均分最高：{2}，平均分最低：{3}", maxs , mins , maxa , mina);
            //Console.WriteLine("总分最高学生信息：");
            //Console.WriteLine("\t学号：{0}\t姓名：{1}\t性别：{2}\t语文：{3}\t数学：{4}\t英语：{5}\t总分：{6}\t平均分：{7}", listx[maxs].Num, listx[maxs].Name, listx[maxs].Sex, listc[maxs].YuWen, listc[maxs].ShuXue, listc[maxs].YingYu, listc[maxs].Sum, listc[maxs].Aver);
            //Console.WriteLine("总分最低学生信息：");
            //Console.WriteLine("\t学号：{0}\t姓名：{1}\t性别：{2}\t语文：{3}\t数学：{4}\t英语：{5}\t总分：{6}\t平均分：{7}", listx[mins].Num, listx[mins].Name, listx[mins].Sex, listc[mins].YuWen, listc[mins].ShuXue, listc[mins].YingYu, listc[mins].Sum, listc[mins].Aver);

        }
        /// <summary>
        /// 排序
        /// </summary>
        public void Sort()
        {
            listx.Sort(delegate (Student s1, Student s2) { return string.Compare(s1.Name, s2.Name); });
            count = listx.Count();
            if (count == 0)
            {
                Console.WriteLine("没有学生信息！");
                return;
            }
            Console.WriteLine("按姓名排序如下：");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("\t学号：{0}\t姓名：{1}\t性别：{2}\t语文：{3}\t数学：{4}\t英语：{5}\t总分：{6}\t平均分：{7}", listx[i].Num, listx[i].Name, listx[i].Sex, listc[i].YuWen, listc[i].ShuXue, listc[i].YingYu, listc[i].Sum, listc[i].Aver);
            }
        }
        /// <summary>
        /// 查询
        /// </summary>
        public void Seach()
        {
            count = listx.Count();
            if (count == 0)
            {
                Console.WriteLine("没有学生信息！");
                return;
            }
            Console.WriteLine("请输入要查询学生的学号：");
            string num = Console.ReadLine();
            for (int i = 0; i <= count; i++)
            {
                if (i == count)
                {
                    Console.WriteLine("未找到该学生！");
                    break;
                }
                if (listx[i].Num == num)
                {
                    Console.WriteLine("\t学号：{0}\t姓名：{1}\t性别：{2}\t语文：{3}\t数学：{4}\t英语：{5}\t总分：{6}\t平均分：{7}", listx[i].Num, listx[i].Name, listx[i].Sex, listc[i].YuWen, listc[i].ShuXue, listc[i].YingYu, listc[i].Sum, listc[i].Aver);
                    break;
                }               
            }
        }
        /// <summary>
        /// 删除
        /// </summary>
        public void Delete()
        {
            count = listx.Count();
            if (count == 0)
            {
                Console.WriteLine("没有学生信息！");
                return;
            }
            Console.WriteLine("请输入要删除学生的学号：");
            string  num = Console.ReadLine();                        
            for (int i = 0; i <= count; i++)
            {
                if (i == count)
                {
                    Console.WriteLine("未找到该学生！");
                    break;
                }
                if (listx[i].Num == num)
                {
                    listx.Remove(listx[i]);
                    listc.Remove(listc[i]);
                    Console.WriteLine("删除成功！");
                    break;
                }
            }
        }
        /// <summary>
        ///修改 
        /// </summary>
        public void Rewrite()
        {
            string Subject;
            count = listx.Count();
            if (count == 0)
            {
                Console.WriteLine("没有学生信息！");
                return;
            }
            Console.WriteLine("请输入要修改学生的学号：");
            string num = Console.ReadLine();
            for (int i = 0; i <= count; i++)
            {
                if (i == count)
                {
                    Console.WriteLine("未找到该学生！");
                    break;
                }
                if (listx[i].Num == num)
                {
                    Console.WriteLine("请输入要修改的科目：（语文/数学/英语）");
                    Subject = Console.ReadLine();
                    switch (Subject)
                    {
                        case "语文":
                            Console.WriteLine("请输入修改后的语文成绩：");
                            listc[i].YuWen = Convert.ToDouble(Console.ReadLine());
                            listc[i].Sum = listc[i].YuWen + listc[i].ShuXue + listc[i].YingYu;
                            listc[i].Aver = listc[i].Sum / 3;
                            Console.WriteLine("修改成功！");
                            return;
                        case "数学":
                            Console.WriteLine("请输入修改后的数学成绩：");
                            listc[i].ShuXue = Convert.ToDouble(Console.ReadLine());
                            listc[i].Sum = listc[i].YuWen + listc[i].ShuXue + listc[i].YingYu;
                            listc[i].Aver = listc[i].Sum / 3;
                            Console.WriteLine("修改成功！");
                            return;
                        case "英语":
                            Console.WriteLine("请输入修改后的英语成绩：");
                            listc[i].YingYu = Convert.ToDouble(Console.ReadLine());
                            listc[i].Sum = listc[i].YuWen + listc[i].ShuXue + listc[i].YingYu;
                            listc[i].Aver = listc[i].Sum / 3;
                            Console.WriteLine("修改成功！");
                            return;
                        default:
                            Console.WriteLine("未找到该科目！");
                            return;
                    }
                }
            }
        }
    }
}
