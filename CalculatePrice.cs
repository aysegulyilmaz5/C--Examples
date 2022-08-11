using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int booksnumber;
            double total;
            booksnumber = Convert.ToInt16(textBox1.Text);
            if(booksnumber >= 0 && booksnumber <= 20)
            {
                total = (booksnumber * 8) - (booksnumber * 8 * 0.20);
                label3.Text = total + "$";


            }
            if(booksnumber >=21 && booksnumber <= 40)
            {
                total = (booksnumber * 8) - (booksnumber * 8 * 0.40);
                label3.Text = total + "$";
            }
            if (booksnumber >= 41)
            {
                total = (booksnumber * 8) - (booksnumber * 8 * 0.5);
                label3.Text = total + " $";
            }
        }
    }
}
//0-20 --> %20
//21-40 --> %40
//41++ --> %50
//Book = 8
