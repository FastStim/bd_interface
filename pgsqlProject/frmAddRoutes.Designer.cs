namespace pgsqlProject
{
    partial class frmAddRoutes
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
            this.lName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.pButton = new System.Windows.Forms.Panel();
            this.bExit = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.ttInfo = new System.Windows.Forms.ToolTip(this.components);
            this.pButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(12, 36);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(60, 13);
            this.lName.TabIndex = 0;
            this.lName.Text = "Название:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(76, 33);
            this.tbName.MaxLength = 20;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 0;
            this.tbName.TextChanged += new System.EventHandler(this.changeSave);
            // 
            // pButton
            // 
            this.pButton.Controls.Add(this.bExit);
            this.pButton.Controls.Add(this.bSave);
            this.pButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pButton.Location = new System.Drawing.Point(0, 86);
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
            this.bExit.TabIndex = 4;
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
            this.bSave.TabIndex = 3;
            this.ttInfo.SetToolTip(this.bSave, "Сохранить");
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // frmAddRoutes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 124);
            this.ControlBox = false;
            this.Controls.Add(this.pButton);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(204, 163);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(204, 163);
            this.Name = "frmAddRoutes";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddRoutes";
            this.pButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Panel pButton;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.ToolTip ttInfo;
    }
}