using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car car = new Car();
            //car.Cry();
            CarType car = new Car();
            car.Cry();

            Car c = (Car)car;
            c.Monkey();

            bool mk = c is Car;
            Console.WriteLine(mk);

            if (c as Car == null)
            {
                Console.WriteLine("转换失败！");
            }
            else
            {
                Console.WriteLine("转换成功！");
            }

            Console.WriteLine();

            Tiger tiger = new Tiger();
            tiger.Cry();

            Console.ReadKey();
        }
    }
}
