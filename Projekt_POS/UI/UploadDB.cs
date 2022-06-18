using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentFTP;

namespace Projekt_POS.UI
{
    public partial class UploadDB : Form
    {
        public UploadDB()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ftp ftp = new Ftp();
            MemoryStream ms = new MemoryStream();
            using (FileStream fs = new FileStream(@"..\..\..\Database\pos.db", FileMode.Open, FileAccess.Read))
            {
                byte[] data = new byte[fs.Length];
                fs.Read(data, 0, data.Length);
                ms.Write(data, 0, data.Length);
                var status = ftp.UploadData(data);
                if (status == FtpStatus.Success)
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
