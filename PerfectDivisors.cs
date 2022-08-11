using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace If_else_And_loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt16(textBox1.Text);
            for(int i = 1; i <= num; i++)
            {
                if(num %i == 0)
                {
                    listBox1.Items.Add(i);
                }
            }
        }
    }
}
