using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint1
{
    public interface IFigure
    {
        void Draw(Bitmap bitmap, int startX, int startY, int endX, int endY, bool shift);

        Point GetCenterPoint(int startX, int startY, int endX, int endY);
    }
}
