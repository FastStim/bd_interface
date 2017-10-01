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
    public partial class main : Form
    {
        public main()
        {
            frmLogin frm = new frmLogin();
            frm.ShowDialog();

            InitializeComponent();

            setInfo();

            frmJournal frmMDI = new frmJournal();
            frmMDI.MdiParent = this;
            frmMDI.Show();
        }

        void setInfo()
        {
            sslServer.Text = config.server;
            sslDatabase.Text = config.database;
            sslLogin.Text = config.login;
            sslMode.Text = config.mode;
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tmsLogin_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.ShowDialog();

            setInfo();
        }

        private void closeMDI()
        {
            foreach (Form frmMDI in this.MdiChildren)
            {
                frmMDI.Close();
            }
        }

        private void tmsJournal_Click(object sender, EventArgs e)
        {
            closeMDI();

            frmJournal frmMDI = new frmJournal();
            frmMDI.MdiParent = this;
            frmMDI.Show();
        }

        

        private void tmsSDriver_Click(object sender, EventArgs e)
        {
            closeMDI();

            frmSDriver frmMDI = new frmSDriver();
            frmMDI.MdiParent = this;
            frmMDI.Show();
        }
    }
}
