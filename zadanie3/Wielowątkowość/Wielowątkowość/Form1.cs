using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace Wielowątkowość
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            //zdefiniowanie wartości dla progressbara
            progressBar1.Minimum = 0;
            progressBar1.Step = 1;
            //element walidacji wprowadzanych danych do textboxa
            textBox1.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);

        }


        private void Form1_Load(object sender, EventArgs e)
        {

            CheckForIllegalCrossThreadCalls = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }
        //Walidacja wprowadzanego znaku do textboxa, musi byc cyfrą bo inaczej wyskoczy messagebox
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Tylko cyfry w zakresie od 3 do 6");
            }
        }
        //Otwarcie nowego wątku oraz wywołanie funkcji procces(wykonującej permutacje) po kliknięciu buttona
        private void button1_Click(object sender, EventArgs e)
        {

            Thread thread = new Thread(new ThreadStart(process));
            thread.Start();


        }



        public void process()
        {

            string textboxvalue = textBox1.Text;
            int n = int.Parse(textboxvalue);

            switch (n)
            {
                //Permutacje dla 3 zer
                case 3:
                    {
                        for (int i = 0; i < 1000; i++)
                        {

                            int a = 0 + i;
                            //Aktualizacja ilości wykonanych permutacji w labelu
                            string text = $"{a.ToString()}/999";
                            label2.Text =$"Permutacje: {text}";
                            label2.Refresh();
                            //Funkcja wypisująca permutacje w oknie programu
                            richTextBox1.AppendText(String.Format("{0}{1}", $"{a:000}", Environment.NewLine));
                            // richTextBox1.ScrollToCaret();
                            //Aktualizacja progresu progressbara
                            progressBar1.Maximum = 999;
                            progressBar1.Value = i;
                            //uśpienie wątku na 100ms
                            Thread.Sleep(100);
                            //Wyłączenie przycisku "Generuj" w celu zablokowania możliwości włączenia więcej niż jednego wykonania funkcji na raz
                            if (progressBar1.Value < progressBar1.Maximum)
                            {
                                button1.Enabled = false;
                            }
                            else
                            {
                                button1.Enabled = true;
                            }
                        }


                        break;
                    }
                //Permutacje dla 4 zer
                case 4:
                    {
                        for (int i = 0; i < 10000; i++)
                        {
                            int a = 0 + i;
                            string text = $"{a.ToString()}/9999";
                            label2.Text = $"Permutacje: {text}";
                            label2.Refresh();
                            progressBar1.Maximum = 9999;
                            progressBar1.Value = i;
                            
                            richTextBox1.AppendText(String.Format("{0}{1}", $"{a:0000}", Environment.NewLine));
                            // richTextBox1.ScrollToCaret();
                            Thread.Sleep(100);
                            if (progressBar1.Value < progressBar1.Maximum)
                            {
                                button1.Enabled = false;
                            }
                            else
                            {
                                button1.Enabled = true;
                            }
                        }

                        break;
                    }
                //Permutacje dla 5 zer
                case 5:
                    {
                        for (int i = 0; i < 100000; i++)
                        {
                            int a = 0 + i;
                            string text = $"{a.ToString()}/99999";
                            label2.Text = $"Permutacje: {text}";
                            label2.Refresh();
                            progressBar1.Maximum = 99999;
                            progressBar1.Value = i;
                            richTextBox1.AppendText(String.Format("{0}{1}", $"{a:00000}", Environment.NewLine));
                            // richTextBox1.ScrollToCaret();
                            Thread.Sleep(100);
                            if (progressBar1.Value < progressBar1.Maximum)
                            {
                                button1.Enabled = false;
                            }
                            else
                            {
                                button1.Enabled = true;
                            }
                        }

                        break;
                    }
                //Permutacje dla 6 zer
                case 6:
                    {
                        for (int i = 0; i < 1000000; i++)
                        {
                            int a = 0 + i;
                            string text = $"{a.ToString()}/999999";
                            label2.Text = $"Permutacje: {text}";
                            label2.Refresh();
                            progressBar1.Maximum = 999999;
                            progressBar1.Value = i;
                            richTextBox1.AppendText(String.Format("{0}{1}", $"{a:000000}", Environment.NewLine));
                            // richTextBox1.ScrollToCaret();
                            
                            if (progressBar1.Value < progressBar1.Maximum)
                            {
                                button1.Enabled = false;
                            }
                            else
                            {
                                button1.Enabled = true;
                            }

                        }

                        break;
                    }
                default:
                    {
                        //Sprawdzenie czy wprowadzona liczba mieści się w założonym zakresie 3-6
                        MessageBox.Show("Zakres od 3 do 6");
                        break;
                    }

            }



        }

    }

}
