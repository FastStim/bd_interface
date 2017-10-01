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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            if (config.mode == "С")
            {
                if (MessageBox.Show("Закрыть программу?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            else
            {
                Close();
            }
        }

        private void changeFocus(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, false);
            }

        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            if (tbLogin.Text.Trim() == "" || tbPassword.Text.Trim() == "")
            {
                MessageBox.Show("Поля пользователь и пароль обязательны к заполнению", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            procedure sql = new procedure();
            DataTable dtData = sql.login(tbLogin.Text, tbPassword.Text);
            if (dtData != null && dtData.Rows.Count > 0)
            { 
                config.login = tbLogin.Text;
                config.password = tbPassword.Text;
                config.mode = dtData.Rows[0]["mode"].ToString();

                Close();
            }
            else
            {
                MessageBox.Show("Не правильно указан пользователь или пароль", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
              
        }
    }
}
