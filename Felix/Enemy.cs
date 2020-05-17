using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Felix
{
    class Enemy
    {
        private PictureBox Ralph = new PictureBox();
        public Enemy()
        {
            Ralph.Width = 100;
            Ralph.Height = 100;
            Ralph.BackColor = Color.Red;
        }
        public void drawTo(Form f)
        {
            f.Controls.Add(Ralph);
        }
        public Rectangle getBounds()
        {
            return Ralph.Bounds;
        }
        public void setPos(int x, int y)
        {
            Ralph.Location = new Point(x, y);
        }


    }

}
