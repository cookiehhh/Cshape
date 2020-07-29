using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PlantVsZombie.controls;
using PlantVsZombie.baseClass;

namespace PlantVsZombie.forms
{
    public partial class GardenForm : Form
    {
        private Game game;
        private GameRenders gameRenders;
        public GardenForm()
        {
            InitializeComponent();
            game = new Game();
            gameRenders = new GameRenders(this, this.game);
        }

        private void zombiesAnimateTimer_Tick(object sender, EventArgs e)
        {
            game.Go();
        }

        private void GardenForm_Paint(object sender, PaintEventArgs e)
        {
            foreach (Render render in gameRenders.RenderList)
            {
                render.PaintObj(e.Graphics);
            }
        }
    }
}
