using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferObject;

namespace PresentationLayer
{
    public partial class QuanLyNhanVien: Form
    {
        private NhanVienBL nvbl = new NhanVienBL();
        private string tenDangNhap;
        public QuanLyNhanVien(string tenDangNhap)
        {
            InitializeComponent();
            this.tenDangNhap = tenDangNhap;
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            // Gắn lại vị trí của grBoxNV theo vị trí của dgvNhanVien
            grBoxNV.Top = dgvNhanVien.Bottom + 10;
            grBoxNV.Left = (this.ClientSize.Width - grBoxNV.Width) / 2;
            try
            {
                dgvNhanVien.DataSource = nvbl.GetNhanViens();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;

            if (i >= 0)
            {
                txtMaNV.Text = dgvNhanVien.Rows[i].Cells["MaNV"].Value.ToString();
                txtHoTen.Text = dgvNhanVien.Rows[i].Cells["HoTen"].Value.ToString();
                cboGioiTinh.Text = dgvNhanVien.Rows[i].Cells["GioiTinh"].Value.ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(dgvNhanVien.Rows[i].Cells["NgaySinh"].Value);
                txtEmail.Text = dgvNhanVien.Rows[i].Cells["Email"].Value.ToString();
                txtDiaChi.Text = dgvNhanVien.Rows[i].Cells["DiaChi"].Value.ToString();
                txtSDT.Text = dgvNhanVien.Rows[i].Cells["SDT"].Value.ToString();
                cbCviec.SelectedItem = dgvNhanVien.Rows[i].Cells["MaCV"].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien nv = new NhanVien
                {
                    MaNV = txtMaNV.Text.Trim(),
                    HoTen = txtHoTen.Text.Trim(),
                    GioiTinh = cboGioiTinh.SelectedItem?.ToString(),
                    NgaySinh = dtpNgaySinh.Value,
                    Email = txtEmail.Text.Trim(),
                    DiaChi = txtDiaChi.Text.Trim(),
                    SDT = txtSDT.Text.Trim(),
                    MaCV = cbCviec.Text.Trim()
                };

                if (nvbl.CapNhat(nv) > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    dgvNhanVien.DataSource = nvbl.GetNhanViens();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtHoTen.Clear();
            cboGioiTinh.SelectedItem = -1;
            dtpNgaySinh.Value = DateTime.Now;
            txtEmail.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            cbCviec.SelectedItem = -1;
        }
    }
}
