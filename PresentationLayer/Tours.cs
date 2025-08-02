using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferObject;

namespace PresentationLayer
{
    public partial class Tours : Form
    {
        private ToursBL tourbl = new ToursBL();
        private string tenDangNhap;

        public Tours(string tennhanvien)
        {
            InitializeComponent();
            this.tenDangNhap = tennhanvien;

        }
        private void Tour_Load(object sender, EventArgs e)
        {
            try
            {
                dgvTTTour.DataSource = tourbl.GetTours();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách tour  : " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboLoaiTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTourType = cboLoaiTour.SelectedItem.ToString();
            List<Tour> tours = tourbl.GetTourByType(selectedTourType);

            dgvTTTour.DataSource = tours;
        }

        private void dgvTTTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;

            if (i >= 0)
            {
                lbMaTour.Text = dgvTTTour.Rows[i].Cells[0].Value.ToString();
                lbTenTour.Text = dgvTTTour.Rows[i].Cells[1].Value.ToString();
                string fileAnh = dgvTTTour.Rows[i].Cells[3].Value.ToString();
                lbGiaTour.Text = dgvTTTour.Rows[i].Cells[4].Value.ToString();

                lbTGBatDau.Text = ((DateTime)dgvTTTour.Rows[i].Cells[5].Value).ToString("dd/MM/yyyy");
                lbTGKetThuc.Text = ((DateTime)dgvTTTour.Rows[i].Cells[6].Value).ToString("dd/MM/yyyy");

                lbMaLoaiTour.Text = dgvTTTour.Rows[i].Cells[7].Value.ToString();
                lbPT.Text = dgvTTTour.Rows[i].Cells[8].Value.ToString();
                lbDiemXP.Text = dgvTTTour.Rows[i].Cells[9].Value.ToString();

                string pathAnh = Path.Combine(Application.StartupPath, "AnhTour", fileAnh);

                if (File.Exists(pathAnh))
                {
                    ptbAnhTour.Image = Image.FromFile(pathAnh);
                }
                else
                {
                    ptbAnhTour.Image = null;
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string keyword = txtTimTour.Text.Trim();
            dgvTTTour.DataSource = tourbl.SearchTourByName(keyword);
        }

        private void btnDatTour_Click(object sender, EventArgs e)
        {
            string maTour = dgvTTTour.CurrentRow.Cells[0].Value.ToString();
            var tour = tourbl.GetTourByID(maTour); 


            if (tour != null)
            {
                DatTour formDatTour = new DatTour(tour, tenDangNhap); 
                formDatTour.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tour không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

