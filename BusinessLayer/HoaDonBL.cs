using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DataLayer;
using TransferObject;

namespace BusinessLayer
{
    public class HoaDonBL
    {
        private HoaDonDL hddl;
        public HoaDonBL()
        {
            hddl = new HoaDonDL();
        }

        public List<HoaDon> GetHoaDons()
        {
            try
            {
                return hddl.GetHoaDon();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public bool XoaHoaDon(string soHD)
        {
            return hddl.DeleteHoaDon(soHD);
        }
        public string XuLyThanhToan(HoaDon hd)
        {
            string soHD = hddl.ThemHoaDon(hd);
            return soHD;
        }
    }
}
