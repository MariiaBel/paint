using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint1
{
    public class Circle : IFigure
    {
       

        private IFigure line = new Line();
        public void Draw(int startX, int startY, int endX, int endY, bool shift)
        {
            try
            {
                int radius = Convert.ToInt32(Math.Sqrt(Math.Pow(endX - startX, 2) + Math.Pow(endY - startY, 2)));
                if (shift)
                {

                    int ax = -radius + startX;
                    int ay = startY;
                    int ay1 = startY;
                    for (int x = -radius; x <= radius; x++)
                    {
                        int yOTx = Convert.ToInt32(Math.Sqrt(Math.Abs(Math.Pow(radius, 2) - Math.Pow(x, 2))));
                        line.Draw(ax, ay, x + startX, yOTx + startY, shift);
                        line.Draw(ax, ay1, x + startX, -yOTx + startY,shift);
                        ax = x + startX;
                        ay = yOTx + startY;
                        ay1 = -yOTx + startY;
                    }
                }
                else
                {
                    double w = Math.Abs(endX - startX);
                    double h = Math.Abs(endY - startY);
                    double big, small;
                    bool flagVertical = false;
                    if (w >= h)
                    {
                        big = w;
                        small = h;
                    }
                    else
                    {
                        big = h;
                        small = w;
                        flagVertical = true;
                    }
                    int tmpX = 0, tmpY = 0;

                    for (int i = 0; i <= big; i++)
                    {
                        double x; double y;

                        if (flagVertical)
                        {
                            y = i;
                            x = Math.Sqrt((Math.Pow(small, 2) / Math.Pow(big, 2)) * (Math.Pow(big, 2) - Math.Pow(y, 2)));
                        }
                        else
                        {
                            x = i;
                            y = Math.Sqrt((Math.Pow(small, 2) / Math.Pow(big, 2)) * (Math.Pow(big, 2) - Math.Pow(x, 2)));
                        }


                        if (i == 0)
                        {
                            line.Draw(Convert.ToInt32(startX + x), Convert.ToInt32(startY + y), Convert.ToInt32(startX + x), Convert.ToInt32(startY + y), shift);
                            line.Draw(Convert.ToInt32(startX + x), Convert.ToInt32(startY - y), Convert.ToInt32(startX + x), Convert.ToInt32(startY - y), shift);
                            line.Draw(Convert.ToInt32(startX - x), Convert.ToInt32(startY - y), Convert.ToInt32(startX - x), Convert.ToInt32(startY - y), shift);
                            line.Draw(Convert.ToInt32(startX - x), Convert.ToInt32(startY + y), Convert.ToInt32(startX - x), Convert.ToInt32(startY + y), shift);



                            tmpX = Convert.ToInt32(x);
                            tmpY = Convert.ToInt32(y);
                        }
                        else
                        {
                            line.Draw((startX + tmpX), (startY + tmpY), Convert.ToInt32(startX + x), Convert.ToInt32(startY + y), shift);
                            line.Draw((startX + tmpX), (startY - tmpY), Convert.ToInt32(startX + x), Convert.ToInt32(startY - y), shift);
                            line.Draw((startX - tmpX), (startY - tmpY), Convert.ToInt32(startX - x), Convert.ToInt32(startY - y), shift);
                            line.Draw((startX - tmpX), (startY + tmpY), Convert.ToInt32(startX - x), Convert.ToInt32(startY + y), shift);
                            tmpX = Convert.ToInt32(x);
                            tmpY = Convert.ToInt32(y);
                        }

                    }
                }
            }
            catch (Exception)
            {

            }
      
        }
    }
}
