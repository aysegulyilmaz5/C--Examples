using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variables_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        int till = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int popcorn, ticket, water, tea, sum;
            popcorn = Convert.ToInt16(textpopcorn.Text);
            ticket = Convert.ToInt16(textticket.Text);
            water = Convert.ToInt16(textwater.Text);
            tea = Convert.ToInt16(texttea.Text);

            sum = popcorn * 4 + tea * 2 + ticket * 8 + water * 1;
            labelsum.Text = sum.ToString() + "$";

            till = till + sum;
            labeltill.Text = till.ToString() + "$";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textpopcorn.Text = "";
            texttea.Text = "";
            textticket.Text = " ";
            textwater.Text = " ";
            textpopcorn.Focus();

        }
    } 
}
