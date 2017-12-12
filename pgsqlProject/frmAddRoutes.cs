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
    public partial class frmAddRoutes : Form
    {
        int id = -1;
        bool change = false;
        procedure sql = new procedure();

        public frmAddRoutes()
        {
            InitializeComponent();

            this.Text = "Добавить маршрут";
        }

        public frmAddRoutes(DataRow row)
        {
            InitializeComponent();

            this.Text = "Редактировать маршрут";
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
            tbName.Text = row["name"].ToString();
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
            sql.setSRoutes(id, tbName.Text);
        }
    }
}
