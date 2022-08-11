using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum cities { İstanbul, Antalya, İzmir, Aydın, Muğla, Balıkesir }
        private void button1_Click(object sender, EventArgs e)
        {
            int plaque = Convert.ToInt16(label1.Text);
            cities c;
            c = (cities)plaque;
            label1.Text = c.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
