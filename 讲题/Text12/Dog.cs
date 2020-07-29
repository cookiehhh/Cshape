using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace Text12
{
    class Dog:Animal
    {
        public void shurt()
        {
            MessageBox.Show("我叫" + Name + "   汪，我今年" + Age + "岁了");
        }
    }
}
