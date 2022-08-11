using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizz_Grades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name, surname;
            int exam1, exam2, project;
            double average;
            name = textBox1.Text;
            surname = textBox2.Text;
            exam1 = Convert.ToInt16(textBox3.Text);
            exam2 = Convert.ToInt16(textBox4.Text);
            project = Convert.ToInt16(textBox5.Text);
            average = (exam1 + exam2 +  project)/3;
            listBox2.Items.Add(name + " " + surname + " " + "Average:" + average);
        }
    }
}
