namespace Paint1
{
    partial class Vector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vector));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.растроваяГрафикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBrush)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.загрузитьToolStripMenuItem,
            this.растроваяГрафикаToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            // 
            // растроваяГрафикаToolStripMenuItem
            // 
            this.растроваяГрафикаToolStripMenuItem.Name = "растроваяГрафикаToolStripMenuItem";
            this.растроваяГрафикаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.растроваяГрафикаToolStripMenuItem.Text = "Растровая графика";
            this.растроваяГрафикаToolStripMenuItem.Click += new System.EventHandler(this.растроваяГрафикаToolStripMenuItem_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.button2);
            this.panel.Controls.Add(this.panel2);
            this.panel.Controls.Add(this.panel1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel.Location = new System.Drawing.Point(0, 24);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(800, 73);
            this.panel.TabIndex = 2;
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
            this.panel2.Location = new System.Drawing.Point(208, 13);
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
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.colorBt);
            this.panel1.Controls.Add(this.trackBrush);
            this.panel1.Controls.Add(this.cleanBt);
            this.panel1.Controls.Add(this.brushTool);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 55);
            this.panel1.TabIndex = 6;
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
            // 
            // trackBrush
            // 
            this.trackBrush.AutoSize = false;
            this.trackBrush.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBrush.Location = new System.Drawing.Point(48, 3);
            this.trackBrush.Name = "trackBrush";
            this.trackBrush.Size = new System.Drawing.Size(126, 37);
            this.trackBrush.TabIndex = 2;
            // 
            // cleanBt
            // 
            this.cleanBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cleanBt.BackgroundImage")));
            this.cleanBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cleanBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cleanBt.FlatAppearance.BorderSize = 0;
            this.cleanBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cleanBt.Location = new System.Drawing.Point(3, 26);
            this.cleanBt.Name = "cleanBt";
            this.cleanBt.Size = new System.Drawing.Size(17, 17);
            this.cleanBt.TabIndex = 1;
            this.cleanBt.UseVisualStyleBackColor = true;
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
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.ErrorImage = null;
            this.canvas.Location = new System.Drawing.Point(0, 97);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(800, 353);
            this.canvas.TabIndex = 3;
            this.canvas.TabStop = false;
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(361, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 54);
            this.button2.TabIndex = 10;
            this.button2.Text = "Change";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Vector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Vector";
            this.Text = "Vector";
            this.Load += new System.EventHandler(this.Vector_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBrush)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem растроваяГрафикаToolStripMenuItem;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button figurePolygon;
        private System.Windows.Forms.Button figureTriangle;
        private System.Windows.Forms.Button figureCircle;
        private System.Windows.Forms.Button figureSquare;
        private System.Windows.Forms.Button pointPolygon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button colorBt;
        public System.Windows.Forms.TrackBar trackBrush;
        private System.Windows.Forms.Button cleanBt;
        private System.Windows.Forms.Button brushTool;
        public System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Button button2;
    }
}