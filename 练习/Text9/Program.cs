using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text9
{
    class Student
    {
        string num;
        string name;
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
            List<string> arr = new List<string>();
            arr.Add ("hello");
            arr.Add ("world");
            arr.Add ("hello");
            string str = arr[0];
            Console.WriteLine(str);
            Console.WriteLine(10.0 / 3);
            Console.WriteLine(365 % 100);
            bool asd = 3 > 5;
            Console.WriteLine(asd);

            for(int i = 1; i <= 31;i++)
            {
                Console.WriteLine("今天是五月的{0}天",i);
                for (int j = 1; j <= 3;j++)
                {
                    Console.WriteLine("今天的第{0}顿饭",j);
                }
            }
            
            string[] arr = new string[] { "aaa", "bbb", "ccc", "ddd", "eee" };
            string a = "";
            for (int i = 0;i < arr.Length;i++)
            {
                a += arr[i];
                if (i < arr.Length -1)
                {
                    a += "|";
                }
            }
            Console.WriteLine(a);
            */
            /*
            int[] arr = new int[] { 111, 222, 3333, 4444, 555555 };
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            */
            /*
            int[] iarr = new int[5];
            float[] farr = new float[5];
            double[] darr = new double[5];
            string[] sarr = new string[5];
            bool[] barr = new bool[5];

            foreach (bool i in barr)
            {
                Console.WriteLine(i);
            }
            */
            
            int[,] map = new int[,]
            {
                {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 },
                {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
                {1,0,0,0,0,0,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,1 },
                {1,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
                {1,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
                {1,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
                {1,0,1,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,0,1 },
                {1,0,0,1,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,1 },
                {1,0,0,0,1,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,1 },
                {1,0,0,0,0,1,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,1 },
                {1,0,0,0,0,0,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,1 },
                {1,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,1 },
                {1,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,1 },
                {1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,1 },
                {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,0,1 },
                {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
                {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 }
            };

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[i, j] == 1)
                    {
                        Console.Write("■");
                    }
                    if (map[i, j] == 0)
                    {
                        Console.Write("□");
                    }
                }
                Console.WriteLine();
            }

            //int num = 5;
            //Add(ref num);
            //Console.WriteLine("num:" + num);
            /*
            int a = 10;
            int b = 5;

            int m_max;
            int m_min;
            int m_sum;
            double m_aver;
            Number(a, b, out m_max, out m_min, out m_sum, out m_aver);
            Console.WriteLine("Max={0},Min={1},Sum={2},Aver={3}", m_max, m_min, m_sum, m_aver);
            */
            //int a = AddNum(100);
            //Console.WriteLine(a);

            Console.ReadKey();
        }
        /// <summary>
        /// 递归
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        //static int AddNum(int n)
        //{
        //    if (n == 1)
        //    {
        //        return 1;
        //    }
        //    return n + AddNum(n - 1);
        //}


        /// <summary>
        /// out
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="max"></param>
        /// <param name="min"></param>
        /// <param name="sum"></param>
        /// <param name="aver"></param>

        /*
        static void Number(int a,int b,out int max,out int min,out int sum,out double aver)
        {
            if (a > b)
            {
                max = a;
                min = b;
            }
            else
            {
                max = b;
                min = a;
            }
            sum = a + b;
            aver = (a + b) / 2.0;
        }
        */
        /*
        static void Add(ref int num)
        {
            Console.WriteLine("s"+num);
            num += 10;
            Console.WriteLine("e"+num);
        }
        */
        /*
        static int Add(int a,int b)
        {
            return a + b;
        }
        static double Add(double a,double b)
        {
            return a + b;
        }
        static double Add(double a,int b)
        {
            return a + b;
        }
        */
        /*
        static int Add(int a,int b)
        {
            return a + b;
        }
        static double add(double a,int b)
        {
            return a + b;
        }
        */
        /*
        static void Show()
        {
            Console.WriteLine("封装");
        }
        static void For(int[] arr)
        {
            for (int i = 0;i < arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static int Get(int[] arr)
        {
            return arr.Length;
        }
        */
    

    }
}
