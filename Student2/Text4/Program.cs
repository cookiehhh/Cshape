using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Text;

namespace Text4
{
    class ExamManager
    {
        static int CLASS_STUDENT_COUNT = 40;
        static int CLASS_COUNT = 4;
        static int[,] cj = new int[CLASS_COUNT, CLASS_STUDENT_COUNT];
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------学生成绩管理系统----------------");
            int selected;
            do
            {
                //用户选择要执行的功能：
                selected = SelectFunc();
                //如果选择0，则退出：
                if (selected == 0)
                    break;
                //根据selected来执行相应功能:  
                switch (selected)
                {
                    //1、输入成绩：
                    case 1:
                        {
                            int classNumber = SelectClass();
                            InputScore(classNumber); //两行代码可以合为：InputScore(SelectClass());
                            break;
                        }
                    //2、清空成绩：      
                    //case 2:
                    //    {
                    //        int classNumber = SelectClass();
                    //        //ClearScore(classNumber);
                    //        break;
                    //    }
                    //3、输出成绩：
                    case 3:
                        {
                            int classNumber = SelectClass();
                            OutputScore(classNumber);
                            break;
                        }
                        ////4、查询成绩：
                        //case 4:
                        //    {
                        //        int classNumber = SelectClass();
                        //        int studentNumber = SelectStudent();
                        //        FindScore(classNumber, studentNumber);
                        //        //以上三行也可合为：FindScore(SelectClass(),SelectStudent());
                        //        break;
                        //    }
                        ////5、统计成绩：
                        //case 5:
                        //    {
                        //        int classNumber = SelectClass();
                        //        TotalScore(classNumber);
                        //        break;
                        //    }
                }
            } while (true); //一直循环，直到前面用户输入0跳出。
        }
        static int SelectFunc()
        {
            int selected;
            do
            {
                Console.WriteLine("请选择操作(0-5):/n");
                Console.WriteLine("[1] 录入成绩");
                Console.WriteLine("[2] 清空成绩");
                Console.WriteLine("[3] 输出成绩");
                Console.WriteLine("[4] 查询成绩");
                Console.WriteLine("[5] 统计成绩");
                Console.WriteLine("[0] 退出系统");
                selected = int.Parse(Console.ReadLine());
            } while (selected < 0 || selected > 5);
            return selected;
        }
        //用户输入班级编号：
        static int SelectClass()
        {
            int classNumber; //班级编号
            do
            {
                Console.WriteLine("请输入班级编号：(1-4)");
                classNumber = int.Parse(Console.ReadLine());
            } while (classNumber < 1 || classNumber > CLASS_COUNT);
            return classNumber - 1;
        }
        //录入成绩
        //参数 classNumber: 班级编号
        static void InputScore(int classNumber)
        {
            /*一个班级最多40个学员，但也可以少于40个，所以我们规定，当用户输入-1时，表示已经输入完毕。*/
            //判断classNumber是否在合法的范围内：
            if (classNumber < 0 || classNumber >= CLASS_COUNT)
                return;
            //提示字串：
            Console.WriteLine("请输入{0}班的学生成绩,输入-1表示结束。", classNumber + 1);
            for (int i = 0; i < CLASS_STUDENT_COUNT; i++)
            {
                Console.WriteLine("请输入{0}号学员成绩：", i + 1);
                cj[classNumber, i] = int.Parse(Console.ReadLine());   //cj 是全局变量，所以这里可以直接用。
                //判断是否为-1，若是，跳出循环：
                if (-1 == cj[classNumber, i])
                    break;
            }
        }
        //输出成绩：
        static void OutputScore(int classNumber)
        {
            //判断classNumber是否在合法的范围内：
            if (classNumber < 0 || classNumber >= CLASS_COUNT)
                return;

            Console.WriteLine("============================");
            Console.WriteLine("{0}班成绩", classNumber + 1);
            /*
                有两点要注意：
                1、要求每行输出5个成绩。
                2、每个班级并不一定是40个成绩，所以只要遇到-1，则停止输出。当然，如果该班
                  成绩尚未录入，则输出的是40个0。
            */
            for (int i = 0; i < CLASS_STUDENT_COUNT; i++)
            {
                if (i % 5 == 0) //因为每行输出5个，所以i被5 整除，表示是一新行
                    Console.WriteLine();

                if (-1 == cj[classNumber, i]) //遇到成绩为-1...
                    break;
                Console.Write(cj[classNumber, i] + "/t");
            }
            Console.WriteLine("/n");
        }
    }
}
