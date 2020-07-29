using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PlantVsZombie.baseClass;
using PlantVsZombie.renders;
using PlantVsZombie.forms;

namespace PlantVsZombie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gardenForm = new GardenForm();


        }
        private Form gardenForm;

        private void button1_Click(object sender, EventArgs e)
        {
            if (gardenForm != null)
            {
                gardenForm = new GardenForm();
                if (!gardenForm.Visible)
                {
                    gardenForm.Visible = true;
                }
            }


        }


    }
}
