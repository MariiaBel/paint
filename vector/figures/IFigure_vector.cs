using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint1
{
    public interface IFigure_vector
    {
        void Initial(Point point, Color color, float truck);
        List<Point> GetFigure();
        void ImageMauseMoveTillCreation(Point p);
        Point GetPoint(int index);
        int GetCountPoint();
        Pen GetPen();
        void ChangePoint(Point point, int index);
    }
}
