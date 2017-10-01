namespace pgsqlProject
{
    partial class main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tmsFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsDirectory = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsJournal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReport = new System.Windows.Forms.ToolStripMenuItem();
            this.ssInfo = new System.Windows.Forms.StatusStrip();
            this.sslMode = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslLogin = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslServer = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslDatabase = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmsSDriver = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenu.SuspendLayout();
            this.ssInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsFile,
            this.tmsDirectory,
            this.tmsJournal,
            this.tsmReport});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(624, 24);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // tmsFile
            // 
            this.tmsFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsLogin,
            this.tsmExit});
            this.tmsFile.Name = "tmsFile";
            this.tmsFile.Size = new System.Drawing.Size(48, 20);
            this.tmsFile.Text = "&Файл";
            // 
            // tmsLogin
            // 
            this.tmsLogin.Name = "tmsLogin";
            this.tmsLogin.Size = new System.Drawing.Size(200, 22);
            this.tmsLogin.Text = "Сменить &пользователя";
            this.tmsLogin.Click += new System.EventHandler(this.tmsLogin_Click);
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Size = new System.Drawing.Size(200, 22);
            this.tsmExit.Text = "&Выход";
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // tmsDirectory
            // 
            this.tmsDirectory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsSDriver});
            this.tmsDirectory.Name = "tmsDirectory";
            this.tmsDirectory.Size = new System.Drawing.Size(94, 20);
            this.tmsDirectory.Text = "&Справочники";
            // 
            // tmsJournal
            // 
            this.tmsJournal.Name = "tmsJournal";
            this.tmsJournal.Size = new System.Drawing.Size(63, 20);
            this.tmsJournal.Text = "&Журнал";
            this.tmsJournal.Click += new System.EventHandler(this.tmsJournal_Click);
            // 
            // tsmReport
            // 
            this.tsmReport.Name = "tsmReport";
            this.tsmReport.Size = new System.Drawing.Size(60, 20);
            this.tsmReport.Text = "&Отчеты";
            // 
            // ssInfo
            // 
            this.ssInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslMode,
            this.sslLogin,
            this.sslServer,
            this.sslDatabase});
            this.ssInfo.Location = new System.Drawing.Point(0, 419);
            this.ssInfo.Name = "ssInfo";
            this.ssInfo.Size = new System.Drawing.Size(624, 22);
            this.ssInfo.TabIndex = 1;
            // 
            // sslMode
            // 
            this.sslMode.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.sslMode.Name = "sslMode";
            this.sslMode.Size = new System.Drawing.Size(4, 17);
            // 
            // sslLogin
            // 
            this.sslLogin.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.sslLogin.Name = "sslLogin";
            this.sslLogin.Size = new System.Drawing.Size(4, 17);
            // 
            // sslServer
            // 
            this.sslServer.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.sslServer.Name = "sslServer";
            this.sslServer.Size = new System.Drawing.Size(4, 17);
            // 
            // sslDatabase
            // 
            this.sslDatabase.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.sslDatabase.Name = "sslDatabase";
            this.sslDatabase.Size = new System.Drawing.Size(4, 17);
            // 
            // tmsSDriver
            // 
            this.tmsSDriver.Name = "tmsSDriver";
            this.tmsSDriver.Size = new System.Drawing.Size(202, 22);
            this.tmsSDriver.Text = "Справочник водителей";
            this.tmsSDriver.Click += new System.EventHandler(this.tmsSDriver_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.ssInfo);
            this.Controls.Add(this.msMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMenu;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Главная автопарк";
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ssInfo.ResumeLayout(false);
            this.ssInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem tmsFile;
        private System.Windows.Forms.StatusStrip ssInfo;
        private System.Windows.Forms.ToolStripStatusLabel sslServer;
        private System.Windows.Forms.ToolStripStatusLabel sslDatabase;
        private System.Windows.Forms.ToolStripStatusLabel sslLogin;
        private System.Windows.Forms.ToolStripMenuItem tmsLogin;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripMenuItem tmsDirectory;
        private System.Windows.Forms.ToolStripMenuItem tmsJournal;
        private System.Windows.Forms.ToolStripMenuItem tsmReport;
        private System.Windows.Forms.ToolStripStatusLabel sslMode;
        private System.Windows.Forms.ToolStripMenuItem tmsSDriver;
    }
}

