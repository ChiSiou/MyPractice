using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePage
{
    public partial class Paint : Form
    {
        public Paint()
        {

            InitializeComponent();
            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic.BackgroundImage = bm;
        }
        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black, 1);
        int index ;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
            }
            pic.Refresh();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
        }
    }
}
