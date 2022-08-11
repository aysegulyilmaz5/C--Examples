using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series["Book"].Points.AddXY("Akdeniz", 5);
            chart1.Series["Book"].Points.AddXY("Ege", 10);
            chart1.Series["Book"].Points.AddXY("Marmara", 35);
            chart1.Series["Book"].Points.AddXY("Karadeniz", 4);
            chart1.Series["Book"].Points.AddXY("Anadolu", 2);
        }
    } 
}
