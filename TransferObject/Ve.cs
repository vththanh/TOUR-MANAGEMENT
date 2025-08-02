using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class Ve
    {
        public string MaTour { get; set; }
        public string TenTour { get; set; }
        public string DiaDiemXP { get; set; }
        public string TenPhuongTien { get; set; }
        public DateTime TGBatDau { get; set; }
        public DateTime TGKetThuc { get; set; }
        public decimal Gia { get; set; }
        public decimal ThanhTien { get; set; }  // Mặc định = 0 khi khởi tạo

        public Ve(string maTour, string tenTour, string diaDiemXP, string tenPhuongTien,
                 DateTime tgBatDau, DateTime tgKetThuc, decimal gia)
        {
            this.MaTour = maTour;
            this.TenTour = tenTour;
            this.DiaDiemXP = diaDiemXP;
            this.TenPhuongTien = tenPhuongTien;
            this.TGBatDau = tgBatDau;
            this.TGKetThuc = tgKetThuc;
            this.Gia = gia;
            this.ThanhTien = 0;
        }

        public void CapNhatThanhTien(int soLuongVe)
        {
            ThanhTien = Gia * soLuongVe;
        }

        public Ve() { }
    }
}

