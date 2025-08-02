using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DataLayer;
using TransferObject;

namespace BusinessLayer
{
    public class ChiTietHoaDonBL
    {
        ChiTietHoaDonDL cthddl;
        public ChiTietHoaDonBL()
        {
            cthddl = new ChiTietHoaDonDL();
        }

        public ChiTietHD LayThongTinChiTiet(string soHD)
        {
            return cthddl.LayChiTietHoaDon(soHD);
        }
    }
}

