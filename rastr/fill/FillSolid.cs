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


        public Bitmap MyBitmap { get; set;}

        public void Fill(int x, int y, Color fillColor)
        {
            Color temp = MyBitmap.GetPixel(x, y);

            int countLeft = x;
            int countRight = x;

            while (countLeft - 1 > 0 && MyBitmap.GetPixel(countLeft - 1, y) == temp)
            {
                countLeft--;
            }

            while (countRight + 1 < MyBitmap.Width && MyBitmap.GetPixel(countRight + 1, y) == temp)
            {
                countRight++;
            }

            for (int i = countLeft; i <= countRight; i++)
            {
                MyBitmap.SetPixel(i, y, fillColor);
            }

            for (int i = countLeft; i <= countRight; i++)
            {
                if (MyBitmap.GetPixel(i, y - 1) == temp && y - 1 > 0)
                {
                    Fill(i, y - 1, fillColor);
                }

                if (MyBitmap.GetPixel(i, y + 1) == temp && y + 1 < MyBitmap.Height - 1)
                {
                    Fill(i, y + 1, fillColor);
                }
            }
        }
    }
}
