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
    public class KhachHangDL : DataProvider
    {
        public List<KhachHang> GetKhachHang()
        {

            List<KhachHang> lKhachHang = new List<KhachHang>();
            string sql = "SELECT * FROM KHACHHANG";

            try
            {
                Connect();
                SqlDataReader reader = MyExcuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    string maKH = reader["MaKH"].ToString();
                    string hoTen = reader["HoTen"].ToString();
                    string gioiTinh = reader["GioiTinh"].ToString();
                    string sdt = reader["Sdt"].ToString();
                    string email = reader["Email"].ToString();

                    KhachHang kh = new KhachHang(maKH, hoTen, gioiTinh, sdt, email);
                    lKhachHang.Add(kh);
                }
                reader.Close();
                return lKhachHang;
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
        public List<KhachHang> SearchKhachHangByName(string keyword)
        {
            List<KhachHang> list = new List<KhachHang>();
            
            string sql = "SELECT * FROM KHACHHANG WHERE HoTen LIKE N'%" + keyword + "%'";

            try
            {
                Connect();
                SqlDataReader reader = MyExcuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    string maKH = reader["MaKH"].ToString();
                    string hoTen = reader["HoTen"].ToString();
                    string gioiTinh = reader["GioiTinh"].ToString();
                    string sdt = reader["Sdt"].ToString();
                    string email = reader["Email"].ToString();

                    KhachHang kh = new KhachHang(maKH, hoTen, gioiTinh, sdt, email);
                    list.Add(kh);
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

            return list;
        }
        private string GetNewCustomerId()
        {
            string sql = "SELECT TOP 1 MaKH FROM KHACHHANG WHERE MaKH LIKE 'KH%' ORDER BY MaKH DESC";
            try
            {
                Connect();
                object result = MyExcuteScalar(sql, CommandType.Text);
                if (result != null && result != DBNull.Value)
                {
                    string lastMaKH = result.ToString();
                    int number = int.Parse(lastMaKH.Substring(2));
                    return "KH" + (number + 1).ToString("D3");
                }
                else
                {
                    return "KH001";
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (FormatException ex)
            {
                throw ex;
            }
            finally
            {
                Disconnect();
            }
        }

        public string Insert(KhachHang kh)
        {
            string newMaKH = GetNewCustomerId();
            kh.MaKH = newMaKH;

            string sql = "uspAddKH";
            List<SqlParameter> parameters = new List<SqlParameter>
    {
        new SqlParameter("@MaKH", kh.MaKH),
        new SqlParameter("@HoTen", kh.HoTen),
        new SqlParameter("@GioiTinh", kh.GioiTinh),
        new SqlParameter("@SDT", kh.SDT),
        new SqlParameter("@Email", kh.Email)
    };

            try
            {
                int rows = MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters);
                return rows > 0 ? kh.MaKH : null;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public bool Update(KhachHang kh)
        {
            string sql = "uspUpdateKH";
            List<SqlParameter> parameters = new List<SqlParameter>
    {
        new SqlParameter("@MaKH", kh.MaKH),
        new SqlParameter("@HoTen", kh.HoTen),
        new SqlParameter("@GioiTinh", kh.GioiTinh),
        new SqlParameter("@SDT", kh.SDT),
        new SqlParameter("@Email", kh.Email)
    };
            try
            {
                int rows = MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters);
                return rows > 0; 
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public bool DeleteKhachHang(string maKH)
        {
            string sql = "uspDeleteKhachHang";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@maKH", maKH)
            };

            try
            {
                int result = MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters);
                return result > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi khi xóa khách hàng: " + ex.Message);
            }
        }

        public bool KhachHangCoHoaDon(string maKH)
        {
            string sql = "SELECT COUNT(*) FROM HoaDon WHERE MaKH = @maKH";
            List<SqlParameter> parameters = new List<SqlParameter>
    {
        new SqlParameter("@maKH", maKH)
    };

            try
            {
                Connect();
                object result = MyExcuteScalar(sql, CommandType.Text, parameters);
                int count = Convert.ToInt32(result);
                return count > 0;
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
