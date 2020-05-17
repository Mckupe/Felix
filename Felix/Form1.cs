using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Felix
{

    public partial class Form1 : Form
    {     
        List<Neigbors> nList = new List<Neigbors>();
        List<Windows> WList = new List<Windows>();
        bool goLeft = false;
        bool goRight = false;
        bool jumping = false;
        bool fixes = false;
        bool wallTaches = false;
        bool HpFlag = false;
        int rand;
        int jumpSpeed = 10;
        int force = 8;
        int score = 0;
        int Hp = 3;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F){fixes = true;}
            if (e.KeyCode == Keys.Left){goLeft = true;}
            if (e.KeyCode == Keys.Right){goRight = true;}
            if (e.KeyCode == Keys.Space && !jumping){jumping = true;}
            if (e.KeyCode == Keys.Escape){this.Close();}
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F){fixes = false;}
            if (e.KeyCode == Keys.Left){goLeft = false;}
            if (e.KeyCode == Keys.Right){goRight = false;}
            if (jumping){jumping = false;}
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Movment();

            EnemyScript();

            Collision();

            CollectItem();

            WindowsScript();

            WinAndDead();
        }

        private void WinAndDead()
        {
            if (Hp == 0)
            {
                timer1.Stop();
                MessageBox.Show("You are dead!Not big surprise.");
            }
            if (score == 22)
            {
                timer1.Stop();
                MessageBox.Show("You win this time...");
            }
        }

        private void Movment()
        {
            if (jumping && force < 0) { jumping = false; }
            if (goLeft) { Player.Left -= 5; }
            if (goRight) { Player.Left += 5; }
            if (jumping) { jumpSpeed = -12; force -= 1; }
            else { jumpSpeed = 7; }
        }

        private void WindowsScript()
        {
            foreach (Windows windows in WList)
            {
                if (Player.Bounds.IntersectsWith(windows.getBounds()) && fixes)
                {
                    windows.changeColor(Color.White);
                    if (!windows.fixedYet)
                    {
                        score = score + 10;
                        windows.fixedYet = true;
                        LblScore.Text = "Score: " + score;
                    }
                    LblScore.Text = "Score: " + score;
                }
            }
        }

        private void CollectItem()
        {
            foreach (Neigbors c in nList)
            {
                if (Player.Bounds.IntersectsWith(c.getBounds()))
                {
                    c.setPos(1001, 1001);
                    score++;
                    LblScore.Text = "Score: " + score;
                }
            }
        }

        private void Collision()
        {
            Player.Top += jumpSpeed;

            if (!Player.Bounds.IntersectsWith(platform.Bounds) && jumping == false)
            {
                Player.Top += 10;
            }

            foreach (Control x in Controls)
            {
                if (x is PictureBox && (string)x.Tag == "platform")
                {
                    if (Player.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        force = 13;
                        Player.Top = x.Top - Player.Height;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "wall")
                {
                    if (Player.Bounds.IntersectsWith(x.Bounds) && Player.Location.X < x.Location.X)
                    {
                        Player.Left = x.Right - Player.Width - 25;
                    }
                    else if (Player.Bounds.IntersectsWith(x.Bounds) && Player.Location.X > x.Location.X)
                        Player.Left = x.Right;
                }
            }
        }

        private void EnemyScript()
        {
            foreach (Control x in Controls)
                if ((string)x.Tag == "breack")
                    if (Player.Bounds.IntersectsWith(x.Bounds) && HpFlag == false) { Hp -= 1; HpFlag = true; HpBar.Text = "Hp:" + Hp; }

            if (rand != 1)
            {
                progectals.Top = Ralph.Location.Y - 4;
                progectals.Left = Ralph.Location.X;
                if (!Ralph.Bounds.IntersectsWith(wall.Bounds) && wallTaches == false)
                {
                    Ralph.Left += 5;
                    progectals.Left += 5;
                }
                else wallTaches = true;
                if (!Ralph.Bounds.IntersectsWith(pictureBox3.Bounds) && wallTaches == true) { Ralph.Left -= 5; progectals.Left -= 5; }
                else wallTaches = false;
            }
            else if (!progectals.Bounds.IntersectsWith(platform.Bounds)) progectals.Top += 30;
            else progectals.Left += 1000;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Neigbors c1 = new Neigbors();
            c1.drawTo(this);
            nList.Add(c1);
            c1.setPos(100, 200);
            Neigbors c2 = new Neigbors();
            c2.drawTo(this);
            nList.Add(c2);
            c2.setPos(300, 200);
            Windows w1 = new Windows();
            w1.drawTo(this);
            WList.Add(w1);
            w1.setPos(100, 365);
            Windows w2 = new Windows();
            w2.drawTo(this);
            WList.Add(w2);
            w2.setPos(300, 365);
        }

        private void TmrEnemy_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            rand = rnd.Next(0, 2);
            HpFlag = false;         
        }
        
    }
}
