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
        public void Draw(int startX, int startY, int endX, int endY)
        {
            if (endX > startX)
            {
                int a = Convert.ToInt32(Math.Sqrt(Math.Pow(Math.Abs(endX - startX), 2) + Math.Pow(Math.Abs(endY - startY), 2)));
                int h = Convert.ToInt32(Math.Sqrt(Math.Pow(a, 2) - Math.Pow(startX - (endX - a), 2)));
                line.Draw(startX, startY, endX, endY);
                if (endY > startY)
                {
                    line.Draw(endX, endY, endX - a, startY + h);
                    line.Draw(endX - a, startY + h, startX, startY);
                }
                else
                {
                    line.Draw(endX, endY, endX - a, startY - h);
                    line.Draw(endX - a, startY - h, startX, startY);
                }
            }
            else
            {
                int a = Convert.ToInt32(Math.Sqrt(Math.Pow(Math.Abs(endX - startX), 2) + Math.Pow(Math.Abs(endY - startY), 2)));
                int h = Convert.ToInt32(Math.Sqrt(Math.Pow(a, 2) - Math.Pow(startX - (endX + a), 2)));
                line.Draw(startX, startY, endX, endY);
                if (endY > startY)
                {
                    line.Draw(endX, endY, endX + a, startY + h);
                    line.Draw(endX + a, startY + h, startX, startY);
                }
                else
                {
                    line.Draw(endX, endY, endX + a, startY - h);
                    line.Draw(endX + a, startY - h, startX, startY);
                }
            }
        }
    }
}
