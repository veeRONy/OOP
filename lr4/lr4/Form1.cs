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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (ModifierKeys == Keys.Control)
            {
                chbCTRL.Checked = true;
            }
            else if (e.KeyCode == Keys.Delete)
            {
                for(int i=0;i<circles.Count;++i)
                {
                    // если круг выделен, то удаляем его
                    if (circles[i].isHighLighted() == true)
                    {
                        circles.Remove(circles[i]);
                        --i;
                    }
                }
                // последний в списке делаем выделенным
                if (circles.Count!=0)
                    circles.Last().SetPenColor(Color.Blue);
                Refresh();
            }
        }
        
        List<CCircle> circles = new List<CCircle>();
        
        private void frmMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (chbCTRL.Checked==false)
            {
                // все круги в контейнере делаем красными
                foreach (CCircle circle1 in circles)
                    circle1.SetPenColor(Color.Red);

                // создаем новый круг
                CCircle circle = new CCircle(e.X, e.Y);
                // добавляем в контейнер
                circles.Add(circle);
            }
            else
            {
                foreach (CCircle circle in circles)
                    // проверяем, кликнули ли на круг
                   if (circle.isClickedOnCircle(e.X, e.Y))
                   {
                        // если да, то выделяем его голубым цветом
                       circle.SetPenColor(Color.Blue);
                           if (checkBox2.Checked == true)
                               break;
                   }
            }
            Refresh();
        }
        
        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            // русуем все круги из контейнера
            foreach (CCircle circle in circles)
                circle.DrawCircle(this);
        }

        private void frmMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (chbCTRL.Checked == true)
                chbCTRL.Checked = false;
        }
    }

}
