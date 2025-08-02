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
    public class DiemDuLichBL
    {
        private DiemDuLichDL diemdl;
        public DiemDuLichBL()
        {
            diemdl = new DiemDuLichDL();
        }
        public List<DiemDuLich> GetDiemDuLiches()
        {
            try
            {
                return diemdl.GetDiemDuLich();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int ThemDDL(DiemDuLich d)
        {
            if (string.IsNullOrWhiteSpace(d.TenDDL))
                throw new ArgumentException("Tên điểm du lịch và loại Tour không được để trống.");

            d.MaDDL = diemdl.GenerateMaDiemDuLich();

            return diemdl.Insert(d);
        }
        public int SuaDDL(DiemDuLich d)
        {
            if (string.IsNullOrWhiteSpace(d.TenDDL) )
                throw new ArgumentException("Tên điểm du lịch và loại Tour không được để trống.");

            return diemdl.Update(d);
        }
        public int XoaDiemDuLich(string maDDL)
        {
            return diemdl.Delete(maDDL);
        }
    }
}
