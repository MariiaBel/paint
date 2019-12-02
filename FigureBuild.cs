using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint1
{
    public interface IFigureBuild 
    {
        void BuildFigure(int startX, int startY, int endX, int endY, bool shift);
    }
}
