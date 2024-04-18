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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BetaCinema.GUI.Admin.Statistic
{
    public partial class fChart : Form
    {
        public fChart()
        {
            InitializeComponent();
        }

        public void DrawColumnChartFromDataGridView(DataGridView dataGridView)
        {
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để vẽ biểu đồ.");
                return;
            }

            List<int> dataList = new List<int>();

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells["DoanhThu"].Value != null)
                {
                    if (int.TryParse(row.Cells["DoanhThu"].Value.ToString(), out int value))
                    {
                        dataList.Add(value);
                    }
                }
            }
        }

        public void DrawRevenueChartMovie(DataGridView dataGridView)
        {
            Series series = new Series("Doanh thu theo phim");

            series.ChartType = SeriesChartType.Column;

            var query = from DataGridViewRow row in dataGridView.Rows
                        where row.Cells["MaPhim"].Value != null &&
                              row.Cells["DoanhThu"].Value != null
                        group Convert.ToDouble(row.Cells["DoanhThu"].Value) by row.Cells["MaPhim"].Value.ToString() into g
                        select new { Movie = g.Key, Revenue = g.Sum() };

            foreach (var item in query)
            {
                DataPoint dataPoint = new DataPoint();
                dataPoint.SetValueXY(item.Movie, item.Revenue);
                dataPoint.Label = item.Movie;
                dataPoint.Color = Color.FromArgb(65, 140, 240);
                dataPoint.Font = new Font("Segoe UI", 13, FontStyle.Regular);
                series.Points.Add(dataPoint);
            }

            chart1.Series.Add(series);
            chart1.ChartAreas[0].AxisX.Title = "Phim";
            chart1.ChartAreas[0].AxisY.Title = "Doanh thu";

            chart1.ChartAreas[0].AxisX.TitleFont = new Font("Segoe UI", 13, FontStyle.Regular);
            chart1.ChartAreas[0].AxisY.TitleFont = new Font("Segoe UI", 13, FontStyle.Regular);
            chart1.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Segoe UI", 13, FontStyle.Regular);
            chart1.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Segoe UI", 13, FontStyle.Regular);

            chart1.Legends.Clear();
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        }

        public void DrawRevenueChartProduct(DataGridView dataGridView)
        {
            Series series = new Series("Doanh thu theo sản phẩm");

            series.ChartType = SeriesChartType.Column;

            var query = from DataGridViewRow row in dataGridView.Rows
                        where row.Cells["MaSP"].Value != null &&
                              row.Cells["DoanhThu"].Value != null
                        group Convert.ToDouble(row.Cells["DoanhThu"].Value) by row.Cells["MaSP"].Value.ToString() into g
                        select new { Product = g.Key, Revenue = g.Sum() };

            foreach (var item in query)
            {
                DataPoint dataPoint = new DataPoint();
                dataPoint.SetValueXY(item.Product, item.Revenue);
                dataPoint.Label = item.Product;
                dataPoint.Color = Color.FromArgb(65, 140, 240);
                dataPoint.Font = new Font("Segoe UI", 13, FontStyle.Regular);
                series.Points.Add(dataPoint);
            }

            chart1.Series.Add(series);
            chart1.ChartAreas[0].AxisX.Title = "Sản phẩm";
            chart1.ChartAreas[0].AxisY.Title = "Doanh thu";

            chart1.ChartAreas[0].AxisX.TitleFont = new Font("Segoe UI", 13, FontStyle.Regular);
            chart1.ChartAreas[0].AxisY.TitleFont = new Font("Segoe UI", 13, FontStyle.Regular);
            chart1.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Segoe UI", 13, FontStyle.Regular);
            chart1.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Segoe UI", 13, FontStyle.Regular);

            chart1.Legends.Clear();
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        }
    }
}
