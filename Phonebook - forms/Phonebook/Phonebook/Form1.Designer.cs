namespace Phonebook
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.firstname = new System.Windows.Forms.TextBox();
            this.text_number = new System.Windows.Forms.TextBox();
            this.first_name = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.Label();
            this.firstname_search = new System.Windows.Forms.TextBox();
            this.add_contact = new System.Windows.Forms.Label();
            this.search_by_name = new System.Windows.Forms.Label();
            this.search_by_number = new System.Windows.Forms.Label();
            this.user_number = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.edit_firstname = new System.Windows.Forms.TextBox();
            this.edit_number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.edit_lastname = new System.Windows.Forms.TextBox();
            this.lastname_search = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(424, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(430, 355);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Edit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(32, 74);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(98, 23);
            this.firstname.TabIndex = 5;
            // 
            // text_number
            // 
            this.text_number.Location = new System.Drawing.Point(290, 75);
            this.text_number.Name = "text_number";
            this.text_number.Size = new System.Drawing.Size(98, 23);
            this.text_number.TabIndex = 6;
            // 
            // first_name
            // 
            this.first_name.AutoSize = true;
            this.first_name.Location = new System.Drawing.Point(42, 44);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(65, 15);
            this.first_name.TabIndex = 7;
            this.first_name.Text = "First name:";
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Location = new System.Drawing.Point(304, 44);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(54, 15);
            this.number.TabIndex = 8;
            this.number.Text = "Number:";
            // 
            // firstname_search
            // 
            this.firstname_search.Location = new System.Drawing.Point(38, 199);
            this.firstname_search.Name = "firstname_search";
            this.firstname_search.Size = new System.Drawing.Size(98, 23);
            this.firstname_search.TabIndex = 9;
            this.firstname_search.TextChanged += new System.EventHandler(this.firstname_search_TextChanged);
            // 
            // add_contact
            // 
            this.add_contact.AutoSize = true;
            this.add_contact.Location = new System.Drawing.Point(187, 12);
            this.add_contact.Name = "add_contact";
            this.add_contact.Size = new System.Drawing.Size(75, 15);
            this.add_contact.TabIndex = 10;
            this.add_contact.Text = "Add contact:";
            // 
            // search_by_name
            // 
            this.search_by_name.AutoSize = true;
            this.search_by_name.Location = new System.Drawing.Point(42, 168);
            this.search_by_name.Name = "search_by_name";
            this.search_by_name.Size = new System.Drawing.Size(94, 15);
            this.search_by_name.TabIndex = 11;
            this.search_by_name.Text = "Search by name:";
            // 
            // search_by_number
            // 
            this.search_by_number.AutoSize = true;
            this.search_by_number.Location = new System.Drawing.Point(304, 168);
            this.search_by_number.Name = "search_by_number";
            this.search_by_number.Size = new System.Drawing.Size(106, 15);
            this.search_by_number.TabIndex = 12;
            this.search_by_number.Text = "Search by number:";
            // 
            // user_number
            // 
            this.user_number.Location = new System.Drawing.Point(304, 198);
            this.user_number.Name = "user_number";
            this.user_number.Size = new System.Drawing.Size(100, 23);
            this.user_number.TabIndex = 13;
            this.user_number.TextChanged += new System.EventHandler(this.user_number_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(538, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(514, 524);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // edit_firstname
            // 
            this.edit_firstname.Location = new System.Drawing.Point(26, 356);
            this.edit_firstname.Name = "edit_firstname";
            this.edit_firstname.Size = new System.Drawing.Size(100, 23);
            this.edit_firstname.TabIndex = 15;
            // 
            // edit_number
            // 
            this.edit_number.Location = new System.Drawing.Point(288, 356);
            this.edit_number.Name = "edit_number";
            this.edit_number.Size = new System.Drawing.Size(100, 23);
            this.edit_number.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Edit contact:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Number";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 513);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(169, 450);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "Import File";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 23;
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.Location = new System.Drawing.Point(187, 44);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(64, 15);
            this.lastname.TabIndex = 24;
            this.lastname.Text = "Last name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "Last name:";
            // 
            // edit_lastname
            // 
            this.edit_lastname.Location = new System.Drawing.Point(158, 356);
            this.edit_lastname.Name = "edit_lastname";
            this.edit_lastname.Size = new System.Drawing.Size(100, 23);
            this.edit_lastname.TabIndex = 26;
            // 
            // lastname_search
            // 
            this.lastname_search.Location = new System.Drawing.Point(170, 198);
            this.lastname_search.Name = "lastname_search";
            this.lastname_search.Size = new System.Drawing.Size(100, 23);
            this.lastname_search.TabIndex = 27;
            this.lastname_search.TextChanged += new System.EventHandler(this.lastname_search_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "Search by last name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 548);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lastname_search);
            this.Controls.Add(this.edit_lastname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edit_number);
            this.Controls.Add(this.edit_firstname);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.user_number);
            this.Controls.Add(this.search_by_number);
            this.Controls.Add(this.search_by_name);
            this.Controls.Add(this.add_contact);
            this.Controls.Add(this.firstname_search);
            this.Controls.Add(this.number);
            this.Controls.Add(this.first_name);
            this.Controls.Add(this.text_number);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion
        private Button button1;
        private Button button4;
        private TextBox firstname;
        private TextBox text_number;
        private Label first_name;
        private Label number;
        private TextBox textBox1;
        private Label add_contact;
        private Label search_by_name;
        private Label search_by_number;
        private TextBox user_number;
        private TextBox firstname_search;
        private DataGridView dataGridView1;
        private TextBox edit_firstname;
        private TextBox edit_number;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
        private Button button3;
        private Label lastname;
        private Label label5;
        private TextBox edit_lastname;
        private TextBox lastname_search;
        private Label label4;
    }
}