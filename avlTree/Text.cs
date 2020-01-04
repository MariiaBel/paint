using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint1.avlTree
{
    class Text
    {
        static Font drawFont = new Font(settingsAvlBuilding.fontFamily, settingsAvlBuilding.fontSize);
        static SolidBrush drawBrush = new SolidBrush(Brush.BrushColor);
        static StringFormat stringFormat = new StringFormat();

        public Text()
        {
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
        }

        public void Draw(Bitmap bitmap, int value, Point centerPoint)
        {
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.DrawString(Convert.ToString(value), drawFont, drawBrush, centerPoint, stringFormat);
        }
    }
}
