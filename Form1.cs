using System;
using System.Drawing;
using System.Windows.Forms;


namespace Paint1
{
    public partial class Form1 : Form
    {
        //Растровая графика
        IFill typeFill = null;
        IFigure contur = new Line();
        IFigureBuild figure = new Build(new Line(), new FillSolid());
        string flagFigure = "line";
        Bitmap bitmapImage, memoryBitmap;
        bool mouseDown = false, shift = false, autoFill = false;
        int firstPointX, firstPointY, prevPointX = -1, prevPointY = -1, memoryFirstPointX, memoryFirstPointY;
        CustomColorDialog colorDialog = new CustomColorDialog();
        Graphics RastrGraph;
        Button button = null;

        //Векторная графика
        Graphics VectorGraph;
        Pen p;
        Bitmap bitmapVector;
        Holst holst;
        IFigure_vector model;
        IBuild build;
        Point pointToChange;
        bool flag = false, change = true;
        string changeFigure;
        int Tochka;

        public Form1()
        {
            InitializeComponent();
            vector.Visible = false;
            vector.Location = new Point(12, 17);
            this.Height = 720;
            this.Width = 784;
            RastrTools.Visible = false;
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bitmapImage = new Bitmap(canvas.Width, canvas.Height);
            bitmapVector = new Bitmap(canvas.Width, canvas.Height);
            VectorGraph = Graphics.FromImage(bitmapVector);
            holst = new Holst();
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Location.X >= 0 && e.Location.X < bitmapImage.Width && e.Location.Y >= 0 && e.Location.Y < bitmapImage.Height)
            {
                if(mouseDown)
                {
                    switch (flagFigure)
                    {
                        case "brush":
                            DrawBrush(e);
                            break;
                        case "ppolygon":
                            return;
                        case "square":
                            DrawFigure(firstPointX, firstPointY, e.Location.X, e.Location.Y);
                            break;
                        case "circle":
                            DrawFigure(firstPointX, firstPointY, e.Location.X, e.Location.Y);
                            break;
                        case "triangle":
                            DrawFigure(firstPointX, firstPointY, e.Location.X, e.Location.Y);
                            break;
                        case "fpolygon":
                            DrawFigure(firstPointX, firstPointY, e.Location.X, e.Location.Y);
                            break;
                    }           
                }
                else
                {
                    if (flagFigure == "ppolygon" && prevPointX != -1 && prevPointY != -1) DrawFigureByPoint(e);
                } 
            }
        }

        private void DrawBrush(MouseEventArgs e)
        {
            Brush.BitmapImage = bitmapImage;
            figure = new Build(contur, typeFill);
            figure.SetBit(bitmapImage);
            figure.BuildFigure(firstPointX, firstPointY, e.Location.X, e.Location.Y, shift);
            firstPointX = e.Location.X;
            firstPointY = e.Location.Y;
            canvas.Image = bitmapImage;
        }

        private void DrawFigureByPoint(MouseEventArgs e)
        {
            prevPointX = firstPointX;
            prevPointY = firstPointY;
            DrawFigure(prevPointX, prevPointY, e.Location.X, e.Location.Y);
        }


        //Добавлен булевый атрибут для метода DrawFigureSquare
        private void DrawFigure(int x1, int y1, int x2, int y2) 
        {
            
            int x = (x1 + x2) / 2;
            int y = (y1 + y2) / 2;
            CloneBitmap(out memoryBitmap);
            
            RastrGraph = Graphics.FromImage(memoryBitmap);
            Bitmap bitmap = new Bitmap(canvas.Width, canvas.Height);
            figure = new Build(contur, typeFill);
            figure.SetModify(Color.Red, autoFill, bitmap, x, y);
            figure.BuildFigure(x1, y1, x2, y2, shift);

            RastrGraph.DrawImage(figure.ReturnBit(), 0, 0);
            canvas.Image = memoryBitmap; 
            
        }

        private void CloneBitmap(out Bitmap btm)
        {
          
            Rectangle r = new Rectangle(0, 0, bitmapImage.Width-1, bitmapImage.Height-1 );
            btm =  bitmapImage.Clone(r, System.Drawing.Imaging.PixelFormat.DontCare);
            Brush.BitmapImage = btm;
            
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            firstPointX = e.Location.X;
            firstPointY = e.Location.Y;
            if (flagFigure == "fillSolid")
            {
                FillCanvas(e);
            }
            
            if (flagFigure == "ppolygon" && prevPointX == -1 && prevPointY == -1)
            {
                CloneBitmap(out memoryBitmap);
                prevPointX = firstPointX;
                prevPointY = firstPointY;
                memoryFirstPointX = firstPointX;
                memoryFirstPointY = firstPointY;
            }
        }

        private void FillCanvas(MouseEventArgs e)
        {
            IFill typeFill = new FillSolid(bitmapImage);
            typeFill.Fill(e.X, e.Y, Brush.BrushColor);
            canvas.Image = typeFill.ReturnBit();
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            if (memoryBitmap != null)
            {
                bitmapImage = memoryBitmap;
            }
            Brush.BitmapImage = bitmapImage;
            Brush.BrushColor = colorDialog.Color;
        }

