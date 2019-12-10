using System.Drawing;
namespace Paint1
{
    public class FigureByPoint : IFigure
    {
        public void Draw(Bitmap bitmap, int startX, int startY, int endX, int endY, bool shift)
        {
            Brush.DrawLine(bitmap, startX, startY, endX, endY);
        }
    }
}
