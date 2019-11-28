using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint1
{
    public partial class Form1 : Form
    {
        Bitmap bitmapImage, memoryBitmap;
        bool flag = false;
        string flagTool = "brush";
        int firstPointX, firstPointY, prevPointX = -1, prevPointY = -1, memoryFirstPointX, memoryFirstPointY;
        Brush brush;
        Figure figure;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bitmapImage = new Bitmap(canvas.Width, canvas.Height);
            brush = new Brush(ref bitmapImage);
            figure = new Figure(brush);
            canvas.Image = bitmapImage;
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Location.X >= 0 && e.Location.X < canvas.Width && e.Location.Y >= 0 && e.Location.Y < canvas.Height)
            {
                if(flag)
                {
                    if (flagTool == "brush") DrawBrush(e);
                    else if (flagTool == "square") DrawFigureSquare(e);
                    else if (flagTool == "circle") DrawFigureCircle(e);
                }
                else
                {
                    if (flagTool == "pointPolygon" && prevPointX != -1 && prevPointY != -1) DrawFigureByPoint(e);
                }
            }
        }

        private void DrawFigureCircle(MouseEventArgs e)
        {
            DrawFigure(firstPointX, firstPointY, e.Location.X, e.Location.Y);
        }

        private void DrawBrush(MouseEventArgs e)
        {
            brush.DrawLine(firstPointX, firstPointY, e.Location.X, e.Location.Y);
            firstPointX = e.Location.X;
            firstPointY = e.Location.Y;

            canvas.Image = bitmapImage;
        }

        private void DrawFigureSquare(MouseEventArgs e)
        {
            DrawFigure(firstPointX, firstPointY, e.Location.X, e.Location.Y);
        }
        
        private void DrawFigureByPoint(MouseEventArgs e)
        {
            DrawFigure(prevPointX, prevPointY, e.Location.X, e.Location.Y);

            prevPointX = firstPointX;
            prevPointY = firstPointY;

        }

        private void DrawFigure(int x1, int y1, int x2, int y2) 
        {
            CloneBitmap(out memoryBitmap);

            if(flagTool == "square") figure.DrawFigureSquare(x1, y1, x2, y2);
            else if(flagTool == "pointPolygon") figure.DrawFigureByPoint(x1, y1, x2, y2);
            else if (flagTool == "circle") figure.DrawFigureCircle(x1, y1, x2, y2);

            canvas.Image = memoryBitmap;
        }

        private void CloneBitmap(out Bitmap btm)
        {
            Rectangle r = new Rectangle(0, 0, canvas.Width - 1, canvas.Height - 1);
            btm =  bitmapImage.Clone(r, System.Drawing.Imaging.PixelFormat.DontCare);

            this.brush.BitmapImage = btm;
            this.figure.Brush = brush;

        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            firstPointX = e.Location.X;
            firstPointY = e.Location.Y;
            if (flagTool == "pointPolygon" && prevPointX == -1 && prevPointY == -1)
            {
                CloneBitmap(out memoryBitmap);

                prevPointX = firstPointX;
                prevPointY = firstPointY;
                memoryFirstPointX = firstPointX;
                memoryFirstPointY = firstPointY;
            }
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
            if (flagTool != "brush") bitmapImage = memoryBitmap;

            brush.BitmapImage = bitmapImage;
            brush.BrushColor = colorDialog.Color;
        }

        private void colorBt_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                colorBt.BackColor = colorDialog.Color;
                brush.BrushColor = colorDialog.Color;
            }
        }

        private void canvas_DoubleClick(object sender, EventArgs e)
        {
            if (flagTool == "pointPolygon")
            {
                figure.DrawFigureByPoint(prevPointX, prevPointY, memoryFirstPointX, memoryFirstPointY);
                bitmapImage = memoryBitmap;
                canvas.Image = bitmapImage;
                prevPointX = -1;
                prevPointY = -1;
            }
        }

        private void btnCicle_Click(object sender, EventArgs e)
        {
            this.flagTool = "circle";
        }

        private void trackBrush_ValueChanged(object sender, EventArgs e)
        {
            brush.BrushThickness = trackBrush.Value + 1;
        }

        private void trackBrush_Scroll(object sender, EventArgs e)
        {

        }

        private void figureSquare_Click(object sender, EventArgs e)
        {
            this.flagTool = "square";
        }

        private void pointPolygon_Click(object sender, EventArgs e)
        {
            this.flagTool = "pointPolygon";
        }

        private void brushTool_Click(object sender, EventArgs e)
        {
            this.flagTool = "brush";
        }

        private void cleanBt_Click(object sender, EventArgs e)
        {
            Color lastColorBrush = brush.BrushColor;
            int lastThicknessBrush = brush.BrushThickness;

            bitmapImage = new Bitmap(canvas.Width, canvas.Height);
            canvas.Image = bitmapImage;
            brush.BitmapImage = bitmapImage;
            brush.BrushColor = lastColorBrush;
            brush.BrushThickness = lastThicknessBrush;
        }
    }
}
