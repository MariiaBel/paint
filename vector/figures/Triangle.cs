using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint1
{
    class Triangle_vector : IFigure_vector
    {
        public List<Point> points
        {
            get;
            set;
        }
        public Pen pen;
        Point p3;

        public void Initial(Point p, Color color, float size)
        {
            this.pen = new Pen(color, size);
            points = new List<Point>();
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
            points[1] = p;
            TriangleTop(points[0], points[1]);
        }

        public void ChangePoint(Point point, int index)
        {
            points[index] = point;
        }

        public void TriangleTop(Point start, Point end)
        {
            int w = Math.Abs(end.X - start.X);
            int h = Math.Abs(end.Y - start.Y);


            if (end.X > start.X)
            {
                if (end.Y > start.Y)
                {
                    p3.X = Convert.ToInt32(w * Math.Cos(Math.PI / 3) - h * Math.Sin(Math.PI / 3) + start.X);
                    p3.Y = Convert.ToInt32(w * Math.Sin(Math.PI / 3) + h * Math.Cos(Math.PI / 3) + start.Y);
                }
                else
                {
                    p3.X = Convert.ToInt32(Math.Abs(w * Math.Cos(Math.PI / 3) - h * Math.Sin(Math.PI / 3) - end.X));
                    p3.Y = Convert.ToInt32(w * Math.Sin(Math.PI / 3) + h * Math.Cos(Math.PI / 3) + end.Y);
                }
            }
            else
            {
                if (end.Y > start.Y)
                {
                    p3.X = Convert.ToInt32(end.X + w * Math.Cos(Math.PI / 3) - h * Math.Sin(Math.PI / 3));
                    p3.Y = Convert.ToInt32(end.Y - (w * Math.Sin(Math.PI / 3) + h * Math.Cos(Math.PI / 3)));
                }
                else
                {
                    p3.X = Convert.ToInt32(start.X + Math.Abs(w * Math.Cos(Math.PI / 3) - h * Math.Sin(Math.PI / 3)));
                    if (h == 0)
                    {
                        p3.X = Convert.ToInt32(end.X + Math.Abs(w * Math.Cos(Math.PI / 3) - h * Math.Sin(Math.PI / 3)));
                    }
                    if (w != 0 && Math.Atan(h / w) <= Math.PI / 6)
                    {
                        p3.X = Convert.ToInt32(end.X + Math.Abs(w * Math.Cos(Math.PI / 3) + h * Math.Sin(Math.PI / 3)));
                    }
                    p3.Y = Convert.ToInt32(start.Y - (w * Math.Sin(Math.PI / 3) + h * Math.Cos(Math.PI / 3)));
                    
                }
            }

            points[2] = p3;
        }
    }
}
