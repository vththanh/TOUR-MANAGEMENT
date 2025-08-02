using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class Account
    {
        public Account()
        {
        }

        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string MaNV { get; set; }

        public Account(string tenDangNhap, string matKhau)
        {
            this.TenDangNhap = tenDangNhap;
            this.MatKhau = matKhau;
        }
    }
}
