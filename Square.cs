namespace Paint1
{
    public class Square : IFigure
    {
        public bool IsRectrangle { get; set; }

        private IFigure line = new Line();

        public Square()
        {            
        }

        public void Draw(int startX, int startY, int endX, int endY)
        {

            if (!IsRectrangle)
            {
                //квадрат
                int width = endX - startX;
                line.Draw(startX, startY, startX + width, startY);
                line.Draw(startX, startY, startX, startY + width);
                line.Draw(startX + width, startY, startX + width, startY + width);
                line.Draw(startX, startY + width, startX + width, startY + width);

            }
            else
            {
                line.Draw(startX, startY, endX, startY);
                line.Draw(startX, startY, startX, endY);
                line.Draw(endX, startY, endX, endY);
                line.Draw(startX, endY, endX, endY);
            }
        }
    }
}
