
namespace Paint1
{
    public class FigureByPoint : IFigure
    {
        public void Draw(int startX, int startY, int endX, int endY, bool shift)
        {
            Brush.DrawLine(startX, startY, endX, endY);
        }
    }
}
