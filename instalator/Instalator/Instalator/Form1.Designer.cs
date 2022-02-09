namespace Instalator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.opera = new System.Windows.Forms.RadioButton();
            this.mozilla = new System.Windows.Forms.RadioButton();
            this.chrome = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nvidia = new System.Windows.Forms.RadioButton();
            this.amd = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.discord = new System.Windows.Forms.CheckBox();
            this.apps = new System.Windows.Forms.GroupBox();
            this.notepad = new System.Windows.Forms.CheckBox();
            this.teamviewer = new System.Windows.Forms.CheckBox();
            this.zip = new System.Windows.Forms.CheckBox();
            this.winrar = new System.Windows.Forms.CheckBox();
            this.spotify = new System.Windows.Forms.CheckBox();
            this.teams = new System.Windows.Forms.CheckBox();
            this.java = new System.Windows.Forms.CheckBox();
            this.netflix = new System.Windows.Forms.CheckBox();
            this.ccleaner = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.epic = new System.Windows.Forms.CheckBox();
            this.uconnect = new System.Windows.Forms.CheckBox();
            this.gog = new System.Windows.Forms.CheckBox();
            this.steam = new System.Windows.Forms.CheckBox();
            this.origin = new System.Windows.Forms.CheckBox();
            this.games = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.hwmonitor = new System.Windows.Forms.CheckBox();
            this.powermax = new System.Windows.Forms.CheckBox();
            this.cpuz = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.exitapp = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.apps.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose browser: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.opera);
            this.groupBox1.Controls.Add(this.mozilla);
            this.groupBox1.Controls.Add(this.chrome);
            this.groupBox1.Location = new System.Drawing.Point(30, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 99);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose browser: ";
            // 
            // opera
            // 
            this.opera.AutoSize = true;
            this.opera.Location = new System.Drawing.Point(6, 72);
            this.opera.Name = "opera";
            this.opera.Size = new System.Drawing.Size(75, 19);
            this.opera.TabIndex = 4;
            this.opera.Text = "Opera GX";
            this.opera.UseVisualStyleBackColor = true;
            // 
            // mozilla
            // 
            this.mozilla.AutoSize = true;
            this.mozilla.Location = new System.Drawing.Point(6, 47);
            this.mozilla.Name = "mozilla";
            this.mozilla.Size = new System.Drawing.Size(102, 19);
            this.mozilla.TabIndex = 3;
            this.mozilla.Text = "Mozilla Firefox";
            this.mozilla.UseVisualStyleBackColor = true;
            // 
            // chrome
            // 
            this.chrome.AutoSize = true;
            this.chrome.Checked = true;
            this.chrome.Location = new System.Drawing.Point(6, 22);
            this.chrome.Name = "chrome";
            this.chrome.Size = new System.Drawing.Size(109, 19);
            this.chrome.TabIndex = 2;
            this.chrome.TabStop = true;
            this.chrome.Text = "Google Chrome";
            this.chrome.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Install";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nvidia);
            this.groupBox2.Controls.Add(this.amd);
            this.groupBox2.Location = new System.Drawing.Point(30, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(142, 78);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose drivers:";
            // 
            // nvidia
            // 
            this.nvidia.AutoSize = true;
            this.nvidia.Location = new System.Drawing.Point(4, 47);
            this.nvidia.Name = "nvidia";
            this.nvidia.Size = new System.Drawing.Size(60, 19);
            this.nvidia.TabIndex = 6;
            this.nvidia.Text = "NVidia";
            this.nvidia.UseVisualStyleBackColor = true;
            // 
            // amd
            // 
            this.amd.AutoSize = true;
            this.amd.Checked = true;
            this.amd.Location = new System.Drawing.Point(4, 22);
            this.amd.Name = "amd";
            this.amd.Size = new System.Drawing.Size(52, 19);
            this.amd.TabIndex = 5;
            this.amd.TabStop = true;
            this.amd.Text = "AMD";
            this.amd.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "GPU Drivers:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Applications:";
            // 
            // discord
            // 
            this.discord.AutoSize = true;
            this.discord.Location = new System.Drawing.Point(6, 23);
            this.discord.Name = "discord";
            this.discord.Size = new System.Drawing.Size(66, 19);
            this.discord.TabIndex = 7;
            this.discord.Text = "Discord";
            this.discord.UseVisualStyleBackColor = true;
            // 
            // apps
            // 
            this.apps.Controls.Add(this.notepad);
            this.apps.Controls.Add(this.teamviewer);
            this.apps.Controls.Add(this.zip);
            this.apps.Controls.Add(this.winrar);
            this.apps.Controls.Add(this.spotify);
            this.apps.Controls.Add(this.teams);
            this.apps.Controls.Add(this.java);
            this.apps.Controls.Add(this.netflix);
            this.apps.Controls.Add(this.ccleaner);
            this.apps.Location = new System.Drawing.Point(281, 36);
            this.apps.Name = "apps";
            this.apps.Size = new System.Drawing.Size(142, 294);
            this.apps.TabIndex = 8;
            this.apps.TabStop = false;
            this.apps.Text = "Choose apps:";
            // 
            // notepad
            // 
            this.notepad.AutoSize = true;
            this.notepad.Location = new System.Drawing.Point(6, 222);
            this.notepad.Name = "notepad";
            this.notepad.Size = new System.Drawing.Size(88, 19);
            this.notepad.TabIndex = 15;
            this.notepad.Text = "Notepad++";
            this.notepad.UseVisualStyleBackColor = true;
            // 
            // teamviewer
            // 
            this.teamviewer.AutoSize = true;
            this.teamviewer.Location = new System.Drawing.Point(6, 197);
            this.teamviewer.Name = "teamviewer";
            this.teamviewer.Size = new System.Drawing.Size(89, 19);
            this.teamviewer.TabIndex = 11;
            this.teamviewer.Text = "TeamViewer";
            this.teamviewer.UseVisualStyleBackColor = true;
            // 
            // zip
            // 
            this.zip.AutoSize = true;
            this.zip.Location = new System.Drawing.Point(6, 172);
            this.zip.Name = "zip";
            this.zip.Size = new System.Drawing.Size(47, 19);
            this.zip.TabIndex = 14;
            this.zip.Text = "7zip";
            this.zip.UseVisualStyleBackColor = true;
            // 
            // winrar
            // 
            this.winrar.AutoSize = true;
            this.winrar.Location = new System.Drawing.Point(6, 147);
            this.winrar.Name = "winrar";
            this.winrar.Size = new System.Drawing.Size(69, 19);
            this.winrar.TabIndex = 13;
            this.winrar.Text = "WinRAR";
            this.winrar.UseVisualStyleBackColor = true;
            // 
            // spotify
            // 
            this.spotify.AutoSize = true;
            this.spotify.Location = new System.Drawing.Point(6, 122);
            this.spotify.Name = "spotify";
            this.spotify.Size = new System.Drawing.Size(63, 19);
            this.spotify.TabIndex = 12;
            this.spotify.Text = "Spotify";
            this.spotify.UseVisualStyleBackColor = true;
            // 
            // teams
            // 
            this.teams.AutoSize = true;
            this.teams.Location = new System.Drawing.Point(6, 72);
            this.teams.Name = "teams";
            this.teams.Size = new System.Drawing.Size(59, 19);
            this.teams.TabIndex = 11;
            this.teams.Text = "Teams";
            this.teams.UseVisualStyleBackColor = true;
            // 
            // java
            // 
            this.java.AutoSize = true;
            this.java.Location = new System.Drawing.Point(6, 47);
            this.java.Name = "java";
            this.java.Size = new System.Drawing.Size(48, 19);
            this.java.TabIndex = 10;
            this.java.Text = "Java";
            this.java.UseVisualStyleBackColor = true;
            // 
            // netflix
            // 
            this.netflix.AutoSize = true;
            this.netflix.Location = new System.Drawing.Point(6, 97);
            this.netflix.Name = "netflix";
            this.netflix.Size = new System.Drawing.Size(61, 19);
            this.netflix.TabIndex = 9;
            this.netflix.Text = "Netflix";
            this.netflix.UseVisualStyleBackColor = true;
            // 
            // ccleaner
            // 
            this.ccleaner.AutoSize = true;
            this.ccleaner.Location = new System.Drawing.Point(6, 22);
            this.ccleaner.Name = "ccleaner";
            this.ccleaner.Size = new System.Drawing.Size(74, 19);
            this.ccleaner.TabIndex = 8;
            this.ccleaner.Text = "CCleaner";
            this.ccleaner.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.epic);
            this.groupBox4.Controls.Add(this.uconnect);
            this.groupBox4.Controls.Add(this.gog);
            this.groupBox4.Controls.Add(this.steam);
            this.groupBox4.Controls.Add(this.origin);
            this.groupBox4.Controls.Add(this.discord);
            this.groupBox4.Location = new System.Drawing.Point(495, 36);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(130, 210);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Choose platform:";
            // 
            // epic
            // 
            this.epic.AutoSize = true;
            this.epic.Location = new System.Drawing.Point(6, 147);
            this.epic.Name = "epic";
            this.epic.Size = new System.Drawing.Size(87, 19);
            this.epic.TabIndex = 16;
            this.epic.Text = "Epic Games";
            this.epic.UseVisualStyleBackColor = true;
            // 
            // uconnect
            // 
            this.uconnect.AutoSize = true;
            this.uconnect.Location = new System.Drawing.Point(6, 122);
            this.uconnect.Name = "uconnect";
            this.uconnect.Size = new System.Drawing.Size(79, 19);
            this.uconnect.TabIndex = 15;
            this.uconnect.Text = "UConnect";
            this.uconnect.UseVisualStyleBackColor = true;
            // 
            // gog
            // 
            this.gog.AutoSize = true;
            this.gog.Location = new System.Drawing.Point(6, 97);
            this.gog.Name = "gog";
            this.gog.Size = new System.Drawing.Size(86, 19);
            this.gog.TabIndex = 14;
            this.gog.Text = "GOGGalaxy";
            this.gog.UseVisualStyleBackColor = true;
            // 
            // steam
            // 
            this.steam.AutoSize = true;
            this.steam.Location = new System.Drawing.Point(6, 47);
            this.steam.Name = "steam";
            this.steam.Size = new System.Drawing.Size(59, 19);
            this.steam.TabIndex = 13;
            this.steam.Text = "Steam";
            this.steam.UseVisualStyleBackColor = true;
            // 
            // origin
            // 
            this.origin.AutoSize = true;
            this.origin.Location = new System.Drawing.Point(6, 71);
            this.origin.Name = "origin";
            this.origin.Size = new System.Drawing.Size(59, 19);
            this.origin.TabIndex = 12;
            this.origin.Text = "Origin";
            this.origin.UseVisualStyleBackColor = true;
            // 
            // games
            // 
            this.games.AutoSize = true;
            this.games.Location = new System.Drawing.Point(495, 9);
            this.games.Name = "games";
            this.games.Size = new System.Drawing.Size(49, 15);
            this.games.TabIndex = 10;
            this.games.Text = "Games :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.hwmonitor);
            this.groupBox3.Controls.Add(this.powermax);
            this.groupBox3.Controls.Add(this.cpuz);
            this.groupBox3.Location = new System.Drawing.Point(678, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(134, 116);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Choose app:";
            // 
            // hwmonitor
            // 
            this.hwmonitor.AutoSize = true;
            this.hwmonitor.Location = new System.Drawing.Point(6, 48);
            this.hwmonitor.Name = "hwmonitor";
            this.hwmonitor.Size = new System.Drawing.Size(89, 19);
            this.hwmonitor.TabIndex = 2;
            this.hwmonitor.Text = "HWMonitor";
            this.hwmonitor.UseVisualStyleBackColor = true;
            // 
            // powermax
            // 
            this.powermax.AutoSize = true;
            this.powermax.Location = new System.Drawing.Point(6, 73);
            this.powermax.Name = "powermax";
            this.powermax.Size = new System.Drawing.Size(82, 19);
            this.powermax.TabIndex = 1;
            this.powermax.Text = "Powermax";
            this.powermax.UseVisualStyleBackColor = true;
            // 
            // cpuz
            // 
            this.cpuz.AutoSize = true;
            this.cpuz.Location = new System.Drawing.Point(6, 22);
            this.cpuz.Name = "cpuz";
            this.cpuz.Size = new System.Drawing.Size(67, 19);
            this.cpuz.TabIndex = 0;
            this.cpuz.Text = "CPU - Z";
            this.cpuz.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(678, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "System informations:";
            // 
            // exitapp
            // 
            this.exitapp.Location = new System.Drawing.Point(123, 349);
            this.exitapp.Name = "exitapp";
            this.exitapp.Size = new System.Drawing.Size(75, 23);
            this.exitapp.TabIndex = 13;
            this.exitapp.Text = "Exit";
            this.exitapp.UseVisualStyleBackColor = true;
            this.exitapp.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 385);
            this.Controls.Add(this.exitapp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.games);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.apps);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "A";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.apps.ResumeLayout(false);
            this.apps.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private RadioButton opera;
        private RadioButton mozilla;
        private RadioButton chrome;
        private Button button1;
        private GroupBox groupBox2;
        private RadioButton amd;
        private Label label2;
        private RadioButton nvidia;
        private Label label3;
        private CheckBox discord;
        private GroupBox apps;
        private CheckBox spotify;
        private CheckBox teams;
        private CheckBox java;
        private CheckBox netflix;
        private CheckBox ccleaner;
        private GroupBox groupBox4;
        private CheckBox epic;
        private CheckBox uconnect;
        private CheckBox gog;
        private CheckBox steam;
        private CheckBox origin;
        private Label games;
        private CheckBox winrar;
        private CheckBox zip;
        private CheckBox teamviewer;
        private CheckBox notepad;
        private GroupBox groupBox3;
        private Label label4;
        private CheckBox hwmonitor;
        private CheckBox powermax;
        private CheckBox cpuz;
        private Button exitapp;
    }
}