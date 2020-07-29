using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PlantVsZombie.controls
{
    class ZombieControlPB: PictureBox
    {
      
        public ZombieControlPB()
        {
            BackColor = System.Drawing.Color.Transparent;
            BackgroundImageLayout = ImageLayout.Stretch;
            Image = Properties.Resources.Zombie;
            SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
        }

     
    }
}
