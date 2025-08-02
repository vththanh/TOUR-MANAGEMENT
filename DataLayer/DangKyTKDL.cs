using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace DataLayer
{
    public class DangKyTKDL:DataProvider
    {
        public int Insert(Account acc)
        {
            string sql = "uspAddAccount";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@TenDangNhap", acc.TenDangNhap));
            parameters.Add(new SqlParameter("@MatKhau", acc.MatKhau));
            parameters.Add(new SqlParameter("@MaNV", acc.MaNV));
            try
            {
                return MyExecuteNonQuery(sql,CommandType.StoredProcedure,parameters);
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }
        public bool IsUsernameTaken(string tenDangNhap)
        {
            string sql = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = '" + tenDangNhap + "'";
            try
            {
                int count = (int)MyExcuteScalar(sql, CommandType.Text);
                return count > 0;
            }
            catch(SqlException ex)
            {
                throw ex;
            }

        }
    }
}
