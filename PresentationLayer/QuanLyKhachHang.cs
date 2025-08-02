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
    public partial class QuanLyKhachHang: Form
    {
        private KhachHangBL khbl = new KhachHangBL();
        public QuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                dgvKH.DataSource = khbl.GetKhachHangs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách khách  : " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;

            if (i >= 0)
            {
                txtMaKH.Text = dgvKH.Rows[i].Cells["MaKH"].Value.ToString();
                txtTenKH.Text = dgvKH.Rows[i].Cells["HoTen"].Value.ToString();
                txtSdt.Text = dgvKH.Rows[i].Cells["Sdt"].Value.ToString();
                txtEmail.Text = dgvKH.Rows[i].Cells["Email"].Value.ToString();

                string gioiTinh = dgvKH.Rows[i].Cells["GioiTinh"].Value.ToString();
                if (gioiTinh == "Nam") rdoNam.Checked = true;
                else if (gioiTinh == "Nữ") rdoNu.Checked = true;

            }
        }

        private void btnTimKH_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKH.Text.Trim();
            dgvKH.DataSource = khbl.SearchByName(keyword);
        }
        private void LamMoi(object sender, EventArgs e)
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtSdt.Clear();
            txtEmail.Clear();
            rdoNam.Checked = false;
            rdoNu.Checked = false;

            dgvKH.DataSource = khbl.GetKhachHangs();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text.Trim();
            if (string.IsNullOrEmpty(maKH))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa.");
                return;
            }

            string gioiTinh = rdoNam.Checked ? "Nam" : "Nữ";

            KhachHang kh = new KhachHang(
                maKH,
                txtTenKH.Text.Trim(),
                gioiTinh,
                txtSdt.Text.Trim(),
                txtEmail.Text.Trim()
            );

            bool kq = khbl.Sua(kh);
            if (kq)
            {
                MessageBox.Show("Cập nhật thành công");
                dgvKH.DataSource = khbl.GetKhachHangs();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text.Trim();

            if (string.IsNullOrEmpty(maKH))
            {
                MessageBox.Show("Vui lòng chọn khách hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (khbl.KiemTraKhachHangCoHoaDon(maKH))
            {
                MessageBox.Show("Không thể xóa khách hàng vì đang có hóa đơn.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc muốn xóa khách hàng này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                bool ketQua = khbl.XoaKhachHang(maKH); 
                if (ketQua)
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvKH.DataSource = khbl.GetKhachHangs();
                    LamMoi(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
