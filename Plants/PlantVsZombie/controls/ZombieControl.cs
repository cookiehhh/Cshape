using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PlantVsZombie.controls
{
    public partial class ZombieControl : UserControl
    {
       
        public ZombieControl()
        {
            InitializeComponent();
            BackColor = System.Drawing.Color.Transparent;
            BackgroundImageLayout = ImageLayout.Stretch;
            BackgroundImage = Properties.Resources.Zombie; 
        }
        private int cell = 0;
      

        private void timer1_Tick(object sender, EventArgs e)
        {
            cell++;
            switch (cell)
            {
                case 1: BackgroundImage = Properties.Resources.Zombie; break;
                case 2: BackgroundImage = Properties.Resources.Zombie2; break;
                default: BackgroundImage = Properties.Resources.Zombie;
                    cell = 0; break;

            }
        }
    }
}
