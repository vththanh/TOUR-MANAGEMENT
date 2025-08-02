using BusinessLayer;
using PresentationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Main : Form
    {
        private string tenDangNhap;
        private Form currentFormChild;
        public Main(string tenDangNhap)
        {
            InitializeComponent();
            this.tenDangNhap = tenDangNhap;
        }        

        private void OpenChildForm(Form FormCon)
        {
            if (FormCon.IsDisposed)
            {
                // Tạo lại instance mới nếu form đã bị dispose
                if (FormCon.GetType() == typeof(QuanLyNhanVien))
                {
                    FormCon = new QuanLyNhanVien(tenDangNhap); // cần truyền lại tham số nếu có
                }
                else
                {
                    FormCon = (Form)Activator.CreateInstance(FormCon.GetType());
                }
            }
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            currentFormChild = FormCon;

            FormCon.TopLevel = false;
            FormCon.FormBorderStyle = FormBorderStyle.None;
            FormCon.Dock = DockStyle.Fill;
            pnlContent.Controls.Clear(); // tránh chồng form
            pnlContent.Controls.Add(FormCon);
            pnlContent.Tag = FormCon;

            FormCon.BringToFront();
            FormCon.Show();
        }
        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TrangChu(tenDangNhap));
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DangNhap dnhap = new DangNhap();
            this.Hide();
            DialogResult result = dnhap.ShowDialog();
            this.Close();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            OpenChildForm(new TrangChu(tenDangNhap));
            NhanVienBL nvbl = new NhanVienBL();
            string hoTen = nvbl.LayHoTenTheoTenDangNhap(tenDangNhap);
            lblUserInfo.Text = $"Xin chào, {hoTen}";
        }

        private void btnQLDVu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyDichVu());
           
        }
        private void btnQLNV_Click(object sender, EventArgs e)
        {
            NhanVienBL nvbl = new NhanVienBL();
            string maCVu = nvbl.LayChucVuTheoTenDangNhap(tenDangNhap);

            if (maCVu?.Trim().ToUpper() != "QL")
            {
                MessageBox.Show("Chức năng này chỉ dành cho quản lý!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            OpenChildForm(new QuanLyNhanVien(tenDangNhap));
        }
        private void btnQLKHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyKhachHang());

        }
        private void btnQLTour_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyTour());
        }

        private void btnQLHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyHoaDon());
        }

        private void btnTour_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Tours(tenDangNhap));
        }

        private void btnTke_Click(object sender, EventArgs e)
        {
            NhanVienBL nvbl = new NhanVienBL();
            string maCVu = nvbl.LayChucVuTheoTenDangNhap(tenDangNhap);

            if (maCVu?.Trim().ToUpper() != "QL")
            {
                MessageBox.Show("Chức năng này chỉ dành cho quản lý!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            OpenChildForm(new BaoCaoThongKe());
        }
    }
}
