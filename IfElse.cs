using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate_Area
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "aysegul")
            {
                label1.Text = "true";
            }
            else
            {
                label1.Text = "false";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt16(textBox2.Text);
            if(number == 5)
            {
                label2.Text = "true";
            }
            else
            {
                label2.Text = "false";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt16(textBox3.Text);
            if(number %2 == 0)
            {
                label3.Text = "even number";
            }
            else
            {
                label3.Text = "odd number";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt16(textBox4.Text);
            if(number % 2 == 0 && number >= 10)
            {
                label4.Text = "greater than 10 and even number";

            }
            else
            {
                label4.Text = " less than 10 or odd number";
            }
        }
    }
}
