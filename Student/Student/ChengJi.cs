using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    /// <summary>
    /// 成绩类
    /// </summary>
    class ChengJi
    {
        /// <summary>
        /// 语文
        /// </summary>
        public float YuWen;
        /// <summary>
        /// 数学
        /// </summary>
        public float ShuXue;
        /// <summary>
        /// 英语
        /// </summary>
        public float YingYu;


        /// <summary>
        /// 平均值
        /// </summary>
        public float aver()
        {
            return (YuWen + ShuXue + YingYu) / 3;
        }
        /// <summary>
        /// 总成绩
        /// </summary>
        public float sum()
        {
            return YuWen + ShuXue + YingYu;
        }
        
   
    }
}
