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
    public partial class LogInView : Form
    {
        public LogInView()
        {
            InitializeComponent();
            passwordTextBox.PasswordChar = '*';
            Ftp ftp = new Ftp();
            ftp.DownloadDb();
            
        }
        
        private void LogInButtonClick(object sender, EventArgs e)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var query = context.Users
                        .Where(x => x.Name == loginTextBox.Text && x.Password == new Encrypt().EncryptPassword(passwordTextBox.Text))
                        .ToList();
                    if (query.Any())
                    {
                        MainWindow fm1 = new MainWindow();
                        this.Hide();
                        fm1.Show();
                        context.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Błędny login lub hasło.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Wystąpił błąd");
            }
        }

        private void RegisterButtonClick(object sender, EventArgs e)
        {
            try
            {
                SignInView signIn = new SignInView();
                signIn.Show();
                this.Hide();            
            }
            catch
            {
                MessageBox.Show("Wystąpił błąd");
            }
        }

        private void LogInView_FormClosed(object sender, FormClosedEventArgs e)
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Tools\Dbdelete\DbDelete.exe");
            Process.Start(new ProcessStartInfo(path));
            Environment.Exit(0);
        }
    }
}
