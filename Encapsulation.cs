using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Car rb = new Car();
            rb.color = "Blue";
            rb.speed = 160;
            rb.power = 1245.56;
            rb.price = 50000;
            rb.situation = 's';
            rb.YEAR = -2016;
            rb.BRAND = "Golf";
            rb.peak = 2017;
            rb.plaque = "34 AI 3406";
            rb.person = "Aysegul";

            label1.Text = rb.color;
            label2.Text = rb.speed.ToString();
            label3.Text = rb.power.ToString();
            label4.Text = rb.price.ToString();
            label5.Text = rb.situation.ToString();
            label6.Text = rb.YEAR.ToString();
            label7.Text = rb.BRAND.ToString();
            pictureBox1.BackColor = Color.Aqua;

            label8.Text = rb.peak.ToString() ;
            label9.Text = rb.plaque;
            label10.Text = rb.person;
        }
    }
}
