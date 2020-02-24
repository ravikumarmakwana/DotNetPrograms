using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            OnBtnClick("1");
        }
        private void OnBtnClick(string v)
        {
            int position = text.SelectionStart;
            text.Text = text.Text.Insert(position, v);
            text.SelectionStart = position + 1;
            text.Focus();
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            OnBtnClick(".");
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            OnBtnClick("0");
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            OnBtnClick("3");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OnBtnClick("+");
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            OnBtnClick("-");
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            OnBtnClick("*");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            OnBtnClick("/");
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            OnBtnClick("%");
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

        private void btnSix_Click(object sender, EventArgs e)
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

        private void btnTwo_Click(object sender, EventArgs e)
        {
            OnBtnClick("2");
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            text.Text = "";
        }
    }
}
