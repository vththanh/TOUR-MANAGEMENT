using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferObject;

namespace PresentationLayer
{
    public partial class TrangChu : Form
    {
        private string tenDangNhap;
        public TrangChu(string tenNhanVien)
        {
            InitializeComponent();
            this.tenDangNhap = tenNhanVien;
        }

        private void btnDatNgay_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && btn.Tag != null)
            {
                string maTour = btn.Tag.ToString();

                Tour tour = new ToursBL().GetTourByID(maTour);
                if (tour != null)
                {
                    DatTour datTourForm = new DatTour(tour, tenDangNhap); // có thể là user đang đăng nhập
                    datTourForm.ShowDialog();
                }
            }
        }
    }
}
