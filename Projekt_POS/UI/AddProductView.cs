namespace Projekt_POS.UI
{
    public partial class AddProductView : Form
    {
        public AddProductView()
        {
            InitializeComponent();
        }
        private void AddClick(object sender, EventArgs e)
        {
            try
            {
                var product = new Product
                {
                    Name = productNameTextBox.Text,
                    Size = sizeTextBox.Text,
                    ProducerCode = producerCodeTextBox.Text,
                    Manufacturer = producerTextBox.Text,
                    Count = int.Parse(countTextBox.Text),
                    Price = float.Parse(priceTextBox.Text),
                    EanCode = eanTextBox.Text,
                    PhotoUrl = urlTextBox.Text
                };
                using (var context = new AppDbContext())
                {
                    context.Products.Add(product);
                    context.SaveChanges();
                    MessageBox.Show("Produkt został dodany pomyślnie.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas dodawania produktu. {ex}", "Niepowodzenie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
