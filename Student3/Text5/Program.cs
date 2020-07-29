using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text5
{
    class Student
    {
        private string[,] studentList = new string[10, 3];
        static void Main(string[] args)
        {
            Student stu = new Student();
            //stu.Option();
            stu.AddStudent();
        }
        private void AddStudent()
        {
            char isStop = 'n';
            do
            {
                int i = 0;
                for (; i < 10; i++)
                {
                    if (this.studentList[i, 0] == null)
                    {
                        break;
                    }
                    else if (i == 9)
                    {
                        Console.WriteLine("学生信息已满！无法添加！");
                    }
                }
                if (i != 10)
                {
                    Console.WriteLine("请输入学生姓名：");
                    this.studentList[i, 0] = Console.ReadLine();
                    Console.WriteLine("请输入学生年龄：");
                    this.studentList[i, 1] = Console.ReadLine();
                    Console.WriteLine("请输入学生成绩：");
                    this.studentList[i, 2] = Console.ReadLine();
                    Console.WriteLine("学生\"{0}\"添加成功！", this.studentList[i, 0]);
                }
                Console.WriteLine("是否继续添加学生？（y/n）");
                isStop = char.Parse(Console.ReadLine());
            } while (isStop == 'y');
        }
        private void DeleteStudent()
        {
            char isStop = 'n';
            do
            {
                Console.WriteLine("请输入学生姓名");
                string name = Console.ReadLine();
                for (int i = 0; i < 10; i++)
                {
                    if (this.studentList[i, 0] == name)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            this.studentList[i, j] = null;
                        }
                        Console.WriteLine("学生\"{0}\"删除成功！", name);
                        break;
                    }
                    else if (i == 9)
                    {
                        Console.WriteLine("学生\"{0}\"不存在！", name);
                    }
                }
                Console.WriteLine("是否继续删除？（y/n）");
                isStop = char.Parse(Console.ReadLine());
            } while (isStop == 'y');
        }
        private void ModifyStudent()
        {
            char isStop = 'n';
            do
            {
                Console.WriteLine("请输入学生姓名");
                string name = Console.ReadLine();
                for (int i = 0; i < 10; i++)
                {
                    if (this.studentList[i, 0] == name)
                    {
                        Console.WriteLine("请输入学生新年龄：");
                        this.studentList[i, 1] = Console.ReadLine();
                        Console.WriteLine("请输入学生新成绩：");
                        this.studentList[i, 2] = Console.ReadLine();
                        Console.WriteLine("学生\"{0}\"修改成功！", name);
                        break;
                    }
                    else if (i == 9)
                    {
                        Console.WriteLine("学生\"{0}\"不存在", name);
                    }
                }
                Console.WriteLine("是否继续修改？（y/n）");
                isStop = char.Parse(Console.ReadLine());

            } while (isStop == 'y');

               
        }
        private void SeachStudent()
        {
            Console.WriteLine("请输入学生姓名：");
            string name = Console.ReadLine();
            for (int i = 0;i < 10;i++)
            {
                if (this.studentList[i,0] == name)
                {
                    Console.WriteLine("姓名\t年龄\t成绩");
                    Console.WriteLine("{0}\t{1}\t{2}",this.studentList[i,0],this.studentList[i,1],this.studentList[i,2]);

                }
            }
        }
        private void ShowStudentList()
        {
            char isStop = 'n';
            do
            {
                Console.WriteLine("姓名\t年龄\t成绩");
                for (int i = 0; i < 10; i++)
                {
                    if (this.studentList[i, 0] != null)
                    {
                        Console.WriteLine("{0}\t{1}\t{2}", this.studentList[i, 0], this.studentList[i, 1], this.studentList[i, 2]);
                    }
                }
                Console.WriteLine("是否继续？（y/n）");
                isStop = char.Parse(Console.ReadLine());

            } while (isStop == 'y');
        }
        private void ExitProgram()
        {
            Console.WriteLine("谢谢使用！再见！");
            System.Environment.Exit(0);
        }
    }

}
