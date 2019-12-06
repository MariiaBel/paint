using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint1
{
    public class Triangle : IFigure
    {
        private IFigure line = new Line();
        public void Draw(int startX, int startY, int endX, int endY, bool shift)
        {
            if (shift)
            {
                line.Draw(startX, startY, endX, endY, shift);
                line.Draw(startX, startY, startX, endY, shift);
                line.Draw(startX, endY, endX, endY, shift);
            }
            else
            {
                int w = Math.Abs(endX - startX);
                int h = Math.Abs(endY - startY);

                line.Draw(startX, startY, endX, endY, shift);

                if (endX > startX)
                {
                    if (endY > startY)
                    {
                        int x3 = Convert.ToInt32(w * Math.Cos(Math.PI / 3) - h * Math.Sin(Math.PI / 3) + startX);
                        int y3 = Convert.ToInt32(w * Math.Sin(Math.PI / 3) + h * Math.Cos(Math.PI / 3) + startY);
                        line.Draw(endX, endY, x3, y3, shift);
                        line.Draw(x3, y3, startX, startY, shift);
                    }
                    else
                    {
                        int x3 = Convert.ToInt32(Math.Abs(w * Math.Cos(Math.PI / 3) - h * Math.Sin(Math.PI / 3) - endX));
                        int y3 = Convert.ToInt32(w * Math.Sin(Math.PI / 3) + h * Math.Cos(Math.PI / 3) + endY);
                        line.Draw(endX, endY, x3, y3, shift);
                        line.Draw(x3, y3, startX, startY, shift);
                    }
                }
                else
                {
                    if (endY > startY)
                    {
                        int x4 = Convert.ToInt32(endX + w * Math.Cos(Math.PI / 3) - h * Math.Sin(Math.PI / 3));
                        int y4 = Convert.ToInt32(endY - (w * Math.Sin(Math.PI / 3) + h * Math.Cos(Math.PI / 3)));
                        line.Draw(endX, endY, x4, y4, shift);
                        line.Draw(x4, y4, startX, startY, shift);

                    }
                    else
                    {
                        int x4 = Convert.ToInt32(startX + Math.Abs(w * Math.Cos(Math.PI / 3) - h * Math.Sin(Math.PI / 3)));
                        if (h == 0)
                        {
                            x4 = Convert.ToInt32(endX + Math.Abs(w * Math.Cos(Math.PI / 3) - h * Math.Sin(Math.PI / 3)));
                        }
                        if (w != 0 && Math.Atan(h / w) <= Math.PI / 6)
                        {
                            x4 = Convert.ToInt32(endX + Math.Abs(w * Math.Cos(Math.PI / 3) + h * Math.Sin(Math.PI / 3)));
                        }
                        int y4 = Convert.ToInt32(Math.Abs(w * Math.Sin(Math.PI / 3) + h * Math.Cos(Math.PI / 3) - startY));
                        line.Draw(endX, endY, x4, y4, shift);
                        line.Draw(x4, y4, startX, startY, shift);
                    }
                }
            }
        }
    }
}
