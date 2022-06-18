using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_POS.UI
{
    public partial class SignInView : Form
    {
        public SignInView()
        {
            InitializeComponent();
            PasswordTextBox.PasswordChar = '*';
            ConfirmPasswordTextBox.PasswordChar = '*';
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            try
            {
                var logInView = new LogInView();
                this.Hide();
                logInView.Show();
            }
            catch
            {
                MessageBox.Show("Wystąpił błąd");
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(LoginTextBox.Text) || string.IsNullOrWhiteSpace(PasswordTextBox.Text)
                    || string.IsNullOrWhiteSpace(ConfirmPasswordTextBox.Text))
                {
                    MessageBox.Show("Wypełnij wszystkie wymagane pola!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (PasswordTextBox.Text != ConfirmPasswordTextBox.Text)
                    {
                        MessageBox.Show("Wpisane hasła nie są takie same!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        using (var context = new AppDbContext())
                        {
                            var users = context.Users.Where(x => x.Name == LoginTextBox.Text).ToList();
                            if (users.Any())
                                MessageBox.Show("Użytkownik o takim loginie już istnieje! Wybierz inny login.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                            {
                                var user = new User
                                {
                                    Name = LoginTextBox.Text,
                                    Password = new Encrypt().EncryptPassword(PasswordTextBox.Text)
                                };
                                context.Users.Add(user);
                                context.SaveChanges();
                                MessageBox.Show($"Użytkownik {LoginTextBox.Text} został poprawnie dodany!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                var logInView = new LogInView();
                                this.Hide();
                                logInView.Show();
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Wystąpił błąd");
            }
        }

        private void SignInView_FormClosed(object sender, FormClosedEventArgs e)
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Tools\Dbdelete\DbDelete.exe");
            Process.Start(new ProcessStartInfo(path));
            Environment.Exit(0);
        }
    }
}
