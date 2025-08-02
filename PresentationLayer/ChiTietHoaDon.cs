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
    public partial class ChiTietHoaDon: Form
    {
        ChiTietHoaDonBL cthdbl = new ChiTietHoaDonBL();
        private string maHD;
        private ChiTietHD cthd;

        public ChiTietHoaDon(string soHD)
        {
            InitializeComponent();
            maHD = soHD;
        }

        private void ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maHD))
            {
                MessageBox.Show("Không có mã hóa đơn để hiển thị!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            cthd = cthdbl.LayThongTinChiTiet(maHD);

            if (cthd != null)
            {
                lbSoHD.Text = cthd.SoHD;
                lbTenKH.Text = cthd.TenKH;
                lbNgayLap.Text = cthd.NgayLapHD.ToString("dd/MM/yyyy");
                lbThanhTien.Text = cthd.ThanhTien.ToString("N0"); 
                lbTenTour.Text = cthd.TenTour;
                lbDiemXP.Text = cthd.DiemXP;
                lbPTien.Text = cthd.TenPhuongTien;
                lbNgayDi.Text = cthd.TGBatDau.ToString("dd/MM/yyyy");
                lbNgayKT.Text = cthd.TGKetThuc.ToString("dd/MM/yyyy");
                lbSoVe.Text = cthd.SLVe.ToString(); 
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font fontTitle = new Font("Times New Roman", 18, FontStyle.Bold);
            Font fontContent = new Font("Arial", 12, FontStyle.Regular);
            Brush brush = Brushes.Black;

            float y = 100;

            e.Graphics.DrawString("HÓA ĐƠN DU LỊCH", fontTitle, Brushes.DarkRed, new PointF(250, y));
            y += 50;

            if (cthd != null)
            {
                e.Graphics.DrawString("Số HĐ: " + cthd.SoHD, fontContent, brush, new PointF(50, y)); y += 30;
                e.Graphics.DrawString("Khách hàng: " + cthd.TenKH, fontContent, brush, new PointF(50, y)); y += 30;
                e.Graphics.DrawString("Ngày lập: " + cthd.NgayLapHD.ToString("dd/MM/yyyy"), fontContent, brush, new PointF(50, y)); y += 30;
                e.Graphics.DrawString("Tên tour: " + cthd.TenTour, fontContent, brush, new PointF(50, y)); y += 30;
                e.Graphics.DrawString("Điểm xuất phát: " + cthd.DiemXP, fontContent, brush, new PointF(50, y)); y += 30;
                e.Graphics.DrawString("Phương tiện: " + cthd.TenPhuongTien, fontContent, brush, new PointF(50, y)); y += 30;
                e.Graphics.DrawString("Ngày đi: " + cthd.TGBatDau.ToString("dd/MM/yyyy"), fontContent, brush, new PointF(50, y)); y += 30;
                e.Graphics.DrawString("Ngày kết thúc: " + cthd.TGKetThuc.ToString("dd/MM/yyyy"), fontContent, brush, new PointF(50, y)); y += 30;
                e.Graphics.DrawString("Số vé: " + cthd.SLVe.ToString(), fontContent, brush, new PointF(50, y)); y += 30;
                e.Graphics.DrawString("Thành tiền: " + cthd.ThanhTien.ToString("N0") + " VND", fontContent, brush, new PointF(50, y)); y += 40;
            }
            else
            {
                e.Graphics.DrawString("Không có dữ liệu hóa đơn để in.", fontContent, Brushes.Red, new PointF(50, y));
            }

            e.Graphics.DrawString("Cảm ơn quý khách. Chúc chuyến đi vui vẻ!", fontContent, brush, new PointF(50, y));
        
    }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
