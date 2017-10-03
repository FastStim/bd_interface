namespace pgsqlProject
{
    partial class frmAddDriver
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
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbPartherName = new System.Windows.Forms.TextBox();
            this.pButton = new System.Windows.Forms.Panel();
            this.bExit = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.ttInfo = new System.Windows.Forms.ToolTip(this.components);
            this.pButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // lFirstName
            // 
            this.lFirstName.AutoSize = true;
            this.lFirstName.Location = new System.Drawing.Point(12, 9);
            this.lFirstName.Name = "lFirstName";
            this.lFirstName.Size = new System.Drawing.Size(32, 13);
            this.lFirstName.TabIndex = 0;
            this.lFirstName.Text = "Имя:";
            // 
            // lLastName
            // 
            this.lLastName.AutoSize = true;
            this.lLastName.Location = new System.Drawing.Point(12, 35);
            this.lLastName.Name = "lLastName";
            this.lLastName.Size = new System.Drawing.Size(59, 13);
            this.lLastName.TabIndex = 0;
            this.lLastName.Text = "Фамилия:";
            // 
            // lPartherName
            // 
            this.lPartherName.AutoSize = true;
            this.lPartherName.Location = new System.Drawing.Point(12, 61);
            this.lPartherName.Name = "lPartherName";
            this.lPartherName.Size = new System.Drawing.Size(57, 13);
            this.lPartherName.TabIndex = 0;
            this.lPartherName.Text = "Отчество:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(74, 6);
            this.tbFirstName.MaxLength = 20;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbFirstName.TabIndex = 1;
            this.tbFirstName.TextChanged += new System.EventHandler(this.changeSave);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(74, 32);
            this.tbLastName.MaxLength = 20;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 2;
            this.tbLastName.TextChanged += new System.EventHandler(this.changeSave);
            // 
            // tbPartherName
            // 
            this.tbPartherName.Location = new System.Drawing.Point(74, 58);
            this.tbPartherName.MaxLength = 20;
            this.tbPartherName.Name = "tbPartherName";
            this.tbPartherName.Size = new System.Drawing.Size(100, 20);
            this.tbPartherName.TabIndex = 3;
            this.tbPartherName.TextChanged += new System.EventHandler(this.changeSave);
            // 
            // pButton
            // 
            this.pButton.Controls.Add(this.bExit);
            this.pButton.Controls.Add(this.bSave);
            this.pButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pButton.Location = new System.Drawing.Point(0, 86);
            this.pButton.Name = "pButton";
            this.pButton.Size = new System.Drawing.Size(188, 38);
            this.pButton.TabIndex = 2;
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
            // frmAddDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 124);
            this.ControlBox = false;
            this.Controls.Add(this.pButton);
            this.Controls.Add(this.tbPartherName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lPartherName);
            this.Controls.Add(this.lLastName);
            this.Controls.Add(this.lFirstName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(204, 163);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(204, 163);
            this.Name = "frmAddDriver";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddDriver";
            this.pButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lFirstName;
        private System.Windows.Forms.Label lLastName;
        private System.Windows.Forms.Label lPartherName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbPartherName;
        private System.Windows.Forms.Panel pButton;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.ToolTip ttInfo;
    }
}