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
    public partial class frmSDriver : Form
    {
        procedure sql = new procedure();
        DataTable dtData;

        public frmSDriver()
        {
            InitializeComponent();

            enableButton();
            setData();
        }

        private void setData()
        {
            dtData = sql.getSDriver();
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
            filter += "first_name like '%" + tbFirstName.Text + "%' ";
            filter += "and last_name like '%" + tbLastName.Text + "%' ";
            filter += "and parther_name like '%" + tbPatherName.Text + "%'";

            dtData.DefaultView.RowFilter = filter;
            dtData.AcceptChanges();
        }

        private void tbExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            addPersonel();
        }

        private void addPersonel()
        {
            frmAddDriver frm = new frmAddDriver();
            frm.ShowDialog();

            setData();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            editPersonnel();
        }

        private void editPersonnel()
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
            addPersonel();
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
                    if (int.Parse(dtRows.Rows[dgvData.CurrentRow.Index]["e_car"].ToString()) == 1)
                    {
                        MessageBox.Show("Нельзя удалить, строка связанна с другой таблицей", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    sql.delSDriver(int.Parse(dtRows.Rows[dgvData.CurrentRow.Index]["id"].ToString()));

                    setData();
                }
            }
            
        }

        private void dgvData_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && config.mode == "АДМ")
                editPersonnel();
        }

        private void dgvData_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (dgvData != null && Convert.ToInt32(dgvData.Rows[e.RowIndex].Cells["eCar"].Value) == 0)
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
    }
}
