using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePage.ScreenSavers
{
    public partial class ScreenSaver : Form
    {
        public ScreenSaver()
        {
            InitializeComponent();
        }
        Point _mousestart;    
        bool _isFirstMove = true;
        
        private void ScreenSaver_KeyDown(object sender, KeyEventArgs e)
        {
            Application.Exit();
        }

        private void ScreenSaver_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void ScreenSaver_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isFirstMove)
            {
                _mousestart = e.Location;
                _isFirstMove = false;
                return;
            }
            int move_X = Math.Abs(e.X - _mousestart.X);
            int move_Y = Math.Abs(e.Y - _mousestart.Y);

            if (move_X > 10 || move_Y > 10)
            {
                Application.Exit();
            }
        }
        int speedX1 = 5;
        int speedY1 = 4;

        int speedX2 = -4;
        int speedY2 = 6;

        private void timer1_Tick(object sender, EventArgs e)
        {
            picfish.Left += speedX1;
            picfish.Top += speedY1;

            picShark.Left += speedX2;
            picShark.Top += speedY2;

            if (picfish.Right >= this.ClientSize.Width || picfish.Left <= 0)
            {
                speedX1 = -speedX1; 

            }
            if (picfish.Bottom >= this.ClientSize.Height || picfish.Top <= 0)
            {
                speedY1 = -speedY1; 
            }
            
            if (picShark.Right >= this.ClientSize.Width || picShark.Left <= 0)
            {
                speedX2 = -speedX2;
            }
            if (picShark.Bottom >= this.ClientSize.Height || picShark.Top <= 0)
            {
                speedY2 = -speedY2;
            }
            if (picfish.Bounds.IntersectsWith(picShark.Bounds))
            {
                speedX1 = -speedX1;
                speedY1 = -speedY1;

                speedX2 = -speedX2;
                speedY2 = -speedY2;
            }
        }
    }
}
