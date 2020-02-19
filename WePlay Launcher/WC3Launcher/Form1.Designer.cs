namespace WC3Launcher
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnGo = new System.Windows.Forms.Button();
            this.chkClearCash = new System.Windows.Forms.CheckBox();
            this.txtGameExePath = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.wbNews = new System.Windows.Forms.WebBrowser();
            this.chkLaunchGameOnStart = new System.Windows.Forms.CheckBox();
            this.chkUseOpenGL = new System.Windows.Forms.CheckBox();
            this.chkUseWindowMode = new System.Windows.Forms.CheckBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.linkAdv = new System.Windows.Forms.LinkLabel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGo.Location = new System.Drawing.Point(566, 265);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(206, 74);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Giriş";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // chkClearCash
            // 
            this.chkClearCash.AutoSize = true;
            this.chkClearCash.Checked = true;
            this.chkClearCash.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkClearCash.Location = new System.Drawing.Point(566, 198);
            this.chkClearCash.Name = "chkClearCash";
            this.chkClearCash.Size = new System.Drawing.Size(167, 17);
            this.chkClearCash.TabIndex = 4;
            this.chkClearCash.Text = "Cache Temizle(bncache.dat)";
            this.chkClearCash.UseVisualStyleBackColor = true;
            this.chkClearCash.CheckedChanged += new System.EventHandler(this.chkClearCash_CheckedChanged);
            // 
            // txtGameExePath
            // 
            this.txtGameExePath.Location = new System.Drawing.Point(566, 233);
            this.txtGameExePath.Name = "txtGameExePath";
            this.txtGameExePath.ReadOnly = true;
            this.txtGameExePath.Size = new System.Drawing.Size(171, 22);
            this.txtGameExePath.TabIndex = 5;
            this.txtGameExePath.Text = "Warcraft III Klasorü";
            this.txtGameExePath.Click += new System.EventHandler(this.txtGameExePath_Click);
            this.txtGameExePath.TextChanged += new System.EventHandler(this.txtGameExePath_TextChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "w3l.exe";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(743, 232);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(29, 23);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.wbNews);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.MinimumSize = new System.Drawing.Size(548, 330);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 330);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Haberler";
            // 
            // wbNews
            // 
            this.wbNews.Location = new System.Drawing.Point(6, 19);
            this.wbNews.MinimumSize = new System.Drawing.Size(536, 300);
            this.wbNews.Name = "wbNews";
            this.wbNews.Size = new System.Drawing.Size(536, 300);
            this.wbNews.TabIndex = 3;
            this.wbNews.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbNews_DocumentCompleted);
            // 
            // chkLaunchGameOnStart
            // 
            this.chkLaunchGameOnStart.AutoSize = true;
            this.chkLaunchGameOnStart.Location = new System.Drawing.Point(566, 129);
            this.chkLaunchGameOnStart.Name = "chkLaunchGameOnStart";
            this.chkLaunchGameOnStart.Size = new System.Drawing.Size(122, 17);
            this.chkLaunchGameOnStart.TabIndex = 9;
            this.chkLaunchGameOnStart.Text = "Başlangıçta Çalıştır";
            this.chkLaunchGameOnStart.UseVisualStyleBackColor = true;
            this.chkLaunchGameOnStart.CheckedChanged += new System.EventHandler(this.chkLaunchGameOnStart_CheckedChanged);
            // 
            // chkUseOpenGL
            // 
            this.chkUseOpenGL.AutoSize = true;
            this.chkUseOpenGL.Checked = true;
            this.chkUseOpenGL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseOpenGL.Location = new System.Drawing.Point(566, 175);
            this.chkUseOpenGL.Name = "chkUseOpenGL";
            this.chkUseOpenGL.Size = new System.Drawing.Size(100, 17);
            this.chkUseOpenGL.TabIndex = 10;
            this.chkUseOpenGL.Text = "OpenGL Kullan";
            this.chkUseOpenGL.UseVisualStyleBackColor = true;
            this.chkUseOpenGL.CheckedChanged += new System.EventHandler(this.chkUseOpenGL_CheckedChanged);
            // 
            // chkUseWindowMode
            // 
            this.chkUseWindowMode.AutoSize = true;
            this.chkUseWindowMode.Location = new System.Drawing.Point(566, 152);
            this.chkUseWindowMode.Name = "chkUseWindowMode";
            this.chkUseWindowMode.Size = new System.Drawing.Size(101, 17);
            this.chkUseWindowMode.TabIndex = 11;
            this.chkUseWindowMode.Text = "Window Mode";
            this.chkUseWindowMode.UseVisualStyleBackColor = true;
            this.chkUseWindowMode.CheckedChanged += new System.EventHandler(this.chkUseWindowMode_CheckedChanged);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // linkAdv
            // 
            this.linkAdv.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkAdv.Location = new System.Drawing.Point(566, 14);
            this.linkAdv.Name = "linkAdv";
            this.linkAdv.Size = new System.Drawing.Size(206, 91);
            this.linkAdv.TabIndex = 7;
            this.linkAdv.TabStop = true;
            this.linkAdv.Text = "Reklam Alanı";
            this.linkAdv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkAdv.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAdv_LinkClicked);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(18, 377);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(754, 23);
            this.progressBar1.TabIndex = 12;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 412);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.chkUseWindowMode);
            this.Controls.Add(this.chkUseOpenGL);
            this.Controls.Add(this.chkLaunchGameOnStart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkAdv);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtGameExePath);
            this.Controls.Add(this.chkClearCash);
            this.Controls.Add(this.btnGo);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WePlay WarCraft III Launcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.CheckBox chkClearCash;
        private System.Windows.Forms.TextBox txtGameExePath;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.WebBrowser wbNews;
        private System.Windows.Forms.CheckBox chkLaunchGameOnStart;
        private System.Windows.Forms.CheckBox chkUseOpenGL;
        private System.Windows.Forms.CheckBox chkUseWindowMode;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.LinkLabel linkAdv;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

