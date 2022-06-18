using System.Data;

namespace Projekt_POS.UI
{
    public partial class SearchProductView : Form
    {
        public SearchProductView()
        {
            InitializeComponent();
        }

        private void SearchClick(object sender, EventArgs e)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var nazwa = nameTextBox.Text;
                    var kodean = eanTextBox.Text;
                    var kodproducenta = producerCodeTextBox.Text;
                    var rozmiar = sizeTextBox.Text;
                    var query = context.Products.Where(x => 
                    (!string.IsNullOrWhiteSpace(kodean) && x.EanCode.Contains(kodean)) ||
                    (!string.IsNullOrWhiteSpace(nazwa) && x.Name.Contains(nazwa)) ||
                    (!string.IsNullOrWhiteSpace(kodproducenta) && x.ProducerCode.Contains(kodproducenta)) ||
                    (!string.IsNullOrWhiteSpace(rozmiar) && x.Size.Contains(rozmiar)))
                        .ToList();
                    dataGridView1.DataSource = query;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas wyszukiwania produktu: {ex.Message}.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowAllClick(object sender, EventArgs e)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var query = context.Products.ToList();
                    dataGridView1.DataSource = query;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas wyszukiwania produktu: {ex.Message}.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
