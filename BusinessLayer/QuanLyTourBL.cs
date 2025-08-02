using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataLayer;
using TransferObject;

namespace BusinessLayer
{
    public class QuanLyTourBL
    {
        private QuanLyTourDL quanlytourDL;

        public QuanLyTourBL()
        {
            quanlytourDL = new QuanLyTourDL();
        }

        public List<Tour> GetTours()
        {
            try
            {
                return quanlytourDL.GetTours();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public bool SuaTour(Tour tour)
        {
            return quanlytourDL.UpdateTour(tour);

        }
        public string ThemTour(Tour tour)
        {
            if (string.IsNullOrWhiteSpace(tour.TenTour))
                throw new Exception("Tên tour không được để trống.");

            var danhSach = quanlytourDL.GetTours();
            if (danhSach.Any(t => t.MaTour == tour.MaTour))
                throw new Exception("Mã tour đã tồn tại.");

            if (tour.TGKetThuc < tour.TGBatDau)
                throw new Exception("Thời gian kết thúc không được nhỏ hơn thời gian bắt đầu.");
            return quanlytourDL.InsertTour(tour);
        }

        public bool XoaTour(string maTour)
        {
            if (quanlytourDL.IsCheckKH_Tour(maTour))
            {
                return false; 
            }

            return quanlytourDL.DeleteTour(maTour);
        }
        public string GetNewMaTour()
        {
            return quanlytourDL.GetNewMaTour();
        }
    }
}
