namespace Paint1
{
    public class Square : IFigure
    {
        

        private IFigure line = new Line();

        public Square()
        {            
        }

        public void Draw(int startX, int startY, int endX, int endY, bool shift)
        {

            if (shift)
            {
                //квадрат
                int width = endX - startX;
                line.Draw(startX, startY, startX + width, startY, shift);
                line.Draw(startX, startY, startX, startY + width, shift);
                line.Draw(startX + width, startY, startX + width, startY + width, shift);
                line.Draw(startX, startY + width, startX + width, startY + width, shift);

            }
            else
            {
                line.Draw(startX, startY, endX, startY, shift);
                line.Draw(startX, startY, startX, endY, shift);
                line.Draw(endX, startY, endX, endY, shift);
                line.Draw(startX, endY, endX, endY, shift);
            }
        }
    }
}
