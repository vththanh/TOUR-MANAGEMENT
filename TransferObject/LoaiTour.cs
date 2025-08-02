using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class LoaiTour
    {
        public string MaLoaiTour { get; set; }
        public string TenLoaiTour { get; set; }

        public LoaiTour(string maLoaiTour, string tenLoaiTour)
        {
            this.MaLoaiTour = maLoaiTour;
            this.TenLoaiTour = tenLoaiTour;
        }
        public LoaiTour() { }
    }
}
