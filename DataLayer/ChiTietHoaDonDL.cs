using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TransferObject;

namespace DataLayer
{
    public class ChiTietHoaDonDL : DataProvider
    {
        public ChiTietHD LayChiTietHoaDon(string soHD)
        {
            string sql = @"
               SELECT hd.SoHD, hd.NgayLapHD, hd.SoLuongVe, hd.ThanhTien,
               kh.HoTen AS TenKH,
               tt.TenTour, xp.DiaDiemXP, pt.TenPhuongTien,
               tt.TGBatDau, tt.TGKetThuc
            FROM HOADON hd
            JOIN KHACHHANG kh ON hd.MaKH = kh.MaKH
            JOIN THONGTINTOUR tt ON hd.MaTour = tt.MaTour
            JOIN DIEMXUATPHAT xp ON tt.MaXP = xp.MaXP
            JOIN PHUONGTIENTOUR pt ON tt.MaPhuongTien=pt.MaPhuongTien
            WHERE hd.SoHD = @soHD";

            List<SqlParameter> parameters = new List<SqlParameter>
    {
        new SqlParameter("@soHD", soHD)
    };

            try
            {
                Connect();
                SqlDataReader reader = MyExcuteReader(sql, CommandType.Text, parameters);

                if (reader != null && reader.Read())
                {
                    var ct = new ChiTietHD
                    {
                        SoHD = reader["SoHD"].ToString(),
                        NgayLapHD = (DateTime)reader["NgayLapHD"],
                        SLVe = Convert.ToInt32(reader["SoLuongVe"]),
                        ThanhTien = reader["ThanhTien"] != DBNull.Value ? Convert.ToDecimal(reader["ThanhTien"]) : 0,
                        TenKH = reader["TenKH"].ToString(),
                        TenTour = reader["TenTour"].ToString(),
                        DiemXP = reader["DiaDiemXP"].ToString(),
                        TenPhuongTien = reader["TenPhuongTien"].ToString(),
                        TGBatDau = (DateTime)reader["TGBatDau"],
                        TGKetThuc = (DateTime)reader["TGKetThuc"]
                    };
                    reader.Close();
                    return ct;
                }

                reader?.Close();
                return null;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                Disconnect();
            }
        }
    }
}
