﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Returning_Methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Sum(int num1,int num2)
        {
            int sum = num1 + num2;
            return sum;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = Sum(4, 8).ToString();
            label2.Text = Sum(89, 14).ToString();
            label3.Text = Sum(12345, 23453).ToString();
        }
    }
}
