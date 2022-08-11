using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace BookShelf
{
    public partial class BookShelf : Form
    {
        public BookShelf()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\aysegul\Desktop\BookShelff.mdb");

        void lists()
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("Select * From BookShelff",baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        //
        private void BookShelf_Load(object sender, EventArgs e)
        {
            lists();
        }

        private void button_list_Click(object sender, EventArgs e)
        {
            lists();
        }
        string situation = " ";

        private void button_register_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand command = new OleDbCommand("insert into BookShelff (BookName,Author,Categories,Page,Situation) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            command.Parameters.AddWithValue("@p1", textBox_name.Text);
            command.Parameters.AddWithValue("@p2", textBox_author.Text);
            command.Parameters.AddWithValue("@p3", comboBox_categories.Text);
            command.Parameters.AddWithValue("@p4", textBox_page.Text);
            command.Parameters.AddWithValue("@p5", situation);
            command.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Book is register in system", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lists();

        }

        private void radioButton_used_CheckedChanged(object sender, EventArgs e)
        {
            situation = "0";
        }

        private void radioButton_notused_CheckedChanged(object sender, EventArgs e)
        {
            situation = "1";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;

            textBox_ıd.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            textBox_name.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            textBox_author.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            textBox_page.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            comboBox_categories.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            if(dataGridView1.Rows[selected].Cells[5].Value.ToString()== "True")
            {
                radioButton_notused.Checked = true;

            }
            else
            {
                radioButton_used.Checked = true;
            }

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand command = new OleDbCommand("Delete From BookShelff where BookId=@p1", baglanti);
            command.Parameters.AddWithValue("@p1", textBox_ıd.Text);
            command.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Book is deleted in list");
            lists();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand command = new OleDbCommand("Update BookShelff set BookName=@p1,Author=@p2,Categories=@p3,Page=@p4 where BookId=@p6", baglanti);
            command.Parameters.AddWithValue("@p1", textBox_name.Text);
            command.Parameters.AddWithValue("@p2", textBox_author.Text);
            command.Parameters.AddWithValue("@p3", comboBox_categories.Text);
            command.Parameters.AddWithValue("@p4", textBox_page.Text);
            if(radioButton_notused.Checked == true)
            {
                command.Parameters.AddWithValue("@p5", situation);
            }
            if(radioButton_used.Checked == true)
            {
                command.Parameters.AddWithValue("@p5", situation);
            }
            command.Parameters.AddWithValue("@p6", textBox_ıd.Text);
            command.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Book is updated in list");
            lists();
        }

        private void button_find_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand command = new OleDbCommand("Select * From BookShelff where BookName=@p1", baglanti);
            command.Parameters.AddWithValue("@p1", textBox_namefind.Text);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand command = new OleDbCommand("Select * From BookShelff where BookName like '%"+textBox_namefind.Text+"%'", baglanti);
            command.Parameters.AddWithValue("@p1", textBox_namefind.Text);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
    }
}
