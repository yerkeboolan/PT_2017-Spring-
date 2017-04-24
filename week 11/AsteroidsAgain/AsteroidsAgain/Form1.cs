using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsteroidsAgain
{
    public partial class Form1 : Form
    {
        
        Graphics g;

        Asters ast;
        Ship ship;
        Bullet bullet;
        Gun gun;

        int i = 1;
        
        List<Asters> asts = new List<Asters>();
        List<Stars> stars = new List<Stars>();
        List<Asters> asters;
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            asters = new List<Asters>();
           ast = new Asters(g, new Point(100, 100));
            asts.Add(new Asters(g, new Point(180, 200)));
            asts.Add(new Asters(g, new Point(220, 450)));
            asts.Add(new Asters(g, new Point(800, 170)));
            asts.Add(new Asters(g, new Point(610, 510)));

            stars.Add(new Stars(g, new Point(70, 125)));
            stars.Add(new Stars(g, new Point(360, 85)));
            stars.Add(new Stars(g, new Point(695, 142)));
            stars.Add(new Stars(g, new Point(880, 275)));
            stars.Add(new Stars(g, new Point(770, 400)));
            stars.Add(new Stars(g, new Point(865, 570)));
            stars.Add(new Stars(g, new Point(380, 500)));
            stars.Add(new Stars(g, new Point(70, 510)));

            ship = new Ship(g, new Point(492, 325));
            bullet = new Bullet(g, new Point(547, 240));
            gun = new Gun(g, new Point(492, 325));

            timer1.Enabled = true;
            timer1.Interval = 100;

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    i = 1;
                    break;
                case Keys.Down:
                    i = 2;
                    break;
                case Keys.Right:
                    i = 3;
                    break;
                case Keys.Left:
                    i = 4;
                    break;



            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            foreach(Asters a in asts)
            {
                a.Move(Width, Height);
                
            }

            foreach(Stars s in stars)
            {
                s.Move(Width, Height);
            }

                      

            Refresh();
        }


    private void Form1_Paint(object sender, PaintEventArgs e)
    {
        g.Clear(Color.Black);
        foreach (Asters a in asts)
        {
            a.Draw();
        }

        foreach (Stars s in stars)
        {
            s.Draw();
        }


        bullet.Draw();

        ship.Move(Width, Height, i, gun);
        ship.Draw();
        gun.Draw();
       
            }
        }
    }

