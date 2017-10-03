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
    public partial class frmAddDriver : Form
    {
        int id = -1;

        public frmAddDriver()
        {
            InitializeComponent();

            this.Text = "Добавить водителя";
        }

        public frmAddDriver(DataRow row)
        {
            InitializeComponent();

            this.Text = "Редактировать водителя";
            setInfo(row);
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void setInfo(DataRow row)
        {
            id = (int)row["id"];
            tbFirstName.Text = row["first_name"].ToString();
            tbLastName.Text = row["last_name"].ToString();
            tbPartherName.Text = row["parther_name"].ToString();
        }
    }
}
