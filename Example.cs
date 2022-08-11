using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double midterm1, midterm2, project, average;
            string situation;
            midterm1 = Convert.ToDouble(textBox1.Text);
            midterm2 = Convert.ToDouble(textBox2.Text);
            project = Convert.ToDouble(textBox3.Text);

            average = (midterm1 + midterm2 + project) / 3;

            if(average >= 50)
            {
                situation = "pass";
            }
            else
            {
                situation = "left";
            }

            textBox4.Text = average.ToString("0.00") + " /" + situation;
        }
    }
}
