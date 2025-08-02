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
    public class PhuongTienTourDL:DataProvider
    {
        public List<PhuongTienTour> GetPTTour()
        {
            string ma, name;
            List<PhuongTienTour> ptien = new List<PhuongTienTour>();
            string sql = "SELECT * FROM PHUONGTIENTOUR";
            try
            {
                Connect();
                SqlDataReader reader = MyExcuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    ma = reader[0].ToString();
                    name = reader[1].ToString();

                    PhuongTienTour trans = new PhuongTienTour(ma, name);
                    ptien.Add(trans);
                }
                reader.Close();
                return ptien;
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
        public string GeneratePhuongTienTour()
        {
            string sql = "SELECT TOP 1 MaPhuongTien FROM PHUONGTIENTOUR WHERE MaPhuongTien LIKE 'PT%' ORDER BY MaPhuongTien DESC";
            try
            {
                Connect();
                object result = MyExcuteScalar(sql, CommandType.Text);
                if (result != null && result != DBNull.Value)
                {
                    string lastMaPT = result.ToString();
                    int number = int.Parse(lastMaPT.Substring(2));
                    return "PT" + (number + 1).ToString("D3");
                }
                else
                {
                    return "PT000";
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
        public int Insert(PhuongTienTour d)
        {
            string sql = "INSERT INTO PHUONGTIENTOUR VALUES ('"+d.MaPhuongTien+"',N'"+d.TenPhuongTien+"')";
            try
            {
                return MyExecuteNonQuery(sql, CommandType.Text);
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }
        public int Update(PhuongTienTour d)
        {
            string sql = "UPDATE PHUONGTIENTOUR SET TenPhuongTien = '"+d.TenPhuongTien+"' WHERE MaPhuongTien = '"+d.MaPhuongTien+"'";
            try
            {
                return MyExecuteNonQuery(sql, CommandType.Text);
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }
        public int Delete(string maPT)
        {
            string sql = "DELETE FROM PHUONGTIENTOUR WHERE MaPhuongTien = '"+maPT+"'";
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
