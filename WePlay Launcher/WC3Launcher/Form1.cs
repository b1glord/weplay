using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Net;


namespace WC3Launcher
{

    public partial class frmMain : Form
    {
        //[DllImport("w3lh.dll", EntryPoint = "GameMain")] // 0x000014C0
       // public static extern int GameMain(int hModule);

        //[DllImport("kernel32.dll", EntryPoint = "LoadLibrary")]
        //public static extern int LoadLibrary( [MarshalAs(UnmanagedType.LPStr)] string lpLibFileName);

        private string gameExePath; // path to the game
        private bool clearCash; // clear cache on start(bncash.dat)
        private bool launchGameOnStart; // run game when laucher starts?
        private bool useOpenGL; // use OpenGL?
        private bool useWindowMode; // run game in window mode?
        
        private string bannerURL = "http://f1games.125mb.com/pvpgn/banner.php"; // remote file format: "image,url"
        private bool loadBanner = true; // you can change it to enable or disable advertise text
        private string newsURL = "http://f1games.125mb.com/pvpgn/";


        public frmMain()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            wbNews.Url = new Uri(newsURL);
            this.Icon = Properties.Resources.Warcraft_3_Reign_of_Chaos;
            notifyIcon.Text = this.Text;
            notifyIcon.Icon=this.Icon;

            // загрузка настроек
            gameExePath = Properties.Settings.Default.gameExePath;
            clearCash = Properties.Settings.Default.clearCash;
            launchGameOnStart = Properties.Settings.Default.launchGameOnStart;
            useOpenGL = Properties.Settings.Default.useOpenGL;
            useWindowMode = Properties.Settings.Default.useWindowMode;

            txtGameExePath.Text = gameExePath;
            chkClearCash.Checked = clearCash;
            chkLaunchGameOnStart.Checked = launchGameOnStart;
            chkUseOpenGL.Checked = useOpenGL;
            chkUseWindowMode.Checked = useWindowMode;

            // обнулить надпись на баннере
            linkAdv.Text = "";

            // запуск игры при старте лаунчера
            if (launchGameOnStart)
                btnGo_Click(null, null);

            if (loadBanner)
            {
                groupBox1.Height = 263;
                groupBox1.Top = 39;
                wbNews.Height = 238;
                LoadBanner();
            }
            else
            {
                groupBox1.Height = 290;
                groupBox1.Top = 12;
                wbNews.Height = 265;
            }

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            // проверка пути
            if (gameExePath.Length == 0 || !File.Exists(gameExePath))
                btnBrowse_Click(null, null);


            //int hModule = LoadLibrary(@"C:\ProgramData\Blizzard Entertainment\Warcraft III\game.dll");
            //GameMain(hModule);

            try
            {
                string filename = txtGameExePath.Text; // full path to the game exe
                string directory = Directory.GetParent(filename).FullName; // path to the directory of the file to be runned
               
                if (chkClearCash.Checked)
                    File.Delete(directory + @"\bncache.dat");

                Process game = new Process();
                game.StartInfo.FileName = filename;
                game.StartInfo.WorkingDirectory = directory;

                // arguments for the game start
                if (useWindowMode)
                    game.StartInfo.Arguments += "-window ";
                if (useOpenGL)
                    game.StartInfo.Arguments += "-opengl ";

                this.WindowState = FormWindowState.Minimized;
                game.Start();

                
                

            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "w3l.exe | *.exe";
            DialogResult ds = openFileDialog.ShowDialog();
            if (ds!=DialogResult.Cancel)
                txtGameExePath.Text = openFileDialog.FileName;
        }

        private void chkClearCash_CheckedChanged(object sender, EventArgs e)
        {
            
            clearCash = chkClearCash.Checked;
        }

        private void chkLaunchGameOnStart_CheckedChanged(object sender, EventArgs e)
        {
            launchGameOnStart = chkLaunchGameOnStart.Checked;
        }

        private void txtGameExePath_TextChanged(object sender, EventArgs e)
        {
            gameExePath = txtGameExePath.Text;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.gameExePath = gameExePath;
            Properties.Settings.Default.clearCash = clearCash;
            Properties.Settings.Default.launchGameOnStart = launchGameOnStart;
            Properties.Settings.Default.useOpenGL = useOpenGL;
            Properties.Settings.Default.useWindowMode = useWindowMode;

            Properties.Settings.Default.Save();
        }

        private void chkUseWindowMode_CheckedChanged(object sender, EventArgs e)
        {
            useWindowMode = chkUseWindowMode.Checked;
        }

        private void chkUseOpenGL_CheckedChanged(object sender, EventArgs e)
        {
            useOpenGL = chkUseOpenGL.Checked;
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {

            if (this.WindowState == FormWindowState.Minimized) 
            {
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
            }
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
        }

        private void txtGameExePath_Click(object sender, EventArgs e)
        {
            btnBrowse_Click(null,null);
        }



        private void LoadBanner()
        {
            // async loading
            readRemoteFile(bannerURL);
        }

        private void readRemoteFile(string address)
        {
            try
            {
                WebClient wc = new WebClient();
                wc.Encoding = Encoding.UTF8;
                wc.DownloadStringCompleted += new DownloadStringCompletedEventHandler(wc_DownloadStringCompleted);
                wc.DownloadStringAsync(new Uri(address));

            }
            catch {}
        }

        private string advUrl;
        private void wc_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            try
            {
                string[] data = e.Result.Split("||".ToCharArray());

                linkAdv.Text = data[0];
                advUrl = data[2];
            }
            catch { }
        }

        private void linkAdv_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(advUrl);
        }

        private void wbNews_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
