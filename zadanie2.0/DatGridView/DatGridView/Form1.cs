using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;


namespace DatGridView
{
    public partial class Form1 : Form
    {

        int index;
        public Form1()
        {
            InitializeComponent();
            this.dataGridView1.CellClick += new DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CheckForIllegalCrossThreadCalls = false;
            backgroundWorker1.RunWorkerAsync();

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (backgroundWorker1.CancellationPending == false)
            {
                sumA();
                sumB();
                sumC();
                sumD();
            }
        }

        //Dodawanie wartoœci do tabeli
        private void button_add_Values(object sender, EventArgs e)
        {
            if (textBox1.Text == String.Empty || textBox2.Text == String.Empty || textBox3.Text == String.Empty || textBox4.Text == String.Empty)
            {
                MessageBox.Show("Puste pola! WprowadŸ dane");
            }
            else
            {
                int min = 0;
                int max = 1000;
                int value1 = int.Parse(textBox1.Text);
                int value2 = int.Parse(textBox2.Text);
                int value3 = int.Parse(textBox3.Text);
                int value4 = int.Parse(textBox4.Text);
                //Sprawdzenie czy wprowadzana wartoœæ mieœci siê w zakresie 
                if (value1 < min || value2 < min || value3 < min || value4 < min || value1 > max || value2 > max || value3 > max || value4 > max)
                {
                    MessageBox.Show("Twoja liczba jest poza zakresem 0 a 1000");
                }
                else
                {
                    dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();

                }
            }

        }


        //Suma kolumny A
        public void sumA()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);

            }

            textBox8.Text = sum.ToString();
            textBox8.Enabled = false;

        }

        //Suma kolumny B
        public void sumB()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);

            }

            textBox7.Text = sum.ToString();
            textBox7.Enabled = false;

        }

        //Suma kolumny C
        public void sumC()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);

            }

            textBox6.Text = sum.ToString();
            textBox6.Enabled = false;

        }

        //Suma kolumny D
        public void sumD()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);

            }

            textBox5.Text = sum.ToString();
            textBox5.Enabled = false;

        }


        //Usuwanie wybranych wierszy
        private void button_deleteRow(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }


        //Pobieranie wartoœci z tabeli do edycji
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            textBox4.Text = row.Cells[3].Value.ToString();
        }


        //Edytowanie wybranych wartoœci
        private void button_editValues(object sender, EventArgs e)
        {

            //Sprawdzenie czy zosta³y pobrane wartoœci do edytowania
            if (textBox1.Text == String.Empty || textBox2.Text == String.Empty || textBox3.Text == String.Empty || textBox4.Text == String.Empty)
            {
                MessageBox.Show("Puste pola! Pobierz dane do edycji");
            }
            else
            {


                DataGridViewRow newdata = dataGridView1.Rows[index];

                int min = 0;
                int max = 1000;
                int value1 = int.Parse(textBox1.Text);
                int value2 = int.Parse(textBox2.Text);
                int value3 = int.Parse(textBox3.Text);
                int value4 = int.Parse(textBox4.Text);

                //Sprawdzenie czy wprowadzone wartoœci do edycji mieszcz¹ siê w zakresie
                if (value1 < 0 || value1 > 1000)
                {
                    MessageBox.Show("Twoja liczba jest poza zakresem 0 a 1000");
                }
                else
                {
                    newdata.Cells[0].Value = textBox1.Text;
                }
                if (value2 < min || value2 > max)
                {
                    MessageBox.Show("Twoja liczba jest poza zakresem 0 a 1000");
                }
                else
                {
                    newdata.Cells[1].Value = textBox2.Text;
                }
                if (value3 < min || value3 > max)
                {
                    MessageBox.Show("Twoja liczba jest poza zakresem 0 a 1000");
                }
                else
                {
                    newdata.Cells[2].Value = textBox3.Text;
                }
                if (value4 < min || value4 > max)
                {
                    MessageBox.Show("Twoja liczba jest poza zakresem 0 a 1000");
                }
                else
                {
                    newdata.Cells[3].Value = textBox4.Text;
                }

            }
        }


    }
}