        private void colorBt_Click(object sender, EventArgs e)
        {           
            DialogResult dr = colorDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                colorBt.BackColor = colorDialog.Color;
                Brush.BrushColor = colorDialog.Color;
            }
        }

        private void canvas_DoubleClick(object sender, EventArgs e)
        {
            if (flagFigure == "ppolygon")
            {
                figure.BuildFigure(prevPointX, prevPointY, memoryFirstPointX, memoryFirstPointY, shift);
                bitmapImage = memoryBitmap;
                canvas.Image = bitmapImage;
                prevPointX = -1;
                prevPointY = -1;
            }
        }
       
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            shift = false;
        }
  
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Shift)
            {
                shift = true;
            }
        }

        private void trackBrush_ValueChanged(object sender, EventArgs e)
        {
            Brush.BrushThickness = trackBrush.Value + 1;
        }

        private void trackBrush_Scroll(object sender, EventArgs e)
        {

        }

        private void Form1_SizeChanged(object sender, EventArgs e )
        {
           
        }
        private void figureSquare_BackColorChanged(object sender, EventArgs e)
        {

        }
        private void canvas_SizeChanged(object sender, EventArgs e)
        {
            //Bitmap btm = new Bitmap(canvas.Width, canvas.Height);
            //Rectangle r = new Rectangle(0, 0, btm.Width - 1, btm.Height - 1);
            //btm = bitmapImage.Clone(r, System.Drawing.Imaging.PixelFormat.DontCare);
            //bitmapImage = btm;
            //canvas.Image = bitmapImage;
        }
        private void figurePolygon_Click(object sender, EventArgs e)
        {
            
            contur = new Fpolygon();
            flagFigure = "fpolygon";
            ButtonChange(figurePolygon);
        }
        private void fill_Click(object sender, EventArgs e)
        {
            flagFigure = "fillSolid";
            typeFill = new FillSolid();
           
            ButtonChange(fill);
        }

        private void RastrTools_Click_1(object sender, EventArgs e)
        {
            vector.Visible = false;
            rastr.Visible = true;
            VectorTools.Visible = true;
            RastrTools.Visible = false;
        }

        private void canvas_vector_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            if (change)
            {
                model.Initial(new Point(e.X, e.Y), Color.Black, trackBrush.Value);
                holst.Add(model);

            }
            else
            {
                model = holst.Interaction(new Point(e.X, e.Y));
                if (model != null)
                {
                    for (int i = 0; i < model.GetCountPoint(); i++)
                    {
                        if (model.GetPoint(i) == e.Location)
                        {
                            Tochka = i;
                        }
                    }
                }


            }
        }

        private void canvas_vector_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

        private void line_Click(object sender, EventArgs e)
        {
            changeFigure = "line";
            model = new VectorLine();
            change = true;
        }

        private void canvas_vector_MouseMove(object sender, MouseEventArgs e)
        {
            if (change)
            {
                if (flag)
                {
                    switch (changeFigure)
                    {
                        case "line":
                            bitmapVector = new Bitmap(canvas_vector.Width, canvas_vector.Height);
                            model.ImageMauseMoveTillCreation(new Point(e.X, e.Y));
                            Painter.DrawFigure(model, bitmapVector);
                            holst.Add(model);
                            canvas_vector.Image = holst.Update(bitmapVector);
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
                        model.ChangePoint(e.Location, Tochka);
                        bitmapVector = new Bitmap(canvas_vector.Width, canvas_vector.Height);
                        pointToChange = e.Location;
                        Painter.DrawFigure(model, bitmapVector);
                        holst.Add(model);
                        canvas_vector.Image = holst.Update(bitmapVector);
                    }
                }

            }
        }

        private void change_figure_Click(object sender, EventArgs e)
        {
            change = false;
            holst.build = new Change();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            FigureAngles.SetAngles(Convert.ToInt32(numericUpDown1.Value));
        }

        private void VectorTools_Click_1(object sender, EventArgs e)
        {
            vector.Visible = true;
            rastr.Visible = false;
            RastrTools.Visible = true;
            VectorTools.Visible = false;
        }

        private void checkFill_CheckedChanged(object sender, EventArgs e)
        {
            if (!autoFill)
            {
                autoFill = true;
                typeFill = new FillSolid();
                
            } else
            {
                autoFill = false;
                typeFill = null;
                
            }
        }
        private void figureTriangle_Click(object sender, EventArgs e)
        {           
            contur = new Triangle();
            flagFigure = "triangle";
            ButtonChange(figureTriangle);
        }
        private void figureCircle_Click(object sender, EventArgs e)
        {
            contur = new Circle();
            flagFigure = "circle";
            ButtonChange(figureCircle);
        }
        private void figureSquare_Click(object sender, EventArgs e)
        {
            contur = new Square();
            flagFigure = "square";
            ButtonChange(figureSquare);
        }

        private void pointPolygon_Click(object sender, EventArgs e)
        {         
            contur = new Polygon();
            flagFigure = "ppolygon";
            ButtonChange(pointPolygon);
        }

        private void brushTool_Click(object sender, EventArgs e)
        {
            contur = new Line();
            flagFigure = "brush";
            ButtonChange(brushTool);
        }

        private void cleanBt_Click(object sender, EventArgs e)
        {
            Color lastColorBrush = Brush.BrushColor;
            int lastThicknessBrush = Brush.BrushThickness;
            bitmapImage = new Bitmap(canvas.Width, canvas.Height);
            memoryBitmap = bitmapImage;
            canvas.Image = bitmapImage;
            Brush.BitmapImage = bitmapImage;
            Brush.BrushColor = lastColorBrush;
            Brush.BrushThickness = lastThicknessBrush;
        }    

        private void ButtonChange(Button master)
        {
            if (button == null)
            {
                master.BackColor = Color.Silver;
            }
            else
            {
                button.BackColor = Color.White;         
                master.BackColor = Color.Silver;
            }
            button = master;
        }
    }
}
