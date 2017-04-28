using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {

        Paintbase paint;

        public Form1()
        {
            InitializeComponent();
            paint = new Paintbase(pictureBox1);
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            paint.MouseDown(e);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            paint.MouseMove(sender, e);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            paint.MouseUp(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            string name = b.Text;
            paint.ChangeShape(name);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
           paint.onPaint(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                Color c = cd.Color;
                paint.SetColor(c);
                Button b = sender as Button;
                b.BackColor = c;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            paint.SetWidth(trackBar1.Value);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paint.Save();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paint.Open();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paint.New();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

   
    }
}
