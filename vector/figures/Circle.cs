using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint1
{
    public class Circle_vector
    {
        public List<Point> points;
        public Pen pen;
        Point pointForCircle;

        public void Circle(Point p, Color c, float s)
        {
            this.pen = new Pen(c, s);
            points = new List<Point>();
            points.Add(p);
            points.Add(p);
        }
        public void MouseMoveTillCreation(Point p)
        {
            points[1] = p;
            CircleRadius(points[0], points[1]);
        }
        public void CircleRadius(Point start, Point end)
        {
            int radius = Convert.ToInt32(Math.Sqrt(Math.Pow(end.X - start.X, 2) + Math.Pow(end.Y - start.Y, 2)));
            //int ax = -radius + start.X;
            //int ay = start.Y;
            //int ay1 = start.Y;
            for (int x = -radius; x <= radius; x++)
            {
                int pointForCircle = Convert.ToInt32(Math.Sqrt(Math.Abs(Math.Pow(radius, 2) - Math.Pow(x, 2))));
                //line.Draw(bitmap, ax, ay, x + startX, yOTx + startY, shift);
                //line.Draw(bitmap, ax, ay1, x + startX, -yOTx + startY, shift);
                //ax = x + start.X;
                //ay = yOTx + start.Y;
                //ay1 = -yOTx + start.Y;
            }
            points[1] = pointForCircle;
            
        }
    }
}
//     case "Circle":
//                            bitmapVector = new Bitmap(canvas.Width, canvas.Height);
//                            model.ImageMauseMoveTillCreation(new Point(e.X, e.Y));
//                            Painter.DrawFigure(model, bitmapVector);
//                            holst.figures.Add(model);
//                            canvas.Image = holst.Update(bitmapVector);
//                            break;