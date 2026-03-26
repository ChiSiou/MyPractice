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

        Bitmap _bm;
        Graphics _g;
        Point _start, _end;
        bool paint = false;
        Pen _pen;
        DrawTool _CurrentTool;
        PentoolType p = new PentoolType();
        Color CurrentColor = Color.Black;
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
                    case DrawTool.Pen:
                    case DrawTool.Eraser:
                        _end = e.Location;
                        _g.DrawLine(_pen, _start, _end);
                        _start = _end;
                        pic.Image = _bm;
                        break;
                    case DrawTool.Brush:
                        _end = e.Location;
                        _g.DrawLine(_pen, _start, _end);
                        _start = _end;
                        pic.Image = _bm;
                        break;
                    case DrawTool.Line:
                        _end = e.Location;
                        pic.Invalidate();
                        break;
                    case DrawTool.Rentangle:
                        _end = e.Location;
                        pic.Invalidate();
                        break;
                }
            }
        }



        private void btnColor_Click(object sender, EventArgs e)
        {
            p.PickColor(ref CurrentColor);
            _pen = p.picktool(_CurrentTool, pic.BackColor, CurrentColor, _pen.Width);
            pickedcolor.BackColor = CurrentColor;
        }

        private void tkbSizeChange_Scroll(object sender, EventArgs e)
        {
            _pen.Width = tkbSizeChange.Value;
        }

        private void btnPen_Click(object sender, EventArgs e)
        {
            _CurrentTool = DrawTool.Pen;
            _pen = p.picktool(_CurrentTool, pic.BackColor, CurrentColor, _pen.Width);
        }

        private void btnBrush_Click(object sender, EventArgs e)
        {
            _CurrentTool = DrawTool.Brush;
            _pen = p.picktool(_CurrentTool, pic.BackColor, CurrentColor, _pen.Width);
        }

        private void btnEraser_Click(object sender, EventArgs e)
        {
            _CurrentTool = DrawTool.Eraser;
            _pen = p.picktool(_CurrentTool, pic.BackColor, CurrentColor, _pen.Width);

        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            _CurrentTool = DrawTool.Line;
            _pen = p.picktool(_CurrentTool, pic.BackColor, CurrentColor, _pen.Width);
        }

        private void btnRentangle_Click(object sender, EventArgs e)
        {
            _CurrentTool = DrawTool.Rentangle;
            _pen = p.picktool(_CurrentTool, pic.BackColor, CurrentColor, _pen.Width);
        }

        private void pic_Paint(object sender, PaintEventArgs e)
        {
            if (paint)
            {
                switch (_CurrentTool)
                {
                    case DrawTool.Line:
                        e.Graphics.DrawLine(_pen, _start, _end);
                        break;
                    case DrawTool.Rentangle:
                        int rect_startx = Math.Min(_start.X, _end.X);
                        int rect_starty = Math.Min(_start.Y, _end.Y);
                        int rect_width = Math.Abs(_start.X - _end.X);
                        int rect_height = Math.Abs(_start.Y - _end.Y);
                        e.Graphics.DrawRectangle(_pen, rect_startx, rect_starty, rect_width, rect_height);
                        break;
                }
            }
            if (paint && _CurrentTool == DrawTool.Line)
            {
                e.Graphics.DrawLine(_pen, _start, _end);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            switch (_CurrentTool)
            {
                case DrawTool.Line:
                    _g.DrawLine(_pen, _start, _end);
                    pic.Image = _bm;
                    break;
                case DrawTool.Rentangle:
                    int rect_startx = Math.Min(_start.X, _end.X);
                    int rect_starty = Math.Min(_start.Y, _end.Y);
                    int rect_width = Math.Abs(_start.X - _end.X);
                    int rect_height = Math.Abs(_start.Y - _end.Y);
                    _g.DrawRectangle(_pen, rect_startx, rect_starty, rect_width, rect_height);
                    pic.Image = _bm;
                    break;
            }
        }
    }
}
