using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PlantVsZombie.baseClass;
using System.Windows.Forms;
using PlantVsZombie.gdipaints;
using System.Drawing;

namespace PlantVsZombie.renders
{
    class PeaBulletRender : Render
    {
        public PeaBulletRender(Form form, BaseObject baseObject)
            : base(form,baseObject, 1)
        {
            iGDIPaint = new PaintOnePicture(Bitmaps,baseObject);
        }
        protected override void initializeImages()
        {
            Bitmaps = new Bitmap[this.Max_Frame];
            Bitmaps[0] = Properties.Resources.PB00;
           
           
        }
    }
}
