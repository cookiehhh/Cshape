using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text12
{
    class Car1:Animal1
    {
        public Car1():base()
        {

        }
        public Car1(string name) : base(name)
        {
            //this.name = name;
        }
        public Car1(string name, int age) : base(name,age)
        {
            //this.name = name;
            //this.age = age;
        }
        public void shurt()
        {
            MessageBox.Show("我叫" + name + "   喵，我今年" + age + "岁了");
        }
    }
}
