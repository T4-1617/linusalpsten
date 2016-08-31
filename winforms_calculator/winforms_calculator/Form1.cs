using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winforms_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Enter first number";
            label2.Text = "Enter second number";
            button1.Text = "+";
            button2.Text = "-";
            button3.Text = "*";
            button4.Text = "/";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show((int.Parse(textBox1.Text) + int.Parse(textBox2.Text)).ToString(),"Answer", MessageBoxButtons.OKCancel);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show((int.Parse(textBox1.Text) - int.Parse(textBox2.Text)).ToString(), "Answer", MessageBoxButtons.OKCancel);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show((int.Parse(textBox1.Text) * int.Parse(textBox2.Text)).ToString(), "Answer", MessageBoxButtons.OKCancel);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show((int.Parse(textBox1.Text) / int.Parse(textBox2.Text)).ToString(), "Answer", MessageBoxButtons.OKCancel);
        }
    }
}
