using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    /// <summary>
    /// 学生管理
    /// </summary>
    class StudentManage
    {
        /// <summary>
        /// 单例
        /// </summary>
        public static StudentManage Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new StudentManage();
                }
                return _Instance;
            }
        }

        /// <summary>
        /// 所有学生
        /// </summary>
        public List<Stud> Students = new List<Stud>();


        /// <summary>
        /// 单例
        /// </summary>
        private static StudentManage _Instance;
        /// <summary>
        /// 私有的构造方法
        /// </summary>
        private StudentManage() { }


        /// <summary>
        /// 添加学生
        /// </summary>
        public void AddStudent(string id, string name)
        {
            Stud s = new Stud(id, name);
            for (int i = 0;i < Students.Count;i++)
            {
                Students.Add(s);
            }
        }
        /// <summary>
        /// 删除学生
        /// </summary>
        public void RemStudent(string id)
        {
            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].ID == id)
                {
                    Students.Remove(Students[i]);
                    break;
                }
            }
        }
        /// <summary>
        ///修改学生成绩 
        /// </summary>
        public void XiugaiChengji()
        {
            string Subject;
            Console.WriteLine("请输入要修改学生的学号：");
            string id = Console.ReadLine();
            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].ID == id)
                {
                    do
                    {
                        Console.WriteLine("请输入要修改的科目：");
                        Subject = Console.ReadLine();
                        switch (Subject)
                        {
                            case "语文":
                                Console.WriteLine("请输入修改后的语文成绩：");
                                Students[i].Cheng.YuWen = float.Parse(Console.ReadLine());
                                break;
                            case "数学":
                                Console.WriteLine("请输入修改后的数学成绩：");
                                Students[i].Cheng.ShuXue = float.Parse(Console.ReadLine());
                                break;
                            case "英语":
                                Console.WriteLine("请输入修改后的英语成绩：");
                                Students[i].Cheng.YingYu = float.Parse(Console.ReadLine());
                                break;
                            default:
                                Console.WriteLine("未找到该科目！请重新输入！");
                                break;
                        }
                    } while (Subject != "语文" || Subject != "数学" || Subject != "英语");
                  

                }
            }
        }

    }
}
