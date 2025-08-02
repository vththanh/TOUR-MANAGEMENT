using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject.DichVu
{
    public class DiemDuLich
    {
        public string MaDDL { get; set; }
        public string TenDDL { get; set; }
        public string MaLoaiTour { get; set; }
        public string TenLoaiTour { get; set; }

        public DiemDuLich() { }

        public DiemDuLich(string ma, string ten, string maLoai, string tenLoai)
        {
            MaDDL = ma;
            TenDDL = ten;
            MaLoaiTour = maLoai;
            TenLoaiTour = tenLoai;
        }
    }
}
