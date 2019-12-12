namespace Paint1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkFill = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.figurePolygon = new System.Windows.Forms.Button();
            this.figureTriangle = new System.Windows.Forms.Button();
            this.figureCircle = new System.Windows.Forms.Button();
            this.figureSquare = new System.Windows.Forms.Button();
            this.pointPolygon = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fill = new System.Windows.Forms.Button();
            this.colorBt = new System.Windows.Forms.Button();
            this.trackBrush = new System.Windows.Forms.TrackBar();
            this.cleanBt = new System.Windows.Forms.Button();
            this.brushTool = new System.Windows.Forms.Button();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VectorTools = new System.Windows.Forms.ToolStripMenuItem();
            this.RastrTools = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.load = new System.Windows.Forms.ToolStripMenuItem();
            this.rastr = new System.Windows.Forms.Panel();
            this.vector = new System.Windows.Forms.Panel();
            this.canvas_vector = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.change_figure = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button8 = new System.Windows.Forms.Button();
            this.line = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBrush)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.rastr.SuspendLayout();
            this.vector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas_vector)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.numericUpDown1);
            this.panel.Controls.Add(this.checkFill);
            this.panel.Controls.Add(this.panel2);
            this.panel.Controls.Add(this.panel1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(784, 73);
            this.panel.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(335, 42);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(55, 26);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // checkFill
            // 
            this.checkFill.AutoSize = true;
            this.checkFill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkFill.FlatAppearance.BorderSize = 0;
            this.checkFill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkFill.Location = new System.Drawing.Point(335, 10);
            this.checkFill.Name = "checkFill";
            this.checkFill.Size = new System.Drawing.Size(91, 24);
            this.checkFill.TabIndex = 8;
            this.checkFill.Text = "Заливка";
            this.checkFill.UseVisualStyleBackColor = true;
            this.checkFill.CheckedChanged += new System.EventHandler(this.checkFill_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.figurePolygon);
            this.panel2.Controls.Add(this.figureTriangle);
            this.panel2.Controls.Add(this.figureCircle);
            this.panel2.Controls.Add(this.figureSquare);
            this.panel2.Controls.Add(this.pointPolygon);
            this.panel2.Location = new System.Drawing.Point(208, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(121, 54);
            this.panel2.TabIndex = 7;
            // 
            // figurePolygon
            // 
            this.figurePolygon.BackColor = System.Drawing.Color.White;
            this.figurePolygon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("figurePolygon.BackgroundImage")));
            this.figurePolygon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.figurePolygon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.figurePolygon.FlatAppearance.BorderSize = 0;
            this.figurePolygon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.figurePolygon.Location = new System.Drawing.Point(95, 3);
            this.figurePolygon.Name = "figurePolygon";
            this.figurePolygon.Size = new System.Drawing.Size(17, 17);
            this.figurePolygon.TabIndex = 8;
            this.figurePolygon.UseVisualStyleBackColor = false;
            this.figurePolygon.Click += new System.EventHandler(this.figurePolygon_Click);
            // 
            // figureTriangle
            // 
            this.figureTriangle.BackColor = System.Drawing.Color.White;
            this.figureTriangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("figureTriangle.BackgroundImage")));
            this.figureTriangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.figureTriangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.figureTriangle.FlatAppearance.BorderSize = 0;
            this.figureTriangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.figureTriangle.Location = new System.Drawing.Point(72, 3);
            this.figureTriangle.Name = "figureTriangle";
            this.figureTriangle.Size = new System.Drawing.Size(17, 17);
            this.figureTriangle.TabIndex = 7;
            this.figureTriangle.UseVisualStyleBackColor = false;
            this.figureTriangle.Click += new System.EventHandler(this.figureTriangle_Click);
            // 
            // figureCircle
            // 
            this.figureCircle.BackColor = System.Drawing.Color.White;
            this.figureCircle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("figureCircle.BackgroundImage")));
            this.figureCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.figureCircle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.figureCircle.FlatAppearance.BorderSize = 0;
            this.figureCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.figureCircle.Location = new System.Drawing.Point(49, 3);
            this.figureCircle.Name = "figureCircle";
            this.figureCircle.Size = new System.Drawing.Size(17, 17);
            this.figureCircle.TabIndex = 6;
            this.figureCircle.UseVisualStyleBackColor = false;
            this.figureCircle.Click += new System.EventHandler(this.figureCircle_Click);
            // 
            // figureSquare
            // 
            this.figureSquare.BackColor = System.Drawing.Color.White;
            this.figureSquare.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("figureSquare.BackgroundImage")));
            this.figureSquare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.figureSquare.FlatAppearance.BorderSize = 0;
            this.figureSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.figureSquare.Location = new System.Drawing.Point(3, 3);
            this.figureSquare.Name = "figureSquare";
            this.figureSquare.Size = new System.Drawing.Size(17, 17);
            this.figureSquare.TabIndex = 3;
            this.figureSquare.UseVisualStyleBackColor = false;
            this.figureSquare.Click += new System.EventHandler(this.figureSquare_Click);
            // 
            // pointPolygon
            // 
            this.pointPolygon.BackColor = System.Drawing.Color.White;
            this.pointPolygon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pointPolygon.BackgroundImage")));
            this.pointPolygon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pointPolygon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pointPolygon.FlatAppearance.BorderSize = 0;
            this.pointPolygon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pointPolygon.Location = new System.Drawing.Point(26, 3);
            this.pointPolygon.Name = "pointPolygon";
            this.pointPolygon.Size = new System.Drawing.Size(17, 17);
            this.pointPolygon.TabIndex = 5;
            this.pointPolygon.UseVisualStyleBackColor = false;
            this.pointPolygon.Click += new System.EventHandler(this.pointPolygon_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.fill);
            this.panel1.Controls.Add(this.colorBt);
            this.panel1.Controls.Add(this.trackBrush);
            this.panel1.Controls.Add(this.cleanBt);
            this.panel1.Controls.Add(this.brushTool);
            this.panel1.Location = new System.Drawing.Point(10, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(55, 55, 3, 55);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15, 15, 0, 15);
            this.panel1.Size = new System.Drawing.Size(177, 55);
            this.panel1.TabIndex = 6;
            // 
            // fill
            // 
            this.fill.BackColor = System.Drawing.Color.White;
            this.fill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fill.BackgroundImage")));
            this.fill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fill.FlatAppearance.BorderSize = 0;
            this.fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fill.Location = new System.Drawing.Point(3, 26);
            this.fill.Name = "fill";
            this.fill.Size = new System.Drawing.Size(17, 17);
            this.fill.TabIndex = 5;
            this.fill.UseVisualStyleBackColor = false;
            this.fill.Click += new System.EventHandler(this.fill_Click);
            // 
            // colorBt
            // 
            this.colorBt.BackColor = System.Drawing.Color.Black;
            this.colorBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorBt.FlatAppearance.BorderSize = 0;
            this.colorBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorBt.Location = new System.Drawing.Point(25, 3);
            this.colorBt.Name = "colorBt";
            this.colorBt.Size = new System.Drawing.Size(17, 17);
            this.colorBt.TabIndex = 1;
            this.colorBt.UseVisualStyleBackColor = false;
            this.colorBt.Click += new System.EventHandler(this.colorBt_Click);
            // 
            // trackBrush
            // 
            this.trackBrush.AutoSize = false;
            this.trackBrush.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBrush.Location = new System.Drawing.Point(48, 3);
            this.trackBrush.Name = "trackBrush";
            this.trackBrush.Size = new System.Drawing.Size(126, 37);
            this.trackBrush.TabIndex = 2;
            this.trackBrush.ValueChanged += new System.EventHandler(this.trackBrush_ValueChanged);
            // 
            // cleanBt
            // 
            this.cleanBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cleanBt.BackgroundImage")));
            this.cleanBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cleanBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cleanBt.FlatAppearance.BorderSize = 0;
            this.cleanBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cleanBt.Location = new System.Drawing.Point(25, 26);
            this.cleanBt.Name = "cleanBt";
            this.cleanBt.Size = new System.Drawing.Size(17, 17);
            this.cleanBt.TabIndex = 1;
            this.cleanBt.UseVisualStyleBackColor = true;
            this.cleanBt.Click += new System.EventHandler(this.cleanBt_Click);
            // 
            // brushTool
            // 
            this.brushTool.BackColor = System.Drawing.Color.White;
            this.brushTool.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("brushTool.BackgroundImage")));
            this.brushTool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.brushTool.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brushTool.FlatAppearance.BorderSize = 0;
            this.brushTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brushTool.Location = new System.Drawing.Point(3, 3);
            this.brushTool.Name = "brushTool";
            this.brushTool.Size = new System.Drawing.Size(17, 17);
            this.brushTool.TabIndex = 4;
            this.brushTool.UseVisualStyleBackColor = false;
            this.brushTool.Click += new System.EventHandler(this.brushTool_Click);
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.canvas.ErrorImage = null;
            this.canvas.Location = new System.Drawing.Point(0, 73);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(784, 647);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.DoubleClick += new System.EventHandler(this.canvas_DoubleClick);
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(57, 759);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VectorTools,
            this.RastrTools,
            this.Save,
            this.SaveAs,
            this.load});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(48, 19);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // VectorTools
            // 
            this.VectorTools.Name = "VectorTools";
            this.VectorTools.Size = new System.Drawing.Size(180, 22);
            this.VectorTools.Text = "Векторная графика";
            this.VectorTools.Click += new System.EventHandler(this.VectorTools_Click_1);
            // 
            // RastrTools
            // 
            this.RastrTools.Name = "RastrTools";
            this.RastrTools.Size = new System.Drawing.Size(180, 22);
            this.RastrTools.Text = "Растровая графика";
            this.RastrTools.Click += new System.EventHandler(this.RastrTools_Click_1);
            // 
            // Save
            // 
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(180, 22);
            this.Save.Text = "Сохранить";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // SaveAs
            // 
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(180, 22);
            this.SaveAs.Text = "Сохранить как";
            this.SaveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // load
            // 
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(180, 22);
            this.load.Text = "Загрузить";
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // rastr
            // 
            this.rastr.Controls.Add(this.panel);
            this.rastr.Controls.Add(this.canvas);
            this.rastr.Location = new System.Drawing.Point(12, 27);
            this.rastr.Name = "rastr";
            this.rastr.Size = new System.Drawing.Size(784, 720);
            this.rastr.TabIndex = 2;
            // 
            // vector
            // 
            this.vector.Controls.Add(this.canvas_vector);
            this.vector.Controls.Add(this.panel3);
            this.vector.Location = new System.Drawing.Point(803, 28);
            this.vector.Name = "vector";
            this.vector.Size = new System.Drawing.Size(773, 720);
            this.vector.TabIndex = 3;
            // 
            // canvas_vector
            // 
            this.canvas_vector.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.canvas_vector.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.canvas_vector.ErrorImage = null;
            this.canvas_vector.Location = new System.Drawing.Point(0, 73);
            this.canvas_vector.Name = "canvas_vector";
            this.canvas_vector.Size = new System.Drawing.Size(773, 647);
            this.canvas_vector.TabIndex = 4;
            this.canvas_vector.TabStop = false;
            this.canvas_vector.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_vector_MouseDown);
            this.canvas_vector.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_vector_MouseMove);
            this.canvas_vector.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_vector_MouseUp);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.change_figure);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(773, 73);
            this.panel3.TabIndex = 3;
            // 
            // change_figure
            // 
            this.change_figure.Location = new System.Drawing.Point(336, 29);
            this.change_figure.Name = "change_figure";
            this.change_figure.Size = new System.Drawing.Size(84, 37);
            this.change_figure.TabIndex = 8;
            this.change_figure.Text = "change";
            this.change_figure.UseVisualStyleBackColor = true;
            this.change_figure.Click += new System.EventHandler(this.change_figure_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.button6);
            this.panel4.Location = new System.Drawing.Point(209, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(121, 54);
            this.panel4.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(95, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(17, 17);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(72, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(17, 17);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(49, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(17, 17);
            this.button4.TabIndex = 6;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(3, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(17, 17);
            this.button5.TabIndex = 3;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(26, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(17, 17);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.button7);
            this.panel5.Controls.Add(this.trackBar1);
            this.panel5.Controls.Add(this.button8);
            this.panel5.Controls.Add(this.line);
            this.panel5.Location = new System.Drawing.Point(14, 11);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(177, 55);
            this.panel5.TabIndex = 6;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Black;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(25, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(17, 17);
            this.button7.TabIndex = 1;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.Location = new System.Drawing.Point(48, 3);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(126, 37);
            this.trackBar1.TabIndex = 2;
            // 
            // button8
            // 
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(3, 26);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(17, 17);
            this.button8.TabIndex = 1;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.White;
            this.line.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("line.BackgroundImage")));
            this.line.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.line.Cursor = System.Windows.Forms.Cursors.Hand;
            this.line.FlatAppearance.BorderSize = 0;
            this.line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.line.Location = new System.Drawing.Point(3, 3);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(17, 17);
            this.line.TabIndex = 4;
            this.line.UseVisualStyleBackColor = false;
            this.line.Click += new System.EventHandler(this.line_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1443, 759);
            this.Controls.Add(this.vector);
            this.Controls.Add(this.rastr);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBrush)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.rastr.ResumeLayout(false);
            this.vector.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.canvas_vector)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Button cleanBt;
        private System.Windows.Forms.Button colorBt;
        private System.Windows.Forms.Button figureSquare;
        private System.Windows.Forms.Button brushTool;
        private System.Windows.Forms.Button pointPolygon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button figureCircle;
        public System.Windows.Forms.TrackBar trackBrush;
        private System.Windows.Forms.Button figurePolygon;
        private System.Windows.Forms.Button figureTriangle;
        private System.Windows.Forms.Button fill;
        private System.Windows.Forms.CheckBox checkFill;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VectorTools;
        private System.Windows.Forms.Panel rastr;
        private System.Windows.Forms.Panel vector;
        private System.Windows.Forms.Panel panel3;
       
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button7;
        public System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button line;
        public System.Windows.Forms.PictureBox canvas_vector;
        private System.Windows.Forms.ToolStripMenuItem RastrTools;
        private System.Windows.Forms.Button change_figure;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem SaveAs;
        private System.Windows.Forms.ToolStripMenuItem load;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

