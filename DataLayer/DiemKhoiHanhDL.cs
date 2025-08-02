using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject.DichVu;

namespace DataLayer
{
    public class DiemKhoiHanhDL:DataProvider
    {
        public List<DiemKhoiHanh> GetDiemKH()
        {
            string ma, name;
            List<DiemKhoiHanh> dkh = new List<DiemKhoiHanh>();
            string sql = "SELECT * FROM DIEMXUATPHAT";
            try
            {
                Connect();
                SqlDataReader reader = MyExcuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    ma = reader[0].ToString();
                    name = reader[1].ToString();

                    DiemKhoiHanh khoihanh = new DiemKhoiHanh(ma,name);
                    dkh.Add(khoihanh);
                }
                reader.Close();
                return dkh;
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
        public string GenerateMaDiemKhoiHanh()
        {
            string sql = "SELECT TOP 1 MaXP FROM DIEMXUATPHAT WHERE MaXP LIKE 'XP%' ORDER BY MaXP DESC";
            try
            {
                Connect();
                object result = MyExcuteScalar(sql, CommandType.Text);
                if (result != null && result != DBNull.Value)
                {
                    string lastMaXP = result.ToString();
                    int number = int.Parse(lastMaXP.Substring(2));
                    return "XP" + (number + 1).ToString("D3");
                }
                else
                {
                    return "XP000";
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
        public int Insert(DiemKhoiHanh d)
        {
            string sql = "INSERT INTO DIEMXUATPHAT VALUES ('"+d.MaXP+"',N'"+d.DiaDiemXP+"')";
            try
            {
                return MyExecuteNonQuery(sql, CommandType.Text);
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }
        public int Update(DiemKhoiHanh d)
        {
            string sql = "UPDATE DIEMXUATPHAT SET DiaDiemXP = N'"+d.DiaDiemXP+"' WHERE MaXP = '"+d.MaXP+"'";
            try
            {
                return MyExecuteNonQuery(sql, CommandType.Text);
            }
            catch(SqlException ex)
            { 
                throw ex;
            }
        }
        public int Delete(string maXP)
        {
            string sql = "DELETE FROM DIEMXUATPHAT WHERE MaXP = '"+maXP+"'";
            try
            {
                return MyExecuteNonQuery(sql, CommandType.Text);
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }
    }
       
}
