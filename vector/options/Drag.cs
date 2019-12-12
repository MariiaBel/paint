using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint1
{
    class Drag
    {
        public void FindDelta(IFigure_vector figure, Point start)
        {
            List<Point> points = figure.GetFigure();
            for (int i = 0; i < points.Count; i++)
            {
                if (start.X < points[1].X && start.X > points[2].X)
                {
                    if (start.Y > points[0].Y && start.Y < points[2].Y)
                    {

                        deltaX1 = start.X - points[0].X;
                        deltaY1 = start.Y - points[0].Y;
                        deltaX2 = start.X - points[1].X;
                        deltaY2 = start.Y - points[1].Y;
                        deltaX3 = start.X - points[2].X;
                        deltaY3 = start.Y - points[2].Y;
                    }
                }
            }
            
        }
        public void Move()
        {
            Point diff1 = e.Location, diff2 = e.Location, diff3 = e.Location;
            diff1.X = e.X - deltaX1;
            diff1.Y = e.Y - deltaY1;
            diff2.X = e.X - deltaX2;
            diff2.Y = e.Y - deltaY2;
            diff3.X = e.X - deltaX3;
            diff3.Y = e.Y - deltaY3;
            tr.points[0] = diff1;
            tr.points[1] = diff2;
            tr.points[2] = diff3;
            vectorImage = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            VectorGraph = Graphics.FromImage(vectorImage);
            VectorGraph.Clear(Color.White);
            pictureBox1.Image = canvas.Update(vectorImage);

        }

        public Point ReturnPoints(List<Point> p)
        {
            for (int i = 0; i < p.Count; i++)
            {
                return p[i];
            }
        }

        public int ReturnDelta(List<Point> p)
        {
            for (int i = 0; i < p.Count; i++)
            {
                return p[i];
            }
        }
    }
}
