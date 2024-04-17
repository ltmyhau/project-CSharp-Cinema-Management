using BetaCinema.DAO;
using BetaCinema.DTO;
using BetaCinema.GUI.Admin.Movie;
using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace BetaCinema.GUI.Admin.Genre
{
    public partial class fGenre : Form
    {
        BindingSource bsGenreList = new BindingSource();

        public fGenre()
        {
            InitializeComponent();

            lblTitle.Text = "DANH SÁCH PHIM THEO THỂ LOẠI";
        }

        #region Methods
        public void LoadListGenre()
        {
            bsGenreList.DataSource = GenreDAO.Instance.GetListGenre();
        }

        private void CustomizeDgvMovie()
        {
            dgvMovie.EnableHeadersVisualStyles = false;
            dgvMovie.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(1, 81, 152);
            dgvMovie.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvMovie.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvMovie.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMovie.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvMovie.RowTemplate.Height = 30;

            dgvMovie.Columns["MaPhim"].HeaderText = "Mã phim";
            dgvMovie.Columns["TenPhim"].HeaderText = "Tên phim";
            dgvMovie.Columns["BieuTuongPL"].HeaderText = "Phân loại";
            dgvMovie.Columns["QuocGia"].HeaderText = "Quốc gia";
            dgvMovie.Columns["ThoiLuong"].HeaderText = "Thời lượng";
            dgvMovie.Columns["NgayKhoiChieu"].HeaderText = "Ngày khởi chiếu";
            dgvMovie.Columns["TheLoaiPhim"].HeaderText = "Thể loại";

            dgvMovie.Columns["MaPhim"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMovie.Columns["ThoiLuong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMovie.Columns["NgayKhoiChieu"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvMovie.Columns["MaPL"].Visible = false;
            dgvMovie.Columns["DaoDien"].Visible = false;
            dgvMovie.Columns["MoTa"].Visible = false;
            dgvMovie.Columns["Poster"].Visible = false;
            dgvMovie.Columns["Trailer"].Visible = false;
        }

        private void CustomizeDgvGenre()
        {
            dgvGenre.EnableHeadersVisualStyles = false;
            dgvGenre.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(1, 81, 152);
            dgvGenre.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvGenre.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvGenre.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvGenre.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvGenre.RowTemplate.Height = 30;

            dgvGenre.Columns["MaTL"].HeaderText = "Mã thể loại";
            dgvGenre.Columns["TenTheLoai"].HeaderText = "Tên thể loại";
            dgvGenre.Columns["MaTL"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void SetColumnWidthsInPercentageDgvMovie()
        {
            int totalWidth = dgvMovie.Width;

            dgvMovie.Columns["MaPhim"].Width = (int)(0.1 * totalWidth);
            dgvMovie.Columns["TenPhim"].Width = (int)(0.25 * totalWidth);
            dgvMovie.Columns["BieuTuongPL"].Width = (int)(0.1 * totalWidth);
            dgvMovie.Columns["QuocGia"].Width = (int)(0.1 * totalWidth);
            dgvMovie.Columns["ThoiLuong"].Width = (int)(0.1 * totalWidth);
            dgvMovie.Columns["NgayKhoiChieu"].Width = (int)(0.15 * totalWidth);
            dgvMovie.Columns["TheLoaiPhim"].Width = (int)(0.2 * totalWidth);

            dgvMovie.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        private void SetColumnWidthsInPercentageDgvGenre()
        {
            int totalWidth = dgvGenre.Width;

            dgvGenre.Columns["MaTL"].Width = (int)(0.4 * totalWidth);
            dgvGenre.Columns["TenTheLoai"].Width = (int)(0.6 * totalWidth);

            dgvGenre.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        private void BindingGenre()
        {
            txtGenreID.DataBindings.Add(new Binding("Text", dgvGenre.DataSource, "MaTL", true, DataSourceUpdateMode.Never));
            txtGenreName.DataBindings.Add(new Binding("Text", dgvGenre.DataSource, "TenTheLoai", true, DataSourceUpdateMode.Never));
        }

        public void ExportFileGenre(DataTable dataTable, string sheetName, string title)
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

            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "B1");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Times New Roman";
            head.Font.Size = "13";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Mã thể loại";
            cl1.ColumnWidth = 13;
            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Tên thể loại";
            cl2.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "B3");
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

        public void ExportFileMovie(DataTable dataTable, string sheetName, string title, string tenTheLoai)
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

            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "H1");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Times New Roman";
            head.Font.Size = "20";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range cDate = oSheet.get_Range("G2", "H2");
            cDate.MergeCells = true;
            cDate.Value2 = "Thể loại: " + tenTheLoai;
            cDate.Font.Name = "Times New Roman";
            cDate.Font.Size = "11";
            cDate.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A4", "A4");
            cl1.Value2 = "Mã phim";
            cl1.ColumnWidth = 10;
            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B4", "B4");
            cl2.Value2 = "Tên phim";
            cl2.ColumnWidth = 40;
            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C4", "C4");
            cl3.Value2 = "Phân loại";
            cl3.ColumnWidth = 10;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D4", "D4");
            cl4.Value2 = "Đạo diễn";
            cl4.ColumnWidth = 20;
            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E4", "E4");
            cl5.Value2 = "Quốc gia";
            cl5.ColumnWidth = 13;
            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F4", "F4");
            cl6.Value2 = "Thời lượng (phút)";
            cl6.ColumnWidth = 17;
            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G4", "G4");
            cl7.Value2 = "Ngày khời chiếu";
            cl7.ColumnWidth = 15;
            Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H4", "H4");
            cl8.Value2 = "Thể loại";
            cl8.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A4", "H4");
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

            int rowStart = 5;
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
            Microsoft.Office.Interop.Excel.Range c04 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, colStart + 3];
            Microsoft.Office.Interop.Excel.Range cN4 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, colStart + 3];
            oSheet.get_Range(c04, cN4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
            Microsoft.Office.Interop.Excel.Range c0N = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, colEnd];
            Microsoft.Office.Interop.Excel.Range cNN = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, colEnd];
            oSheet.get_Range(c0N, cNN).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
        }
        #endregion

        #region Events
        private void fGenre_Load(object sender, EventArgs e)
        {
            dgvGenre.DataSource = bsGenreList;
            pnlConfirm.Location = new Point(400, 100);
            LoadListGenre();
            string tenTL = dgvGenre.Rows[0].Cells["TenTheLoai"].Value.ToString();
            dgvMovie.DataSource = MovieDetailDAO.Instance.GetListMoiveDetailByGenreName(tenTL);
            CustomizeDgvMovie();
            CustomizeDgvGenre();
            BindingGenre();
            this.SizeChanged += fGenre_SizeChanged;
            SetColumnWidthsInPercentageDgvMovie();
            SetColumnWidthsInPercentageDgvGenre();
        }

        private void fGenre_SizeChanged(object sender, EventArgs e)
        {
            SetColumnWidthsInPercentageDgvMovie();
            SetColumnWidthsInPercentageDgvGenre();
        }

        private void dgvGenre_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string tenTL = dgvGenre.Rows[e.RowIndex].Cells["TenTheLoai"].Value.ToString();
                dgvMovie.DataSource = MovieDetailDAO.Instance.GetListMoiveDetailByGenreName(tenTL);
            }
            pnlControls.Visible = true;
            pnlConfirm.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlControls.Visible = false;
            pnlConfirm.Visible = true;
            txtGenreName.Clear();
            txtGenreName.Focus();
            txtGenreID.Text = GenreDAO.Instance.GetNextMaTL();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGenreName.Text))
            {
                MessageBox.Show("Tên thể loại không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGenreName.Focus();
            }
            else
            {
                if (GenreDAO.Instance.UpdateGenre(txtGenreID.Text, txtGenreName.Text))
                {
                    MessageBox.Show("Đã chỉnh sửa thể loại phim thành công.", "Thông báo", MessageBoxButtons.OK);
                    LoadListGenre();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi khi chỉnh sửa thể loại phim.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa thể loại phim này? Tất cả thông tin liên quan cũng sẽ bị xóa.\r\n\r\nBạn có thực sự muốn xóa?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (GenreDAO.Instance.DaleteGenre(txtGenreID.Text))
                {
                    MessageBox.Show("Đã xoá thể loại phim thành công.", "Thông báo", MessageBoxButtons.OK);
                    LoadListGenre();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi khi xóa phim.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGenreName.Text))
            {
                MessageBox.Show("Tên thể loại không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGenreName.Focus();
            }
            else
            {
                if (GenreDAO.Instance.InsertGenre(txtGenreName.Text))
                {
                    MessageBox.Show("Đã thêm thể loại phim thành công.", "Thông báo", MessageBoxButtons.OK);
                    LoadListGenre();
                    pnlConfirm.Visible = false;
                    pnlControls.Visible = true;
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi khi thêm thể loại phim.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlConfirm.Visible = false;
            pnlControls.Visible = true;
            txtGenreID.Clear();
            txtGenreName.Clear();
        }

        private void btnExportGenre_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            DataColumn col1 = new DataColumn("MaTL");
            DataColumn col2 = new DataColumn("TenTheLoai");

            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);

            foreach (DataGridViewRow dgvRow in dgvGenre.Rows)
            {
                DataRow row = dataTable.NewRow();

                row[0] = dgvRow.Cells["MaTL"].Value;
                row[1] = dgvRow.Cells["TenTheLoai"].Value;

                dataTable.Rows.Add(row);
            }

            ExportFileGenre(dataTable, "Thể loại", "DANH SÁCH THỂ LOẠI");
        }

        private void btnPrintGenre_Click(object sender, EventArgs e)
        {
            List<GenreDTO> list = GenreDAO.Instance.GetListGenre();
            rptGenre r = new rptGenre();
            r.SetDataSource(list);
            fReport f = new fReport();
            f.crvReport.ReportSource = r;
            f.ShowDialog();
        }

        private void btnExportMovie_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            DataColumn col1 = new DataColumn("MaPhim");
            DataColumn col2 = new DataColumn("TenPhim");
            DataColumn col3 = new DataColumn("MaPL");
            DataColumn col4 = new DataColumn("DaoDien");
            DataColumn col5 = new DataColumn("QuocGia");
            DataColumn col6 = new DataColumn("ThoiLuong");
            DataColumn col7 = new DataColumn("NgayKhoiChieu");
            DataColumn col8 = new DataColumn("TheLoaiPhim");

            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);
            dataTable.Columns.Add(col4);
            dataTable.Columns.Add(col5);
            dataTable.Columns.Add(col6);
            dataTable.Columns.Add(col7);
            dataTable.Columns.Add(col8);

            foreach (DataGridViewRow dgvRow in dgvMovie.Rows)
            {
                DataRow row = dataTable.NewRow();

                row[0] = dgvRow.Cells["MaPhim"].Value;
                row[1] = dgvRow.Cells["TenPhim"].Value;
                row[2] = dgvRow.Cells["MaPL"].Value;
                row[3] = dgvRow.Cells["DaoDien"].Value;
                row[4] = dgvRow.Cells["QuocGia"].Value;
                row[5] = dgvRow.Cells["ThoiLuong"].Value;
                row[6] = ((DateTime)dgvRow.Cells["NgayKhoiChieu"].Value).ToString("dd/MM/yyyy");
                row[7] = dgvRow.Cells["TheLoaiPhim"].Value;

                dataTable.Rows.Add(row);
            }

            ExportFileMovie(dataTable, "Phim", "DANH SÁCH PHIM", txtGenreName.Text);
        }

        private void btnPrintMovie_Click(object sender, EventArgs e)
        {
            List<MovieDetailDTO> list = MovieDetailDAO.Instance.GetListMoiveDetailByGenreName(txtGenreName.Text);
            //TextObject text = rptMovie.ReportDefinition.Section["Section3"].ReportObjects["tobTheLoai"];
            //text.Text = txtGenreName.Text;

            //rptMovieByGenre r = new rptMovieByGenre();
            //r.SetDataSource(list);
            //fReportMovieByGenre f = new fReportMovieByGenre(txtGenreName.Text);
            //f.crvReport.ReportSource = r;
            //f.ShowDialog();
        }
        #endregion
    }
}
