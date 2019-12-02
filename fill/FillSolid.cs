using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint1
{
    class FillSolid : IFill
    {
        
        public void Fill(int x, int y, Color brush, Bitmap bitmap)
        {
            Color temp = bitmap.GetPixel(x, y);
            
            if (bitmap.GetPixel(x+1, y+1) == temp)
            {
                Fill(x+1, y+1, brush, bitmap);
                bitmap.SetPixel(x, y, brush);
                return;
            } else if (bitmap.GetPixel(x, y) == temp)
            {
                Fill(x-1, y-1, brush, bitmap);
                bitmap.SetPixel(x, y, brush);
                return;
            } else if (bitmap.GetPixel(x+1, y) == temp)
            {
                Fill(x+1, y-1, brush, bitmap);
                bitmap.SetPixel(x, y, brush);
                return;
            } else if (bitmap.GetPixel(x, y+1) == temp)
            {
                Fill(x-1, y+1, brush, bitmap);
                bitmap.SetPixel(x, y, brush);
                return;
            }
           
            
            
        }

        

    }
}
