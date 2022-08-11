﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Text_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string filename, filepath;
        StreamWriter Sw;

   
        private void button1_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = folderBrowserDialog1.SelectedPath.ToString();
                textBox1.Text = filename;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            filename = textBox2.Text;
            Sw = File.CreateText(filepath + "\\" + filename + ".txt");
            Sw.Close();
            
            
        }
    }
}
