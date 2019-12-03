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
        public void Draw(int startX, int startY, int endX, int endY, bool shift, int angles)
        {
            if (endX > startX)
            {
                int a = Convert.ToInt32(Math.Sqrt(Math.Pow(Math.Abs(endX - startX), 2) + Math.Pow(Math.Abs(endY - startY), 2)));
                int h = Convert.ToInt32(Math.Sqrt(Math.Pow(a, 2) - Math.Pow(startX - (endX - a), 2)));
                line.Draw(startX, startY, endX, endY, shift, angles);
                if (endY > startY)
                {
                    line.Draw(endX, endY, endX - a, startY + h, shift, angles);
                    line.Draw(endX - a, startY + h, startX, startY, shift, angles);
                }
                else
                {
                    line.Draw(endX, endY, endX - a, startY - h, shift, angles);
                    line.Draw(endX - a, startY - h, startX, startY, shift, angles);
                }
            }
            else
            {
                int a = Convert.ToInt32(Math.Sqrt(Math.Pow(Math.Abs(endX - startX), 2) + Math.Pow(Math.Abs(endY - startY), 2)));
                int h = Convert.ToInt32(Math.Sqrt(Math.Pow(a, 2) - Math.Pow(startX - (endX + a), 2)));
                line.Draw(startX, startY, endX, endY, shift, angles);
                if (endY > startY)
                {
                    line.Draw(endX, endY, endX + a, startY + h, shift, angles);
                    line.Draw(endX + a, startY + h, startX, startY, shift, angles);
                }
                else
                {
                    line.Draw(endX, endY, endX + a, startY - h, shift, angles);
                    line.Draw(endX + a, startY - h, startX, startY, shift, angles);
                }
            }
        }
    }
}
