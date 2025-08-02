using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TransferObject;

namespace BusinessLayer
{
    public class NhanVienBL
    {
        private NhanVienDL nvdl;
        public NhanVienBL()
        {
            nvdl = new NhanVienDL();
        }
        public string LayMaNVTheoTenDangNhap(string tenDangNhap)
        {
            return nvdl.GetMaNVByTenDangNhap(tenDangNhap);
        }
        public string LayHoTenTheoTenDangNhap(string tenDangNhap)
        {
            return nvdl.GetHoTenByTenDangNhap(tenDangNhap);
        }
        public string LayChucVuTheoTenDangNhap(string tenDangNhap)
        {
            return nvdl.GetChucVuByTenDangNhap(tenDangNhap);
        }
        public List<NhanVien> GetNhanViens()
        {
            try
            {
                return nvdl.GetNhanVien();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int CapNhat(NhanVien nv)
        {
            return nvdl.Update(nv);
        }
    }
}
