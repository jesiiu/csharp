using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
namespace Projekt_POS.UI
{
    public partial class CartView : Form
    {
        public List<Product> products { get; set; }
        
        public CartView(List<Product> products)
        {
            InitializeComponent();
            dataGridView1.DataSource = products;
        }       
        private void SellClick(object sender, EventArgs e)
        {
            try
            {  
                var document = new Document()
                {
                        
                        Type = typeofDoc.Items[typeofDoc.SelectedIndex].ToString(),
                        InsertDate = DateTime.Now,
                        TotalPrice = TotalPrice(),
                        TotalCount = TotalCount(),
                        Payment = paymentList.Items[paymentList.SelectedIndex].ToString(),
                        Description = "Sprzedaż towaru"
                };
                using (var context = new AppDbContext())
                {
                    context.Documents.Add(document);
                    context.SaveChanges();
                    UpdateCount();
                    MessageBox.Show("Dokument stworzony. Sprzedaż zakończona", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }             
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas tworzenia dokumentu: {ex}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void UpdateCount()
        {
            try
            {
                foreach (var product in products)
                {

                    using (var context = new AppDbContext())
                    {
                        var query = context.Products.Where(x => x.Id == product.Id).FirstOrDefault();
                        query.Count = query.Count - product.Count;
                        context.Products.Update(query);
                        context.SaveChanges();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Wystąpił błąd", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public float TotalPrice()
        {        
            try
            {
                float price = 0;
                foreach (var product in products)
                {
                    price += product.Price;
                }
                return price;
            }
            catch
            {
                MessageBox.Show("Wystąpił błąd z kwotą produktów", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public int TotalCount()
        {        
            try
            {
                int count = 0;
                foreach (var product in products)
                {
                    count += product.Count;
                }
                return count;
            }
            catch 
            {
                MessageBox.Show("Wystąpił błąd z ilością towaru", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0; 
            } 
        }
    }
}
