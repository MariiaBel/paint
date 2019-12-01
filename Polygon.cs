using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint1
{
    public class Polygon : IFigure
    {
        public void Draw(int startX, int startY, int endX, int endY)
        {
            Brush.DrawLine(startX, startY, endX, endY);
        }
    }
}
