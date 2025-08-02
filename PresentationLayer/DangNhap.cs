using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using TransferObject;
using System.Data.SqlClient;

namespace PresentationLayer
{
    public partial class DangNhap : Form
    {
        private LoginBL loginBL;
        public DangNhap()
        {
            InitializeComponent();
            loginBL = new LoginBL();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "Nhập mật khẩu")
                txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            DangKy dangKy = new DangKy();
            this.Hide();
            DialogResult result = dangKy.ShowDialog();
            this.Close();
        }
        private bool UserLogin(Account acc)
        {
            try
            {
                return loginBL.Login(acc);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = txtUsername.Text.Trim();
            pass = txtPassword.Text;
            Account account = new Account(user, pass);
            if (UserLogin(account) == true)
            {
                Main main = new Main(user);
                this.Hide();
                DialogResult result = main.ShowDialog();
                this.Close();
            }
            else
            {
                string msg = "User and password are incorrect!";
                DialogResult result = MessageBox.Show(msg, "Login", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Cancel)
                {
                    txtUsername.Focus();
                    txtPassword.Clear();
                }
                else
                    this.DialogResult = DialogResult.Cancel;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


