using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PenPickTool

{
    public class PentoolType
    {

        public enum DrawTool
        {
            Pen,
            Brush,
            Eraser,
            Line,
            Rentangle,
        };
        
        public void PickColor(ref Color CurrentColoren)
        {
            ColorDialog pickcolor = new ColorDialog();
            if (pickcolor.ShowDialog() == DialogResult.OK)
            {
                CurrentColoren = pickcolor.Color;
            }
        }
        public Pen picktool(DrawTool _CurrentTool, Color backcolor, Color FromColorDialog, float pensize)
        {
            Pen pen = new Pen(FromColorDialog, pensize);
            switch (_CurrentTool)
            {
                case DrawTool.Pen:
                    break;
                case DrawTool.Brush:
                    HatchBrush hBrush = new HatchBrush(HatchStyle.Cross, FromColorDialog, Color.Transparent);
                    pen.Brush = hBrush;
                    break;
                case DrawTool.Eraser:
                    pen.Color = backcolor;
                    break;
                case DrawTool.Line:
                    break;
                case DrawTool.Rentangle:
                    break;
            }
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;
            return pen;
        }
    }
}
