namespace pgsqlProject
{
    partial class frmSDriver
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
            this.pButton = new System.Windows.Forms.Panel();
            this.bDelete = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.bsData = new System.Windows.Forms.BindingSource(this.components);
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPartherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsData)).BeginInit();
            this.SuspendLayout();
            // 
            // pButton
            // 
            this.pButton.Controls.Add(this.bDelete);
            this.pButton.Controls.Add(this.bEdit);
            this.pButton.Controls.Add(this.bAdd);
            this.pButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pButton.Location = new System.Drawing.Point(0, 382);
            this.pButton.Name = "pButton";
            this.pButton.Size = new System.Drawing.Size(486, 40);
            this.pButton.TabIndex = 0;
            // 
            // bDelete
            // 
            this.bDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bDelete.BackgroundImage = global::pgsqlProject.Properties.Resources.trash_o_32;
            this.bDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bDelete.Location = new System.Drawing.Point(451, 3);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(32, 32);
            this.bDelete.TabIndex = 3;
            this.bDelete.UseVisualStyleBackColor = true;
            // 
            // bEdit
            // 
            this.bEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bEdit.BackgroundImage = global::pgsqlProject.Properties.Resources.edit_32;
            this.bEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bEdit.Location = new System.Drawing.Point(413, 3);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(32, 32);
            this.bEdit.TabIndex = 2;
            this.bEdit.UseVisualStyleBackColor = true;
            // 
            // bAdd
            // 
            this.bAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bAdd.BackgroundImage = global::pgsqlProject.Properties.Resources.plus_square_o_32;
            this.bAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bAdd.Location = new System.Drawing.Point(375, 3);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(32, 32);
            this.bAdd.TabIndex = 1;
            this.bAdd.UseVisualStyleBackColor = true;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToResizeRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId,
            this.cFirstName,
            this.cLastName,
            this.cPartherName});
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(0, 0);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.RowTemplate.ReadOnly = true;
            this.dgvData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(486, 382);
            this.dgvData.TabIndex = 0;
            // 
            // cId
            // 
            this.cId.DataPropertyName = "id";
            this.cId.HeaderText = "id";
            this.cId.Name = "cId";
            this.cId.ReadOnly = true;
            this.cId.Visible = false;
            // 
            // cFirstName
            // 
            this.cFirstName.DataPropertyName = "first_name";
            this.cFirstName.HeaderText = "Имя";
            this.cFirstName.Name = "cFirstName";
            this.cFirstName.ReadOnly = true;
            // 
            // cLastName
            // 
            this.cLastName.DataPropertyName = "last_name";
            this.cLastName.HeaderText = "Фамилия";
            this.cLastName.Name = "cLastName";
            this.cLastName.ReadOnly = true;
            // 
            // cPartherName
            // 
            this.cPartherName.DataPropertyName = "parther_name";
            this.cPartherName.HeaderText = "Отчество";
            this.cPartherName.Name = "cPartherName";
            this.cPartherName.ReadOnly = true;
            // 
            // frmSDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 422);
            this.ControlBox = false;
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.pButton);
            this.Name = "frmSDriver";
            this.Text = "Справочник водителей";
            this.Load += new System.EventHandler(this.frmSDriver_Load);
            this.pButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pButton;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.BindingSource bsData;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPartherName;
    }
}