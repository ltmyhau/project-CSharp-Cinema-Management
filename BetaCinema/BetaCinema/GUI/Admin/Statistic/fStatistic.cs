using BetaCinema.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetaCinema.GUI.Admin.Statistic
{
    public partial class fStatistic : Form
    {
        public fStatistic()
        {
            InitializeComponent();
        }

        #region Methods
        public void LoadStatisticsByMovie()
        {
            if (rdoPTatCa.Checked)
            {
                dgvStatisticsByMovie.DataSource = DataProvider.Instance.ExecuteQuery("EXEC spThongKeDoanhThuPhim");
            }
            else
            {
                dgvStatisticsByMovie.DataSource = DataProvider.Instance.ExecuteQuery("EXEC spThongKeDoanhThuPhim @tuNgay , @denNgay ", new object[] { dtpPTuNgay.Value, dtpPDenNgay.Value });
            }
        }

        public void LoadStatisticsByProduct()
        {
            if (rdoSPTatCa.Checked)
            {
                dgvStatisticsByProduct.DataSource = DataProvider.Instance.ExecuteQuery("EXEC spThongKeDoanhThuSanPham");
            }
            else
            {
                dgvStatisticsByProduct.DataSource = DataProvider.Instance.ExecuteQuery("EXEC spThongKeDoanhThuSanPham @tuNgay , @denNgay ", new object[] { dtpPTuNgay.Value, dtpPDenNgay.Value });
            }
        }

        private void CustomizeDgvStatisticsByMovie()
        {
            dgvStatisticsByMovie.EnableHeadersVisualStyles = false;
            dgvStatisticsByMovie.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(1, 81, 152);
            dgvStatisticsByMovie.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvStatisticsByMovie.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvStatisticsByMovie.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStatisticsByMovie.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvStatisticsByMovie.RowTemplate.Height = 30;

            dgvStatisticsByMovie.Columns["MaPhim"].HeaderText = "Mã Phim";
            dgvStatisticsByMovie.Columns["TenPhim"].HeaderText = "Tên phim";
            dgvStatisticsByMovie.Columns["SoSuatChieu"].HeaderText = "Số suất chiếu";
            dgvStatisticsByMovie.Columns["TongSoVe"].HeaderText = "Tổng số vé";
            dgvStatisticsByMovie.Columns["SoVeBanRa"].HeaderText = "Số vé bán ra";
            dgvStatisticsByMovie.Columns["SoVeTon"].HeaderText = "Số vé tồn";
            dgvStatisticsByMovie.Columns["DoanhThu"].HeaderText = "Doanh thu";

            dgvStatisticsByMovie.Columns["MaPhim"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStatisticsByMovie.Columns["SoSuatChieu"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStatisticsByMovie.Columns["TongSoVe"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStatisticsByMovie.Columns["SoVeBanRa"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStatisticsByMovie.Columns["SoVeTon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStatisticsByMovie.Columns["DoanhThu"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void SetColumnWidthsInPercentageDgvStatisticsByMovie()
        {
            int totalWidth = dgvStatisticsByMovie.Width;

            dgvStatisticsByMovie.Columns["MaPhim"].Width = (int)(0.1 * totalWidth);
            dgvStatisticsByMovie.Columns["TenPhim"].Width = (int)(0.3 * totalWidth);
            dgvStatisticsByMovie.Columns["SoSuatChieu"].Width = (int)(0.12 * totalWidth);
            dgvStatisticsByMovie.Columns["TongSoVe"].Width = (int)(0.12 * totalWidth);
            dgvStatisticsByMovie.Columns["SoVeBanRa"].Width = (int)(0.12 * totalWidth);
            dgvStatisticsByMovie.Columns["SoVeTon"].Width = (int)(0.12 * totalWidth);
            dgvStatisticsByMovie.Columns["DoanhThu"].Width = (int)(0.12 * totalWidth);

            dgvStatisticsByMovie.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        private void CustomizeDgvStatisticsByProduct()
        {
            dgvStatisticsByProduct.EnableHeadersVisualStyles = false;
            dgvStatisticsByProduct.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(1, 81, 152);
            dgvStatisticsByProduct.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvStatisticsByProduct.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvStatisticsByProduct.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStatisticsByProduct.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvStatisticsByProduct.RowTemplate.Height = 30;

            dgvStatisticsByProduct.Columns["MaSP"].HeaderText = "Mã sản phẩm";
            dgvStatisticsByProduct.Columns["TenSP"].HeaderText = "Tên sản phẩm";
            dgvStatisticsByProduct.Columns["SoLuongTon"].HeaderText = "Số lượng tồn";
            dgvStatisticsByProduct.Columns["SoLuongDaBan"].HeaderText = "Số lượng đã bán";
            dgvStatisticsByProduct.Columns["DoanhThu"].HeaderText = "Doanh thu";

            dgvStatisticsByProduct.Columns["MaSP"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStatisticsByProduct.Columns["SoLuongTon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStatisticsByProduct.Columns["SoLuongDaBan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStatisticsByProduct.Columns["DoanhThu"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void SetColumnWidthsInPercentageDgvStatisticsByProduct()
        {
            int totalWidth = dgvStatisticsByProduct.Width;

            dgvStatisticsByProduct.Columns["MaSP"].Width = (int)(0.15 * totalWidth);
            dgvStatisticsByProduct.Columns["TenSP"].Width = (int)(0.4 * totalWidth);
            dgvStatisticsByProduct.Columns["SoLuongTon"].Width = (int)(0.15 * totalWidth);
            dgvStatisticsByProduct.Columns["SoLuongDaBan"].Width = (int)(0.15 * totalWidth);
            dgvStatisticsByProduct.Columns["DoanhThu"].Width = (int)(0.15 * totalWidth);

            dgvStatisticsByProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }
        #endregion

        #region Events
        private void fStatistic_Load(object sender, EventArgs e)
        {
            LoadStatisticsByMovie();
            CustomizeDgvStatisticsByMovie();
            LoadStatisticsByProduct();
            CustomizeDgvStatisticsByProduct();
            this.SizeChanged += fStatistic_SizeChanged;
            SetColumnWidthsInPercentageDgvStatisticsByMovie();
            SetColumnWidthsInPercentageDgvStatisticsByProduct();
        }

        private void fStatistic_SizeChanged(object sender, EventArgs e)
        {
            SetColumnWidthsInPercentageDgvStatisticsByMovie();
            SetColumnWidthsInPercentageDgvStatisticsByProduct();
        }

        private void rdoTatCa_CheckedChanged(object sender, EventArgs e)
        {
            LoadStatisticsByMovie();
        }

        private void rdoKhoangThoiGian_CheckedChanged(object sender, EventArgs e)
        {
            LoadStatisticsByMovie();
        }

        private void dtpPTuNgay_ValueChanged(object sender, EventArgs e)
        {
            rdoPKhoangThoiGian.Checked = true;
            LoadStatisticsByMovie();
        }

        private void dtpPDenNgay_ValueChanged(object sender, EventArgs e)
        {
            rdoPKhoangThoiGian.Checked = true;
            LoadStatisticsByMovie();
        }

        private void dgvStatisticsByMovie_DataSourceChanged(object sender, EventArgs e)
        {
            int tongVe = 0;
            double tongDoanhThu = 0;
            foreach (DataGridViewRow row in dgvStatisticsByMovie.Rows)
            {
                if (row.Cells["SoVeBanRa"].Value != null && int.TryParse(row.Cells["SoVeBanRa"].Value.ToString(), out int soVe))
                {
                    tongVe += soVe;
                }
                if (row.Cells["DoanhThu"].Value != null && int.TryParse(row.Cells["DoanhThu"].Value.ToString(), out int doanhTHu))
                {
                    tongDoanhThu += doanhTHu;
                }
            }
            txtPTongVe.Text = tongVe.ToString();
            txtDoanhThuPhim.Text = string.Format("{0:N0} đ", tongDoanhThu);
        }

        private void rdoSPTatCa_CheckedChanged(object sender, EventArgs e)
        {
            LoadStatisticsByProduct();
        }

        private void rdoSPKhoangThoiGian_CheckedChanged(object sender, EventArgs e)
        {
            LoadStatisticsByProduct();
        }

        private void dtpSPTuNgay_ValueChanged(object sender, EventArgs e)
        {
            rdoSPKhoangThoiGian.Checked = true;
            LoadStatisticsByProduct();
        }

        private void dtpSPDenNgay_ValueChanged(object sender, EventArgs e)
        {
            rdoSPKhoangThoiGian.Checked = true;
            LoadStatisticsByProduct();
        }

        private void dgvProduct_DataSourceChanged(object sender, EventArgs e)
        {
            int soLuongDaBan = 0;
            double tongDoanhThu = 0;
            foreach (DataGridViewRow row in dgvStatisticsByProduct.Rows)
            {
                if (row.Cells["SoLuongDaBan"].Value != null && int.TryParse(row.Cells["SoLuongDaBan"].Value.ToString(), out int soLuong))
                {
                    soLuongDaBan += soLuong;
                }
                if (row.Cells["DoanhThu"].Value != null && int.TryParse(row.Cells["DoanhThu"].Value.ToString(), out int doanhTHu))
                {
                    tongDoanhThu += doanhTHu;
                }
            }
            txtSoLuongDaBan.Text = soLuongDaBan.ToString();
            txtDoanhThuSP.Text = string.Format("{0:N0} đ", tongDoanhThu);
        }

        private void btnPChart_Click(object sender, EventArgs e)
        {
            fChart f = new fChart();
            f.DrawRevenueChartMovie(dgvStatisticsByMovie);
            f.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnPExport_Click(object sender, EventArgs e)
        {

        }

        private void btnSPChart_Click(object sender, EventArgs e)
        {
            fChart f = new fChart();
            f.DrawRevenueChartProduct(dgvStatisticsByProduct);
            f.ShowDialog();
        }

        private void btnSPPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnSPExport_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
