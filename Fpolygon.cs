using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint1
{
    class Fpolygon: IFigure
    {
        public IFigure line = new Line();

        public void Draw(int startX, int startY, int endX, int endY, bool shift, int angles)
        {
            int i, X = startX, Y = startY,
                R = Convert.ToInt32(Math.Sqrt(Math.Pow(endX - startX, 2) + Math.Pow(endY - startY, 2)));

            if (angles < 3) angles = 3;
            double angle;
            double pointX1 = R * Math.Cos(0) + X,
                   pointY1 = R * Math.Sin(0) + Y;
            double pointX1m = pointX1,
                   pointY1m = pointY1;
            double pointX2, pointY2;

            //pointX1 = R * Math.Cos(angle) + X;
            //pointY1 = R * Math.Sin(angle) + Y;

            for (i = 1; i <= angles; i++)
            {
                angle = 2 * Math.PI * i / angles;

                pointX2 = R * Math.Cos(angle) + X;
                pointY2 = R * Math.Sin(angle) + Y;

                if (i == angles) Brush.DrawLine(Convert.ToInt32(pointX1), Convert.ToInt32(pointY1), Convert.ToInt32(pointX1m), Convert.ToInt32(pointY1m));
                else Brush.DrawLine(Convert.ToInt32(pointX1), Convert.ToInt32(pointY1), Convert.ToInt32(pointX2), Convert.ToInt32(pointY2));
                pointX1 = pointX2;
                pointY1 = pointY2;
            }
        }
    }
}
