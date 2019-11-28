using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;

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

        public void DrawFigureSquare(int startX, int startY, int endX, int endY, bool shift)
        {
           
            if (shift)
            {
                //квадрат
                int width = endX - startX;
                Brush.DrawLine(startX, startY, startX + width, startY);
                Brush.DrawLine(startX, startY, startX, startY + width);
                Brush.DrawLine(startX + width, startY, startX + width, startY + width);
                Brush.DrawLine(startX, startY + width, startX + width, startY + width);

            } else
            {
                Brush.DrawLine(startX, startY, endX, startY);
                Brush.DrawLine(startX, startY, startX, endY);
                Brush.DrawLine(endX, startY, endX, endY);
                Brush.DrawLine(startX, endY, endX, endY);
            }
        }

        public void DrawFigureCircle(int startX, int startY, int endX, int endY, bool shift)
        {
            try
            {
                int radius = Convert.ToInt32(Math.Sqrt(Math.Pow(endX - startX, 2) + Math.Pow(endY - startY, 2)));
                if (shift)
                {

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

                    for (int i = 0; i<=big; i++)
                    {
                        double x; double y;
                        
                        if (flagVertical)
                        {
                            y = i;
                            x = Math.Sqrt((Math.Pow(small, 2)/ Math.Pow(big, 2))*(Math.Pow(big, 2) - Math.Pow(y, 2)));
                        }
                        else
                        {
                            x = i;
                            y = Math.Sqrt((Math.Pow(small, 2) / Math.Pow(big, 2)) * (Math.Pow(big, 2) - Math.Pow(x, 2)));
                        }


                        if (i == 0)
                        {
                            Brush.DrawLine(Convert.ToInt32(startX + x), Convert.ToInt32(startY + y), Convert.ToInt32(startX + x), Convert.ToInt32(startY + y));
                            Brush.DrawLine(Convert.ToInt32(startX + x), Convert.ToInt32(startY - y), Convert.ToInt32(startX + x), Convert.ToInt32(startY - y));
                            Brush.DrawLine(Convert.ToInt32(startX - x), Convert.ToInt32(startY - y), Convert.ToInt32(startX - x), Convert.ToInt32(startY - y));
                            Brush.DrawLine(Convert.ToInt32(startX - x), Convert.ToInt32(startY + y), Convert.ToInt32(startX - x), Convert.ToInt32(startY + y));

                          

                            tmpX = Convert.ToInt32(x);
                            tmpY = Convert.ToInt32(y);
                        }
                        else
                        {
                            Brush.DrawLine((startX + tmpX), (startY + tmpY), Convert.ToInt32(startX + x), Convert.ToInt32(startY + y));
                            Brush.DrawLine((startX + tmpX), (startY - tmpY), Convert.ToInt32(startX + x), Convert.ToInt32(startY - y));
                            Brush.DrawLine((startX - tmpX), (startY - tmpY), Convert.ToInt32(startX - x), Convert.ToInt32(startY - y));
                            Brush.DrawLine((startX - tmpX), (startY + tmpY), Convert.ToInt32(startX - x), Convert.ToInt32(startY + y));
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

        public void DrawFigureByPoint(int startX, int startY, int endX, int endY)
        {
            Brush.DrawLine(startX, startY, endX, endY);
        }

     
    }
}
