using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class BaoCaoDL:DataProvider
    {
        // Lấy doanh thu theo khoảng thời gian
        public DataTable LayDoanhThuTheoThoiGian(DateTime tuNgay, DateTime denNgay)
        {
            string sql = "SELECT CONVERT(varchar, t.TGBatDau, 103) AS Ngay, SUM(h.ThanhTien) AS DoanhThu " +
             "FROM THONGTINTOUR t, HOADON h " +
             "WHERE t.MaTour=h.MaTour AND t.TGBatDau BETWEEN @tuNgay AND @denNgay " +
             "GROUP BY t.TGBatDau " +
             "ORDER BY t.TGBatDau";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@tuNgay", tuNgay));
            parameters.Add(new SqlParameter("@denNgay", denNgay));
            try
            {
                return MyDataTable(sql, CommandType.Text,parameters);
            }
            catch(SqlException ex)
            {
                throw ex;
            }            
        }
        // Lấy doanh thu theo loại tour
        public DataTable LayDoanhThuTheoLoaiTour()
        {
            string sql = @"
                SELECT LT.TenLoaiTour AS LoaiTour, SUM(H.ThanhTien) AS DoanhThu, COUNT(*) AS SoLuong
                FROM LOAITOUR LT, THONGTINTOUR T, HOADON H
                WHERE LT.MaLoaiTour=T.MaLoaiTour AND T.MaTour=H.MaTour
                GROUP BY LT.TenLoaiTour";
            try
            {
                return MyDataTable(sql, CommandType.Text);
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }
    }
}
