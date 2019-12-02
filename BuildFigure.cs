using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint1
{
    class Build : IFigureBuild
    {
        private IFigure figure;

        public Build(IFigure check)
        {
            figure = check;
        }
        public void BuildFigure(int startX, int startY, int endX, int endY, bool shift)
        {
            figure.Draw(startX, startY, endX, endY, shift);
        }
        
        
    }
}
