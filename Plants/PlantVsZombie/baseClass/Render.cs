using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using PlantVsZombie.interfaces;

namespace PlantVsZombie.baseClass
{
    public abstract class Render : IRender
    {
        public Form Form { get; set; }
        protected BaseObject baseObject;
        public Render(Form form,BaseObject baseObject,int MaxFrame)
        {
            this.Form = form;
            this.baseObject = baseObject;
            this.Max_Frame = MaxFrame;
            initializeImages();
        }

        protected Bitmap[] Bitmaps;
        //初始化bitmap
        protected abstract void initializeImages();
       
        protected IGDIPaint iGDIPaint;
        public void PaintObj(Graphics g) {
            iGDIPaint.paint(g);
        }

        protected int cell = 0;
        protected int frame = 0;
        protected int Max_Frame;
        public void animate()
        {
            frame++;
            if (frame >= Max_Frame)
            {
                frame = 0;
            }
            baseObject.Cell = cell = frame;
            Form.Invalidate();
        }
    }
}
