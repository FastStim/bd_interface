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
            
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmSDriver_Load(object sender, EventArgs e)
        {
            setData();
        }

        void setData()
        {
            dtData = sql.getSDriver();
            bsData = new BindingSource();
            bsData.DataSource = dtData;
            dgvData.DataSource = bsData;
        }
    }
}
