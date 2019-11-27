using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint1
{
    public class Brush
    {
        public Color BrushColor { set; get; } = Color.Black;
        public int BrushThickness { set; get; } = 1;
        
        public Bitmap BitmapImage
        {
            set;
            get;
        }

        public Brush(ref Bitmap btm)
        {
            this.BitmapImage = btm;
        }

        public void DrawLine(int startX, int startY, int endX, int endY)
        {
            double w = endX - startX,
                h = endY - startY,
                speed;

            if(Math.Abs(w) > Math.Abs(h))
            {                
                speed = (w == 0) ? 1 : h / w;                
                SetPixelByLength(Convert.ToInt32(w), startX, startY, speed, false);
            }
            else
            {
                speed = (h == 0) ? 1 : w / h;
                SetPixelByLength(Convert.ToInt32(h), startX, startY, speed);
            }
        }

        private void SetPixelByLength(int length, int startX, int startY, double speed, bool sideX = true)
        {
            int istart = 0;
            int iend = length;
            int step = (this.BrushThickness == 1) ? 1 : this.BrushThickness / 2;
            if (length < 0)
            {
                istart = length;
                iend = 0;
            }

            for (int i = istart; i <= iend; i+= step)
            {
                int iSpeed = Convert.ToInt32(i * speed);
                if (sideX)
                {
                    MakePoint(startX, startY, iSpeed, i);                   
                }
                else
                {
                    MakePoint(startX, startY, i, iSpeed);
                }
            }
        }

        private void MakePoint(int startX, int startY, int x, int y)
        {
            int thinkness = this.BrushThickness - 1;
            int starPointX = startX - thinkness;
            int starPointY = startY - thinkness;
            int endPointX = startX + thinkness;
            int endPointY= startY + thinkness;
            int leftedPoint = this.BrushThickness / 2;
            try
            {
                for (int i = starPointX; i <= endPointX; i++)
                {
                    for (int j = starPointY + leftedPoint; j <= endPointY - leftedPoint; j++)
                    {
                        BitmapImage.SetPixel(i + x, j + y, this.BrushColor);
                    }

                    if (i < starPointX + this.BrushThickness / 2) leftedPoint--;
                    if (i > endPointX - this.BrushThickness / 2) leftedPoint++;
                }
            }
            catch {}
        }

        private void MakePointMyFirstResult(int startX, int startY, int x, int y)
        {
            try
            {
                BitmapImage.SetPixel(startX + x, startY + y, this.BrushColor);
                for (int w = 1; w < this.BrushThickness; w++)
                {
                    BitmapImage.SetPixel(startX + x + w, startY + y + w, this.BrushColor);
                    for (int t = 0; t < w; t++)
                    {
                        BitmapImage.SetPixel(startX + x + w, startY + y + t, this.BrushColor);
                        BitmapImage.SetPixel(startX + x + t, startY + y + w, this.BrushColor);
                    }
                }
            }
            catch {}
        }
    }
}
