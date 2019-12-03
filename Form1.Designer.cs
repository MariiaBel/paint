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
            this.panel2 = new System.Windows.Forms.Panel();
            this.figurePolygon = new System.Windows.Forms.Button();
            this.figureTriangle = new System.Windows.Forms.Button();
            this.figureCircle = new System.Windows.Forms.Button();
            this.figureSquare = new System.Windows.Forms.Button();
            this.pointPolygon = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorBt = new System.Windows.Forms.Button();
            this.trackBrush = new System.Windows.Forms.TrackBar();
            this.cleanBt = new System.Windows.Forms.Button();
            this.brushTool = new System.Windows.Forms.Button();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.numericAngles = new System.Windows.Forms.NumericUpDown();
            this.panel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBrush)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAngles)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.numericAngles);
            this.panel.Controls.Add(this.panel2);
            this.panel.Controls.Add(this.panel1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1924, 90);
            this.panel.TabIndex = 0;
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
            this.panel2.Location = new System.Drawing.Point(277, 16);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 66);
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
            this.figurePolygon.Location = new System.Drawing.Point(127, 4);
            this.figurePolygon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.figurePolygon.Name = "figurePolygon";
            this.figurePolygon.Size = new System.Drawing.Size(23, 21);
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
            this.figureTriangle.Location = new System.Drawing.Point(96, 4);
            this.figureTriangle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.figureTriangle.Name = "figureTriangle";
            this.figureTriangle.Size = new System.Drawing.Size(23, 21);
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
            this.figureCircle.Location = new System.Drawing.Point(65, 4);
            this.figureCircle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.figureCircle.Name = "figureCircle";
            this.figureCircle.Size = new System.Drawing.Size(23, 21);
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
            this.figureSquare.Location = new System.Drawing.Point(4, 4);
            this.figureSquare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.figureSquare.Name = "figureSquare";
            this.figureSquare.Size = new System.Drawing.Size(23, 21);
            this.figureSquare.TabIndex = 3;
            this.figureSquare.UseVisualStyleBackColor = false;
            this.figureSquare.BackColorChanged += new System.EventHandler(this.figureSquare_BackColorChanged);
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
            this.pointPolygon.Location = new System.Drawing.Point(35, 4);
            this.pointPolygon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pointPolygon.Name = "pointPolygon";
            this.pointPolygon.Size = new System.Drawing.Size(23, 21);
            this.pointPolygon.TabIndex = 5;
            this.pointPolygon.UseVisualStyleBackColor = false;
            this.pointPolygon.Click += new System.EventHandler(this.pointPolygon_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.colorBt);
            this.panel1.Controls.Add(this.trackBrush);
            this.panel1.Controls.Add(this.cleanBt);
            this.panel1.Controls.Add(this.brushTool);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 67);
            this.panel1.TabIndex = 6;
            // 
            // colorBt
            // 
            this.colorBt.BackColor = System.Drawing.Color.Black;
            this.colorBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorBt.FlatAppearance.BorderSize = 0;
            this.colorBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorBt.Location = new System.Drawing.Point(33, 4);
            this.colorBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.colorBt.Name = "colorBt";
            this.colorBt.Size = new System.Drawing.Size(23, 21);
            this.colorBt.TabIndex = 1;
            this.colorBt.UseVisualStyleBackColor = false;
            this.colorBt.Click += new System.EventHandler(this.colorBt_Click);
            // 
            // trackBrush
            // 
            this.trackBrush.AutoSize = false;
            this.trackBrush.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBrush.Location = new System.Drawing.Point(64, 4);
            this.trackBrush.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBrush.Name = "trackBrush";
            this.trackBrush.Size = new System.Drawing.Size(168, 46);
            this.trackBrush.TabIndex = 2;
            this.trackBrush.Scroll += new System.EventHandler(this.trackBrush_Scroll);
            this.trackBrush.ValueChanged += new System.EventHandler(this.trackBrush_ValueChanged);
            // 
            // cleanBt
            // 
            this.cleanBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cleanBt.BackgroundImage")));
            this.cleanBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cleanBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cleanBt.FlatAppearance.BorderSize = 0;
            this.cleanBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cleanBt.Location = new System.Drawing.Point(33, 32);
            this.cleanBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cleanBt.Name = "cleanBt";
            this.cleanBt.Size = new System.Drawing.Size(23, 21);
            this.cleanBt.TabIndex = 1;
            this.cleanBt.UseVisualStyleBackColor = true;
            this.cleanBt.Click += new System.EventHandler(this.cleanBt_Click);
            // 
            // brushTool
            // 
            this.brushTool.BackColor = System.Drawing.Color.Transparent;
            this.brushTool.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("brushTool.BackgroundImage")));
            this.brushTool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.brushTool.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brushTool.FlatAppearance.BorderSize = 0;
            this.brushTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brushTool.Location = new System.Drawing.Point(4, 4);
            this.brushTool.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.brushTool.Name = "brushTool";
            this.brushTool.Size = new System.Drawing.Size(23, 21);
            this.brushTool.TabIndex = 4;
            this.brushTool.UseVisualStyleBackColor = false;
            this.brushTool.Click += new System.EventHandler(this.brushTool_Click);
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.ErrorImage = null;
            this.canvas.Location = new System.Drawing.Point(0, 90);
            this.canvas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(1924, 965);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.SizeChanged += new System.EventHandler(this.canvas_SizeChanged);
            this.canvas.DoubleClick += new System.EventHandler(this.canvas_DoubleClick);
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // numericAngles
            // 
            this.numericAngles.Location = new System.Drawing.Point(444, 15);
            this.numericAngles.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericAngles.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericAngles.Name = "numericAngles";
            this.numericAngles.Size = new System.Drawing.Size(46, 30);
            this.numericAngles.TabIndex = 1;
            this.numericAngles.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.panel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.AutoSizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBrush)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAngles)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.NumericUpDown numericAngles;
    }
}

