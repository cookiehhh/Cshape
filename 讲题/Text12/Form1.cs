using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            car.Name = "咪咪";
            car.Age = 9;
            car.shurt();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dog dog = new Dog();
            dog.Name = "Dollar";
            dog.Age = 5;
            dog.shurt();
        }
    }
}
