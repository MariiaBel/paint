using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint1
{
    class Figure
    {
        

        public Brush Brush
        {
            set;
            get;
        }
        public Figure(Brush brush)
        {
            this.Brush = brush;
        }

        public void DrawFigureSquare(int startX, int startY, int endX, int endY)
        {
            Brush.DrawLine(startX, startY, endX, startY);
            Brush.DrawLine(startX, startY, startX, endY);
            Brush.DrawLine(endX, startY, endX, endY);
            Brush.DrawLine(startX, endY, endX, endY);
        }

        public void DrawFigureByPoint(int startX, int startY, int endX, int endY)
        {
            Brush.DrawLine(startX, startY, endX, endY);
        }
    }
}
