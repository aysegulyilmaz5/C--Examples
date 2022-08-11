using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int counter;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            Point location = new Point();
            if(counter == 3)
            {
                location.X = 50;
                location.Y = 100;
                pictureBox1.Location = location;
                pictureBox1.BackColor = Color.Aquamarine;
            }
            if(counter == 4)
            {
                location.X = 100;
                location.Y = 50;
                pictureBox1.Location = location;
                pictureBox1.BackColor = Color.Red;
            }
            if (counter == 5)
            {
                location.X = 100;
                location.Y = 150;
                pictureBox1.Location = location;
                pictureBox1.BackColor = Color.Pink;
            }
            if (counter == 6)
            {
                location.X = 150;
                location.Y = 100;
                pictureBox1.Location = location;
                pictureBox1.BackColor = Color.GreenYellow;
            }
            if (counter == 7)
            {
                location.X = 300;
                location.Y = 200;
                pictureBox1.Location = location;
                pictureBox1.BackColor = Color.BlueViolet;
            }
        }
    }
}
