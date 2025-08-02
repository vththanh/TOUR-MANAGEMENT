using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string MaCV { get; set; }

        public NhanVien(string maNV, string hoTen, string gioiTinh, DateTime ngaySinh, string email, string diaChi, string sDT, string maCV)
        {
            this.MaNV = maNV;
            this.HoTen = hoTen;
            this.GioiTinh = gioiTinh;
            this.NgaySinh = ngaySinh;
            this.Email = email;
            this.DiaChi = diaChi;
            this.SDT = sDT;
            this.MaCV = maCV;
        }
        public NhanVien() { }
    }

}
