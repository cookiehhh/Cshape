using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PlantVsZombie.baseClass;
using PlantVsZombie.renders;

namespace PlantVsZombie.controls
{
    public class GameRenders
    {
        private Game game;
        public Game Game { get { return this.game; } set { this.game = value; } }
        private Form gardenForm;
        private List<Render> renderList;
        public List<Render> RenderList { get { return this.renderList; } set { this.renderList = value; } }
        public GameRenders(Form gardenForm, Game game)
        {
            this.gardenForm = gardenForm;
            this.game = game;
            this.game.GameRenders = this;
            init();
        }
        private void init()
        {
            renderList = new List<Render>();
            //花园
            renderList.Add(new GardenRender(this.gardenForm, this.Game.Garden));

            //僵尸
            foreach (BaseObject zombie in this.Game.ZombiesList)
            {
                renderList.Add(new Zombie1Render(this.gardenForm, zombie));
            }

            foreach (BaseObject plant in this.Game.PlantList)
            {
                renderList.Add(new RepeaterRender(this.gardenForm, plant));
            }
        }

    }
}
