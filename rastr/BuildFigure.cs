using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint1
{
    class Build : IFigureBuild, IFill
    {
        private IFigure figure;
        private IFill stateFill;
        private bool checkFill;
        private Color brush;
        private Bitmap bitmap;
        private int x, y;


        public Bitmap ReturnBit()
        {
            return this.bitmap;
        }


        public void SetModify(Color brush, bool autoFill, Bitmap bitmap, int x, int y)
        {
            this.brush = brush;
            checkFill = autoFill;
            this.bitmap = bitmap;
            this.x = x;
            this.y = y;
        }

        public Build(IFigure check, IFill fill)
        {
            figure = check;
            stateFill = fill;
        }

        public void BuildFigure(int startX, int startY, int endX, int endY, bool shift)
        {
            if (checkFill)
            {
               
                figure.Draw(bitmap, startX, startY, endX, endY, shift);
                Fill(x, y, brush);
              
            } else
            {
                figure.Draw(bitmap, startX, startY, endX, endY, shift);
            }
        }


        public void Fill(int x, int y, Color brush) {
            stateFill = new FillSolid(bitmap);
            //Rectangle r = new Rectangle(0, 0, bitmap.Width - 1, bitmap.Height - 1);
            //Bitmap btm = bitmap.Clone(r, System.Drawing.Imaging.PixelFormat.DontCare);
            //bitmap = btm;
            stateFill.Fill(this.x, this.y, brush);   
        }
      



    }
}
