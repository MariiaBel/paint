using System;
using System.Collections.Generic;
using System.Linq;
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

        public void DrawFigureCircle(int startX, int startY, int endX, int endY)
        {
            try
            {
                int radius = Convert.ToInt32(Math.Sqrt(Math.Pow(endX - startX, 2) + Math.Pow(endY - startY, 2)));

                int ax = -radius + startX;
                int ay = startY;
                for (int x = -radius; x <= radius; x++)
                {
                    int yOTx = Convert.ToInt32(Math.Sqrt(Math.Abs(Math.Pow(radius, 2) - Math.Pow(x, 2))));
                    Brush.DrawLine(ax, ay, x + startX, yOTx + startY);
                    ax = x + startX;
                    ay = yOTx + startY;
                }

                ax = -radius + startX;
                ay = startY;
                for (int x = -radius; x <= radius; x++)
                {
                    int yOTx = Convert.ToInt32(Math.Sqrt(Math.Abs(Math.Pow(radius, 2) - Math.Pow(x, 2))));
                    Brush.DrawLine(ax, ay, x + startX, -yOTx + startY);
                    ax = x + startX;
                    ay = -yOTx + startY;
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
