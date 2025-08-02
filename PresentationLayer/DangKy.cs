using PresentationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using TransferObject;

namespace PresentationLayer
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void returnDN()
        {
            DangNhap dnhap = new DangNhap();
            this.Hide();
            DialogResult result = dnhap.ShowDialog();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            returnDN();
        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            returnDN();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text.Trim();
                string maNhap = txtMaXacThuc.Text.Trim();

                if (!DangKyBL.KiemTraMa(email, maNhap))
                {
                    MessageBox.Show("Mã xác thực không đúng hoặc chưa được gửi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string tenDangNhap = txtUsername.Text.Trim();
                string matKhau = txtPassword.Text.Trim();

                NhanVien nv = new NhanVien
                {
                    HoTen = txtFullName.Text.Trim(),
                    GioiTinh = cboGender.SelectedItem?.ToString(),
                    NgaySinh = dtpDateofBirth.Value,
                    Email = email,
                    DiaChi = txtAddress.Text.Trim(),
                    SDT = txtPhone.Text.Trim(),
                    MaCV = cboUserRole.SelectedItem.ToString() == "Quản lý" ? "QL" : "NV"
                };

                Account tk = new Account
                {
                    TenDangNhap = tenDangNhap,
                    MatKhau = matKhau
                };

                DangKyBL dangKyBL = new DangKyBL();
                if (dangKyBL.DangKy(nv, tk))
                {
                    MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    returnDN(); 
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuiMa_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập email.");
                return;
            }

            DangKyBL.GuiMaXacThuc(email);
            MessageBox.Show("Mã xác thực đã được gửi tới email.");
        }
    }
}
