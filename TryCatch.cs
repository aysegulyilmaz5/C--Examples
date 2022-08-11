using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Error_Checks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int number1 = Convert.ToInt16(textBox1.Text);
                int number2 = Convert.ToInt16(textBox2.Text);
                int sum = number1 + number2;
                MessageBox.Show(sum.ToString());
            }
            catch(Exception)
            {
                MessageBox.Show("Please check your values");
            }
        }
    }
}
