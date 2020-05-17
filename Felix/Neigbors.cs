using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Felix
{
    class Neigbors
    {
        private PictureBox Neigbor = new PictureBox();
        public Neigbors()
            {
            Neigbor.Width = 10;
            Neigbor.Height = 40;
            Neigbor.BackColor = Color.Yellow;
            }
        public void drawTo(Form f)
        {
            f.Controls.Add(Neigbor);
        }
        public Rectangle getBounds()
        {
            return Neigbor.Bounds;
        }
        public void setPos (int x,int y)
        {
            Neigbor.Location = new Point(x, y);
        }

    }
}
