using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Text12
{
    class Car:Animal
    {        
        public void shurt ()
        {
            MessageBox.Show("我叫"+Name + "   喵，我今年"+Age+"岁了");
        }
    }
}
