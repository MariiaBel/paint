using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint1
{

    public class Circle_vector : IFigure_vector
    {
        public List<Point> points{ get; set;}
        public Pen pen;
        Point center;
       
        public void Initial(Point point, Color color, float size)
        {
            this.pen = new Pen(color, size);
            points = new List<Point>();
            center = point;  
        }

        public void ImageMauseMoveTillCreation(Point point)
        {
            points = new List<Point>();
            CircleRadius(center, point);
        }
        public void CircleRadius(Point start, Point end)
        {
            Point p = new Point();
            int radius = Convert.ToInt32(Math.Sqrt(Math.Pow(end.X - start.X, 2) + Math.Pow(end.Y - start.Y, 2)));

            for (int x = -radius; x <= radius; x++)
            {
                int yOTx = Convert.ToInt32(Math.Sqrt(Math.Abs(Math.Pow(radius, 2) - Math.Pow(x, 2))));
                p.X = x+ start.X;
                p.Y = yOTx+start.Y;
                points.Add(p);
                
            }
            for (int x = radius; x >= -radius; x--) 
            {
                int yOTx = Convert.ToInt32(Math.Sqrt(Math.Abs(Math.Pow(radius, 2) - Math.Pow(x, 2))));
                p.X = x+start.X;
                p.Y = start.Y-yOTx;
                points.Add(p);
            }
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

        public Pen GetPen()
        {
            return pen;
        }

        public void ChangePoint(Point point, int index)
        {
            points[index] = point;
        }
    
    }
}
