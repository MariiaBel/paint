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

        public void DrawTriangle(int startX, int startY, int endX, int endY)
        {
            if (endX > startX)
            {
                int a = Convert.ToInt32(Math.Sqrt(Math.Pow(Math.Abs(endX - startX), 2) + Math.Pow(Math.Abs(endY - startY), 2)));
                int h = Convert.ToInt32(Math.Sqrt(Math.Pow(a, 2) - Math.Pow(startX - (endX - a), 2)));
                Brush.DrawLine(startX, startY, endX, endY);
                if (endY > startY)
                {
                    Brush.DrawLine(endX, endY, endX - a, startY + h);
                    Brush.DrawLine(endX - a, startY + h, startX, startY);
                }
                else
                {
                    Brush.DrawLine(endX, endY, endX - a, startY - h);
                    Brush.DrawLine(endX - a, startY - h, startX, startY);
                }
            }
            else
            {
                int a = Convert.ToInt32(Math.Sqrt(Math.Pow(Math.Abs(endX - startX), 2) + Math.Pow(Math.Abs(endY - startY), 2)));
                int h = Convert.ToInt32(Math.Sqrt(Math.Pow(a, 2) - Math.Pow(startX - (endX + a), 2)));
                Brush.DrawLine(startX, startY, endX, endY);
                if (endY > startY)
                {
                    Brush.DrawLine(endX, endY, endX + a, startY + h);
                    Brush.DrawLine(endX + a, startY + h, startX, startY);
                }
                else
                {
                    Brush.DrawLine(endX, endY, endX + a, startY - h);
                    Brush.DrawLine(endX + a, startY - h, startX, startY);
                }
            }
        }
    }
}
