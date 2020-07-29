using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stu
{
    /// <summary>
    /// 成绩类
    /// </summary>
    class Score
    {
        List<Subject> sub = new List<Subject>();
        /// <summary>
        /// 语文
        /// </summary>
        public double YuWen;
        /// <summary>
        /// 数学
        /// </summary>
        public double ShuXue;
        /// <summary>
        /// 英语
        /// </summary>
        public double YingYu;
        /// <summary>
        /// 平均成绩
        /// </summary>
        public double Aver;
        /// <summary>
        /// 总成绩
        /// </summary>
        public double Sum;

        public double aver()
        {
            return (YuWen + ShuXue + YingYu) / 3;
        }
        
        public double sum()
        {
            return YuWen + ShuXue + YingYu;
        }

    }
}
