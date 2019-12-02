namespace Paint1
{
    partial class CustomColorDialog
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
            this.btnRed = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDarkCyan = new System.Windows.Forms.Button();
            this.btnPurple = new System.Windows.Forms.Button();
            this.btnRoyalBlue = new System.Windows.Forms.Button();
            this.btnBlack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.FlatAppearance.BorderSize = 0;
            this.btnRed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRed.Location = new System.Drawing.Point(12, 12);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(40, 40);
            this.btnRed.TabIndex = 0;
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(43, 67);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(85, 33);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(134, 67);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 33);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnDarkCyan
            // 
            this.btnDarkCyan.BackColor = System.Drawing.Color.DarkCyan;
            this.btnDarkCyan.FlatAppearance.BorderSize = 0;
            this.btnDarkCyan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDarkCyan.Location = new System.Drawing.Point(57, 12);
            this.btnDarkCyan.Name = "btnDarkCyan";
            this.btnDarkCyan.Size = new System.Drawing.Size(40, 40);
            this.btnDarkCyan.TabIndex = 3;
            this.btnDarkCyan.UseVisualStyleBackColor = false;
            this.btnDarkCyan.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPurple
            // 
            this.btnPurple.BackColor = System.Drawing.Color.Purple;
            this.btnPurple.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPurple.Location = new System.Drawing.Point(103, 12);
            this.btnPurple.Name = "btnPurple";
            this.btnPurple.Size = new System.Drawing.Size(40, 40);
            this.btnPurple.TabIndex = 4;
            this.btnPurple.UseVisualStyleBackColor = false;
            this.btnPurple.Click += new System.EventHandler(this.btnPurple_Click);
            // 
            // btnRoyalBlue
            // 
            this.btnRoyalBlue.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRoyalBlue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRoyalBlue.Location = new System.Drawing.Point(149, 12);
            this.btnRoyalBlue.Name = "btnRoyalBlue";
            this.btnRoyalBlue.Size = new System.Drawing.Size(40, 40);
            this.btnRoyalBlue.TabIndex = 5;
            this.btnRoyalBlue.UseVisualStyleBackColor = false;
            this.btnRoyalBlue.Click += new System.EventHandler(this.btnRoyalBlue_Click);
            // 
            // btnBlack
            // 
            this.btnBlack.BackColor = System.Drawing.Color.Black;
            this.btnBlack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBlack.Location = new System.Drawing.Point(195, 12);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(40, 40);
            this.btnBlack.TabIndex = 6;
            this.btnBlack.UseVisualStyleBackColor = false;
            this.btnBlack.Click += new System.EventHandler(this.btnBlack_Click);
            // 
            // CustomColorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(245, 115);
            this.Controls.Add(this.btnBlack);
            this.Controls.Add(this.btnRoyalBlue);
            this.Controls.Add(this.btnPurple);
            this.Controls.Add(this.btnDarkCyan);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnRed);
            this.Name = "CustomColorDialog";
            this.Text = "CustomColorDialog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDarkCyan;
        private System.Windows.Forms.Button btnPurple;
        private System.Windows.Forms.Button btnRoyalBlue;
        private System.Windows.Forms.Button btnBlack;
    }
}