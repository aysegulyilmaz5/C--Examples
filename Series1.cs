using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Series
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] people = { "Ali", "Ahmet", "Mehmet", "Aslı", "Hakan", "Demet", "Ayşe" };

            label1.Text = people[4];

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] numbers = { 4, 7, 5, 6, 9, 8, 2, 3 };

            label2.Text = numbers[3].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double[] numbers = { 3.2, 4.6, 6.2 };

            label3.Text = numbers[1].ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            char[] alphabets =['A', 'B', 'C', 'D', 'E', 'F'];

            label4.Text = alphabets[4].ToString();
        }
    }
}
