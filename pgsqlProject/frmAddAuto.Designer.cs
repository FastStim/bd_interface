namespace pgsqlProject
{
    partial class frmAddAuto
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
            this.lFirstName = new System.Windows.Forms.Label();
            this.lLastName = new System.Windows.Forms.Label();
            this.lPartherName = new System.Windows.Forms.Label();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.tbMark = new System.Windows.Forms.TextBox();
            this.pButton = new System.Windows.Forms.Panel();
            this.bExit = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.ttInfo = new System.Windows.Forms.ToolTip(this.components);
            this.cbDriver = new System.Windows.Forms.ComboBox();
            this.lDriver = new System.Windows.Forms.Label();
            this.pButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // lFirstName
            // 
            this.lFirstName.AutoSize = true;
            this.lFirstName.Location = new System.Drawing.Point(12, 9);
            this.lFirstName.Name = "lFirstName";
            this.lFirstName.Size = new System.Drawing.Size(44, 13);
            this.lFirstName.TabIndex = 0;
            this.lFirstName.Text = "Номер:";
            // 
            // lLastName
            // 
            this.lLastName.AutoSize = true;
            this.lLastName.Location = new System.Drawing.Point(12, 35);
            this.lLastName.Name = "lLastName";
            this.lLastName.Size = new System.Drawing.Size(35, 13);
            this.lLastName.TabIndex = 0;
            this.lLastName.Text = "Цвет:";
            // 
            // lPartherName
            // 
            this.lPartherName.AutoSize = true;
            this.lPartherName.Location = new System.Drawing.Point(12, 61);
            this.lPartherName.Name = "lPartherName";
            this.lPartherName.Size = new System.Drawing.Size(43, 13);
            this.lPartherName.TabIndex = 0;
            this.lPartherName.Text = "Марка:";
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(74, 6);
            this.tbNum.MaxLength = 20;
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(100, 20);
            this.tbNum.TabIndex = 0;
            this.tbNum.TextChanged += new System.EventHandler(this.changeSave);
            // 
            // tbColor
            // 
            this.tbColor.Location = new System.Drawing.Point(74, 32);
            this.tbColor.MaxLength = 20;
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(100, 20);
            this.tbColor.TabIndex = 1;
            this.tbColor.TextChanged += new System.EventHandler(this.changeSave);
            // 
            // tbMark
            // 
            this.tbMark.Location = new System.Drawing.Point(74, 58);
            this.tbMark.MaxLength = 20;
            this.tbMark.Name = "tbMark";
            this.tbMark.Size = new System.Drawing.Size(100, 20);
            this.tbMark.TabIndex = 2;
            this.tbMark.TextChanged += new System.EventHandler(this.changeSave);
            // 
            // pButton
            // 
            this.pButton.Controls.Add(this.bExit);
            this.pButton.Controls.Add(this.bSave);
            this.pButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pButton.Location = new System.Drawing.Point(0, 111);
            this.pButton.Name = "pButton";
            this.pButton.Size = new System.Drawing.Size(188, 38);
            this.pButton.TabIndex = 99;
            // 
            // bExit
            // 
            this.bExit.BackgroundImage = global::pgsqlProject.Properties.Resources.sign_out_32;
            this.bExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bExit.Location = new System.Drawing.Point(153, 3);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(32, 32);
            this.bExit.TabIndex = 5;
            this.ttInfo.SetToolTip(this.bExit, "Закрыть");
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bSave
            // 
            this.bSave.BackgroundImage = global::pgsqlProject.Properties.Resources.save_32;
            this.bSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bSave.Location = new System.Drawing.Point(115, 3);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(32, 32);
            this.bSave.TabIndex = 4;
            this.ttInfo.SetToolTip(this.bSave, "Сохранить");
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // cbDriver
            // 
            this.cbDriver.FormattingEnabled = true;
            this.cbDriver.Location = new System.Drawing.Point(74, 85);
            this.cbDriver.Name = "cbDriver";
            this.cbDriver.Size = new System.Drawing.Size(100, 21);
            this.cbDriver.TabIndex = 3;
            // 
            // lDriver
            // 
            this.lDriver.AutoSize = true;
            this.lDriver.Location = new System.Drawing.Point(12, 88);
            this.lDriver.Name = "lDriver";
            this.lDriver.Size = new System.Drawing.Size(58, 13);
            this.lDriver.TabIndex = 0;
            this.lDriver.Text = "Водитель:";
            // 
            // frmAddAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 149);
            this.ControlBox = false;
            this.Controls.Add(this.cbDriver);
            this.Controls.Add(this.pButton);
            this.Controls.Add(this.tbMark);
            this.Controls.Add(this.tbColor);
            this.Controls.Add(this.tbNum);
            this.Controls.Add(this.lDriver);
            this.Controls.Add(this.lPartherName);
            this.Controls.Add(this.lLastName);
            this.Controls.Add(this.lFirstName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(204, 188);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(204, 188);
            this.Name = "frmAddAuto";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddAuto";
            this.pButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lFirstName;
        private System.Windows.Forms.Label lLastName;
        private System.Windows.Forms.Label lPartherName;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.TextBox tbMark;
        private System.Windows.Forms.Panel pButton;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.ToolTip ttInfo;
        private System.Windows.Forms.ComboBox cbDriver;
        private System.Windows.Forms.Label lDriver;
    }
}