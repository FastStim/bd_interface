using System;
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
    public partial class frmJournal : Form
    {
        procedure sql = new procedure();
        procedure sqlBw = new procedure();
        DataTable dtData;
        int count = 0;
        bool load = false;

        public frmJournal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Text = "Журнал";

            DataTable dtRoutes = sql.getSRoutes();
            cbRoutes.DataSource = dtRoutes;
            cbRoutes.DisplayMember = "name";
            cbRoutes.ValueMember = "id";

            DataTable dtDrivers = sql.getListDriver();
            cbDriver.DataSource = dtDrivers;
            cbDriver.DisplayMember = "name";
            cbDriver.ValueMember = "id";

            DataTable dtAuto = sql.getListAuto(Convert.ToInt32(cbDriver.SelectedValue));
            cbAuto.DataSource = dtAuto;
            cbAuto.DisplayMember = "name";
            cbAuto.ValueMember = "id";

            if (config.mode == "АДМ" || config.mode == "МН")
                pButton.Visible = true;
            else
                pButton.Visible = false;

            bw.RunWorkerAsync();
        }

        private void frmJournal_Load(object sender, EventArgs e)
        {
            load = true;
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            dtData = sqlBw.getJournal();
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dgvData.DataSource = dtData;
            filter();
        }

        private void filter()
        {
            try
            {
                string filter = "";
                filter += "first_name like '%" + tbFilter.Text + "%' ";
                filter += "or last_name like '%" + tbFilter.Text + "%' ";
                filter += "or parther_name like '%" + tbFilter.Text + "%' ";
                filter += "or num like '%" + tbFilter.Text + "%' ";
                filter += "or color like '%" + tbFilter.Text + "%' ";
                filter += "or mark like '%" + tbFilter.Text + "%'";
                filter += "or name like '%" + tbFilter.Text + "%'";
            
                dtData.DefaultView.RowFilter = filter;
                dtData.AcceptChanges();
            }
            catch
            {
                dtData.AcceptChanges();
            }
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void dgvData_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
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

        private void t1_Tick(object sender, EventArgs e)
        {
            int tCount = sql.getCountJournal();
            if (count == 0) count = tCount;
            if (tCount != count)
            {
                if (!bw.IsBusy)
                {
                    count = tCount;
                    bw.RunWorkerAsync();
                }
            }
        }

        private void t2_Tick(object sender, EventArgs e)
        {
            if (!bw.IsBusy)
                bw.RunWorkerAsync();
        }

        private void cbDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDriver.SelectedIndex != -1 && load)
            { 
                DataTable dtAuto = sql.getListAuto(Convert.ToInt32(cbDriver.SelectedValue));
                cbAuto.DataSource = dtAuto;
                cbAuto.DisplayMember = "name";
                cbAuto.ValueMember = "id";
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            sql.setNewJournal(Convert.ToInt32(cbRoutes.SelectedValue), Convert.ToInt32(cbAuto.SelectedValue));
            if (!bw.IsBusy)
                bw.RunWorkerAsync();
        }

        private void bCheck_Click(object sender, EventArgs e)
        {
            sql.setNewJournal(Convert.ToInt32(dgvData.CurrentRow.Cells["id"].Value));
            if (!bw.IsBusy)
                bw.RunWorkerAsync();
        }
    }
}
