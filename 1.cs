using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text;
            text = "Aysegul";
            label1.Text = text;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text2;
            text2 = "Yilmaz";
            label2.Text = text2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string city;
            city = textBox1.Text;
            label3.Text = city;
        }
    }
}
