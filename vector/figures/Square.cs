using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint1
{
    class Square_vector : IFigure_vector
    {
        public List<Point> points
        {
            get;
            set;
        }
        public Pen pen;
        public Point p1, p2, p3;
        public void Initial(Point p, Color color, float size)
        {
            this.pen = new Pen(color, size);
            points = new List<Point>();
            points.Add(p);
            points.Add(p);
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
            points[2] = p;
            SetNewPoint(points[0], points[2]);
            points[1] = p1;
            points[2] = p2;
            points[3] = p3;


        }

        public void ChangePoint(Point point, int index)
        {
            points[index] = point;
        }

        private void SetNewPoint(Point p0, Point p2)
        {
            int width = p2.X - p0.X;
            this.p2.X = p0.X + width;
            this.p2.Y = p0.Y + width;
            p1.X = p0.X + width;
            p1.Y = p0.Y;
            p3.X = p0.X;
            p3.Y = p1.Y + width;

        }


    }
}
