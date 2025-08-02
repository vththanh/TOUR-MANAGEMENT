using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace DataLayer
{
    public class LoaiTourDL:DataProvider
    {
        public List<LoaiTour> GetAll()
        {
            string sql = "SELECT MaLoaiTour, TenLoaiTour FROM LOAITOUR";
            List<LoaiTour> ds = new List<LoaiTour>();

            try
            {
                Connect();
                SqlDataReader reader = MyExcuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    string ma = reader["MaLoaiTour"].ToString();
                    string ten = reader["TenLoaiTour"].ToString();
                    ds.Add(new LoaiTour(ma, ten));
                }
                reader.Close();
                return ds;
            }
            finally
            {
                Disconnect();
            }
        }
    }
}
