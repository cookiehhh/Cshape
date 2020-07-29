using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PlantVsZombie.interfaces;
using System.Drawing;
using PlantVsZombie.baseClass;

namespace PlantVsZombie.gdipaints
{
    public class PaintLotsPictures:IGDIPaint
    {
        private Bitmap[] Bitmaps;
        private List<BaseObject> list;
        public PaintLotsPictures(Bitmap[] Bitmaps, List<BaseObject> list)
        {
            this.Bitmaps = Bitmaps;
            this.list = list;
        }
        public void paint(Graphics g)
        {
            foreach(BaseObject obj in list){
                g.DrawImageUnscaled(Bitmaps[obj.Cell],
                                             obj.Location.X, obj.Location.Y);
            }
        }
    }
}
