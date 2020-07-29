using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text12
{
    class Dog1:Animal1
    {
        public Dog1():base()
        {

        }
        public Dog1(string name) : base(name)
        {
            //this.name = name;
        }
        public Dog1(string name, int age) : base(name,age)
        {
            //this.name = name;
            //this.age = age;
        }
        public void shurt()
        {
            MessageBox.Show("我叫" + name + "   汪，我今年" + age + "岁了");
        }
    }
}
