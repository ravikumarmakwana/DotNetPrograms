using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            OnBtnClick(".");
        }

        private void OnBtnClick(string v)
        {
            int position=text.SelectionStart;
            text.Text = text.Text.Insert(position, v);
            text.SelectionStart = position + 1;
            text.Focus();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            OnBtnClick("0");
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            OnBtnClick("%");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OnBtnClick("+");
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            OnBtnClick("3");
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            OnBtnClick("2");
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            OnBtnClick("1");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            OnBtnClick("/");
        }

        private void btnSIx_Click(object sender, EventArgs e)
        {
            OnBtnClick("6");
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            OnBtnClick("5");
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            OnBtnClick("4");
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            OnBtnClick("7");
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            OnBtnClick("8");
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            OnBtnClick("9");
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            OnBtnClick("-");
        }

        private void btnMUL_Click(object sender, EventArgs e)
        {
            OnBtnClick("*");
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            text.Text = "";
        }

        private void btnEqu_Click(object sender, EventArgs e)
        {
            String t = text.Text;
            String op = "";
            double no1=0, no2=0;
            if (t.IndexOf('+')!=-1)
            {
                op = "+";
                String[] part = t.Split('+');
                no1 = int.Parse(part[0]);
                no2 = int.Parse(part[1]);
            }
            else if(t.IndexOf('-')!=-1)
            {
                op = "-";
                String[] part = t.Split('-');
                no1 = int.Parse(part[0]);
                no2 = int.Parse(part[1]);
            }
            else if(t.IndexOf('*')!=-1)
            {
                op = "*";
                String[] part = t.Split('*');
                no1 = int.Parse(part[0]);
                no2 = int.Parse(part[1]);
            }
            else if(t.IndexOf('/')!=-1)
            {
                op = "/";
                String[] part = t.Split('/');
                no1 = int.Parse(part[0]);
                no2 = int.Parse(part[1]);
            }
            else if(t.IndexOf('%')!=-1)
            {
                op = "%";
                String[] part = t.Split('%');
                no1 = int.Parse(part[0]);
                no2 = int.Parse(part[1]);
            }
            int position = text.SelectionStart;
            switch (op)
            {
                case "+":
                    text.Text = (no1 + no2).ToString();
                    break;
                case "-":
                    text.Text = (no1 - no2).ToString();
                    break;
                case "*":
                    text.Text = (no1 * no2).ToString();
                    break;
                case "/":
                    text.Text = (no1 / no2).ToString();
                    break;
                case "%":
                    text.Text = (no1 % no2).ToString();
                    break;
            }
            text.SelectionStart = position + 1;
            text.Focus();
        }
    }
}
