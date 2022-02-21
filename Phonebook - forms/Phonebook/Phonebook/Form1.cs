using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;

namespace Phonebook
{
    public partial class Form1 : Form
    {
        private int index;
        public Form1()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_load);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.CellClick += new DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
        }
        DataTable table = new DataTable();
        


        private void Form1_load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("First name", typeof(string));
            table.Columns.Add("Last name", typeof(string));
            table.Columns.Add("Number", typeof(string));

            table.Rows.Add(1,"Kacper", "Kacper", "123456789");
            table.Rows.Add(2,"Eryk","Eryk", "111222333");

            dataGridView1.DataSource = table;
            
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            string firstname = this.firstname.Text.ToString();
            string lastname = this.lastname.Text.ToString();
            string textnumber = text_number.Text.ToString();
            
            Int32 id= dataGridView1.Rows.Count;
            table.Rows.Add(id, firstname, lastname, textnumber);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void firstaname_TextChanged(object sender, EventArgs e)
        {
            if (firstname_search.Text != string.Empty)
            {
                var firstname = firstname_search.Text.ToString();
                DataView dv = new DataView(table);
                dv.RowFilter = $"'{firstname}' = First name";
                dataGridView1.DataSource = dv;
            }
            else if (firstname_search.Text == string.Empty)
            {
                dataGridView1.DataSource = table;
            }
        }

        private void user_number_TextChanged(object sender, EventArgs e)
        {
            if (user_number.Text != string.Empty)
            {
                var usernumber = user_number.Text.ToString();
                DataView dv = new DataView(table);
                dv.RowFilter = $"'{usernumber}' = Number";
                dataGridView1.DataSource = dv;
            }
            else if (user_number.Text == string.Empty)
            {
                dataGridView1.DataSource = table;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (lastname.Text != string.Empty)
            {
                var lastname = lastname_search.Text.ToString();
                DataView dv = new DataView(table);
                dv.RowFilter = $"'{lastname}' = Last name";
                dataGridView1.DataSource = dv;
            }
            else if (lastname.Text == string.Empty)
            {
                dataGridView1.DataSource = table;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            edit_name.Text = selectedRow.Cells[1].Value.ToString();
            edit_number.Text = selectedRow.Cells[2].Value.ToString();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            
            DataGridViewRow update_value = dataGridView1.Rows[index];
            update_value.Cells[1].Value = edit_name.Text;
            update_value.Cells[2].Value = edit_number.Text;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            string path = file.FileName.ToString();
            excel_reader(path);
           
        }
        private void excel_reader(string path)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            var stream = File.Open(path, FileMode.Open, FileAccess.Read);
            var reader = ExcelReaderFactory.CreateReader(stream);
            var result = reader.AsDataSet();
            var tables = result.Tables;
            foreach (DataTable table in tables)
            {
                dataGridView1.DataSource = table;
            }
        }

        
    }
}