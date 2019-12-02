using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint1
{
    interface IFill 
    {
        void Fill(int x, int y, Color brush, Bitmap bitmap);
    }
}
