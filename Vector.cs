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
    public partial class Vector : Form
    {
        Graphics VectorGraph;
        Pen p;
        Bitmap bitmapVector;
        Holst holst;
        VectorLine model;
        Point pointToChange;
        bool flag = false, change = true;
        string figure;
        int Tochka;

        public Vector()
        {
            InitializeComponent();
        }

        private void Vector_Load(object sender, EventArgs e)
        {
            bitmapVector = new Bitmap(canvas.Width, canvas.Height);
            VectorGraph = Graphics.FromImage(bitmapVector);
            holst = new Holst();
        }
        
        private void растроваяГрафикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 rastr = new Form1();
            rastr.Show();
            this.Hide();
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            if (change)
            {
                model = new VectorLine(new Point(e.X, e.Y), Color.Black, trackBrush.Value);
                holst.figures.Add(model);

            }
            else
            {
                model = holst.FindPoint(new Point(e.X, e.Y));
                if (model != null)
                {
                    for (int i = 0; i < model.points.Count; i++)
                    {
                        if (model.points[i] == e.Location)
                        {
                            Tochka = i;
                        }
                    }
                }


            }
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

        private void brushTool_Click(object sender, EventArgs e)
        {
            figure = "line";
            change = true;
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (change)
            {
                if (flag)
                {
                    switch (figure)
                    {
                        case "line":
                            bitmapVector = new Bitmap(canvas.Width, canvas.Height);
                            model.ImageMauseMoveTillCreation(new Point(e.X, e.Y));
                            Painter.DrawFigure(model, bitmapVector);
                            holst.figures.Add(model);
                            canvas.Image = holst.Update(bitmapVector);
                            break;
                    }
                }

            }
            else
            {
                if (flag)
                {
                    if (model != null)
                    {
                        model.points[Tochka] = e.Location;
                        bitmapVector = new Bitmap(canvas.Width, canvas.Height);
                        pointToChange = e.Location;
                        Painter.DrawFigure(model, bitmapVector);
                        holst.figures.Add(model);
                        canvas.Image = holst.Update(bitmapVector);
                    }
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            change = false;
        }

        


    }
}
