namespace pgsqlProject
{
    partial class frmJournal
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
            this.bCheck = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.lAuto = new System.Windows.Forms.Label();
            this.lDriver = new System.Windows.Forms.Label();
            this.lRoutes = new System.Windows.Forms.Label();
            this.cbAuto = new System.Windows.Forms.ComboBox();
            this.cbDriver = new System.Windows.Forms.ComboBox();
            this.cbRoutes = new System.Windows.Forms.ComboBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.t1 = new System.Windows.Forms.Timer(this.components);
            this.t2 = new System.Windows.Forms.Timer(this.components);
            this.bw = new System.ComponentModel.BackgroundWorker();
            this.pFilter = new System.Windows.Forms.Panel();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.ttInfo = new System.Windows.Forms.ToolTip(this.components);
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_in = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_out = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parther_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.pFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pButton
            // 
            this.pButton.Controls.Add(this.bCheck);
            this.pButton.Controls.Add(this.bAdd);
            this.pButton.Controls.Add(this.lAuto);
            this.pButton.Controls.Add(this.lDriver);
            this.pButton.Controls.Add(this.lRoutes);
            this.pButton.Controls.Add(this.cbAuto);
            this.pButton.Controls.Add(this.cbDriver);
            this.pButton.Controls.Add(this.cbRoutes);
            this.pButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pButton.Location = new System.Drawing.Point(0, 404);
            this.pButton.Name = "pButton";
            this.pButton.Size = new System.Drawing.Size(904, 45);
            this.pButton.TabIndex = 0;
            // 
            // bCheck
            // 
            this.bCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bCheck.BackgroundImage = global::pgsqlProject.Properties.Resources.check_square_o;
            this.bCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bCheck.Location = new System.Drawing.Point(869, 10);
            this.bCheck.Name = "bCheck";
            this.bCheck.Size = new System.Drawing.Size(32, 32);
            this.bCheck.TabIndex = 5;
            this.ttInfo.SetToolTip(this.bCheck, "Потвердить завершение поездки");
            this.bCheck.UseVisualStyleBackColor = true;
            this.bCheck.Click += new System.EventHandler(this.bCheck_Click);
            // 
            // bAdd
            // 
            this.bAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bAdd.BackgroundImage = global::pgsqlProject.Properties.Resources.plus_square_o_32;
            this.bAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bAdd.Location = new System.Drawing.Point(494, 10);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(32, 32);
            this.bAdd.TabIndex = 5;
            this.ttInfo.SetToolTip(this.bAdd, "Добавить маршрут");
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // lAuto
            // 
            this.lAuto.AutoSize = true;
            this.lAuto.Location = new System.Drawing.Point(326, 5);
            this.lAuto.Name = "lAuto";
            this.lAuto.Size = new System.Drawing.Size(31, 13);
            this.lAuto.TabIndex = 1;
            this.lAuto.Text = "Авто";
            // 
            // lDriver
            // 
            this.lDriver.AutoSize = true;
            this.lDriver.Location = new System.Drawing.Point(161, 5);
            this.lDriver.Name = "lDriver";
            this.lDriver.Size = new System.Drawing.Size(58, 13);
            this.lDriver.TabIndex = 1;
            this.lDriver.Text = "Водитель:";
            // 
            // lRoutes
            // 
            this.lRoutes.AutoSize = true;
            this.lRoutes.Location = new System.Drawing.Point(12, 5);
            this.lRoutes.Name = "lRoutes";
            this.lRoutes.Size = new System.Drawing.Size(55, 13);
            this.lRoutes.TabIndex = 1;
            this.lRoutes.Text = "Маршрут:";
            // 
            // cbAuto
            // 
            this.cbAuto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAuto.FormattingEnabled = true;
            this.cbAuto.Location = new System.Drawing.Point(329, 21);
            this.cbAuto.Name = "cbAuto";
            this.cbAuto.Size = new System.Drawing.Size(159, 21);
            this.cbAuto.TabIndex = 0;
            // 
            // cbDriver
            // 
            this.cbDriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDriver.FormattingEnabled = true;
            this.cbDriver.Location = new System.Drawing.Point(164, 21);
            this.cbDriver.Name = "cbDriver";
            this.cbDriver.Size = new System.Drawing.Size(159, 21);
            this.cbDriver.TabIndex = 0;
            this.cbDriver.SelectedIndexChanged += new System.EventHandler(this.cbDriver_SelectedIndexChanged);
            // 
            // cbRoutes
            // 
            this.cbRoutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoutes.FormattingEnabled = true;
            this.cbRoutes.Location = new System.Drawing.Point(12, 21);
            this.cbRoutes.Name = "cbRoutes";
            this.cbRoutes.Size = new System.Drawing.Size(146, 21);
            this.cbRoutes.TabIndex = 0;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToResizeRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.time_in,
            this.time_out,
            this.num,
            this.color,
            this.mark,
            this.first_name,
            this.last_name,
            this.parther_name});
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(0, 22);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(904, 382);
            this.dgvData.TabIndex = 1;
            this.dgvData.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvData_RowPostPaint);
            // 
            // t1
            // 
            this.t1.Enabled = true;
            this.t1.Interval = 5000;
            this.t1.Tick += new System.EventHandler(this.t1_Tick);
            // 
            // t2
            // 
            this.t2.Enabled = true;
            this.t2.Interval = 60000;
            this.t2.Tick += new System.EventHandler(this.t2_Tick);
            // 
            // bw
            // 
            this.bw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_DoWork);
            this.bw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_RunWorkerCompleted);
            // 
            // pFilter
            // 
            this.pFilter.Controls.Add(this.tbFilter);
            this.pFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pFilter.Location = new System.Drawing.Point(0, 0);
            this.pFilter.Name = "pFilter";
            this.pFilter.Size = new System.Drawing.Size(904, 22);
            this.pFilter.TabIndex = 2;
            // 
            // tbFilter
            // 
            this.tbFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbFilter.Location = new System.Drawing.Point(0, 0);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbFilter.Size = new System.Drawing.Size(904, 20);
            this.tbFilter.TabIndex = 0;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Маршрут";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // time_in
            // 
            this.time_in.DataPropertyName = "time_in";
            this.time_in.HeaderText = "Время выезда";
            this.time_in.Name = "time_in";
            this.time_in.ReadOnly = true;
            // 
            // time_out
            // 
            this.time_out.DataPropertyName = "time_out";
            this.time_out.HeaderText = "Время приезда";
            this.time_out.Name = "time_out";
            this.time_out.ReadOnly = true;
            // 
            // num
            // 
            this.num.DataPropertyName = "num";
            this.num.HeaderText = "Номер авто";
            this.num.Name = "num";
            this.num.ReadOnly = true;
            // 
            // color
            // 
            this.color.DataPropertyName = "color";
            this.color.HeaderText = "Цвет";
            this.color.Name = "color";
            this.color.ReadOnly = true;
            // 
            // mark
            // 
            this.mark.DataPropertyName = "mark";
            this.mark.HeaderText = "Марка";
            this.mark.Name = "mark";
            this.mark.ReadOnly = true;
            // 
            // first_name
            // 
            this.first_name.DataPropertyName = "first_name";
            this.first_name.HeaderText = "Имя";
            this.first_name.Name = "first_name";
            this.first_name.ReadOnly = true;
            // 
            // last_name
            // 
            this.last_name.DataPropertyName = "last_name";
            this.last_name.HeaderText = "Фамилия";
            this.last_name.Name = "last_name";
            this.last_name.ReadOnly = true;
            // 
            // parther_name
            // 
            this.parther_name.DataPropertyName = "parther_name";
            this.parther_name.HeaderText = "Отчество";
            this.parther_name.Name = "parther_name";
            this.parther_name.ReadOnly = true;
            // 
            // frmJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 449);
            this.ControlBox = false;
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.pButton);
            this.Controls.Add(this.pFilter);
            this.Name = "frmJournal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Журнал";
            this.Load += new System.EventHandler(this.frmJournal_Load);
            this.pButton.ResumeLayout(false);
            this.pButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.pFilter.ResumeLayout(false);
            this.pFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pButton;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Timer t1;
        private System.Windows.Forms.Timer t2;
        private System.ComponentModel.BackgroundWorker bw;
        private System.Windows.Forms.Panel pFilter;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Label lAuto;
        private System.Windows.Forms.Label lDriver;
        private System.Windows.Forms.Label lRoutes;
        private System.Windows.Forms.ComboBox cbAuto;
        private System.Windows.Forms.ComboBox cbDriver;
        private System.Windows.Forms.ComboBox cbRoutes;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.ToolTip ttInfo;
        private System.Windows.Forms.Button bCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_in;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_out;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn mark;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn parther_name;
    }
}