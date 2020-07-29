using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stu
{
    /// <summary>
    /// 学生类
    /// </summary>
    class Student
    {
        /// <summary>
        /// 学号
        /// </summary>
        private string num;
        /// <summary>
        /// 名字
        /// </summary>
        private string name;
        /// <summary>
        /// 性别
        /// </summary>
        private string sex;

        public string Num
        {
            get { return num; }
            set { num = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
 

    }
}
