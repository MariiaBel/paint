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
    public partial class CustomColorDialog : Form
    {
        public Color Color = Color.Black;
        public Color fillColor = Color.Black;
        public CustomColorDialog()
        {
            InitializeComponent();
        }

        private void btnRed_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            { fillColor = Color.Red; }
            else if (e.Button == MouseButtons.Left)
            { Color = Color.Red; }
        }

        private void btnDarkCyan_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            { fillColor = Color.DarkCyan; }
            else if (e.Button == MouseButtons.Left)
            { Color = Color.DarkCyan; }
        }

        private void btnPurple_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            { fillColor = Color.Purple; }
            else if (e.Button == MouseButtons.Left)
            { Color = Color.Purple; }
        }

        private void btnRoyalBlue_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            { fillColor = Color.RoyalBlue; }
            else if (e.Button == MouseButtons.Left)
            { Color = Color.RoyalBlue; }
        }

        private void btnBlack_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            { fillColor = Color.Black; }
            else if (e.Button == MouseButtons.Left)
            { Color = Color.Black; }
        }
    }
}
