using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint1
{


    public class Holst
    {
        public List<VectorLine> figures;

        public Holst()
        {
            figures = new List<VectorLine>();
        }

        public Bitmap Update(Bitmap b)
        {
            foreach (VectorLine f in figures)
            {
                Painter.DrawFigure(f, b);
            }
            return b;
        }

        public VectorLine FindPoint(Point p)
        {
            foreach (VectorLine f in figures)
            {
                if (f.points.Contains(p))
                {
                    return f;
                }
            }

            return null;

        }
    }
}
