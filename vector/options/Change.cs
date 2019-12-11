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
            foreach (IFigure_vector f in figures)
            {
                if (f.GetFigure().Contains(p))
                {
                    return f;
                }
            }

            return null;

        }
    }
}
