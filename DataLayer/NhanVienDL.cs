using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using System.Data;
using TransferObject.DichVu;

namespace DataLayer
{
    public class NhanVienDL : DataProvider
    {
        public string GenerateMaNV()
        {
            string sql = "SELECT TOP 1 MaNV FROM NhanVien WHERE MaNV LIKE 'NV%' ORDER BY MaNV DESC";
            try
            {
                Connect();
                object result = MyExcuteScalar(sql, CommandType.Text);
                if (result != null && result != DBNull.Value)
                {
                    string lastMaNV = result.ToString();
                    int number = int.Parse(lastMaNV.Substring(2));
                    return "NV" + (number + 1).ToString("D3");
                }
                else
                {
                    return "NV000";
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
        public string Insert(NhanVien nv)
        {
            nv.MaNV = GenerateMaNV();
            string sql = "uspAddNV";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@MaNV", nv.MaNV));
            parameters.Add(new SqlParameter("@HoTen", nv.HoTen));
            parameters.Add(new SqlParameter("@GioiTinh", nv.GioiTinh));
            parameters.Add(new SqlParameter("@NgaySinh", SqlDbType.Date) { Value = nv.NgaySinh });
            parameters.Add(new SqlParameter("@Email", nv.Email));
            parameters.Add(new SqlParameter("@DiaChi", nv.DiaChi));
            parameters.Add(new SqlParameter("@SDT", nv.SDT));
            parameters.Add(new SqlParameter("@MaCV", nv.MaCV));
            try
            {
                int rows = MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters);
                if (rows > 0)
                    return nv.MaNV;
                else
                    return null;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public string GetMaNVByTenDangNhap(string tenDangNhap)
        {
            string sql = @"SELECT nv.MaNV
                   FROM NhanVien nv 
                   JOIN TaiKhoan tk ON nv.MaNV = tk.MaNV 
                   WHERE tk.TenDangNhap = '" + tenDangNhap + "'";

            try
            {
                object result = MyExcuteScalar(sql, CommandType.Text);
                return result?.ToString();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public string GetHoTenByTenDangNhap(string tenDangNhap)
        {
            string sql = @"SELECT nv.HoTen 
                   FROM NhanVien nv 
                   JOIN TaiKhoan tk ON nv.MaNV = tk.MaNV 
                   WHERE tk.TenDangNhap = '"+ tenDangNhap +"'";

            try
            {
                object result = MyExcuteScalar(sql, CommandType.Text);
                return result?.ToString();
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }
        public string GetChucVuByTenDangNhap(string tenDangNhap)
        {
            string sql = @"SELECT nv.MaCV 
                   FROM NhanVien nv 
                   JOIN TaiKhoan tk ON nv.MaNV = tk.MaNV 
                   WHERE tk.TenDangNhap = '"+tenDangNhap+"'";
            try
            {
                object result = MyExcuteScalar(sql, CommandType.Text);
                return result?.ToString();
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }

        public List<NhanVien> GetNhanVien()
        {
            string maNV, hoTen, gioiTinh, email, diachi, sdt, maCV;
            DateTime ngaySinh;
            List<NhanVien> lNhanVien = new List<NhanVien>();
            string sql = "SELECT * FROM NHANVIEN";
            try
            {
                Connect();
                SqlDataReader reader = MyExcuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    maNV = reader[0].ToString();
                    hoTen = reader[1].ToString();
                    gioiTinh = reader[2].ToString();
                    ngaySinh = Convert.ToDateTime(reader[3]);
                    email = reader[4].ToString();
                    diachi = reader[5].ToString();
                    sdt = reader[6].ToString();
                    maCV = reader[7].ToString();

                    NhanVien nv = new NhanVien(maNV, hoTen, gioiTinh, ngaySinh, email, diachi, sdt, maCV);
                    lNhanVien.Add(nv);
                }
                reader.Close();
                return lNhanVien;
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
        public int Update(NhanVien nv)
        {
            string sql = "uspUpdateNV";
            List<SqlParameter> parameters = new List<SqlParameter>
    {
        new SqlParameter("@MaNV", nv.MaNV),
        new SqlParameter("@HoTen", nv.HoTen),
        new SqlParameter("@GioiTinh", nv.GioiTinh),
        new SqlParameter("@NgaySinh", SqlDbType.Date) { Value = nv.NgaySinh },
        new SqlParameter("@Email", nv.Email),
        new SqlParameter("@DiaChi", nv.DiaChi),
        new SqlParameter("@SDT", nv.SDT),
        new SqlParameter("@MaCV", nv.MaCV)
    };
            try
            {
                return MyExecuteNonQuery(sql, CommandType.StoredProcedure,parameters);
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }
    }
        
}
