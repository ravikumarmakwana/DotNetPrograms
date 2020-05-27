using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float fontSize = label1.Font.Size;
            label1.Font = new Font(label1.Font.FontFamily, ++fontSize);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float fontSize = label1.Font.Size;
            label1.Font = new Font(label1.Font.FontFamily, --fontSize);
        }
    }
}
