
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TransferObject;
using BusinessLayer;
using System.IO;

namespace PresentationLayer
{
    public partial class QuanLyTour : Form
    {
        private QuanLyTourBL quanlytourbl = new QuanLyTourBL();
        public QuanLyTour()
        {
            InitializeComponent();
        }
        private void LoadQuanLyTour()
        {
            try
            {
                dgvThongtinTour.DataSource = quanlytourbl.GetTours();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách tour  : " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void QuanLyTour_Load(object sender, EventArgs e)
        {
            LoadQuanLyTour();
        }

        private void dgvThongtinTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaTour.Enabled = false;
            int i = e.RowIndex;

            if (i >= 0)
            {
                txtMaTour.Text = dgvThongtinTour.Rows[i].Cells[0].Value.ToString();
                txtTenTour.Text = dgvThongtinTour.Rows[i].Cells[1].Value.ToString();
                txtMoTa.Text = dgvThongtinTour.Rows[i].Cells[2].Value.ToString();
                txtAnhTour.Text = dgvThongtinTour.Rows[i].Cells[3].Value.ToString();
                txtGiaTour.Text = dgvThongtinTour.Rows[i].Cells[4].Value.ToString();

                dptNgayBD.Value = Convert.ToDateTime(dgvThongtinTour.Rows[i].Cells[5].Value);
                dptNgayKT.Value = Convert.ToDateTime(dgvThongtinTour.Rows[i].Cells[6].Value);

                cboMaLoaiTour.SelectedItem = dgvThongtinTour.Rows[i].Cells[7].Value.ToString();
                cboMaPhuongTien.SelectedItem = dgvThongtinTour.Rows[i].Cells[8].Value.ToString();
                cboMaXuatPhat.SelectedItem = dgvThongtinTour.Rows[i].Cells[9].Value.ToString();
                cboMaDiemDuLich.SelectedItem = dgvThongtinTour.Rows[i].Cells[10].Value.ToString();

                string fileAnh = txtAnhTour.Text;
                string pathAnh = Path.Combine(Application.StartupPath, "AnhTour", fileAnh);

                if (File.Exists(pathAnh))
                    ptbThemAnh.Image = Image.FromFile(pathAnh);
                else
                    ptbThemAnh.Image = null; 
            }
        }

        private void btnSuaTour_Click(object sender, EventArgs e)
        {
            try
            {
                string maTour = txtMaTour.Text.Trim();
                if (string.IsNullOrEmpty(maTour))
                {
                    MessageBox.Show("Vui lòng chọn tour cần sửa.");
                    return;
                }

                Tour tour = new Tour
                {
                    MaTour = maTour, 
                    TenTour = txtTenTour.Text.Trim(),
                    MoTaTour = txtMoTa.Text.Trim(),
                    AnhTour = txtAnhTour.Text.Trim(),
                    GiaTour = decimal.Parse(txtGiaTour.Text.Trim()),
                    TGBatDau = dptNgayBD.Value,
                    TGKetThuc = dptNgayKT.Value,
                    MaLoaiTour = cboMaLoaiTour.Text.Trim(),
                    MaPhuongTien = cboMaPhuongTien.Text.Trim(),
                    MaXP = cboMaXuatPhat.Text.Trim(),
                    MaDDL = cboMaDiemDuLich.Text.Trim()
                };

                bool kq = quanlytourbl.SuaTour(tour);
                if (kq)
                {
                    MessageBox.Show("Cập nhật tour thành công!");
                    dgvThongtinTour.DataSource = quanlytourbl.GetTours();
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật tour!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa tour: " + ex.Message);
            }
        }

        private void btnThemTour_Click(object sender, EventArgs e)
        {
            txtMaTour.Enabled = true;
            try
            {
                string maTour = txtMaTour.Text.Trim();
                if (string.IsNullOrEmpty(maTour))
                {
                    maTour = quanlytourbl.GetNewMaTour(); 
                }

                Tour tour = new Tour
                {
                    MaTour = maTour,
                    TenTour = txtTenTour.Text.Trim(),
                    MoTaTour = txtMoTa.Text.Trim(),
                    AnhTour = txtAnhTour.Text.Trim(),
                    GiaTour = decimal.Parse(txtGiaTour.Text.Trim()),
                    TGBatDau = dptNgayBD.Value,
                    TGKetThuc = dptNgayKT.Value,
                    MaLoaiTour = cboMaLoaiTour.Text.Trim(),
                    MaPhuongTien = cboMaPhuongTien.Text.Trim(),
                    MaXP = cboMaXuatPhat.Text.Trim(),
                    MaDDL = cboMaDiemDuLich.Text.Trim()
                };

                quanlytourbl.ThemTour(tour);
                MessageBox.Show("Thêm tour thành công!");
                LoadQuanLyTour();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm tour: " + ex.Message);
            }
        }

        private void btnXoaTour_Click(object sender, EventArgs e)
        {
            try
            {
                string maTour = txtMaTour.Text.Trim();
                if (string.IsNullOrEmpty(maTour))
                {
                    MessageBox.Show("Vui lòng chọn tour để xóa.");
                    return;
                }

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tour này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    bool kq = quanlytourbl.XoaTour(maTour);
                    if (kq)
                    {
                        MessageBox.Show("Xóa tour thành công!");
                        dgvThongtinTour.DataSource = quanlytourbl.GetTours();
                    }
                    else
                    {
                        MessageBox.Show("Tour này đã có hóa đơn, không thể xóa!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa tour: " + ex.Message);
            }
        }
        private void ptbThemAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog.Title = "Chọn ảnh tour";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileName(openFileDialog.FileName);
                string sourcePath = openFileDialog.FileName;
                string destPath = Path.Combine(Application.StartupPath, "AnhTour");

                if (!Directory.Exists(destPath))
                    Directory.CreateDirectory(destPath);

                string fullDestPath = Path.Combine(destPath, fileName);
                File.Copy(sourcePath, fullDestPath, true); 

                txtAnhTour.Text = fileName; 
                ptbThemAnh.Image = Image.FromFile(fullDestPath); 
            }
        }
        private void LamMoi_Click(object sender, EventArgs e)
        {
            txtMaTour.Clear();
            txtTenTour.Clear();
            txtMoTa.Clear();
            txtAnhTour.Clear();
            txtGiaTour.Clear();

            dptNgayBD.Value = DateTime.Now;
            dptNgayKT.Value = DateTime.Now;

            if (cboMaLoaiTour.Items.Count > 0) cboMaLoaiTour.SelectedIndex = 0;
            if (cboMaPhuongTien.Items.Count > 0) cboMaPhuongTien.SelectedIndex = 0;
            if (cboMaXuatPhat.Items.Count > 0) cboMaXuatPhat.SelectedIndex = 0;
            if (cboMaDiemDuLich.Items.Count > 0) cboMaDiemDuLich.SelectedIndex = 0;

            ptbThemAnh.Image = null;
        }
    }
}
