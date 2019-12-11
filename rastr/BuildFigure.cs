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
        private Color FillColor;
        private int x, y;
        
        public Bitmap MyBitmap { get; set; }

        public void SetModify(Color FillColor, bool autoFill, int x, int y)
        {
            this.FillColor = FillColor;
            checkFill = autoFill;         
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
               
                figure.Draw(MyBitmap, startX, startY, endX, endY, shift);
                if ((startX < x && x < endX ) || (endX  < x && x < startX ) )
                {
                    if ((startY < y && y < endY) || (endY < y && y < startY ))
                    {
                        Fill(x, y, FillColor);
                    }
                }
            } else
            {
                figure.Draw(MyBitmap, startX, startY, endX, endY, shift);
            }
        }


        public void Fill(int x, int y, Color FillColor) 
        {
            stateFill = new FillSolid();
            stateFill.MyBitmap = MyBitmap;
            stateFill.Fill(this.x, this.y, FillColor);   
        }
    }
}
