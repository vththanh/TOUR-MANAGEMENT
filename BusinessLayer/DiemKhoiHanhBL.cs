using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject.DichVu;

namespace BusinessLayer
{
    public class DiemKhoiHanhBL
    {
        private DiemKhoiHanhDL diemkhdl;
        public DiemKhoiHanhBL()
        {
            diemkhdl = new DiemKhoiHanhDL();
        }
        public List<DiemKhoiHanh> GetDiemKhoiHanhs()
        {
            try
            {
                return diemkhdl.GetDiemKH();
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }
        public int Them(DiemKhoiHanh d)
        {
            if (string.IsNullOrWhiteSpace(d.DiaDiemXP))
                throw new ArgumentException("Tên điểm khởi hành không được để trống.");

            d.MaXP = diemkhdl.GenerateMaDiemKhoiHanh();

            return diemkhdl.Insert(d);
        }
        public int Sua(DiemKhoiHanh d)
        {
            if (string.IsNullOrWhiteSpace(d.DiaDiemXP))
                throw new ArgumentException("Tên điểm khởi hành không được để trống.");

            return diemkhdl.Update(d);
        }
        public int XoaDiemKhoiHanh(string maXP)
        {
            return diemkhdl.Delete(maXP);
        }
    }
}
