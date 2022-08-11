using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string message;
        public string bywho;
        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = message;
            label2.Text = bywho;
        }
    }
}
