using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1, number2, sum,sub,mult,div;
            number1 = Convert.ToInt16(textBox1.Text);
            number2 = Convert.ToInt16(textBox2.Text);
            sum = number1 + number2;
            sub = number1 - number2;
            mult = number1 * number2;
            div = number1 / number2;
            MessageBox.Show("Sum: " + sum + "\nSub:" + sub + "\nMult: " + mult + "\nDiv: " + div);
        }
    }
}
