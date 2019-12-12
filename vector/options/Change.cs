using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint1
{ 
    class Change : IBuild
    {
        public IFigure_vector Options(Point p, List<IFigure_vector> figures)
        { 
            int size = 7;
            Point q = new Point(p.X - size, p.Y - size);
            Point tmp;
            
            for (int i = 0; i <= size * 4 + 1; i++)
            {
                for (int j = 0; j <= size * 4 + 1; j++)
                {
                    tmp = new Point(q.X + i, q.Y + j);

                    foreach (IFigure_vector f in figures)
                    {
                        List<Point> points = f.GetFigure();
                        if (points.Contains(tmp))
                        {
                            return f;
                        }
                    }
                }
            }
            return null;

        }
    }
}
