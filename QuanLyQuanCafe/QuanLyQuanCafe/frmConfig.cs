using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class frmConfig : Form
    {
        UserManagement userManagement = new UserManagement();
        public frmConfig()
        {
            InitializeComponent();
        }
        private void cboServername_DropDown(object sender, EventArgs e)
        {
            cboServername.DataSource = userManagement.GetServerName();
            cboServername.DisplayMember = "Servername";
        }

        private void cboDatabase_DropDown(object sender, EventArgs e)
        {
            cboDatabase.DataSource = userManagement.GetDBName(cboServername.Text, txtUsername.Text, txtPassword.Text);
            cboDatabase.DisplayMember = "Name";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            userManagement.SaveConfig(cboServername.Text, txtUsername.Text, txtPassword.Text, cboDatabase.Text);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
