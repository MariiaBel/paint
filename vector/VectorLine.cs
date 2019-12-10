using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint1
{
    public class VectorLine
    {
        public List<Point> points;
        public Pen pen;
        public VectorLine(Point p, Color color, float size)
        {
            this.pen = new Pen(color, size);
            points = new List<Point>();
            points.Add(p);
            points.Add(p);
        }

        public void ImageMauseMoveTillCreation(Point p)
        {
            points[1] = p;
        }




    }
}