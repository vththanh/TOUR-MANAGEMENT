using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject.DichVu
{
    public class DiemKhoiHanh
    {
        public string MaXP { get; set; }
        public string DiaDiemXP { get; set; }

        public DiemKhoiHanh(string maXP,string diaDiemXP)
        {
            this.MaXP = maXP;
            this.DiaDiemXP = diaDiemXP;
        }
        public DiemKhoiHanh() {}
    }
}
