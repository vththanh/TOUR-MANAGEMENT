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
using System.Windows.Forms.DataVisualization.Charting;

namespace PresentationLayer
{
    public partial class BaoCaoThongKe : Form
    {
        private BaoCaoBL bc = new BaoCaoBL();
        public BaoCaoThongKe()
        {
            InitializeComponent();
        }
        private void BaoCaoThongKe_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            string selectedReport = cboReportType.SelectedItem?.ToString();
            DateTime tuNgay = dtpStart.Value.Date;
            DateTime denNgay = dtpEnd.Value.Date;

            DataTable dt = null;

            if (selectedReport == null)
            {
                MessageBox.Show("Vui lòng chọn loại báo cáo.");
                return;
            }

            if (tuNgay > denNgay)
            {
                MessageBox.Show("Từ ngày không được lớn hơn đến ngày.");
                return;
            }

            switch (selectedReport)
            {
                case "Doanh thu theo ngày":
                    dt = bc.GetRevenueByTime(tuNgay, denNgay);
                    break;

                case "Doanh thu theo loại Tour":
                    dt = bc.GetRevenueByTourType();
                    break;

                default:
                    MessageBox.Show("Loại báo cáo chưa được hỗ trợ.");
                    return;
            }

            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu cho khoảng thời gian đã chọn.");
                return;
            }

            dgvReport.DataSource = dt; // hoặc vẽ biểu đồ tùy chọn
            ChartMain.Series.Clear();
            ChartMain.ChartAreas.Clear();
            ChartMain.Titles.Clear();

            ChartArea area = new ChartArea("MainArea");
            area.AxisY.MajorGrid.Enabled = false;
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisX.Title = (selectedReport.Contains("ngày")) ? "Ngày" : "Loại tour";
            area.AxisY.Title = "Doanh thu (VNĐ)";
            area.AxisY.LabelStyle.Format = "{0:N0}";
            ChartMain.ChartAreas.Add(area);

            Series series = new Series("Doanh thu")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true,
                LabelFormat = "{0:N0}",
                XValueMember = dt.Columns[0].ColumnName,
                YValueMembers = dt.Columns[1].ColumnName
            };

            // Gán datasource
            ChartMain.DataSource = dt;
            ChartMain.Series.Add(series);
            ChartMain.Titles.Add(selectedReport.ToUpper());
            ChartMain.DataBind();
        }
    }
}
