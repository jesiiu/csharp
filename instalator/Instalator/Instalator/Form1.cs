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

        public void system_infos()
        {
            string cpuzurl = "https://download.cpuid.com/cpu-z/cpu-z_1.99-en.exe";
            string hwmonitorurl = "https://download.cpuid.com/hwmonitor/hwmonitor_1.45.exe";
            string powermaxurl = "https://download.cpuid.com/powermax/powermax_1.00_setup.exe";

            if(cpuz.Checked == true)
            {
                Process myProcess = new Process();

                try
                {
                    myProcess.StartInfo.UseShellExecute = true;
                    myProcess.StartInfo.FileName = cpuzurl;
                    myProcess.Start();
                }
                catch
                {
                    MessageBox.Show("Wyst¹pi³ b³¹d");
                }
            }
            if(hwmonitor.Checked == true)
            {
                Process myProcess = new Process();

                try
                {
                    myProcess.StartInfo.UseShellExecute = true;
                    myProcess.StartInfo.FileName = hwmonitorurl;
                    myProcess.Start();
                }
                catch
                {
                    MessageBox.Show("Wyst¹pi³ b³¹d");
                }
            }
            if(powermax.Checked == true)
            {
                Process myProcess = new Process();

                try
                {
                    myProcess.StartInfo.UseShellExecute = true;
                    myProcess.StartInfo.FileName = powermaxurl;
                    myProcess.Start();
                }
                catch
                {
                    MessageBox.Show("Wyst¹pi³ b³¹d");
                }
            }
        }

        public void games_checked()
        {
            string discordurl = "https://discord.com/api/download?platform=win";
            string steamurl = "https://cdn.cloudflare.steamstatic.com/client/installer/SteamSetup.exe";
            string originurl = "https://www.origin.com/pol/pl-pl/store/download";
            string gogurl = "https://webinstallers.gog-statics.com/download/GOG_Galaxy_2.0.exe";
            string uconnecturl = "https://ubi.li/4vxt9";
            string epicurl = "https://launcher-public-service-prod06.ol.epicgames.com/launcher/api/installer/download/EpicGamesLauncherInstaller.msi";

            if (discord.Checked == true)
            {
                Process myProcess = new Process();

                try
                {
                    myProcess.StartInfo.UseShellExecute = true;
                    myProcess.StartInfo.FileName = discordurl;
                    myProcess.Start();
                }
                catch
                {
                    MessageBox.Show("Wyst¹pi³ b³¹d");
                }
            }
            if(steam.Checked == true)
            {
                Process myProcess = new Process();

                try
                {
                    myProcess.StartInfo.UseShellExecute = true;
                    myProcess.StartInfo.FileName = steamurl;
                    myProcess.Start();
                }
                catch
                {
                    MessageBox.Show("Wyst¹pi³ b³¹d");
                }
            }
            if(origin.Checked == true)
            {
                Process myProcess = new Process();

                try
                {
                    myProcess.StartInfo.UseShellExecute = true;
                    myProcess.StartInfo.FileName = originurl;
                    myProcess.Start();
                }
                catch
                {
                    MessageBox.Show("Wyst¹pi³ b³¹d");
                }
            }
            if(gog.Checked == true)
            {
                Process myProcess = new Process();

                try
                {
                    myProcess.StartInfo.UseShellExecute = true;
                    myProcess.StartInfo.FileName = gogurl;
                    myProcess.Start();
                }
                catch
                {
                    MessageBox.Show("Wyst¹pi³ b³¹d");
                }
            }
            if(uconnect.Checked == true)
            {
                Process myProcess = new Process();

                try
                {
                    myProcess.StartInfo.UseShellExecute = true;
                    myProcess.StartInfo.FileName = uconnecturl;
                    myProcess.Start();
                }
                catch
                {
                    MessageBox.Show("Wyst¹pi³ b³¹d");
                }
            }
            if(epic.Checked == true)
            {
                Process myProcess = new Process();

                try
                {
                    myProcess.StartInfo.UseShellExecute = true;
                    myProcess.StartInfo.FileName = epicurl;
                    myProcess.Start();
                }
                catch
                {
                    MessageBox.Show("Wyst¹pi³ b³¹d");
                }
            }
        }

        public void applications()
        {
            
            string ccleanerurl = "https://www.ccleaner.com/ccleaner/download/standard";
            string javaurl = "https://www.java.com/pl/download/";
            string teamsurl = "https://www.microsoft.com/pl-pl/microsoft-teams/download-app#desktopAppDownloadregion";
            string netflixurl = "https://www.microsoft.com/en-us/p/netflix/9wzdncrfj3tj?cid=msft_web_appsforwindowsphone_collection#activetab=pivot:overviewtab";
            string spotifyurl = "https://www.spotify.com/pl/download/windows/";
            string winrarurl = "https://www.rarlab.com/rar/winrar-x64-601pl.exe";
            string zipurl = "https://www.7-zip.org/a/7z2107-x64.exe";
            string teamviewerurl = "https://download.teamviewer.com/download/TeamViewer_Setup_x64.exe";
            string notepadppurl = "https://github.com/notepad-plus-plus/notepad-plus-plus/releases/download/v8.2.1/npp.8.2.1.Installer.x64.exe";

            if (ccleaner.Checked == true)
                {
                Process myProcess = new Process();

                try
                {
                    myProcess.StartInfo.UseShellExecute = true;
                    myProcess.StartInfo.FileName = ccleanerurl;
                    myProcess.Start();
                }
                catch
                {
                    MessageBox.Show("Wyst¹pi³ b³¹d");
                }


            }
            if (java.Checked == true)
            {
                Process myProcess = new Process();

                try
                {
                    myProcess.StartInfo.UseShellExecute = true;
                    myProcess.StartInfo.FileName = javaurl;
                    myProcess.Start();
                }
                catch
                {
                    MessageBox.Show("Wyst¹pi³ b³¹d");
                }
            }
            if(teams.Checked == true)
            {
                Process myProcess = new Process();

                try
                {
                    myProcess.StartInfo.UseShellExecute = true;
                    myProcess.StartInfo.FileName = teamsurl;
                    myProcess.Start();
                }
                catch
                {
                    MessageBox.Show("Wyst¹pi³ b³¹d");
                }
            }
            if(spotify.Checked == true)
            {
                Process myProcess = new Process();

                try
                {
                    myProcess.StartInfo.UseShellExecute = true;
                    myProcess.StartInfo.FileName = spotifyurl;
                    myProcess.Start();
                }
                catch
                {
                    MessageBox.Show("Wyst¹pi³ b³¹d");
                }
            }
            if(netflix.Checked == true)
            {
                Process myProcess = new Process();

                try
                {
                    myProcess.StartInfo.UseShellExecute = true;
                    myProcess.StartInfo.FileName = netflixurl;
                    myProcess.Start();
                }
                catch
                {
                    MessageBox.Show("Wyst¹pi³ b³¹d");
                }
            }
            if(winrar.Checked == true)
            {
                Process myProcess = new Process();

                try
                {
                    myProcess.StartInfo.UseShellExecute = true;
                    myProcess.StartInfo.FileName = winrarurl;
                    myProcess.Start();
                }
                catch
                {
                    MessageBox.Show("Wyst¹pi³ b³¹d");
                }
            }
            if(zip.Checked == true)
            {
                Process myProcess = new Process();

                try
                {
                    myProcess.StartInfo.UseShellExecute = true;
                    myProcess.StartInfo.FileName = zipurl;
                    myProcess.Start();
                }
                catch
                {
                    MessageBox.Show("Wyst¹pi³ b³¹d");
                }
            }
            if(teamviewer.Checked == true)
            {
                Process myProcess = new Process();

                try
                {
                    myProcess.StartInfo.UseShellExecute = true;
                    myProcess.StartInfo.FileName = teamviewerurl;
                    myProcess.Start();
                }
                catch
                {
                    MessageBox.Show("Wyst¹pi³ b³¹d");
                }
            }
            if(notepad.Checked == true)
            {
                Process myProcess = new Process();

                try
                {
                    myProcess.StartInfo.UseShellExecute = true;
                    myProcess.StartInfo.FileName = notepadppurl;
                    myProcess.Start();
                }
                catch
                {
                    MessageBox.Show("Wyst¹pi³ b³¹d");
                }
            }


        }
        public void gpu_drivers()
        {
            string amd = "https://www.amd.com/en/support";
            string nvidia = "https://pl.download.nvidia.com/GFE/GFEClient/3.25.0.84/GeForce_Experience_v3.25.0.84.exe";
            if (this.amd.Checked)
            {
                Process myProcess = new Process();

                try
                {
                    myProcess.StartInfo.UseShellExecute = true;
                    myProcess.StartInfo.FileName = amd;
                    myProcess.Start();
                }
                catch
                {
                    MessageBox.Show("Wyst¹pi³ b³¹d");
                }
            }
            else
            {
                Process myProcess = new Process();

                try
                {
                    myProcess.StartInfo.UseShellExecute = true;
                    myProcess.StartInfo.FileName = nvidia;
                    myProcess.Start();
                }
                catch
                {
                    MessageBox.Show("Wyst¹pi³ b³¹d");
                }
            }
        }

        public void browsers()
        {
           
            string google = "https://www.google.com/chrome/?brand=BNSD&gclid=Cj0KCQiAxoiQBhCRARIsAPsvo-z7gOWHGVcdH_lIfyf59qQuck19r5b4mDJ5xhlDesgmWPNhvfSyMtAaAmhUEALw_wcB&gclsrc=aw.ds";
            string mozilla = "https://download.mozilla.org/?product=firefox-msi-latest-ssl&amp;os=win64&amp;lang=pl";
            string opera = "https://www.opera.com/pl/computer/thanks?ni=eapgx&os=windows";
            if (chrome.Checked)
            {
                Process myProcess = new Process();

                try
                {
                    myProcess.StartInfo.UseShellExecute = true;
                    myProcess.StartInfo.FileName = google;
                    myProcess.Start();
                }
                catch
                {
                    MessageBox.Show("Wyst¹pi³ b³¹d");
                }

            }

            else if (this.mozilla.Checked)
            {
                Process myProcess = new Process();

                try
                {
                    myProcess.StartInfo.UseShellExecute = true;
                    myProcess.StartInfo.FileName = mozilla;
                    myProcess.Start();
                }
                catch
                {
                    MessageBox.Show("Wyst¹pi³ b³¹d");
                }
            }
            else
            {
                Process myProcess = new Process();

                try
                {
                    myProcess.StartInfo.UseShellExecute = true;
                    myProcess.StartInfo.FileName = opera;
                    myProcess.Start();
                }
                catch
                {
                    MessageBox.Show("Wyst¹pi³ b³¹d");
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          browsers();
          gpu_drivers();
          applications();
          games_checked();
          system_infos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}