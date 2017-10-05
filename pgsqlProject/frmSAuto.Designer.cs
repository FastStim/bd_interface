namespace pgsqlProject
{
    partial class frmSAuto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pButton = new System.Windows.Forms.Panel();
            this.tbExit = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPersonnel_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsData = new System.Windows.Forms.BindingSource(this.components);
            this.pFilter = new System.Windows.Forms.Panel();
            this.tbMark = new System.Windows.Forms.TextBox();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.pGrid = new System.Windows.Forms.Panel();
            this.ttInfo = new System.Windows.Forms.ToolTip(this.components);
            this.pButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsData)).BeginInit();
            this.pFilter.SuspendLayout();
            this.pGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // pButton
            // 
            this.pButton.Controls.Add(this.tbExit);
            this.pButton.Controls.Add(this.bDelete);
            this.pButton.Controls.Add(this.bEdit);
            this.pButton.Controls.Add(this.bAdd);
            this.pButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pButton.Location = new System.Drawing.Point(0, 381);
            this.pButton.Name = "pButton";
            this.pButton.Size = new System.Drawing.Size(304, 40);
            this.pButton.TabIndex = 99;
            // 
            // tbExit
            // 
            this.tbExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbExit.BackgroundImage = global::pgsqlProject.Properties.Resources.sign_out_32;
            this.tbExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbExit.Location = new System.Drawing.Point(268, 3);
            this.tbExit.Name = "tbExit";
            this.tbExit.Size = new System.Drawing.Size(32, 32);
            this.tbExit.TabIndex = 7;
            this.ttInfo.SetToolTip(this.tbExit, "Закрыть");
            this.tbExit.UseVisualStyleBackColor = true;
            this.tbExit.Click += new System.EventHandler(this.tbExit_Click);
            // 
            // bDelete
            // 
            this.bDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bDelete.BackgroundImage = global::pgsqlProject.Properties.Resources.trash_o_32;
            this.bDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bDelete.Location = new System.Drawing.Point(230, 3);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(32, 32);
            this.bDelete.TabIndex = 6;
            this.ttInfo.SetToolTip(this.bDelete, "Удалить");
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bEdit
            // 
            this.bEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bEdit.BackgroundImage = global::pgsqlProject.Properties.Resources.edit_32;
            this.bEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bEdit.Location = new System.Drawing.Point(192, 3);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(32, 32);
            this.bEdit.TabIndex = 5;
            this.ttInfo.SetToolTip(this.bEdit, "Редактировать");
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bAdd
            // 
            this.bAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bAdd.BackgroundImage = global::pgsqlProject.Properties.Resources.plus_square_o_32;
            this.bAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bAdd.Location = new System.Drawing.Point(154, 3);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(32, 32);
            this.bAdd.TabIndex = 4;
            this.ttInfo.SetToolTip(this.bAdd, "Добавить");
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToResizeRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId,
            this.cNum,
            this.cColor,
            this.cMark,
            this.cPersonnel_id});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(0, 0);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.RowTemplate.ReadOnly = true;
            this.dgvData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(304, 347);
            this.dgvData.TabIndex = 0;
            this.dgvData.TabStop = false;
            this.dgvData.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvData_CellMouseDoubleClick);
            this.dgvData.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvData_RowPostPaint);
            // 
            // cId
            // 
            this.cId.DataPropertyName = "id";
            this.cId.HeaderText = "id";
            this.cId.Name = "cId";
            this.cId.ReadOnly = true;
            this.cId.Visible = false;
            // 
            // cNum
            // 
            this.cNum.DataPropertyName = "num";
            this.cNum.HeaderText = "Номер";
            this.cNum.Name = "cNum";
            this.cNum.ReadOnly = true;
            // 
            // cColor
            // 
            this.cColor.DataPropertyName = "color";
            this.cColor.HeaderText = "Цвет";
            this.cColor.Name = "cColor";
            this.cColor.ReadOnly = true;
            // 
            // cMark
            // 
            this.cMark.DataPropertyName = "mark";
            this.cMark.HeaderText = "Марка";
            this.cMark.Name = "cMark";
            this.cMark.ReadOnly = true;
            // 
            // cPersonnel_id
            // 
            this.cPersonnel_id.DataPropertyName = "personnel_id";
            this.cPersonnel_id.HeaderText = "personnel";
            this.cPersonnel_id.Name = "cPersonnel_id";
            this.cPersonnel_id.ReadOnly = true;
            this.cPersonnel_id.Visible = false;
            // 
            // pFilter
            // 
            this.pFilter.Controls.Add(this.tbMark);
            this.pFilter.Controls.Add(this.tbColor);
            this.pFilter.Controls.Add(this.tbNum);
            this.pFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pFilter.Location = new System.Drawing.Point(0, 0);
            this.pFilter.Name = "pFilter";
            this.pFilter.Size = new System.Drawing.Size(304, 34);
            this.pFilter.TabIndex = 1;
            // 
            // tbMark
            // 
            this.tbMark.Location = new System.Drawing.Point(205, 8);
            this.tbMark.Name = "tbMark";
            this.tbMark.Size = new System.Drawing.Size(95, 20);
            this.tbMark.TabIndex = 3;
            this.tbMark.TextChanged += new System.EventHandler(this.changeFilter);
            // 
            // tbColor
            // 
            this.tbColor.Location = new System.Drawing.Point(104, 8);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(95, 20);
            this.tbColor.TabIndex = 2;
            this.tbColor.TextChanged += new System.EventHandler(this.changeFilter);
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(3, 8);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(95, 20);
            this.tbNum.TabIndex = 1;
            this.tbNum.TextChanged += new System.EventHandler(this.changeFilter);
            // 
            // pGrid
            // 
            this.pGrid.Controls.Add(this.dgvData);
            this.pGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pGrid.Location = new System.Drawing.Point(0, 34);
            this.pGrid.Name = "pGrid";
            this.pGrid.Size = new System.Drawing.Size(304, 347);
            this.pGrid.TabIndex = 2;
            // 
            // frmSAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 421);
            this.Controls.Add(this.pGrid);
            this.Controls.Add(this.pFilter);
            this.Controls.Add(this.pButton);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 460);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(320, 460);
            this.Name = "frmSAuto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Справочник автомобилей";
            this.pButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsData)).EndInit();
            this.pFilter.ResumeLayout(false);
            this.pFilter.PerformLayout();
            this.pGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pButton;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.BindingSource bsData;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Panel pFilter;
        private System.Windows.Forms.TextBox tbMark;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.Panel pGrid;
        private System.Windows.Forms.Button tbExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn cColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPersonnel_id;
        private System.Windows.Forms.ToolTip ttInfo;
    }
}