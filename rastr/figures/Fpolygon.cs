using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint1
{
    class Fpolygon : IFigure
    {
        private IFigure line = new Line();
        public void Draw(Bitmap bitmap, int startX, int startY, int endX, int endY, bool shift)
        {
            int i, X = startX, Y = startY,
                R = Convert.ToInt32(Math.Sqrt(Math.Pow(endX - startX, 2) + Math.Pow(endY - startY, 2))), angles = FigureAngles.GetAngles();

            double angle;
            double pointX1 = R * Math.Cos(0) + X,
                   pointY1 = R * Math.Sin(0) + Y;
            double pointX1m = pointX1,
                   pointY1m = pointY1;
            double pointX2, pointY2;

            for (i = 1; i <= angles; i++)
            {
                angle = 2 * Math.PI * i / angles;

                pointX2 = R * Math.Cos(angle) + X;
                pointY2 = R * Math.Sin(angle) + Y;

                if (i == angles) line.Draw(bitmap, Convert.ToInt32(pointX1), Convert.ToInt32(pointY1), Convert.ToInt32(pointX1m), Convert.ToInt32(pointY1m), shift);
                else line.Draw(bitmap, Convert.ToInt32(pointX1), Convert.ToInt32(pointY1), Convert.ToInt32(pointX2), Convert.ToInt32(pointY2), shift);
                pointX1 = pointX2;
                pointY1 = pointY2;
            }
        }

        public Point GetCenterPoint(int x1, int y1, int x2, int y2)
        {
            int centerX = (x1 + x2) / 2;
            int centerY = (y1 + y2) / 2;

            return new Point(centerX, centerY);
        }
    }
}
