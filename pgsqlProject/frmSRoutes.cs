﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pgsqlProject
{
    public partial class frmSRoutes : Form
    {
        procedure sql = new procedure();
        DataTable dtData;

        public frmSRoutes()
        {
            InitializeComponent();

            enableButton();
            setData();
        }

        private void setData()
        {
            dtData = sql.getSRoutes();
            filter();

            dgvData.DataSource = dtData.DefaultView;
        }

        private void enableButton()
        {
            bool access = false;
            if (config.mode == "АДМ")
            {
                access = true;
            }

            bAdd.Enabled = bEdit.Enabled = bDelete.Enabled = access;
            bAdd.Visible = bEdit.Visible = bDelete.Visible = access;
        }

        private void changeFilter(object sender, EventArgs e)
        {
            filter();
        }

        private void filter()
        {
            string filter = "";
            filter += "name like '%" + tbName.Text + "%' ";

            dtData.DefaultView.RowFilter = filter;
            dtData.AcceptChanges();
        }

        private void tbExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            addAuto();
        }

        private void addAuto()
        {
            frmAddAuto frm = new frmAddAuto();
            frm.ShowDialog();

            setData();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            editAuto();
        }

        private void editAuto()
        {
            if (dtData != null && dgvData != null && dgvData.RowCount > 0 && dgvData.CurrentRow.Index != -1)
            {
                DataTable dtRows = dtData.DefaultView.ToTable();

                frmAddDriver frm = new frmAddDriver(dtRows.Rows[dgvData.CurrentRow.Index]);
                frm.ShowDialog();

                setData();
            }
        }

        private void tcmsAdd_Click(object sender, EventArgs e)
        {
            addAuto();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (dtData != null && dgvData != null && dgvData.RowCount > 0 && dgvData.CurrentRow.Index != -1)
            {
                DataTable dtRows = dtData.DefaultView.ToTable();

                string message = "Удалить ";
                message += dtRows.Rows[dgvData.CurrentRow.Index]["first_name"].ToString() + " ";
                message += dtRows.Rows[dgvData.CurrentRow.Index]["last_name"].ToString() + " ";
                message += dtRows.Rows[dgvData.CurrentRow.Index]["parther_name"].ToString() + " ";

                if (MessageBox.Show(message, "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Console.WriteLine("Удаление строки");
                }
            }
            
        }

        private void dgvData_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && config.mode == "АДМ")
                editAuto();
        }

        private void dgvData_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (dgvData != null && Convert.ToInt32(dgvData.Rows[e.RowIndex].Cells["eJournal"].Value) == 0)
            {
                dgvData.Rows[e.RowIndex].DefaultCellStyle.BackColor = pColor.BackColor;
                dgvData.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = pColor.BackColor;
            }

            DataGridView dgv = (DataGridView)sender;
            if (dgv.Rows[e.RowIndex].Selected)
            {
                int width = dgv.Width;
                Rectangle r = dgv.GetRowDisplayRectangle(e.RowIndex, false);
                Rectangle rect = new Rectangle(r.X, r.Y, width - 1, r.Height - 1);

                ControlPaint.DrawBorder(e.Graphics, rect,
                    SystemColors.Highlight, 2, ButtonBorderStyle.Solid,
                    SystemColors.Highlight, 2, ButtonBorderStyle.Solid,
                    SystemColors.Highlight, 2, ButtonBorderStyle.Solid,
                    SystemColors.Highlight, 2, ButtonBorderStyle.Solid);
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
