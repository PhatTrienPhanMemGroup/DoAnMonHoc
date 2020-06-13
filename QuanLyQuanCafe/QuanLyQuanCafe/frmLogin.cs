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
    public partial class frmLogin : Form
    {
        UserManagement userManagement = new UserManagement();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống " + lblUsername.Text.ToLower());
                this.txtUsername.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Không được bỏ trống " + lblPassword.Text.ToLower());
                this.txtPassword.Focus();
                return;
            }
            if (userManagement.Check_Config() == 0)
                ProcessLogin();
            if (userManagement.Check_Config() == 1)
            {
                MessageBox.Show("Chuỗi cấu hình không tồn tại");
                ProcessConfig();
            }
            if (userManagement.Check_Config() == 2)
            {
                MessageBox.Show("Chuỗi cấu hình không đúng");
                ProcessConfig();
            }
        }
        private void ProcessConfig()
        {
            frmConfig config = new frmConfig();
            this.Hide();
            config.ShowDialog();
            this.Show();
        }

        private void ProcessLogin()
        {
            int result;
            result = userManagement.Check_User(txtUsername.Text, txtPassword.Text);
            if (result == 0) //Tài khoản không tồn tại
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                return;
            }
            else if (result == 1)
            {
                MessageBox.Show("Tài khoản bị khóa");
                return;
            }

            frmMain main = new frmMain();
            this.Hide();
            main.ShowDialog();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chứ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
