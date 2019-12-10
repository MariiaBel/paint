using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint1
{
    public class FillSolid : IFill
    {

        public Bitmap bitmap;

        public FillSolid(Bitmap bitmap)
        {
            this.bitmap = bitmap;
        }
        public FillSolid()
        {
        }

        public Bitmap ReturnBit()
        {
            return this.bitmap;
        }

        public void Fill(int x, int y, Color brush)
        {
            Color temp = bitmap.GetPixel(x, y);

            int countLeft = x;
            int countRight = x;

            while (countLeft - 1 > 0 && bitmap.GetPixel(countLeft - 1, y) == temp)
            {
                countLeft--;
            }

            while (countRight + 1 < bitmap.Width && bitmap.GetPixel(countRight + 1, y) == temp)
            {
                countRight++;
            }

            for (int i = countLeft; i <= countRight; i++)
            {
                bitmap.SetPixel(i, y, brush);
            }

            for (int i = countLeft; i <= countRight; i++)
            {
                if (bitmap.GetPixel(i, y - 1) == temp && y - 1 > 0)
                {
                    Fill(i, y - 1, brush);
                }

                if (bitmap.GetPixel(i, y + 1) == temp && y + 1 < bitmap.Height - 1)
                {
                    Fill(i, y + 1, brush);
                }
            }
        }

        
        
    }
 
}
