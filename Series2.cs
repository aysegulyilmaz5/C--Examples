using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Series2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] cities = { "Ankara", "Eskişehir", "Antalya", "Adana", "Muğla", "Balıkesir", "İstanbul" };
            for(int i = 0; i < cities.Length; i++)
            {
                listBox1.Items.Add(cities[i]);
            }

            int[] numbers = { 2, 3, 4, 5, 6, 7, 8, 9 };
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    listBox1.Items.Add(numbers[i]);
                }
            }

            int[] numbers1 = { 12, 23, 34, 1, 2, 3, 0, 4, 6, 8, 25, 67, 68, 98, 94, 34, 38, 64, 78, 10, 2, 3, 4, 5 };
            for(int i = 0; i < numbers1.Length; i++)
            {
                if(numbers1[i]%2 == 0)
                {
                    if (numbers1[i] > 10)
                    {
                        listBox1.Items.Add(numbers1[i]);
                    }
                }
            }
        }
    }
}
