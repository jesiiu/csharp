using System.Net;
using System.Runtime;
using System;
using System.Diagnostics;
using System.ComponentModel;



namespace Instalator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Programy do sprawdzania komputera
        public void system_infos()
        {
            /*
            //Linki do pobrania programów
            cpuzurl = "https://download.cpuid.com/cpu-z/cpu-z_1.99-en.exe";
            hwmonitorurl = "https://download.cpuid.com/hwmonitor/hwmonitor_1.45.exe";
            powermaxurl = "https://download.cpuid.com/powermax/powermax_1.00_setup.exe";
            */

            //Pêtla foreach przeszukuj¹ca groupBox. Ma za zadanie znalezienie zaznaczonych checkboxów
            foreach (Control c in systeminfo.Controls)
            {
                //Funkcja if wywo³uj¹ca otwarcie procesu dla zaznaczonych checkboxów 
                if (((CheckBox)c).Checked == true)
                {
                    //Zdefiniowanie nowego procesu
                    Process myProcess = new Process();

                    try
                    {
                        //Próba otwarcia nowego procesu z linkiem URL do strony 
                        myProcess.StartInfo.UseShellExecute = true;
                        myProcess.StartInfo.FileName = c.Tag.ToString();
                        myProcess.Start();
                    }
                    catch
                    {
                        //Je¿eli siê nie powiedzie wyskakuje okno z b³êdem
                        MessageBox.Show("Wyst¹pi³ b³¹d");
                    }

                }

            }
        }

        //Programy powi¹zane z grami
        public void games_checked()
        {
            /*
            discordurl = "https://discord.com/api/download?platform=win";
            steamurl = "https://cdn.cloudflare.steamstatic.com/client/installer/SteamSetup.exe";
            originurl = "https://www.origin.com/pol/pl-pl/store/download";
            gogurl = "https://webinstallers.gog-statics.com/download/GOG_Galaxy_2.0.exe";
            uconnecturl = "https://ubi.li/4vxt9";
            epicurl = "https://launcher-public-service-prod06.ol.epicgames.com/launcher/api/installer/download/EpicGamesLauncherInstaller.msi";
            */

            foreach (Control c in gamesapps.Controls)
            {

                if (((CheckBox)c).Checked == true)
                {
                    Process myProcess = new Process();

                    try
                    {
                        myProcess.StartInfo.UseShellExecute = true;
                        myProcess.StartInfo.FileName = c.Tag.ToString();
                        myProcess.Start();
                    }
                    catch
                    {
                        MessageBox.Show("Wyst¹pi³ b³¹d");
                    }

                }

            }
        }

        //Podstawowe aplikacje 
        public void applications()
        {
            /*
            ccleanerurl = "https://www.ccleaner.com/ccleaner/download/standard";
            javaurl = "https://www.java.com/pl/download/";
            teamsurl = "https://www.microsoft.com/pl-pl/microsoft-teams/download-app#desktopAppDownloadregion";
            netflixurl = "https://www.microsoft.com/en-us/p/netflix/9wzdncrfj3tj?cid=msft_web_appsforwindowsphone_collection#activetab=pivot:overviewtab";
            spotifyurl = "https://www.spotify.com/pl/download/windows/";
            winrarurl = "https://www.rarlab.com/rar/winrar-x64-601pl.exe";
            zipurl = "https://www.7-zip.org/a/7z2107-x64.exe";
            teamviewerurl = "https://download.teamviewer.com/download/TeamViewer_Setup_x64.exe";
            notepadppurl = "https://github.com/notepad-plus-plus/notepad-plus-plus/releases/download/v8.2.1/npp.8.2.1.Installer.x64.exe";
            */

            foreach (Control c in apps.Controls)
            {

                if (((CheckBox)c).Checked == true)
                {
                    Process myProcess = new Process();

                    try
                    {
                        myProcess.StartInfo.UseShellExecute = true;
                        myProcess.StartInfo.FileName = c.Tag.ToString();
                        myProcess.Start();
                    }
                    catch
                    {
                        MessageBox.Show("Wyst¹pi³ b³¹d");
                    }

                }
               
            }


        } 

            //Sterowniki karty graficznej
            public void gpu_drivers()
            {
            /*
                amd = "https://www.amd.com/en/support";
                nvidia = "https://pl.download.nvidia.com/GFE/GFEClient/3.25.0.84/GeForce_Experience_v3.25.0.84.exe";
            */

            foreach (Control c in gpudrivers.Controls)
            {

                if (((RadioButton)c).Checked == true)
                {
                    Process myProcess = new Process();

                    try
                    {
                        myProcess.StartInfo.UseShellExecute = true;
                        myProcess.StartInfo.FileName = c.Tag.ToString();
                        myProcess.Start();
                    }
                    catch
                    {
                        MessageBox.Show("Wyst¹pi³ b³¹d");
                    }

                }

            }
        }

        //Podstawowe przegl¹darki internetowe
        public void browsersapps()
        {
            /*
                string chrome = "https://www.google.com/chrome/?brand=BNSD&gclid=Cj0KCQiAxoiQBhCRARIsAPsvo-z7gOWHGVcdH_lIfyf59qQuck19r5b4mDJ5xhlDesgmWPNhvfSyMtAaAmhUEALw_wcB&gclsrc=aw.ds";
                string mozilla = "https://download.mozilla.org/?product=firefox-msi-latest-ssl&amp;os=win64&amp;lang=pl";
                string opera = "https://www.opera.com/pl/computer/thanks?ni=eapgx&os=windows";
            */

            foreach (Control c in browsers.Controls)
            {

                if (((RadioButton)c).Checked == true)
                {
                    Process myProcess = new Process();

                    try
                    {
                        myProcess.StartInfo.UseShellExecute = true;
                        myProcess.StartInfo.FileName = c.Tag.ToString();
                        myProcess.Start();
                    }
                    catch
                    {
                        MessageBox.Show("Wyst¹pi³ b³¹d");
                    }

                }

            }

    }   

            private void button1_Click(object sender, EventArgs e)
            {

                //Wywo³anie wszyskich funkcji po wciœniêciu przycisku "Install"
                browsersapps();
                gpu_drivers();
                applications();
                games_checked();
                system_infos();
            }

            private void button2_Click(object sender, EventArgs e)
            {
                //Przycisk "Exit" odpowiada za zakoñczenie programu
                if (MessageBox.Show("Are you sure to exit ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
    }
}
