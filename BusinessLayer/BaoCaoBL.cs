using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BaoCaoBL
    {
        private BaoCaoDL baoCaoDL = new BaoCaoDL();

        public DataTable GetRevenueByTime(DateTime tuNgay, DateTime denNgay)
        {
            return baoCaoDL.LayDoanhThuTheoThoiGian(tuNgay, denNgay);
        }

        public DataTable GetRevenueByTourType()
        {
            return baoCaoDL.LayDoanhThuTheoLoaiTour();
        }
    }
}
