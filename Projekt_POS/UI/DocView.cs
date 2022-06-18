using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_POS.UI
{
    public partial class DocView : Form
    {
        public DocView()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var query = context.Documents.ToList();
                    dataGridView1.DataSource = query;
                }
            }
            catch
            {
                MessageBox.Show("Wystąpił błąd", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Type_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var query = context.Documents.Where(x => x.Type.Contains(type.Text.ToString())).ToList();
                    dataGridView1.DataSource = query;
                }
            }
            catch
            {
                MessageBox.Show("Wystąpił błąd", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Date_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var query = context.Documents.Where(x => x.InsertDate.ToString().Contains(date.Text.ToString())).ToList();
                    dataGridView1.DataSource = query;
                }
            }
            catch
            {
                MessageBox.Show("Wystąpił błąd", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Price_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var query = context.Documents.Where(x => x.TotalPrice.ToString().Contains(price.Text.ToString())).ToList();
                    dataGridView1.DataSource = query;
                }
            }
            catch
            {
                MessageBox.Show("Wystąpił błąd", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Count_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var query = context.Documents.Where(x => x.TotalCount.ToString().Contains(count.Text.ToString())).ToList();
                    dataGridView1.DataSource = query;
                }
            }
            catch
            {
                MessageBox.Show("Wystąpił błąd", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
