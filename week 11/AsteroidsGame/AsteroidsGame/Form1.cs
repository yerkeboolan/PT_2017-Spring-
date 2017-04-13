using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsteroidsGame
{
    public partial class Form1 : Form
    {
        Graphics g;
        DepictClass depict = new DepictClass();
        SolidBrush brush1;
        SolidBrush brush2;
        SolidBrush brush3;
        SolidBrush brush4;
        SolidBrush brush5;

        public Form1()
        {
            InitializeComponent();

            g = this.CreateGraphics();

            brush1 = new SolidBrush(Color.Red);
            brush2 = new SolidBrush(Color.Blue);
            brush3 = new SolidBrush(Color.Yellow);
            brush4 = new SolidBrush(Color.White);
            brush5 = new SolidBrush(Color.Green);

            depict.Cosmos(1, 1, this.Width, this.Height);

            depict.Ship(492, 325);

            depict.Stars(70, 125);
            depict.Stars(360, 85);
            depict.Stars(695, 142);
            depict.Stars(880, 275);
            depict.Stars(770, 400);
            depict.Stars(865, 570);
            depict.Stars(380, 500);
            depict.Stars(70, 510);

            depict.Asteroids(180, 200);
            depict.Asteroids(220, 450);
            depict.Asteroids(800, 170);
            depict.Asteroids(610, 510);

            depict.Bullet(547, 240);

            depict.Gun(492, 325);

            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.FillPath(brush2, depict.path1);

            g.FillPath(brush4, depict.path2);

            g.FillPath(brush3, depict.path3);

            g.FillPath(brush1, depict.path4);
            g.FillPath(brush1, depict.path5);

            g.FillPath(brush5, depict.path6);
            g.FillPath(brush5, depict.path7);

            g.FillPath(brush5, depict.path8);
        }
    }
}