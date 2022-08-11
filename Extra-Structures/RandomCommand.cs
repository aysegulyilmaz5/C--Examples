using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int num1, num2, num3;
            num1 = rnd.Next(1, 50);
            num2 = rnd.Next(1, 100);
            num3 = rnd.Next(1, 150);
            label1.Text = num1.ToString();
            label2.Text = num2.ToString();
            label3.Text = num3.ToString();

        }
    }
}
