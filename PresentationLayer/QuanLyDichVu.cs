using BusinessLayer;
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
using TransferObject.DichVu;

namespace PresentationLayer
{
    public partial class QuanLyDichVu: Form
    {
        private DiemKhoiHanhBL diemkhbl;
        private PhuongTienTourBL ptientourbl;
        private DiemDuLichBL diemdlbl;
        private void LoadLoaiTourComboBox()
        {
            var loaiTourBL = new LoaiTourBL();  
            var dsLoaiTour = loaiTourBL.GetAllLoaiTour();

            cmbLoaiTourDL.DataSource = dsLoaiTour;
            cmbLoaiTourDL.DisplayMember = "TenLoaiTour";   
            cmbLoaiTourDL.ValueMember = "MaLoaiTour";     
            cmbLoaiTourDL.SelectedIndex = 0;
        }
        public QuanLyDichVu()
        {
            InitializeComponent();
            diemkhbl = new DiemKhoiHanhBL();
            ptientourbl = new PhuongTienTourBL();
            diemdlbl = new DiemDuLichBL();
            if (dgvDiemDuLich.Columns.Contains("MaLoaiTour"))
                dgvDiemDuLich.Columns["MaLoaiTour"].Visible = false;

            LoadLoaiTourComboBox();
        }

        private void QuanLyDichVu_Load(object sender, EventArgs e)
        {
            try
            {
                dgvDiemKhoiHanh.DataSource = diemkhbl.GetDiemKhoiHanhs();
                dgvPhuongTien.DataSource = ptientourbl.GetPhuongTienTours();
                dgvDiemDuLich.DataSource = diemdlbl.GetDiemDuLiches();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Diem khoi hanh
        private void btnAddKH_Click(object sender, EventArgs e)
        {
            try
            {
                var dto = new DiemKhoiHanh
                { DiaDiemXP=txtTenDiemKhoiHanh.Text.Trim() };

                if (diemkhbl.Them(dto)>0)
                {
                    MessageBox.Show("Thêm thành công!");
                    dgvDiemKhoiHanh.DataSource = diemkhbl.GetDiemKhoiHanhs();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void dgvDiemKhoiHanh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDiemKhoiHanh.Rows[e.RowIndex];
                txtTenDiemKhoiHanh.Text = row.Cells[1].Value.ToString();
                txtMaDiemKhoiHanh.Text = row.Cells[0].Value.ToString();
            }
        }
        private void btnUpdateKH_Click(object sender, EventArgs e)
        {
            try
            {
                var dto = new DiemKhoiHanh
                {
                    MaXP = txtMaDiemKhoiHanh.Text.Trim(),
                    DiaDiemXP = txtTenDiemKhoiHanh.Text.Trim()
                };

                if (diemkhbl.Sua(dto) > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    dgvDiemKhoiHanh.DataSource = diemkhbl.GetDiemKhoiHanhs();
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
        private void btnDeleteKH_Click(object sender, EventArgs e)
        {
            if (txtMaDiemKhoiHanh.Text == "")
            {
                MessageBox.Show("Vui lòng chọn mã điểm khởi hành để xóa.");
                return;
            }

            string maXP = txtMaDiemKhoiHanh.Text;
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (diemkhbl.XoaDiemKhoiHanh(maXP)>0)
                {
                    MessageBox.Show("Xóa thành công!");
                    dgvDiemKhoiHanh.DataSource = diemkhbl.GetDiemKhoiHanhs();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
        }

        private void btnRefreshKH_Click(object sender, EventArgs e)
        {
            txtMaDiemKhoiHanh.Clear();
            txtTenDiemKhoiHanh.Clear();
        }

        //Phuong Tien Tour 
        private void btnThemPT_Click(object sender, EventArgs e)
        {
            try
            {
                var dto = new PhuongTienTour
                { TenPhuongTien = txtTenPhuongTien.Text.Trim() };

                if (ptientourbl.ThemPT(dto) > 0)
                {
                    MessageBox.Show("Thêm thành công!");
                    dgvPhuongTien.DataSource = ptientourbl.GetPhuongTienTours();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dgvPhuongTien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPhuongTien.Rows[e.RowIndex];
                txtTenPhuongTien.Text = row.Cells[1].Value.ToString();
                txtMaPhuongTien.Text = row.Cells[0].Value.ToString();
            }
        }

        private void btnSuaPT_Click(object sender, EventArgs e)
        {
            try
            {
                var dto = new PhuongTienTour
                {
                    MaPhuongTien = txtMaPhuongTien.Text.Trim(),
                    TenPhuongTien = txtTenPhuongTien.Text.Trim()
                };

                if (ptientourbl.Sua(dto) > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    dgvPhuongTien.DataSource = ptientourbl.GetPhuongTienTours();
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

        private void btnXoaPT_Click(object sender, EventArgs e)
        {
            if (txtMaPhuongTien.Text == "")
            {
                MessageBox.Show("Vui lòng chọn mã điểm khởi hành để xóa.");
                return;
            }

            string maPT = txtMaPhuongTien.Text;
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (ptientourbl.XoaPTienTour(maPT) > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    dgvPhuongTien.DataSource = ptientourbl.GetPhuongTienTours();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
        }

        private void btnRefreshPT_Click(object sender, EventArgs e)
        {
            txtMaPhuongTien.Clear();
            txtTenPhuongTien.Clear();
        }
        //DiemDuLich
        private void btnThemDL_Click(object sender, EventArgs e)
        {
            try
            {
                var dto = new DiemDuLich
                { TenDDL = txtTenDiemDen.Text.Trim(),
                  MaLoaiTour = cmbLoaiTourDL.SelectedValue.ToString()};

                if (diemdlbl.ThemDDL(dto) > 0)
                {
                    MessageBox.Show("Thêm thành công!");
                    dgvDiemDuLich.DataSource = diemdlbl.GetDiemDuLiches();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dgvDiemDuLich_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDiemDuLich.Rows[e.RowIndex];
                txtMaDiemDuLich.Text = row.Cells[0].Value.ToString();
                txtTenDiemDen.Text = row.Cells[1].Value.ToString();
                string maLoaiTour = row.Cells["MaLoaiTour"].Value.ToString();
                cmbLoaiTourDL.SelectedValue = maLoaiTour;
            }
        }

        private void btnSuaDL_Click(object sender, EventArgs e)
        {
            try
            {
                var dto = new DiemDuLich
                {
                    MaDDL = txtMaDiemDuLich.Text.Trim(),
                    TenDDL = txtTenDiemDen.Text.Trim(),
                    MaLoaiTour = cmbLoaiTourDL.SelectedValue?.ToString() ?? ""
                };

                if (diemdlbl.SuaDDL(dto) > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    dgvDiemDuLich.DataSource = diemdlbl.GetDiemDuLiches();
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

        private void btnXoaDL_Click(object sender, EventArgs e)
        {
            if (txtMaDiemDuLich.Text == "")
            {
                MessageBox.Show("Vui lòng chọn mã điểm khởi hành để xóa.");
                return;
            }

            string maDDL = txtMaDiemDuLich.Text;
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (diemdlbl.XoaDiemDuLich(maDDL) > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    dgvDiemDuLich.DataSource = diemdlbl.GetDiemDuLiches();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
        }
        private void btnRefreshDL_Click(object sender, EventArgs e)
        {
            txtMaDiemDuLich.Clear();
            txtTenDiemDen.Clear();
        }
    }    
}
