using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Not_Returning_Methods_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Add()
        {
            textBox1.Text = "Aysegul";
            textBox2.Text = "Yilmaz";
            textBox3.Text = "21";
            textBox4.Text = "1.61";
            textBox5.Text = "57.8";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add();
        }
    }
}
