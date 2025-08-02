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
    public class PhuongTienTourBL
    {
        private PhuongTienTourDL ptientourdl;
        public PhuongTienTourBL()
        {
            ptientourdl = new PhuongTienTourDL();
        }
        public List<PhuongTienTour> GetPhuongTienTours()
        {
            try
            {
                return ptientourdl.GetPTTour();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int ThemPT(PhuongTienTour d)
        {
            d.MaPhuongTien = ptientourdl.GeneratePhuongTienTour();
            if (string.IsNullOrWhiteSpace(d.TenPhuongTien))
                throw new ArgumentException("Tên phương tiện không được để trống.");           

            return ptientourdl.Insert(d);
        }
        public int Sua(PhuongTienTour d)
        {
            if (string.IsNullOrWhiteSpace(d.TenPhuongTien))
                throw new ArgumentException("Tên phương tiện không được để trống.");

            return ptientourdl.Update(d);
        }
        public int XoaPTienTour(string maPT)
        {
            return ptientourdl.Delete(maPT);
        }
    }
}
