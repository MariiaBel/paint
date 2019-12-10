using System.Drawing;

namespace Paint1
{
    public class Square : IFigure
    {
        

        private IFigure line = new Line();

        public Square()
        {            
        }

        public void Draw(Bitmap bitmap, int startX, int startY, int endX, int endY, bool shift)
        {

            if (shift)
            {
                //квадрат
                int width = endX - startX;
                line.Draw(bitmap, startX, startY, startX + width, startY, shift);
                line.Draw(bitmap, startX, startY, startX, startY + width, shift);
                line.Draw(bitmap, startX + width, startY, startX + width, startY + width, shift);
                line.Draw(bitmap, startX, startY + width, startX + width, startY + width, shift);

            }
            else
            {
                line.Draw(bitmap, startX, startY, endX, startY, shift);
                line.Draw(bitmap, startX, startY, startX, endY, shift);
                line.Draw(bitmap, endX, startY, endX, endY, shift);
                line.Draw(bitmap, startX, endY, endX, endY, shift);
            }
        }
    }
}
