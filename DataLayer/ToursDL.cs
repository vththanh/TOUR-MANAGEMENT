using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TransferObject;

namespace DataLayer
{
    public class ToursDL : DataProvider
    {
        public List<Tour> GetTour()
        {
            List<Tour> lTour = new List<Tour>();
            string sql = "SELECT * FROM THONGTINTOUR";

            try
            {
                Connect();
                SqlDataReader reader = MyExcuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    string maTour = reader[0].ToString();
                    string tenTour = reader[1].ToString();
                    string moTaTour = reader[2].ToString();
                    string anhTour = reader[3].ToString();
                    decimal giaTour = Convert.ToDecimal(reader[4]);
                    DateTime tgBatDau = Convert.ToDateTime(reader[5]);
                    DateTime tgKetThuc = Convert.ToDateTime(reader[6]);
                    string maLoaiTour = reader[7].ToString();
                    string maPhuongTien = reader[8].ToString();
                    string maXP = reader[9].ToString();
                    string maDDL = reader[10].ToString();

                    Tour tour = new Tour(maTour, tenTour, moTaTour, anhTour, giaTour, tgBatDau, tgKetThuc, maLoaiTour, maPhuongTien, maXP, maDDL);
                    lTour.Add(tour);
                }
                reader.Close();
                return lTour;
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

        public List<Tour> SearchTourByName(string keyword)
        {
            List<Tour> list = new List<Tour>();
            string sql = "SELECT * FROM THONGTINTOUR WHERE TenTour LIKE N'%" + keyword + "%'";

            try
            {
                Connect();
                SqlDataReader reader = MyExcuteReader(sql, CommandType.Text, null);
                while (reader.Read())
                {
                    string maTour = reader[0].ToString();
                    string tenTour = reader[1].ToString();
                    string moTaTour = reader[2].ToString();
                    string anhTour = reader[3].ToString();
                    decimal giaTour = Convert.ToDecimal(reader[4]);
                    DateTime tgBatDau = Convert.ToDateTime(reader[5]);
                    DateTime tgKetThuc = Convert.ToDateTime(reader[6]);
                    string maLoaiTour = reader[7].ToString();
                    string maPhuongTien = reader[8].ToString();
                    string maXP = reader[9].ToString();
                    string maDDL = reader[10].ToString();

                    Tour tour = new Tour(maTour, tenTour, moTaTour, anhTour, giaTour, tgBatDau, tgKetThuc, maLoaiTour, maPhuongTien, maXP, maDDL);
                    list.Add(tour);
                }
                reader.Close();
            }
            catch
            {
                throw;
            }
            finally
            {
                Disconnect();
            }

            return list;
        }

        public List<Tour> GetTourByType(string tourType)
        {
            List<Tour> lTour = new List<Tour>();
            string sql = "";

            if (tourType == "Trong Nước")
            {
                sql = "SELECT * FROM THONGTINTOUR WHERE MaLoaiTour = 'TN'"; // 1 tương ứng với Trong Nước
            }
            else if (tourType == "Ngoài Nước")
            {
                sql = "SELECT * FROM THONGTINTOUR WHERE MaLoaiTour = 'NN'"; // 2 tương ứng với Ngoài Nước
            }
            else
            {
                sql = "SELECT * FROM THONGTINTOUR";
            }

            try
            {
                Connect();
                SqlDataReader reader = MyExcuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    string maTour = reader[0].ToString();
                    string tenTour = reader[1].ToString();
                    string moTaTour = reader[2].ToString();
                    string anhTour = reader[3].ToString();
                    decimal giaTour = Convert.ToDecimal(reader[4]);
                    DateTime tgBatDau = Convert.ToDateTime(reader[5]);
                    DateTime tgKetThuc = Convert.ToDateTime(reader[6]);
                    string maLoaiTour = reader[7].ToString();
                    string maPhuongTien = reader[8].ToString();
                    string maXP = reader[9].ToString();
                    string maDDL = reader[10].ToString();

                    Tour tour = new Tour(maTour, tenTour, moTaTour, anhTour, giaTour, tgBatDau, tgKetThuc, maLoaiTour, maPhuongTien, maXP, maDDL);
                    lTour.Add(tour);
                }
                reader.Close();
                return lTour;
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

        public Tour GetTourByID(string maTour)
        {
            string sql = "SELECT * FROM THONGTINTOUR WHERE MaTour = @maTour";
            List<SqlParameter> parameters = new List<SqlParameter>
    {
        new SqlParameter("@maTour", maTour)
    };
            try
            {
                Connect();
                SqlDataReader reader = MyExcuteReader(sql, CommandType.Text, parameters);
                if (reader.Read())
                {
                    var tour = new Tour
                    {
                        MaTour = reader[0].ToString(),
                        TenTour = reader[1].ToString(),
                        MoTaTour = reader[2].ToString(),
                        AnhTour = reader[3].ToString(),
                        GiaTour = Convert.ToDecimal(reader[4]),
                        TGBatDau = Convert.ToDateTime(reader[5]),
                        TGKetThuc = Convert.ToDateTime(reader[6]),
                        MaLoaiTour = reader[7].ToString(),
                        MaPhuongTien = reader[8].ToString(),
                        MaXP = reader[9].ToString(),
                        MaDDL = reader[10].ToString(),
                    };
                    reader.Close();
                    return tour;
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                Disconnect();
            }

            return null;
        }
    }
}
