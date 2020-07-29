using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text6
{
    public class Person
    {
        public string name;
        public int age;
        public float h;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public void Run (int l , string s)
        {
            Console.WriteLine("往前跑{0}米",l);
            Console.WriteLine(s);
        }
        public int Add (int a , int b)
        {
            int c = a + b;
            Console.WriteLine(c);
            return c;
        }


    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Run (25 , "Hello!");

            int i;
            i = p.Add(5, 6);

            p.Name = "zhangsan ";
            Console.WriteLine(p.Name);
            Console.ReadKey();
        }
    }
}
