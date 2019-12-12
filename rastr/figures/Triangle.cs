using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing
    ;
namespace Paint1
{
    public class Triangle : IFigure
    {
        private IFigure line = new Line();
        public void Draw(Bitmap bitmap, int startX, int startY, int endX, int endY, bool shift)
        {
            if (shift)
            {
                line.Draw(bitmap, startX, startY, endX, endY, shift);
                line.Draw(bitmap, startX, startY, startX, endY, shift);
                line.Draw(bitmap, startX, endY, endX, endY, shift);
            }
            else
            {
                line.Draw(bitmap, startX, startY, endX, endY, shift);

                Point point3 = GetPoint3(startX, startY, endX, endY);

                line.Draw(bitmap, endX, endY, point3.X, point3.Y, shift);
                line.Draw(bitmap, point3.X, point3.Y, startX, startY, shift);
            }
        }

        Point GetPoint3(int startX, int startY, int endX, int endY)
        {
            int x3, y3;
            int w = Math.Abs(endX - startX);
            int h = Math.Abs(endY - startY);

            if (endX > startX)
            {
                if (endY > startY)
                {
                    x3 = Convert.ToInt32(w * Math.Cos(Math.PI / 3) - h * Math.Sin(Math.PI / 3) + startX);
                    y3 = Convert.ToInt32(w * Math.Sin(Math.PI / 3) + h * Math.Cos(Math.PI / 3) + startY);
                }
                else
                {
                    x3 = Convert.ToInt32(Math.Abs(w * Math.Cos(Math.PI / 3) - h * Math.Sin(Math.PI / 3) - endX));
                    y3 = Convert.ToInt32(w * Math.Sin(Math.PI / 3) + h * Math.Cos(Math.PI / 3) + endY);
                }
            }
            else
            {
                if (endY > startY)
                {
                    x3 = Convert.ToInt32(endX + w * Math.Cos(Math.PI / 3) - h * Math.Sin(Math.PI / 3));
                    y3 = Convert.ToInt32(endY - (w * Math.Sin(Math.PI / 3) + h * Math.Cos(Math.PI / 3)));
                }
                else
                {
                    x3 = Convert.ToInt32(startX + Math.Abs(w * Math.Cos(Math.PI / 3) - h * Math.Sin(Math.PI / 3)));
                    if (h == 0)
                    {
                        x3 = Convert.ToInt32(endX + Math.Abs(w * Math.Cos(Math.PI / 3) - h * Math.Sin(Math.PI / 3)));
                    }
                    if (w != 0 && Math.Atan(h / w) <= Math.PI / 6)
                    {
                        x3 = Convert.ToInt32(endX + Math.Abs(w * Math.Cos(Math.PI / 3) + h * Math.Sin(Math.PI / 3)));
                    }
                    y3 = Convert.ToInt32(Math.Abs(w * Math.Sin(Math.PI / 3) + h * Math.Cos(Math.PI / 3) - startY));
                }
            }
            return new Point(x3, y3);
        }

        public Point GetCenterPoint(int x1, int y1, int x2, int y2)
        {
            Point point3 = GetPoint3(x1, y1, x2, y2);

            int centerX = (x1 + x2 + point3.X) / 3;
            int centerY = (y1 + y2 + point3.Y) / 3;

            return new Point(centerX, centerY);
        }
    }
}
