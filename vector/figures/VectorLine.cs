using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint1
{
    public class VectorLine : IFigure_vector
    {
        public List<Point> points {
            get;
            set;
        }
        public Pen pen;

        public void Initial(Point p, Color color, float size)
        {
            this.pen = new Pen(color, size);
            points = new List<Point>();
            points.Add(p);
            points.Add(p);
        }


        public Pen GetPen()
        {
            return pen;
        }
        
        public List<Point> GetFigure()
        {
            return points;
        }

        public Point GetPoint(int index)
        {
            return points[index];             
        }

        public int GetCountPoint()
        {
            return points.Count;
        }

        public void ImageMauseMoveTillCreation(Point p)
        {
            points[1] = p;
        }

        public void ChangePoint(Point point, int index)
        {
            points[index] = point;
        }



    }
}