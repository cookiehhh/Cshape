using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text10
{
    class cjgl
    {
        stu[] xuesheng = new stu[10000];
        int num = 0;
        /// <summary>
        /// 添加学生
        /// </summary>
        /// <param name="name"></param>
        public void tj(string name)
        {
            for (num = 0;num < 5;num ++)
            { 
            xuesheng[num] = new stu(num, name);
            Console.WriteLine("已添加写生 姓名:" + xuesheng[num].NAME + "\t学号：" + xuesheng[num].ID.ToString());
            }
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        public void sc(int id)
        {
            for (int i = 0; i < num; i++)
            {
                if (xuesheng[i] != null)
                {
                    if (xuesheng[i].ID == id) xuesheng[i] = null;
                    Console.WriteLine("删除成功");
                    return;
                }
            }
            Console.WriteLine(" 没有找到学生");
        }
        /// <summary>
        /// 修改学生信息
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public void xgxx(int id, string name)
        {
            for (int i = 0; i < num; i++)
            {
                if (xuesheng[i] != null)
                {
                    if (xuesheng[i].ID == id) xuesheng[i].NAME = name; return;
                }
            }
            Console.WriteLine("没有找到学生");
        }
        /// <summary>
        /// 查询学生信息
        /// </summary>
        /// <param name="id"></param>
        public void cx(int id)
        {
            for (int i = 0; i < num; i++)
            {
                if (xuesheng[i] != null)
                {
                    if (xuesheng[i].ID == id)
                    {
                        Console.WriteLine(xuesheng[i].ID.ToString() + "\t" + xuesheng[i].NAME);
                        xuesheng[i].djcj();//打印学生成绩
                        return;
                    }
                }
            }
            Console.WriteLine("没有找到学生");
        }
    }
}
