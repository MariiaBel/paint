using System;

namespace Paint1
{
    class Figure
    {
        public void DrawFigureByPoint(int startX, int startY, int endX, int endY)
        {
            Brush.DrawLine(startX, startY, endX, endY);
        }
    }
}
