using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For_Each_Example
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
            int number = 0;
            int[] numbers = { 23, 24, 25, 26, 27, 28, 29, 32, 35, 40 };
            foreach (int x in numbers){
                if(x % 4 == 0)
                {
                    Console.WriteLine(x);
                    listBox1.Items.Add(x);
                    sum = sum + x;
                    label1.Text = sum.ToString();
                    number++;
                }
            }

            Console.WriteLine("Sum:" + sum);
            Console.Write("Number:" + number);
            Console.Read();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
