
namespace BookShelf
{
    partial class BookShelf
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookShelf));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ıd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_author = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.comboBox_categories = new System.Windows.Forms.ComboBox();
            this.radioButton_used = new System.Windows.Forms.RadioButton();
            this.radioButton_notused = new System.Windows.Forms.RadioButton();
            this.textBox_page = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_list = new System.Windows.Forms.Button();
            this.button_register = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_find = new System.Windows.Forms.Button();
            this.textBox_namefind = new System.Windows.Forms.TextBox();
            this.label_name2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(591, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book Id:";
            // 
            // textBox_ıd
            // 
            this.textBox_ıd.Enabled = false;
            this.textBox_ıd.Location = new System.Drawing.Point(83, 24);
            this.textBox_ıd.Name = "textBox_ıd";
            this.textBox_ıd.Size = new System.Drawing.Size(97, 20);
            this.textBox_ıd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Book Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Author:";
            // 
            // textBox_author
            // 
            this.textBox_author.Location = new System.Drawing.Point(83, 95);
            this.textBox_author.Name = "textBox_author";
            this.textBox_author.Size = new System.Drawing.Size(97, 20);
            this.textBox_author.TabIndex = 5;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(83, 59);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(97, 20);
            this.textBox_name.TabIndex = 6;
            // 
            // comboBox_categories
            // 
            this.comboBox_categories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_categories.FormattingEnabled = true;
            this.comboBox_categories.Items.AddRange(new object[] {
            "Novel",
            "Story",
            "AutoBiography",
            "Biography",
            "Article"});
            this.comboBox_categories.Location = new System.Drawing.Point(83, 163);
            this.comboBox_categories.Name = "comboBox_categories";
            this.comboBox_categories.Size = new System.Drawing.Size(97, 21);
            this.comboBox_categories.TabIndex = 7;
            // 
            // radioButton_used
            // 
            this.radioButton_used.AutoSize = true;
            this.radioButton_used.Location = new System.Drawing.Point(83, 209);
            this.radioButton_used.Name = "radioButton_used";
            this.radioButton_used.Size = new System.Drawing.Size(50, 17);
            this.radioButton_used.TabIndex = 8;
            this.radioButton_used.TabStop = true;
            this.radioButton_used.Text = "Used";
            this.radioButton_used.UseVisualStyleBackColor = true;
            this.radioButton_used.CheckedChanged += new System.EventHandler(this.radioButton_used_CheckedChanged);
            // 
            // radioButton_notused
            // 
            this.radioButton_notused.AutoSize = true;
            this.radioButton_notused.Location = new System.Drawing.Point(169, 209);
            this.radioButton_notused.Name = "radioButton_notused";
            this.radioButton_notused.Size = new System.Drawing.Size(70, 17);
            this.radioButton_notused.TabIndex = 9;
            this.radioButton_notused.TabStop = true;
            this.radioButton_notused.Text = "Not Used";
            this.radioButton_notused.UseVisualStyleBackColor = true;
            this.radioButton_notused.CheckedChanged += new System.EventHandler(this.radioButton_notused_CheckedChanged);
            // 
            // textBox_page
            // 
            this.textBox_page.Location = new System.Drawing.Point(83, 131);
            this.textBox_page.Name = "textBox_page";
            this.textBox_page.Size = new System.Drawing.Size(97, 20);
            this.textBox_page.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Page:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Categories:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Situation:";
            // 
            // button_list
            // 
            this.button_list.Location = new System.Drawing.Point(260, 27);
            this.button_list.Name = "button_list";
            this.button_list.Size = new System.Drawing.Size(112, 27);
            this.button_list.TabIndex = 14;
            this.button_list.Text = "List";
            this.button_list.UseVisualStyleBackColor = true;
            this.button_list.Click += new System.EventHandler(this.button_list_Click);
            // 
            // button_register
            // 
            this.button_register.Location = new System.Drawing.Point(260, 62);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(112, 27);
            this.button_register.TabIndex = 15;
            this.button_register.Text = "Register";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(260, 95);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(112, 27);
            this.button_delete.TabIndex = 16;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(260, 131);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(112, 27);
            this.button_update.TabIndex = 17;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(414, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // button_find
            // 
            this.button_find.Location = new System.Drawing.Point(411, 209);
            this.button_find.Name = "button_find";
            this.button_find.Size = new System.Drawing.Size(66, 24);
            this.button_find.TabIndex = 19;
            this.button_find.Text = "Find";
            this.button_find.UseVisualStyleBackColor = true;
            this.button_find.Click += new System.EventHandler(this.button_find_Click);
            // 
            // textBox_namefind
            // 
            this.textBox_namefind.Location = new System.Drawing.Point(411, 179);
            this.textBox_namefind.Name = "textBox_namefind";
            this.textBox_namefind.Size = new System.Drawing.Size(145, 20);
            this.textBox_namefind.TabIndex = 21;
            // 
            // label_name2
            // 
            this.label_name2.AutoSize = true;
            this.label_name2.Location = new System.Drawing.Point(326, 182);
            this.label_name2.Name = "label_name2";
            this.label_name2.Size = new System.Drawing.Size(66, 13);
            this.label_name2.TabIndex = 20;
            this.label_name2.Text = "Book Name:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(490, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 24);
            this.button1.TabIndex = 22;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BookShelf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(614, 420);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_namefind);
            this.Controls.Add(this.label_name2);
            this.Controls.Add(this.button_find);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.button_list);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_page);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButton_notused);
            this.Controls.Add(this.radioButton_used);
            this.Controls.Add(this.comboBox_categories);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_author);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_ıd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BookShelf";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.BookShelf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ıd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_author;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.ComboBox comboBox_categories;
        private System.Windows.Forms.RadioButton radioButton_used;
        private System.Windows.Forms.RadioButton radioButton_notused;
        private System.Windows.Forms.TextBox textBox_page;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_list;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_find;
        private System.Windows.Forms.TextBox textBox_namefind;
        private System.Windows.Forms.Label label_name2;
        private System.Windows.Forms.Button button1;
    }
}

