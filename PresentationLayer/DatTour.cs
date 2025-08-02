using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferObject;

namespace PresentationLayer
{
    public partial class DatTour : Form
    {

        private DatTourBL vebl = new DatTourBL();
        private KhachHangBL khbl = new KhachHangBL();
        private HoaDonBL hdbl = new HoaDonBL();
        NhanVienBL nvbl = new NhanVienBL();
        private Ve ve;
        private Tour tour;
        private string tenDangNhap;

        public DatTour(Tour tour, string tenDangNhap)
        {
            InitializeComponent();
            this.tour = tour;
            this.tenDangNhap = tenDangNhap;
        }

        private void DatTour_Load(object sender, EventArgs e)
        {
            if (tour != null)
            {
                lbMaTour.Text = tour.MaTour;
                txtTenTour.Text = tour.TenTour;
                lbGiaTour.Text = tour.GiaTour.ToString("N0");
                lbXuatPhat.Text = tour.MaXP;
                lbPhuongTien.Text = tour.MaPhuongTien;
                lbTGBatDau.Text = tour.TGBatDau.ToString("dd/MM/yyyy");
                lbTGKetThuc.Text = tour.TGKetThuc.ToString("dd/MM/yyyy");

                string pathAnh = Path.Combine(Application.StartupPath, "AnhTour", tour.AnhTour);

                if (File.Exists(pathAnh))
                {
                    ptbAnhTour.Image = Image.FromFile(pathAnh);
                }
                else
                {
                    ptbAnhTour.Image = null;
                }
                ve = vebl.LayThongTinTour(tour.MaTour);
            }
            else
            {
                MessageBox.Show("Dữ liệu tour không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                if (grTTKH.Visible == false)
                {
                    MessageBox.Show("Vui lòng nhập thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtSLVe.Text))
                {
                    MessageBox.Show("Vui lòng nhập số lượng vé!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int soLuongVe;
                if (!int.TryParse(txtSLVe.Text.Trim(), out soLuongVe) || soLuongVe <= 0)
                {
                    MessageBox.Show("Số lượng vé không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string maNV = nvbl.LayMaNVTheoTenDangNhap(tenDangNhap);
                string tenKH = txtHoTenKH.Text.Trim();
                string sdt = txtSDT.Text.Trim();
                string email = txtEmail.Text.Trim();
                string gioiTinh = rdoNam.Checked ? "Nam" : (rdoNu.Checked ? "Nữ" : null);

                if (string.IsNullOrEmpty(tenKH) || string.IsNullOrEmpty(sdt))
                {
                    MessageBox.Show("Hãy nhập đủ thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                KhachHang newKH = new KhachHang
                {

                    HoTen = tenKH,
                    SDT = sdt,
                    Email = email,
                    GioiTinh = gioiTinh
                };
                string maKH = khbl.Them(newKH);
                if (maKH == null)
                {
                    MessageBox.Show("Thêm khách hàng thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal thanhTien;
                bool isValidThanhTien = decimal.TryParse(lbThanhTien.Text.Replace(",", "").Trim(), out thanhTien);
                if (!isValidThanhTien || thanhTien <= 0)
                {
                    MessageBox.Show("Thành tiền không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                HoaDon hoaDon = new HoaDon
                {
                    MaKH = maKH,
                    MaNV = maNV,
                    MaTour = lbMaTour.Text.Trim(),
                    SoLuongVe = soLuongVe,
                    ThanhTien = thanhTien,
                    NgayLapHD = DateTime.Now,
                    NgayDangKy = DateTime.Now
                };

                string soHD = hdbl.XuLyThanhToan(hoaDon);

                if (!string.IsNullOrEmpty(soHD))
                {
                    MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ChiTietHoaDon frmCTHD = new ChiTietHoaDon(soHD);
                    frmCTHD.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi lưu hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thanh toán: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSLVe_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;

            if ((txtSLVe.Text == "") || ctr.Text.Length > 0 && !Char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
            {
                this.errorProvider1.SetError(ctr, "Hãy nhập đúng số lượng vé");
            }
            else
            {
                int slg;
                if (int.TryParse(txtSLVe.Text.Trim(), out slg) && slg > 0)
                {
                    decimal thanhtien = vebl.TinhThanhTien(ve, slg);
                    lbThanhTien.Text = thanhtien.ToString("N0");
                    lbThanhTien.Visible = true;
                    this.errorProvider1.Clear();
                }
                else
                {
                    this.errorProvider1.SetError(ctr, "Số lượng vé phải là một số dương hợp lệ.");
                }
            }
        }

        private void lbXuatPhat_Click(object sender, EventArgs e)
        {

        }

        private void lbPhuongTien_Click(object sender, EventArgs e)
        {

        }

        private void lbGiaTour_Click(object sender, EventArgs e)
        {

        }

        private void lbThanhTien_Click(object sender, EventArgs e)
        {

        }
    }
}