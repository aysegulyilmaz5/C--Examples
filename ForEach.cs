using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For_Each
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            string[] users = { "Ahmet", "Mehmet", "Aslı", "Sultan", "Melisa", "Fatma", "Betül", "Gül", "Zeynep", "Züleyha", "Arzu", "Merve", "Ceyda" };
            foreach (string u in users) 
            {
                listBox1.Items.Add(u);

            }
            int[] grades = { 68, 72, 56, 78, 98, 23, 34, 12, 56, 34, 37, 85 };
            foreach(int x in grades)
            {
                listBox1.Items.Add(x);
                sum = sum + x;
            }
            label1.Text = sum.ToString();

            int average = sum / grades.Length;
            label2.Text = average.ToString();
        }
    }
}
