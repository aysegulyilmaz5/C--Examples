using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace whileloop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1;
            while (i <= 100)
            {
                listBox1.Items.Add("Hello World");
                listBox2.Items.Add(i);
                i++;
            }

            int j = 1;
            int sum = 0;
            while (j <= 100)
            {
                sum = sum + j;
                j++;

            }
            MessageBox.Show(sum.ToString());
        }
    }
}
