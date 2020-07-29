using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    /// <summary>
    /// 学生类
    /// </summary>
    class Stud
    {
        /// <summary>
        /// 学号
        /// </summary>
        public string ID
        {
            get
            {
                return _id;
            }
        }
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
        }
        /// <summary>
        /// 学生成绩
        /// </summary>
        public ChengJi Cheng = new ChengJi();
         
        private string _id;//学号
        private string _name;//姓名

        /// <summary>
        /// 这是一个构造方法
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public Stud(string id,string name)
        {
            _id = id;
            _name = name;
        }
    }
}
