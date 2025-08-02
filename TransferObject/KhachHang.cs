using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class KhachHang
    {
        public string MaKH { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }

        public KhachHang(string maKH, string hoTen, string gioiTinh, string sDT, string email)
        {
            this.MaKH = maKH;
            this.HoTen = hoTen;
            this.GioiTinh = gioiTinh;
            this.SDT = sDT;
            this.Email = email;
        }
        public KhachHang() { }
    }
}
