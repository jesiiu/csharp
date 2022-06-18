using FluentFTP;
using Projekt_POS.UI;
using System.Data;
using System.Diagnostics;
namespace Projekt_POS
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;

        }
        public string eantosend;
        public List<string> POSnumber = new List<string>();
        public List<Product> products = new List<Product>();
        public void buttonnum()
        {
            try
            {
                eanSearchText.Text = POSnumber.Aggregate((x, y) => x + y.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            POSnumber.Add(button1.Text);
            buttonnum();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            POSnumber.Add(button2.Text);
            buttonnum();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            POSnumber.Add(button3.Text);
            buttonnum();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            POSnumber.Add(button4.Text);
            buttonnum();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            POSnumber.Add(button5.Text);
            buttonnum();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            POSnumber.Add(button6.Text);
            buttonnum();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            POSnumber.Add(button7.Text);
            buttonnum();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            POSnumber.Add(button8.Text);
            buttonnum();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            POSnumber.Add(button9.Text);
            buttonnum();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            POSnumber.Add(button14.Text);
            buttonnum();
        }

        private void eanSearchText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (backgroundWorker1.IsBusy == false)
                {
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void addNew_Click(object sender, EventArgs e)
        {
            try
            {
                AddProductView fm2 = new AddProductView();
                fm2.Show();
            }
            catch
            {
                MessageBox.Show("Wyst¹pi³ b³¹d");
            }
        }

        private void searchProduct_Click(object sender, EventArgs e)
        {
            try
            {
                SearchProductView fm3 = new SearchProductView();
                fm3.Show();
            }
            catch
            {
                MessageBox.Show("Wyst¹pi³ b³¹d");
            }
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    dataGridView1.Invoke(new MethodInvoker(delegate
                    {
                        var query = context.Products.Where(x => x.EanCode.Contains(eanSearchText.Text)).ToList();
                        dataGridView1.DataSource = query;

                    }));

                }
            }
            catch
            {
                MessageBox.Show("Wyst¹pi³ b³¹d");
            }

        }

        private void deleteChar_Click(object sender, EventArgs e)
        {
            string text = eanSearchText.Text;
            try
            {
                eanSearchText.Text = text.Remove(text.Length - 1);
                POSnumber.Remove(POSnumber.Last());
            }
            catch
            {
                MessageBox.Show("Nie mo¿na usun¹æ");
            }
        }

        private void sell_Click(object sender, EventArgs e)
        {
            try
            {
                CartView fm4 = new CartView(products);
                fm4.products = products;
                fm4.Show();
   
            }
            catch
            {
                MessageBox.Show("Wyst¹pi³ b³¹d");
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            try
            {
                Product producttobuy = new Product()
                {
                    Id = int.Parse(row.Cells[0].Value.ToString()),
                    Name = row.Cells[1].Value.ToString(),
                    Size = row.Cells[2].Value.ToString(),
                    EanCode = row.Cells[3].Value.ToString(),
                    ProducerCode = row.Cells[4].Value.ToString(),
                    Price = float.Parse(row.Cells[5].Value.ToString()),
                    Count = 1,
                    Manufacturer = row.Cells[7].Value.ToString(),
                    PhotoUrl = row.Cells[8].Value.ToString()

                };
                products.Add(producttobuy);
                MessageBox.Show("Dodano produkt do koszyka");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchDoc_Click(object sender, EventArgs e)
        {
            try
            {
                DocView docview = new DocView();
                docview.Show();
            }
            catch
            {
                MessageBox.Show("Wyst¹pi³ b³¹d");
            }
        }

        private void clearRTB_Click(object sender, EventArgs e)
        {
            try
            {
                POSnumber.Clear();
                eanSearchText.Clear();
                dataGridView1.DataSource = null;
            }
            catch
            {
                MessageBox.Show("Wyst¹pi³ b³¹d");
            }
        }

        public void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Tools\Dbdelete\DbDelete.exe");
            Process.Start(new ProcessStartInfo(path));
            Environment.Exit(0);
        }

        public void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
         
        }

    }
}