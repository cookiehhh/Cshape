using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PlantVsZombie.interfaces;
using System.Drawing;
using PlantVsZombie.baseClass;
using System.Diagnostics;

namespace PlantVsZombie.gdipaints
{
    class PaintOnePicture : IGDIPaint
    {
        private Bitmap[] Bitmaps;
        private BaseObject obj;
        public PaintOnePicture(Bitmap[] Bitmaps,BaseObject obj)
        {
            this.Bitmaps = Bitmaps;            this.obj = obj;        }
        public void paint(System.Drawing.Graphics g)
        {
            Debug.Assert(obj != null, "PaintOnePicture obj不能为null!");
            g.DrawImageUnscaled(Bitmaps[obj.Cell],
                                            obj.Location.X, obj.Location.Y);
           
        }

    }
}
