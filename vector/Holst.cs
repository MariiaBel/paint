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
        List<IFigure_vector> figures;
        public IBuild build;
       
        public Holst()
        {
            figures = new List<IFigure_vector>();
        }
        
        public Bitmap Update(Bitmap b)
        {
            foreach (IFigure_vector f in figures)
            {
                Painter.DrawFigure(f, b);
            }
            return b;
        }

        public void SetBuild(IBuild build)
        {
            this.build = build;
        }

        public IFigure_vector Interaction(Point point)
        {
            IFigure_vector result  = build.Options(point, figures);
            return result;
        }

        public void Add(IFigure_vector figures)
        {
            this.figures.Add(figures);
        }
        

    }
}
