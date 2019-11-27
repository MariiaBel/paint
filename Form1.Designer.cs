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
            this.panel = new System.Windows.Forms.Panel();
            this.brushTool = new System.Windows.Forms.Button();
            this.figureSquare = new System.Windows.Forms.Button();
            this.trackBrush = new System.Windows.Forms.TrackBar();
            this.colorBt = new System.Windows.Forms.Button();
            this.cleanBt = new System.Windows.Forms.Button();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.pointPolygon = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBrush)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.pointPolygon);
            this.panel.Controls.Add(this.brushTool);
            this.panel.Controls.Add(this.figureSquare);
            this.panel.Controls.Add(this.trackBrush);
            this.panel.Controls.Add(this.colorBt);
            this.panel.Controls.Add(this.cleanBt);
            this.panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel.Location = new System.Drawing.Point(603, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(197, 450);
            this.panel.TabIndex = 0;
            // 
            // brushTool
            // 
            this.brushTool.Location = new System.Drawing.Point(3, 70);
            this.brushTool.Name = "brushTool";
            this.brushTool.Size = new System.Drawing.Size(194, 35);
            this.brushTool.TabIndex = 4;
            this.brushTool.Text = "brush";
            this.brushTool.UseVisualStyleBackColor = true;
            this.brushTool.Click += new System.EventHandler(this.brushTool_Click);
            // 
            // figureSquare
            // 
            this.figureSquare.Location = new System.Drawing.Point(3, 111);
            this.figureSquare.Name = "figureSquare";
            this.figureSquare.Size = new System.Drawing.Size(194, 35);
            this.figureSquare.TabIndex = 3;
            this.figureSquare.Text = "square";
            this.figureSquare.UseVisualStyleBackColor = true;
            this.figureSquare.Click += new System.EventHandler(this.figureSquare_Click);
            // 
            // trackBrush
            // 
            this.trackBrush.Location = new System.Drawing.Point(3, 34);
            this.trackBrush.Name = "trackBrush";
            this.trackBrush.Size = new System.Drawing.Size(197, 45);
            this.trackBrush.TabIndex = 2;
            this.trackBrush.Scroll += new System.EventHandler(this.trackBrush_Scroll);
            this.trackBrush.ValueChanged += new System.EventHandler(this.trackBrush_ValueChanged);
            // 
            // colorBt
            // 
            this.colorBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorBt.Location = new System.Drawing.Point(0, 0);
            this.colorBt.Name = "colorBt";
            this.colorBt.Size = new System.Drawing.Size(197, 28);
            this.colorBt.TabIndex = 1;
            this.colorBt.Text = "COLOR";
            this.colorBt.UseVisualStyleBackColor = true;
            this.colorBt.Click += new System.EventHandler(this.colorBt_Click);
            // 
            // cleanBt
            // 
            this.cleanBt.Location = new System.Drawing.Point(0, 416);
            this.cleanBt.Name = "cleanBt";
            this.cleanBt.Size = new System.Drawing.Size(197, 35);
            this.cleanBt.TabIndex = 1;
            this.cleanBt.Text = "CLEAN";
            this.cleanBt.UseVisualStyleBackColor = true;
            this.cleanBt.Click += new System.EventHandler(this.cleanBt_Click);
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(603, 450);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.DoubleClick += new System.EventHandler(this.canvas_DoubleClick);
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // pointPolygon
            // 
            this.pointPolygon.Location = new System.Drawing.Point(3, 152);
            this.pointPolygon.Name = "pointPolygon";
            this.pointPolygon.Size = new System.Drawing.Size(194, 35);
            this.pointPolygon.TabIndex = 5;
            this.pointPolygon.Text = "point polygon";
            this.pointPolygon.UseVisualStyleBackColor = true;
            this.pointPolygon.Click += new System.EventHandler(this.pointPolygon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBrush)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Button cleanBt;
        private System.Windows.Forms.Button colorBt;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.TrackBar trackBrush;
        private System.Windows.Forms.Button figureSquare;
        private System.Windows.Forms.Button brushTool;
        private System.Windows.Forms.Button pointPolygon;
    }
}

