using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint1
{
    public static class Painter
    {
        public static void DrawFigure(IFigure_vector figure, Bitmap bitmap)
        {
            Graphics gr = Graphics.FromImage(bitmap);
            for (int i = 0; i < figure.GetCountPoint() - 1; i++)
            {
                gr.DrawLine(figure.GetPen(), figure.GetPoint(i), figure.GetPoint(i + 1));
            }
            gr.DrawLine(figure.GetPen(), figure.GetPoint(0), figure.GetPoint(figure.GetCountPoint() - 1));
        }
    }
}
