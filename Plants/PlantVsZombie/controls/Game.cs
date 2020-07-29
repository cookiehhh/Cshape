using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PlantVsZombie.baseClass;
using System.Drawing;
using System.Windows.Forms;
using PlantVsZombie.renders;

namespace PlantVsZombie.controls
{
    public class Game
    {
        public BaseObject Garden { get; private set; }
        public GameRenders GameRenders { get; set; }
       // private List<BaseObject> plantList;

        public List<BaseObject> PlantList { get; set; }
        private List<BaseObject> zombiesList;
        public List<BaseObject> ZombiesList
        {
            get
            {
                return this.zombiesList;
            }
            set
            {
                this.zombiesList = value;
            }
        }
        public Game()
        {
            init();
        }
        private void init()
        {
            zombiesList = new List<BaseObject>();
            PlantList = new List<BaseObject>();
            //添加花园
            Garden = new BaseObject(new Point(0, 100));

            //添加僵尸
            for (int i = 0; i < 10; i++)
            {
                zombiesList.Add(new BaseObject(new Point(700 + i * 20, 550)));
            }
            //添加植物
            PlantList.Add(new BaseObject(new Point(250, 580)));
           
        }
        public void Go()
        {

            foreach (Render render in GameRenders.RenderList)
            {
                render.animate();
                
            }
        }
    }
}
