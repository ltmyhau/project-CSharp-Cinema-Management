using BetaCinema.DAO;
using BetaCinema.DTO;
using BetaCinema.GUI.Admin.Movie;
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

        public void ExportFileStatisticsByMovie(DataTable dataTable, string sheetName, string title)
        {
            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbooks oBooks;
            Microsoft.Office.Interop.Excel.Sheets oSheets;
            Microsoft.Office.Interop.Excel.Workbook oBook;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = oExcel.Workbooks.Add(Type.Missing);
            oSheets = oBook.Worksheets;
            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name = sheetName;

            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "G1");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Times New Roman";
            head.Font.Size = "20";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Mã phim";
            cl1.ColumnWidth = 10;
            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Tên phim";
            cl2.ColumnWidth = 40;
            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Số suất chiếu";
            cl3.ColumnWidth = 13;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Tổng số vé";
            cl4.ColumnWidth = 13;
            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Số vé bán ra";
            cl5.ColumnWidth = 13;
            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "Số vé tồn";
            cl6.ColumnWidth = 13;
            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "Doanh thu";
            cl7.ColumnWidth = 13;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "G3");
            rowHead.Font.Bold = true;
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            rowHead.Interior.ColorIndex = 6;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            rowHead.Font.Name = "Times New Roman";
            rowHead.Font.Size = "11";

            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];
            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                DataRow dataRow = dataTable.Rows[row];
                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    arr[row, col] = dataRow[col];
                }
            }

            int rowStart = 4;
            int colStart = 1;
            int rowEnd = rowStart + dataTable.Rows.Count - 1;
            int colEnd = dataTable.Columns.Count;
            Microsoft.Office.Interop.Excel.Range c0 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, colStart];
            Microsoft.Office.Interop.Excel.Range cN = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, colEnd];
            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c0, cN);
            range.Value2 = arr;
            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            oSheet.get_Range(c0, cN).Font.Name = "Times New Roman";
            oSheet.get_Range(c0, cN).Font.Size = "11";
            oSheet.get_Range(c0, cN).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range c02 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, colStart + 1];
            Microsoft.Office.Interop.Excel.Range cN2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, colStart + 1];
            oSheet.get_Range(c02, cN2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
        }

        public void ExportFileStatisticsByProduct(DataTable dataTable, string sheetName, string title)
        {
            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbooks oBooks;
            Microsoft.Office.Interop.Excel.Sheets oSheets;
            Microsoft.Office.Interop.Excel.Workbook oBook;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = oExcel.Workbooks.Add(Type.Missing);
            oSheets = oBook.Worksheets;
            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name = sheetName;

            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "E1");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Times New Roman";
            head.Font.Size = "20";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Mã sản phẩm";
            cl1.ColumnWidth = 13;
            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Tên sản phẩm";
            cl2.ColumnWidth = 40;
            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Số lượng tồn";
            cl3.ColumnWidth = 15;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Số lượng bán ra";
            cl4.ColumnWidth = 15;
            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Doanh thu";
            cl5.ColumnWidth = 15;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "E3");
            rowHead.Font.Bold = true;
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            rowHead.Interior.ColorIndex = 6;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            rowHead.Font.Name = "Times New Roman";
            rowHead.Font.Size = "11";

            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];
            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                DataRow dataRow = dataTable.Rows[row];
                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    arr[row, col] = dataRow[col];
                }
            }

            int rowStart = 4;
            int colStart = 1;
            int rowEnd = rowStart + dataTable.Rows.Count - 1;
            int colEnd = dataTable.Columns.Count;
            Microsoft.Office.Interop.Excel.Range c0 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, colStart];
            Microsoft.Office.Interop.Excel.Range cN = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, colEnd];
            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c0, cN);
            range.Value2 = arr;
            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            oSheet.get_Range(c0, cN).Font.Name = "Times New Roman";
            oSheet.get_Range(c0, cN).Font.Size = "11";
            oSheet.get_Range(c0, cN).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range c02 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, colStart + 1];
            Microsoft.Office.Interop.Excel.Range cN2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, colStart + 1];
            oSheet.get_Range(c02, cN2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
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

        private void btnPPrint_Click(object sender, EventArgs e)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("EXEC spThongKeDoanhThuPhim");
            rptStatisticMovie r = new rptStatisticMovie();
            r.SetDataSource(dataTable);
            fReport f = new fReport();
            f.crvReport.ReportSource = r;
            f.ShowDialog();
        }

        private void btnPExport_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            DataColumn col1 = new DataColumn("MaPhim");
            DataColumn col2 = new DataColumn("TenPhim");
            DataColumn col3 = new DataColumn("SoSuatChieu");
            DataColumn col4 = new DataColumn("TongSoVe");
            DataColumn col5 = new DataColumn("SoVeBanRa");
            DataColumn col6 = new DataColumn("SoVeTon");
            DataColumn col7 = new DataColumn("DoanhThu");

            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);
            dataTable.Columns.Add(col4);
            dataTable.Columns.Add(col5);
            dataTable.Columns.Add(col6);
            dataTable.Columns.Add(col7);

            foreach (DataGridViewRow dgvRow in dgvStatisticsByMovie.Rows)
            {
                DataRow row = dataTable.NewRow();

                row[0] = dgvRow.Cells["MaPhim"].Value;
                row[1] = dgvRow.Cells["TenPhim"].Value;
                row[2] = dgvRow.Cells["SoSuatChieu"].Value;
                row[3] = dgvRow.Cells["TongSoVe"].Value;
                row[4] = dgvRow.Cells["SoVeBanRa"].Value;
                row[5] = dgvRow.Cells["SoVeTon"].Value;
                row[6] = dgvRow.Cells["DoanhThu"].Value;

                dataTable.Rows.Add(row);
            }

            ExportFileStatisticsByMovie(dataTable, "Doanh thu", "THỐNG KÊ DOANH THU THEO PHIM");
        }

        private void btnSPChart_Click(object sender, EventArgs e)
        {
            fChart f = new fChart();
            f.DrawRevenueChartProduct(dgvStatisticsByProduct);
            f.ShowDialog();
        }

        private void btnSPPrint_Click(object sender, EventArgs e)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("EXEC spThongKeDoanhThuSanPham");
            rptStatisticProduct r = new rptStatisticProduct();
            r.SetDataSource(dataTable);
            fReport f = new fReport();
            f.crvReport.ReportSource = r;
            f.ShowDialog();
        }

        private void btnSPExport_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            DataColumn col1 = new DataColumn("MaSP");
            DataColumn col2 = new DataColumn("TenSP");
            DataColumn col3 = new DataColumn("SoLuongTon");
            DataColumn col4 = new DataColumn("SoLuongDaBan");
            DataColumn col5 = new DataColumn("DoanhThu");

            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);
            dataTable.Columns.Add(col4);
            dataTable.Columns.Add(col5);

            foreach (DataGridViewRow dgvRow in dgvStatisticsByProduct.Rows)
            {
                DataRow row = dataTable.NewRow();

                row[0] = dgvRow.Cells["MaSP"].Value;
                row[1] = dgvRow.Cells["TenSP"].Value;
                row[2] = dgvRow.Cells["SoLuongTon"].Value;
                row[3] = dgvRow.Cells["SoLuongDaBan"].Value;
                row[4] = dgvRow.Cells["DoanhThu"].Value;

                dataTable.Rows.Add(row);
            }

            ExportFileStatisticsByProduct(dataTable, "Doanh thu", "THỐNG KÊ DOANH THU THEO SẢN PHẨM");
        }
        #endregion
    }
}
