using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr4
{
    internal class CCircle
    {
        private int x, y, r;
        private Pen pen;
        Graphics g;
        public CCircle(int x, int y)
        {
            this.x = x;
            this.y = y;
            r = 50;
            pen = new Pen(Color.Blue);
        }
        public void DrawCircle(frmMain form)
        {
            g = form.CreateGraphics();
            g.DrawEllipse(pen, x-r, y-r, 2*r, 2*r);
        }
        public void SetPenColor(Color color)
        {
            pen.Color = color;
        }
        
        public bool isClickedOnCircle(int X, int Y)
        {
            if ((X - x)*(X - x) + (Y - y)*(Y - y) <= r*r)
                return true;
            else 
                return false;
        }

        public bool isHighLighted()
        {
            if (pen.Color == Color.Blue)
                return true;
            else return false;
        }
    }
}
