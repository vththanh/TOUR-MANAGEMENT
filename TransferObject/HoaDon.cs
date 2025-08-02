using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class HoaDon
    {

        public string SoHD { get; set; }
        public string MaNV { get; set; }
        public string MaKH { get; set; }
        public string MaTour { get; set; }
        public int  SoLuongVe { get; set; }
        public DateTime NgayDangKy { get; set; }
        public DateTime NgayLapHD { get; set; }
        public decimal ThanhTien { get; set; }

        public HoaDon() { }

        public HoaDon(string soHD, string maNV, string maKH, string maTour, int soLuongVe, DateTime ngayDangKy, DateTime ngayLapHD, decimal thanhTien)
        {
            this.SoHD = soHD;
            this.MaNV = maNV;
            this.MaKH = maKH;
            this.MaTour = maTour;
            this.SoLuongVe = soLuongVe;
            this.NgayDangKy = ngayDangKy;
            this.NgayLapHD = ngayLapHD;
            this.ThanhTien = thanhTien;

        }
    }
}

