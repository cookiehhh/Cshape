using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你要排几个数的顺序：");
            int n;
            n = int.Parse(Console.ReadLine());
            int [] A= new int[n];
            Console.WriteLine("请依次输入你要排序的数:\n");
            for(int i = 0;i < n;i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0;i < n;i++)
            {
                for(int j = i + 1;j < n;j++ )
                {
                    int temp;
                    if(A[i] > A[j])
                    {
                        temp = A[j];
                        A[j] = A[i];
                        A[i] = temp;
                    }
                }
            }
            Console.WriteLine("排序的结果为：\n");
            for(int i = 0;i < n;i++)
            {
                Console.Write(" "+ A[i]);
            }
            
            Console.ReadKey();
        }
    }
}
