using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject.DichVu
{
    public class PhuongTienTour
    {
        public string MaPhuongTien { get; set; }
        public string TenPhuongTien { get; set; }

        public PhuongTienTour(string maPhuongTien, string tenPhuongTien)
        {
            this.MaPhuongTien = maPhuongTien;
            this.TenPhuongTien = tenPhuongTien;
        }
        public PhuongTienTour() { }
    }
}
