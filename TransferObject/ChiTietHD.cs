using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class ChiTietHD
    {
        public string SoHD { get; set; }
        public string TenNV { get; set; }
        public string TenKH { get; set; }
        public DateTime NgayLapHD { get; set; }
        public int SLVe { get; set; }
        public decimal ThanhTien { get; set; }
        public string TenTour { get; set; }
        public string DiemXP { get; set; }
        public string TenPhuongTien { get; set; }
        public DateTime TGBatDau { get; set; }
        public DateTime TGKetThuc { get; set; }
        public int SLVeConLai { get; set; }

        public ChiTietHD(string soHD, string tenNV, string tenKH, DateTime ngayLap,
                                int slVe, decimal thanhTien, string tenTour, string diemXP,
                                string tenPT, DateTime tgBD, DateTime tgKT, int slVeConLai)
        {
            this.SoHD = soHD;
            this.TenNV = tenNV;
            this.TenKH = tenKH;
            this.NgayLapHD = ngayLap;
            this.SLVe = slVe;
            this.ThanhTien = thanhTien;
            this.TenTour = tenTour;
            this.DiemXP = diemXP;
            this.TenPhuongTien = tenPT;
            this.TGBatDau = tgBD;
            this.TGKetThuc = tgKT;
            this.SLVeConLai = slVeConLai;
        }
        public ChiTietHD() { }
    }
}
