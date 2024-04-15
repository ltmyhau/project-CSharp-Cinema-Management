using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BetaCinema.DAO;
using BetaCinema.DTO;
using BetaCinema.GUI;
using BetaCinema.GUI.Admin.Movie;

namespace BetaCinema
{
    public partial class fMovie : Form
    {
        public fMovie()
        {
            InitializeComponent();
        }

        #region Methods
        public void LoadListMovie()
        {
            dgvMovie.DataSource = MovieDetailDAO.Instance.GetListMoiveDetail();
        }

        private void CustomizeDataGridView()
        {
            DataGridViewImageColumn editImageColumn = new DataGridViewImageColumn();
            editImageColumn.Name = "EditColumn";
            editImageColumn.HeaderText = "Chỉnh sửa";
            editImageColumn.Image = Properties.Resources.edit;
            dgvMovie.Columns.Add(editImageColumn);

            DataGridViewImageColumn deleteImageColumn = new DataGridViewImageColumn();
            deleteImageColumn.Name = "DeleteColumn";
            deleteImageColumn.HeaderText = "Xóa";
            deleteImageColumn.Image = Properties.Resources.delete;
            dgvMovie.Columns.Add(deleteImageColumn);

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
            dgvMovie.Columns["DaoDien"].HeaderText = "Đạo diễn";
            dgvMovie.Columns["QuocGia"].HeaderText = "Quốc gia";
            dgvMovie.Columns["ThoiLuong"].HeaderText = "Thời lượng";
            dgvMovie.Columns["NgayKhoiChieu"].HeaderText = "Ngày khởi chiếu";
            dgvMovie.Columns["TheLoaiPhim"].HeaderText = "Thể loại";

            dgvMovie.Columns["MaPhim"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMovie.Columns["ThoiLuong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMovie.Columns["NgayKhoiChieu"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvMovie.Columns["MaPL"].Visible = false;
            dgvMovie.Columns["MoTa"].Visible = false;
            dgvMovie.Columns["Poster"].Visible = false;
            dgvMovie.Columns["Trailer"].Visible = false;
        }

        private void SetColumnWidthsInPercentage()
        {
            int totalWidth = dgvMovie.Width;

            dgvMovie.Columns["MaPhim"].Width = (int)(0.08 * totalWidth);
            dgvMovie.Columns["TenPhim"].Width = (int)(0.2 * totalWidth);
            dgvMovie.Columns["BieuTuongPL"].Width = (int)(0.07 * totalWidth);
            dgvMovie.Columns["DaoDien"].Width = (int)(0.1 * totalWidth);
            dgvMovie.Columns["QuocGia"].Width = (int)(0.1 * totalWidth);
            dgvMovie.Columns["ThoiLuong"].Width = (int)(0.05 * totalWidth);
            dgvMovie.Columns["NgayKhoiChieu"].Width = (int)(0.13 * totalWidth);
            dgvMovie.Columns["TheLoaiPhim"].Width = (int)(0.15 * totalWidth);
            dgvMovie.Columns["EditColumn"].Width = (int)(0.055 * totalWidth);
            dgvMovie.Columns["DeleteColumn"].Width = (int)(0.055 * totalWidth);

            dgvMovie.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        public void ExportFile(DataTable dataTable, string sheetName, string title)
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

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Mã phim";
            cl1.ColumnWidth = 10;
            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Tên phim";
            cl2.ColumnWidth = 40;
            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Phân loại";
            cl3.ColumnWidth = 10;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Đạo diễn";
            cl4.ColumnWidth = 20;
            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Quốc gia";
            cl5.ColumnWidth = 13;
            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "Thời lượng (phút)";
            cl6.ColumnWidth = 17;
            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "Ngày khời chiếu";
            cl7.ColumnWidth = 15;
            Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");
            cl8.Value2 = "Thể loại";
            cl8.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "H3");
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
            Microsoft.Office.Interop.Excel.Range c03 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, colStart + 2];
            Microsoft.Office.Interop.Excel.Range cN3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, colStart + 2];
            oSheet.get_Range(c03, cN3).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
            Microsoft.Office.Interop.Excel.Range c0N = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, colEnd];
            Microsoft.Office.Interop.Excel.Range cNN = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, colEnd];
            oSheet.get_Range(c0N, cNN).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
        }
        #endregion

        #region Events
        private void fMovie_Load(object sender, EventArgs e)
        {
            LoadListMovie();
            CustomizeDataGridView();
            this.SizeChanged += fMovie_SizeChanged;
            SetColumnWidthsInPercentage();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fAddEditMovie f = new fAddEditMovie();
            f.ShowDialog();
        }

        private void dgvMovie_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = dgvMovie.Columns[e.ColumnIndex].Name;
            if (e.RowIndex == -1 || columnName == "EditColumn" || columnName == "DeleteColumn")
            {
                return;
            }
            DataGridViewRow selectedRow = dgvMovie.CurrentRow;
            fMovieDetail f = new fMovieDetail();
            f.Text = "Chi tiết phim";
            f.LoadData(selectedRow);
            f.ShowDialog();
        }

        private void fMovie_SizeChanged(object sender, EventArgs e)
        {
            SetColumnWidthsInPercentage();
        }

        private void dgvMovie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            if (e.ColumnIndex == dgvMovie.Columns["EditColumn"].Index)
            {
                fAddEditMovie f = new fAddEditMovie();
                f.Text = "Chỉnh sửa thông tin phim";
                f.LoadData(dgvMovie.Rows[e.RowIndex]);
                f.ShowDialog();
            }

            if (e.ColumnIndex == dgvMovie.Columns["DeleteColumn"].Index)
            {
                if (MessageBox.Show("Bạn muốn xóa phim này? Tất cả thông tin liên quan cũng sẽ bị xóa.\r\n\r\nBạn có thực sự muốn xóa?", "Thông báo", 
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    string maPhim = dgvMovie.Rows[e.RowIndex].Cells["MaPhim"].Value.ToString();
                    if (MovieDAO.Instance.DeleteMovie(maPhim))
                    {
                        MessageBox.Show("Đã xóa phim thành công.", "Thông báo", MessageBoxButtons.OK);
                        LoadListMovie();
                    }
                    else
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi xóa phim.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                if (rdoMovieID.Checked)
                {
                    dgvMovie.DataSource = MovieDetailDAO.Instance.GetListMoiveDetailByMovieID(txtSearch.Text);
                }
                else
                {
                    dgvMovie.DataSource = MovieDetailDAO.Instance.GetListMoiveDetailByMovieName(txtSearch.Text);
                }
            }
            else
            {
                LoadListMovie();
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadListMovie();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            List<MovieDetailDTO> list = MovieDetailDAO.Instance.GetListMoiveDetail();
            rptMovie r = new rptMovie();
            r.SetDataSource(list);
            fReport f = new fReport();
            f.crvReport.ReportSource = r;
            f.ShowDialog();
        }

        private void btnExport_Click(object sender, EventArgs e)
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

            ExportFile(dataTable, "Phim", "DANH SÁCH PHIM");
        }
        #endregion
    }
}
