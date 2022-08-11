using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variables_2
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
            number = 24;
            label1.Text = number.ToString();
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number2, number3, sum;
            number2 = 5;
            number3 = 8;
            sum = number2 + number3;
            label2.Text = sum.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int edge, area, perimeter;
            edge = 10;
            area = edge * edge;
            perimeter = 4 * edge;
            label3.Text = "Area: " + area + "\nPerimeter: "+perimeter;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int edge1, edge2, area, perimeter;
            edge1 = 10;
            edge2 = 20;
            area = edge1 * edge2;
            perimeter = 2 * edge1 + 2 * edge2;
            label4.Text = "Area:" + area + "\nPerimeter:" + perimeter;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int midterm1, midterm2, final;
            double average;
            midterm1 = 30;
            midterm2 = 50;
            final = 100;
            average = 0.3 * midterm1 + 0.3 * midterm2 + 0.4 * final;
            label5.Text = "Average:" + average;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
