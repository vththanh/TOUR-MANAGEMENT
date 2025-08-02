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
    public class LoginDL : DataProvider
    {
        public bool Login(Account acc)
        {
            string sql = "SELECT COUNT(TenDangNhap) FROM TaiKhoan WHERE TenDangNhap= '" + acc.TenDangNhap + "' AND MatKhau = '" + acc.MatKhau + "'";
            try
            {
                return (int)MyExcuteScalar(sql, CommandType.Text) > 0;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
