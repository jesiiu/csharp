using ExcelDataReader;
using System.Data;

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
        //Create new DataTable
        DataTable table = new DataTable();

        private void Form1_load(object sender, EventArgs e)
        {
            //Load sample of data
            table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("FirstName", typeof(string));
            table.Columns.Add("LastName", typeof(string));
            table.Columns.Add("Number", typeof(string));
            table.Rows.Add(1, "Kacper", "Kacper", "123456789");
            table.Rows.Add(2, "Eryk", "Eryk", "111222333");
            dataGridView1.DataSource = table;
        }

        //Button to add contacts do DataTable
        private void button1_Click(object sender, EventArgs e)
        {
           //Get informations about contact
            string firstname = this.firstname.Text.ToString();
            string lastname = this.lastname.Text.ToString();
            string textnumber = text_number.Text.ToString();
            //Set ID of contact
            Int32 id = dataGridView1.Rows.Count;
            //Add contact do DataTable
            table.Rows.Add(id, firstname, lastname, textnumber);
        }
        //Searching by first name of contact
        private void firstname_search_TextChanged(object sender, EventArgs e)
        {
            //Check if text box with first name is fill
            //If is fill program filter DatTable and show us contact with our name
            if (firstname_search.Text != string.Empty)
            {
                var firstname = firstname_search.Text.ToString();
                DataView dv = new DataView(table);
                dv.RowFilter = $"'{firstname}' = FirstName";
                dataGridView1.DataSource = dv;
            }
            //If text box is empty program show full datatable
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
        private void lastname_search_TextChanged_1(object sender, EventArgs e)
        {
            if (lastname_search.Text != string.Empty)
            {
                var lastname = lastname_search.Text.ToString();
                DataView dv = new DataView(table);
                dv.RowFilter = $"'{lastname}' = LastName";
                dataGridView1.DataSource = dv;
            }
            else if (lastname_search.Text == string.Empty)
            {
                dataGridView1.DataSource = table;
            }
        }
        //Get informations about contact to textbox 
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            edit_firstname.Text = selectedRow.Cells[1].Value.ToString();
            edit_lastname.Text = selectedRow.Cells[2].Value.ToString();
            edit_number.Text = selectedRow.Cells[3].Value.ToString();
        }
        //Edit informations about contact
        private void button4_Click(object sender, EventArgs e)
        {
            DataGridViewRow update_value = dataGridView1.Rows[index];
            update_value.Cells[1].Value = edit_firstname.Text;
            update_value.Cells[2].Value = edit_lastname.Text;
            update_value.Cells[3].Value = edit_number.Text;
        }

        //Exit button
        private void button2_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        //Import Excel file to our DatTable
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            string path = file.FileName.ToString();
            excel_reader(path);
        }
        //Method to import file
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