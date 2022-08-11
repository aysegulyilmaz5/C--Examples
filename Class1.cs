using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Classes
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Car Mercedes = new Car();
            Mercedes.color = "Red";
            Mercedes.speed = 250;
            Mercedes.power = 12345,57;
            Mercedes.price = 5000000;
            Mercedes.situation = 'very good';

            label1.Text = Mercedes.color;
            label2.Text = Mercedes.speed.ToString();
            label3.Text = Mercedes.power.ToString();
            label4.Text = Mercedes.price.ToString();
            label5.Text = Mercedes.situation.ToString();
        }
    }
}
