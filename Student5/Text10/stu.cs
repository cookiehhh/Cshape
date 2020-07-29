using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text10
{
    /// <summary>
    /// 学生类
    /// </summary>
    class stu
    {
        int num;
        string name = null;
        chengji[] cj = new chengji[300];
        int n = 0;
        public stu(int num, string name)
        {
            this.num = num; this.name = name;
        }
        public int ID
        {
            get { return num; }
        }
        public string NAME
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>
        /// 添加成绩
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="fenshu"></param>
        /// <returns></returns>
        public bool tjcj(int id, string name, double fenshu)
        {
            for (int i = 0; i < n; i++) if (cj[i].ID == id) return false;
            cj[n] = new chengji(id, name, fenshu); n++; return true;
        }
        /// <summary>
        /// 平均成绩
        /// </summary>
        /// <returns></returns>
        public double av()
        {
            double a = 0.0;
            for (int i = 0; i < n; i++) { a += cj[i].FENSHU; }
            a /= n;
            return a;
        }
        /// <summary>
        /// 打印成绩
        /// </summary>
        public void djcj()
        {
            Console.WriteLine("课程号\t课程名称\t成绩");
            for (int i = 0; i < n; i++) System.Console.WriteLine(cj[i].ID.ToString() + "\t" +
                        cj[i].NAME + "\t" + cj[i].FENSHU.ToString());
            Console.WriteLine("平均分:\t" + av().ToString());
        }
    }
}
