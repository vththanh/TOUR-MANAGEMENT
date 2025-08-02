using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class Tour
    {
        public string MaTour { get; set; }
        public string TenTour { get; set; }
        public string MoTaTour { get; set; }
        public string AnhTour { get; set; }
        public decimal GiaTour { get; set; }
        public DateTime TGBatDau { get; set; }
        public DateTime TGKetThuc { get; set; }
        public string MaLoaiTour { get; set; }
        public string MaPhuongTien { get; set; }
        public string MaXP { get; set; }
        public string MaDDL { get; set; }

        public Tour(string maTour, string tenTour, string moTaTour, string anhTour,
                   decimal giaTour, DateTime tgBatDau, DateTime tgKetThuc,
                   string maLoaiTour, string maPhuongTien, string maXP, string maDDL)
        {
            this.MaTour = maTour;
            this.TenTour = tenTour;
            this.MoTaTour = moTaTour;
            this.AnhTour = anhTour;
            this.GiaTour = giaTour;
            this.TGBatDau = tgBatDau;
            this.TGKetThuc = tgKetThuc;
            this.MaLoaiTour = maLoaiTour;
            this.MaPhuongTien = maPhuongTien;
            this.MaXP = maXP;
            this.MaDDL = maDDL;
        }
        public Tour() { }
    }
}
