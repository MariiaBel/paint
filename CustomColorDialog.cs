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
        public Color Color = Color.Red;
        public CustomColorDialog()
        {
            InitializeComponent();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            Color = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Color = Color.Green;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Color = Color.Red;
        }

        private void btnPurple_Click(object sender, EventArgs e)
        {
            Color = Color.Purple;
        }

        private void btnRoyalBlue_Click(object sender, EventArgs e)
        {
            Color = Color.RoyalBlue;
        }
    }
}
