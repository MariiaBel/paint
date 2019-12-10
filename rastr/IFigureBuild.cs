using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint1
{
    public interface IFigureBuild 
    {
        void BuildFigure(int startX, int startY, int endX, int endY, bool shift);
        void SetModify(Color brush, bool autoFill, Bitmap bitmap, int x, int y);
        Bitmap ReturnBit();
    }
}
