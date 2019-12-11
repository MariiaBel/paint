using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint1
{
    public interface IBuild
    {
        IFigure_vector Options(Point p, List<IFigure_vector> figures);
    }
}
