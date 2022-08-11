using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynamic_Tools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            Point btnkonum = new Point(20, 10);
            btn.Location = btnkonum;
            btn.Name = "Buton 1";
            btn.Text = "Click";
            btn.BackColor = Color.CadetBlue;
            btn.Height = 50;
            btn.Width = 70;

            Label lbl = new Label();
            Point lblkonum = new Point(100, 100);
            lbl.Location = lblkonum;
            lbl.Name = "Label 1";
            lbl.Text = "Hello";
            lbl.BackColor = Color.Red;
            this.Controls.Add(lbl);
            lbl.AutoSize = true;

            for(int i = 1; i <= 5; i++)
            {
                TextBox txt = new TextBox();
                Point txtkonum = new Point(350, i * 30);
                txt.Location = txtkonum;
                txt.Name = "TextBox" + i;
                txt.Text = i.ToString();
                this.Controls.Add(txt);
            }
            this.Controls.Add(btn);
        }
        
    }
}
