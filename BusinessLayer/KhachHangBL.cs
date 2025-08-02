using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataLayer;
using TransferObject;

namespace BusinessLayer
{
    public class KhachHangBL
    {
        private KhachHangDL khdl;

        public KhachHangBL()
        {
            khdl = new KhachHangDL();
        }

        public List<KhachHang> GetKhachHangs()
        {
            try
            {
                return khdl.GetKhachHang();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public List<KhachHang> SearchByName(string keyword)
        {
            try
            {
                return khdl.SearchKhachHangByName(keyword);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public bool Sua(KhachHang kh)
        {
            return khdl.Update(kh);
        }
        public string Them(KhachHang kh)
        {
            if (string.IsNullOrWhiteSpace(kh.HoTen))
                throw new ArgumentException("Tên khách hàng không được để trống.");

            return khdl.Insert(kh);
        }
        public bool KiemTraKhachHangCoHoaDon(string maKH)
        {
            return khdl.KhachHangCoHoaDon(maKH);
        }
        public bool XoaKhachHang(string maKH)
        {
            return khdl.DeleteKhachHang(maKH);
        }
    }

}
