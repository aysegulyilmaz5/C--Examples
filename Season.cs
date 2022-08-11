using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seasons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string season = textBox1.Text;
            switch (season)
            {
                case "Summer": label2.Text = "June July August";
                    break;
                case "Autumn": label2.Text = "September October November";
                    break;
                case "Spring": label2.Text = "March April May";
                    break;
                case "Winter": label2.Text = "December January February";
                    break;
                default: label2.Text = "Wrong season";break;
            }
        }
    }
}
