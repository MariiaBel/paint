using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint1
{
    public class Polygon : IFigure
    {
        public void Draw(Bitmap bitmap, int startX, int startY, int endX, int endY, bool shift)
        {
            Brush.DrawLine(bitmap, startX, startY, endX, endY);
        }
    }
}
