using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Users_Variables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number;
            number = Convert.ToInt16(textBox1.Text);
            label2.Text = number.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number, result;
            number = Convert.ToInt16(textBox2.Text);
            result = number * number * number;
            label4.Text = result.ToString();
        }
    }
}
