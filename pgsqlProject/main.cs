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

            frmMain frmMDI = new frmMain();
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

            closeMDI();

            frmMain frmMDI = new frmMain();
            frmMDI.MdiParent = this;
            frmMDI.Show();

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
            frmSDriver frm = new frmSDriver();
            frm.ShowDialog();
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            closeMDI();
        }

        private void tmsSAuto_Click(object sender, EventArgs e)
        {
            frmSAuto frm = new frmSAuto();
            frm.ShowDialog();
        }

        private void tmsSRoutes_Click(object sender, EventArgs e)
        {
            frmSRoutes frm = new frmSRoutes();
            frm.ShowDialog();
        }

        private void tmsMain_Click(object sender, EventArgs e)
        {
            closeMDI();

            frmMain frmMDI = new frmMain();
            frmMDI.MdiParent = this;
            frmMDI.Show();
        }

        private void tmsRide_Click(object sender, EventArgs e)
        {
            report.reportRide report = new report.reportRide("report/reportRide.pdf");
            report.printLastJournal();
            report.showReport();
        }
    }
}
