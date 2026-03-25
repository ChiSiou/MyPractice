using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PenPickTool;
using static PenPickTool.PentoolType;

namespace HomePage
{
    public partial class Paint : Form
    {

        Bitmap _bm ;
        Graphics _g ;
        Point _start , _end;
        bool paint = false;
        Pen _pen;
        DrawTool _CurrentTool;
        PentoolType p = new PentoolType();
        public Paint()
        {

            InitializeComponent();
            _bm = new Bitmap(pic.Width, pic.Height);
            _g = Graphics.FromImage(_bm);
            _g.SmoothingMode = SmoothingMode.AntiAlias;
            _pen = new Pen(Color.Black);
        }


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            _start = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                switch (_CurrentTool)
                {
                    case DrawTool.Pen: case DrawTool.Eraser:
                       
                        _end = e.Location;
                        _g.DrawLine(_pen, _start, _end);
                        _start = _end;
                        break;
                    case DrawTool.Brush:
                        _end = e.Location;
                        _g.FillEllipse(_pen.Brush, _end.X - _pen.Width/3 , _end.Y - _pen.Width/3 , _pen.Width, _pen.Width);
                        _g.DrawLine(_pen, _start, _end);
                        _start = _end;
                        break;
                }

            }
            pic.Image = _bm;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            p.PickColor(ref _pen);
        }

        private void tkbSizeChange_Scroll(object sender, EventArgs e)
        {
            _pen.Width = tkbSizeChange.Value;
        }

        private void btnPen_Click(object sender, EventArgs e)
        {
            _CurrentTool = DrawTool.Pen;
            _pen = p.picktool(_CurrentTool, pic.BackColor, _pen.Color, _pen.Width);
        }

        private void btnBrush_Click(object sender, EventArgs e)
        {
            _CurrentTool = DrawTool.Brush;
            _pen = p.picktool(_CurrentTool, pic.BackColor, _pen.Color, _pen.Width);
        }

        private void btnEraser_Click(object sender, EventArgs e)
        {
            _CurrentTool = DrawTool.Eraser;
            _pen = p.picktool(_CurrentTool, pic.BackColor, _pen.Color, _pen.Width);
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            _CurrentTool = DrawTool.Line;
            _pen = p.picktool(_CurrentTool, pic.BackColor, _pen.Color, _pen.Width);
        }

        private void btnRentangle_Click(object sender, EventArgs e)
        {
            _CurrentTool = DrawTool.Rentangle;
            _pen = p.picktool(_CurrentTool, pic.BackColor, _pen.Color, _pen.Width);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
        }
    }
}
