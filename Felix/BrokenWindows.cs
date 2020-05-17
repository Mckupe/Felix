using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Felix
{
    class Windows
    {
        public bool fixedYet = false;
        private PictureBox Window = new PictureBox();
        public Windows()
        {         
            Window.Width = 100;
            Window.Height = 100;
            Window.BackColor = Color.Blue;  
            Window.Tag = "window";
        }
        public void drawTo(Form f)
        {
            f.Controls.Add(Window);
        }
        public Rectangle getBounds()
        {
            return Window.Bounds;
        }
        public bool getLocation()
        {
            return fixedYet;
        }
        public void setLocation()
        {
            fixedYet=true;
        }
        public void setPos(int x, int y)
        {
            Window.Location = new Point(x, y);
        }
        public void changeColor(Color color)
        {
            Window.BackColor = color;
        }


    }

}
