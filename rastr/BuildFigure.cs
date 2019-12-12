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
        
        public Bitmap MyBitmap { get; set; }

        public void SetModify(Color FillColor, bool autoFill)
        {
            this.FillColor = FillColor;
            checkFill = autoFill;   
        }

        public Build(IFigure check, IFill fill)
        {
            figure = check;
            stateFill = fill;
        }

        public void BuildFigure(int startX, int startY, int endX, int endY, bool shift)
        {
            figure.Draw(MyBitmap, startX, startY, endX, endY, shift);

            if (checkFill)
            {
                Point centerPoint = figure.GetCenterPoint(startX, startY, endX, endY);
                if ((startX < centerPoint.X && centerPoint.X < endX ) || (endX  < centerPoint.X && centerPoint.X < startX ) )
                {
                    if ((startY < centerPoint.Y && centerPoint.Y < endY) || (endY < centerPoint.Y && centerPoint.Y < startY ))
                    {
                        if(!centerPoint.IsEmpty) Fill(centerPoint.X, centerPoint.Y, FillColor);
                    }
                }
            }
        }


        public void Fill(int x, int y, Color FillColor) 
        {
            stateFill = new FillSolid();
            stateFill.MyBitmap = MyBitmap;
            stateFill.Fill(x, y, FillColor);   
        }
    }
}
