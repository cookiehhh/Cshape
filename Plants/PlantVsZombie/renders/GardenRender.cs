using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using PlantVsZombie.baseClass;
using PlantVsZombie.gdipaints;

namespace PlantVsZombie.renders
{
    public class GardenRender : Render
    {
        private BaseObject garden;
        private controls.Game game;
        private System.Windows.Forms.Form gardenForm;
        public GardenRender(Form form,BaseObject obj)
            : base(form, obj,1)
        {
           
            iGDIPaint = new PaintOnePicture(Bitmaps,this.baseObject);
        }

       

        protected override void initializeImages()
        {
            Bitmaps = new Bitmap[Max_Frame];
            Bitmaps[0] = Properties.Resources.background1;
            
        }
        
    }
}
