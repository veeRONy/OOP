using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr4_2
{
    public partial class frmMain : Form
    {
        Model model;
        public frmMain()
        {
            InitializeComponent();
            // создаем объект-модель
            model = new Model();
            // добавляем обработчик события
            model.observers += new EventHandler(this.UpdateFromModel);
            // инициализируем значения А и С, которые были сохранены
            model.setValueA(Properties.Settings.Default.A);
            model.setValueC(Properties.Settings.Default.C);
        }

        private void nmcA_ValueChanged(object sender, EventArgs e)
        {
            model.setValueA(Decimal.ToInt32(nmcA.Value));
        }

        private void nmcB_ValueChanged(object sender, EventArgs e)
        {
            model.setValueB(Decimal.ToInt32(nmcB.Value));
        }

        private void nmcC_ValueChanged(object sender, EventArgs e)
        {
            model.setValueC(Decimal.ToInt32(nmcC.Value));
        }

        private void trbA_Scroll(object sender, EventArgs e)
        {
            model.setValueA(Decimal.ToInt32(trbA.Value));
        }

        private void trbB_Scroll(object sender, EventArgs e)
        {
            model.setValueB(Decimal.ToInt32(trbB.Value));
        }

        private void trbC_Scroll(object sender, EventArgs e)
        {
            model.setValueC(Decimal.ToInt32(trbC.Value));
        }

        public void UpdateFromModel(object sender, EventArgs e)
        {
            tbA.Text = model.getValueA().ToString();
            tbB.Text = model.getValueB().ToString();
            tbC.Text = model.getValueC().ToString();

            nmcA.Value = model.getValueA();
            nmcB.Value = model.getValueB();
            nmcC.Value = model.getValueC();

            trbA.Value = model.getValueA();
            trbB.Value = model.getValueB();
            trbC.Value = model.getValueC();

        }

        private void tbA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
                model.setValueA(Int32.Parse(tbA.Text));
        }

        private void tbB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                model.setValueB(Int32.Parse(tbB.Text));
        }

        private void tbC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                model.setValueC(Int32.Parse(tbC.Text));
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // сохраняем значения А и С
            Properties.Settings.Default.A = Decimal.ToInt32(nmcA.Value);
            Properties.Settings.Default.C = Decimal.ToInt32(nmcC.Value);
            Properties.Settings.Default.Save();
        }
    }
    public class Model
    {
        private int valueA, valueB, valueC;
        public EventHandler observers;

        public void setValueA(int a)
        {
            // разрешающее поведение
            valueA = a;
            if (a>valueB && a<=valueC)
            {
                valueB = a;
            }
            else if (a>valueC)
            {
                valueA = valueC;
                valueB = valueC;
            }
            observers.Invoke(this, EventArgs.Empty);
        }
        public void setValueB(int b)
        {
            // ограничивающее поведение
            if (b < valueA)
                valueB = valueA;
            else if (b > valueC)
                valueB = valueC;
            else
                valueB = b;
            observers.Invoke(this, EventArgs.Empty);
        }
        public void setValueC(int c)
        {
            // разрешающее поведение
            valueC = c;
            if (c<valueB && c>=valueA)
            {
                valueB = c; 
            }
            else if (c<valueA)
            {
                valueB = c;
                valueA = c;
            }
            observers.Invoke(this, EventArgs.Empty);
        }
        public int getValueA()
        {
            return valueA;
        }
        public int getValueB()
        {
            return valueB;
        }
        public int getValueC()
        {
            return valueC;
        }

    }

}
