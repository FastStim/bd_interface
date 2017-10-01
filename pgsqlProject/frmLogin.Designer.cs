namespace pgsqlProject
{
    partial class frmLogin
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
            this.lLogin = new System.Windows.Forms.Label();
            this.lPassword = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.pButton = new System.Windows.Forms.Panel();
            this.bExit = new System.Windows.Forms.Button();
            this.bLogin = new System.Windows.Forms.Button();
            this.ttInfo = new System.Windows.Forms.ToolTip(this.components);
            this.pButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // lLogin
            // 
            this.lLogin.AutoSize = true;
            this.lLogin.Location = new System.Drawing.Point(12, 9);
            this.lLogin.Name = "lLogin";
            this.lLogin.Size = new System.Drawing.Size(83, 13);
            this.lLogin.TabIndex = 0;
            this.lLogin.Text = "Пользователь:";
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Location = new System.Drawing.Point(12, 35);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(48, 13);
            this.lPassword.TabIndex = 0;
            this.lPassword.Text = "Пароль:";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(101, 6);
            this.tbLogin.MaxLength = 30;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(100, 20);
            this.tbLogin.TabIndex = 0;
            this.tbLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.changeFocus);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(101, 32);
            this.tbPassword.MaxLength = 30;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '●';
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.changeFocus);
            // 
            // pButton
            // 
            this.pButton.Controls.Add(this.bExit);
            this.pButton.Controls.Add(this.bLogin);
            this.pButton.Location = new System.Drawing.Point(3, 58);
            this.pButton.Name = "pButton";
            this.pButton.Size = new System.Drawing.Size(198, 38);
            this.pButton.TabIndex = 2;
            // 
            // bExit
            // 
            this.bExit.BackgroundImage = global::pgsqlProject.Properties.Resources.sign_out_32;
            this.bExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bExit.Location = new System.Drawing.Point(166, 3);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(32, 32);
            this.bExit.TabIndex = 3;
            this.ttInfo.SetToolTip(this.bExit, "Закрыть");
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bLogin
            // 
            this.bLogin.BackgroundImage = global::pgsqlProject.Properties.Resources.sign_in_32;
            this.bLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bLogin.Location = new System.Drawing.Point(128, 3);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(32, 32);
            this.bLogin.TabIndex = 2;
            this.ttInfo.SetToolTip(this.bLogin, "Вход");
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 104);
            this.ControlBox = false;
            this.Controls.Add(this.pButton);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lPassword);
            this.Controls.Add(this.lLogin);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(230, 143);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(230, 143);
            this.Name = "frmLogin";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Авторизация";
            this.pButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lLogin;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Panel pButton;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.ToolTip ttInfo;
    }
}