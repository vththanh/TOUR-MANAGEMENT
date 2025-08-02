using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TransferObject;

namespace DataLayer
{
    public class DatTourDL : DataProvider
    {
        public Ve LayThongTinTour(string maTour)
        {
            string query = @"
                SELECT tt.MaTour, tt.TenTour, xp.DiaDiemXP, pt.TenPhuongTien,
                       tt.TGBatDau, tt.TGKetThuc, tt.GiaTour
                FROM THONGTINTOUR tt
                JOIN DIEMXUATPHAT xp ON tt.MaXP = xp.MaXP
                JOIN PHUONGTIENTOUR pt ON tt.MaPhuongTien = pt.MaPhuongTien
                WHERE tt.MaTour = @maTour";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@maTour", maTour)
            };

            try
            {
                SqlDataReader reader = MyExcuteReader(query, CommandType.Text, parameters);
                if (reader != null && reader.Read())
                {
                    Ve ve = new Ve
                    {
                        MaTour = reader["MaTour"].ToString(),
                        TenTour = reader["TenTour"].ToString(),
                        DiaDiemXP = reader["DiaDiemXP"].ToString(),
                        TenPhuongTien = reader["TenPhuongTien"].ToString(),
                        TGBatDau = reader["TGBatDau"] != DBNull.Value ? Convert.ToDateTime(reader["TGBatDau"]) : DateTime.MinValue,
                        TGKetThuc = reader["TGKetThuc"] != DBNull.Value ? Convert.ToDateTime(reader["TGKetThuc"]) : DateTime.MinValue,
                        Gia = reader["GiaTour"] != DBNull.Value ? Convert.ToDecimal(reader["GiaTour"]) : 0,
                        ThanhTien = reader["GiaTour"] != DBNull.Value ? Convert.ToDecimal(reader["GiaTour"]) : 0
                    };
                    reader.Close(); 
                    return ve;
                }

                reader?.Close();
                return null;
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi khi lấy thông tin tour: " + ex.Message);
            }
        }
    }
}
