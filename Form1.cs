using Paint1.avlTree;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
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
        Bitmap bitmapVector;
        Holst holst;
        IFigure_vector model;
        bool flag = false, change = true;
        string changeFigure;
        int Tochka;
        Color LineColor = Color.Black;

        // Build AvlTree
        BuildAvl<int> avlTree;

        public Form1()
        {
            InitializeComponent();
            vector.Visible = false;
            vector.Location = new Point(12, 27);
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
            figure = new Build(contur, typeFill);
            
            figure.MyBitmap = bitmapImage;
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
            CloneBitmap(out memoryBitmap);
            
            RastrGraph = Graphics.FromImage(memoryBitmap);
            Bitmap bitmap = new Bitmap(canvas.Width, canvas.Height);
            figure = new Build(contur, typeFill);
            figure.MyBitmap = bitmap;
            figure.SetModify(colorDialog.fillColor, autoFill);
            figure.BuildFigure(x1, y1, x2, y2, shift);

            RastrGraph.DrawImage(figure.MyBitmap, 0, 0);
            canvas.Image = memoryBitmap;  
        }

        private void CloneBitmap(out Bitmap btm)
        {
          
            Rectangle r = new Rectangle(0, 0, bitmapImage.Width-1, bitmapImage.Height-1 );
            btm =  bitmapImage.Clone(r, System.Drawing.Imaging.PixelFormat.DontCare);
            
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
            IFill typeFill = new FillSolid();
            typeFill.MyBitmap = bitmapImage;
            typeFill.Fill(e.X, e.Y, Brush.BrushColor);
            canvas.Image = typeFill.MyBitmap;
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            if (memoryBitmap != null)
            {
                bitmapImage = memoryBitmap;
            }
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
                DrawFigure(prevPointX, prevPointY, memoryFirstPointX, memoryFirstPointY);

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
            bitmapVector = new Bitmap(canvas_vector.Width, canvas_vector.Height);
            VectorGraph = Graphics.FromImage(bitmapVector);
            holst = new Holst();
            canvas_vector.Image = bitmapVector;
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
                switch (changeFigure)
                {
                    case "line":
                        model = new VectorLine();
                        break;
                    case "triangle":
                        model = new Triangle_vector();
                        break;
                    case "circle":
                        model = new Circle_vector();
                        break;
                    case "square":
                        model = new Square_vector();
                        break;
                }
                model.Initial(e.Location, LineColor, trackBar1.Value);
                holst.Add(model);

            }
            else
            {
                int size = 7;
                model = holst.Interaction(e.Location);
                if (model != null)
                {
                    for (int i = 0; i < model.GetCountPoint(); i++)
                    {
                        if (Math.Abs(model.GetPoint(i).X - e.Location.X) <= size)
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
            change = true;
            ButtonChange(line);
        }

        private void canvas_vector_MouseMove(object sender, MouseEventArgs e)
        {
            if (change)
            {
                if (flag)
                {
                    if (model != null)
                    {
                        bitmapVector = new Bitmap(canvas_vector.Width, canvas_vector.Height);
                        model.ImageMauseMoveTillCreation(e.Location);
                        canvas_vector.Image = holst.Update(bitmapVector);
                    }
                    
                }

            }
            else
            {
                if (flag)
                {
                    if (model != null)
                    {
                        switch (changeFigure)
                        {
                            case "drag":
                                int deltaX = e.X - model.GetPoint(Tochka).X;
                                int deltaY = e.Y - model.GetPoint(Tochka).Y;
                                for (int i = 0; i < model.GetCountPoint(); i++)
                                {
                                    int x = model.GetPoint(i).X + deltaX;
                                    int y = model.GetPoint(i).Y + deltaY;
                                    model.ChangePoint(new Point(x, y), i);
                                    bitmapVector = new Bitmap(canvas_vector.Width, canvas_vector.Height);
                                    holst.Add(model);
                                    canvas_vector.Image = holst.Update(bitmapVector);
                                }
                                break;

                            case "change":
                                if (model.GetCountPoint() == 4)
                                {
                                    model.ImageMauseMoveTillCreation(e.Location);
                                }
                                else if (model.GetCountPoint() > 4)
                                {
                                    model.ImageMauseMoveTillCreation(e.Location);
                                } else 
                                {
                                    model.ChangePoint(e.Location, Tochka);
                                }
                                
                               
                           
                                
                                bitmapVector = new Bitmap(canvas_vector.Width, canvas_vector.Height);
                                holst.Add(model);
                                canvas_vector.Image = holst.Update(bitmapVector);
                                break;



                                

                        }
                       
                    }
                }

            }
        }

        private void change_figure_Click(object sender, EventArgs e)
        {
            changeFigure = "change";
            change = false;
            holst.build = new Change();
            ButtonChange(change_figure);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            FigureAngles.SetAngles(Convert.ToInt32(numericUpDown1.Value));
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string FileName = @"C:\Users\User\Desktop\Test.jpg";
            bitmapImage.Save(FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private void SaveAs_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                bitmapImage.Save(saveFileDialog1.OpenFile(), System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }

        private void load_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.Reset();
                bitmapImage = new Bitmap(openFileDialog1.OpenFile());
                canvas.Image = bitmapImage;
            }
        }

        

        private void triangleVectorBtn_Click(object sender, EventArgs e)
        {
            changeFigure = "triangle";
            change = true;
            ButtonChange(triangleVectorBtn);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            changeFigure = "circle";
            change = true;
            ButtonChange(button4);
        }

        private void Drag_Click(object sender, EventArgs e)
        {
            changeFigure = "drag";
            change = false;
            holst.build = new Change();
            ButtonChange(Drag);
        }

        private void clBtn_vec_Click(object sender, EventArgs e)
        {
            bitmapVector = new Bitmap(canvas_vector.Width, canvas_vector.Height);
            VectorGraph = Graphics.FromImage(bitmapVector);
            holst = new Holst();
            canvas_vector.Image = bitmapVector;
        }

        private void square_Click(object sender, EventArgs e)
        {
            changeFigure = "square";
            change = true;
            ButtonChange(square);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                button7.BackColor = colorDialog.Color;
                LineColor = colorDialog.Color;
            }
        }

        private void buildAvlBtn_Click(object sender, EventArgs e)
        {
            if (avlBox.Text == "") return;
            avlTree = new BuildAvl<int>(avlBox.Text);

            bitmapImage = new Bitmap(canvas.Width, canvas.Height);
            memoryBitmap = bitmapImage;
            avlTree.Build(bitmapImage);
            canvas.Image = bitmapImage;
        }

        private void VectorTools_Click_1(object sender, EventArgs e)
        {
            vector.Visible = true;
            rastr.Visible = false;
            RastrTools.Visible = true;
            VectorTools.Visible = false;
            bitmapImage = new Bitmap(canvas.Width, canvas.Height);
            memoryBitmap = bitmapImage;

            canvas.Image = bitmapImage;
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

            bitmapImage = new Bitmap(canvas.Width, canvas.Height);
            memoryBitmap = bitmapImage;
            
            canvas.Image = bitmapImage;
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
