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
    public partial class frmAddAuto : Form
    {
        int id = -1;
        bool change = false;
        procedure sql = new procedure();

        public frmAddAuto()
        {
            InitializeComponent();

            this.Text = "Добавить водителя";

            DataTable dtDrivers = sql.getListAllDriver();
            cbDriver.DataSource = dtDrivers;
            cbDriver.DisplayMember = "name";
            cbDriver.ValueMember = "id";
        }

        public frmAddAuto(DataRow row)
        {
            InitializeComponent();

            this.Text = "Редактировать водителя";

            tbNum.Enabled = false;

            DataTable dtDrivers = sql.getListAllDriver();
            cbDriver.DataSource = dtDrivers;
            cbDriver.DisplayMember = "name";
            cbDriver.ValueMember = "id";

            setInfo(row);

            change = false;
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            if (change && MessageBox.Show("Данные были изменены.\nХотите сохранить изменения?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                save();
            }

            this.Close();
        }

        private void setInfo(DataRow row)
        {
            id = (int)row["id"];
            tbNum.Text = row["num"].ToString();
            tbColor.Text = row["color"].ToString();
            tbMark.Text = row["mark"].ToString();

            cbDriver.SelectedValue = Convert.ToInt32(row["personnel_id"].ToString());
        }

        private void bSave_Click(object sender, EventArgs e)
        { 
            if (change)
            {
                save();
            }
            else if (MessageBox.Show("Нет изменений.\nХотите просто закрыть форму?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            this.Close();
        }

        private void changeSave(object sender, EventArgs e)
        {
            change = true;
        }

        private void save()
        {
            sql.setSAuto(id, tbNum.Text, tbColor.Text, tbMark.Text, Convert.ToInt32(cbDriver.SelectedValue));
        }
    }
}
