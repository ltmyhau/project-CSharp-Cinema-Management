using BetaCinema.DAO;
using BetaCinema.DTO;
using BetaCinema.GUI.Admin.Movie;
using BetaCinema.GUI.Admin.Showtimes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetaCinema.GUI.Admin.Showtime
{
    public partial class fShowtimes : Form
    {
        public fShowtimes()
        {
            InitializeComponent();

            LoadMovie();
            dtpStart.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 00, 00, 00);
            dtpFinish.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
        }

        #region Methods
        void LoadMovie()
        {
            cboMovie.Items.Clear();
            List<BetaCinema.DTO.MovieDTO> listMovie = MovieDAO.Instance.GetMovieList();
            cboMovie.DataSource = listMovie;
            cboMovie.DisplayMember = "TenPhim";
        }

        RadioButton rdbAllRoom;
        void LoadRoom()
        {
            List<RoomDTO> roomList = RoomDAO.Instance.GetRoomList();

            rdbAllRoom = CreateRadioBtnRoom("Tất cả");
            rdbAllRoom.Padding = new Padding(16, 0, 0, 0);
            rdbAllRoom.CheckedChanged += RadioButton_CheckedChanged;
            rdbAllRoom.Checked = true;
            flpRoom.Controls.Add(rdbAllRoom);

            foreach (RoomDTO room in roomList)
            {
                RadioButton rdb = CreateRadioBtnRoom(room.TenPhong);
                rdb.Padding = new Padding(16, 0, 0, 0);
                rdb.CheckedChanged += RadioButton_CheckedChanged;
                rdb.Tag = room;
                flpRoom.Controls.Add(rdb);
            }
        }

        private RadioButton CreateRadioBtnRoom(string text)
        {
            RadioButton rdb = new RadioButton()
            {
                Width = RoomDAO.RoomWidth,
                Height = RoomDAO.RoomHeight,
                Text = text,
                Font = new Font("Segoe UI", 12),
                TextAlign = ContentAlignment.MiddleLeft,
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 },
                Appearance = Appearance.Button,
                Checked = false
            };
            return rdb;
        }

        public void ShowShowtimes()
        {
            MovieDTO movie = (MovieDTO)cboMovie.SelectedItem;
            string maPhim = movie.MaPhim;
            DateTime tuGio = dtpStart.Value;
            DateTime denGio = dtpFinish.Value;

            DateTime ngayChieu = dtpDate.Value;

            string maPhong = null;
            foreach (Control control in flpRoom.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    RoomDTO room = radioButton.Tag as RoomDTO;
                    if (room != null)
                    {
                        maPhong = room.MaPhong.ToString();
                    }
                    break;
                }
            }

            if (maPhong == null)
            {
                if (!chkMovieName.Checked && !chkMovieTime.Checked)
                {
                    dgvShowtimes.DataSource = ShowtimesDAO.Instance.GetShowtimesByDate(ngayChieu);
                }
                else if (chkMovieName.Checked && !chkMovieTime.Checked)
                {
                    dgvShowtimes.DataSource = ShowtimesDAO.Instance.GetShowtimesByDateAndMovieID(ngayChieu, maPhim);
                }
                else if (!chkMovieName.Checked && chkMovieTime.Checked)
                {
                    dgvShowtimes.DataSource = ShowtimesDAO.Instance.GetShowtimesByDateAndMovieTime(ngayChieu, tuGio, denGio);
                }
                else
                {
                    dgvShowtimes.DataSource = ShowtimesDAO.Instance.GetShowtimesByDateAndMovieIDMovieTime(ngayChieu, maPhim, tuGio, denGio);
                }
            }
            else
            {
                if (!chkMovieName.Checked && !chkMovieTime.Checked)
                {
                    dgvShowtimes.DataSource = ShowtimesDAO.Instance.GetShowtimesByDateAndRoomID(ngayChieu, maPhong);
                }
                else if (chkMovieName.Checked && !chkMovieTime.Checked)
                {
                    dgvShowtimes.DataSource = ShowtimesDAO.Instance.GetShowtimesByDateRoomIDAndMovieID(ngayChieu, maPhong, maPhim);
                }
                else if (!chkMovieName.Checked && chkMovieTime.Checked)
                {
                    dgvShowtimes.DataSource = ShowtimesDAO.Instance.GetShowtimesByDateRoomIDAndMovieTime(ngayChieu, maPhong, tuGio, denGio);
                }
                else
                {
                    dgvShowtimes.DataSource = ShowtimesDAO.Instance.GetShowtimesByDateRoomIDAndMovieIDMovieTime(ngayChieu, maPhong, maPhim, tuGio, denGio);
                }
            }
        }

        private void CustomizeDataGridView()
        {
            DataGridViewTextBoxColumn soGheDaDatColumn = new DataGridViewTextBoxColumn();
            soGheDaDatColumn.Name = "SoGheDaDat";
            soGheDaDatColumn.HeaderText = "Số ghế đã đặt";
            dgvShowtimes.Columns.Add(soGheDaDatColumn);

            DataGridViewImageColumn editImageColumn = new DataGridViewImageColumn();
            editImageColumn.Name = "EditColumn";
            editImageColumn.HeaderText = "Chỉnh sửa";
            editImageColumn.Image = Properties.Resources.edit;
            dgvShowtimes.Columns.Add(editImageColumn);

            DataGridViewImageColumn deleteImageColumn = new DataGridViewImageColumn();
            deleteImageColumn.Name = "DeleteColumn";
            deleteImageColumn.HeaderText = "Xóa";
            deleteImageColumn.Image = Properties.Resources.delete;
            dgvShowtimes.Columns.Add(deleteImageColumn);

            dgvShowtimes.EnableHeadersVisualStyles = false;
            dgvShowtimes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(1, 81, 152);
            dgvShowtimes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvShowtimes.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvShowtimes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvShowtimes.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvShowtimes.RowTemplate.Height = 30;

            dgvShowtimes.Columns["MaSC"].HeaderText = "Mã suất chiếu";
            dgvShowtimes.Columns["ThoiGianBD"].HeaderText = "Giờ bắt đầu";
            dgvShowtimes.Columns["ThoiGianKT"].HeaderText = "Giờ kết thúc";
            dgvShowtimes.Columns["TenPhong"].HeaderText = "Tên phòng";
            dgvShowtimes.Columns["TenPhim"].HeaderText = "Tên phim";
            
            dgvShowtimes.Columns["MaSC"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvShowtimes.Columns["ThoiGianBD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvShowtimes.Columns["ThoiGianKT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvShowtimes.Columns["TenPhong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            dgvShowtimes.Columns["MaPhong"].Visible = false;
            dgvShowtimes.Columns["MaPhim"].Visible = false;
            dgvShowtimes.Columns["ThoiLuong"].Visible = false;
            dgvShowtimes.Columns["SoGheTrong"].Visible = false;
            dgvShowtimes.Columns["TongSoGhe"].Visible = false;
        }

        private void SetColumnWidthsInPercentage()
        {
            int totalWidth = dgvShowtimes.Width;
            if (dgvShowtimes.Columns.Contains("EditColumn") && dgvShowtimes.Columns.Contains("DeleteColumn") && dgvShowtimes.Columns.Contains("SoGheDaDat"))
            {
                dgvShowtimes.Columns["EditColumn"].Width = (int)(0.07 * totalWidth);
                dgvShowtimes.Columns["DeleteColumn"].Width = (int)(0.07 * totalWidth);
                dgvShowtimes.Columns["SoGheDaDat"].Width = (int)(0.13 * totalWidth);
            }
            if (dgvShowtimes.Columns["TenPhong"].Visible is false)
            {
                dgvShowtimes.Columns["MaSC"].Width = (int)(0.13 * totalWidth);
                dgvShowtimes.Columns["ThoiGianBD"].Width = (int)(0.15 * totalWidth);
                dgvShowtimes.Columns["ThoiGianKT"].Width = (int)(0.15 * totalWidth);
                dgvShowtimes.Columns["TenPhim"].Width = (int)(0.3 * totalWidth);
            }
            else
            {
                dgvShowtimes.Columns["MaSC"].Width = (int)(0.13 * totalWidth);
                dgvShowtimes.Columns["ThoiGianBD"].Width = (int)(0.15 * totalWidth);
                dgvShowtimes.Columns["ThoiGianKT"].Width = (int)(0.15 * totalWidth);
                dgvShowtimes.Columns["TenPhong"].Width = (int)(0.1 * totalWidth);
                dgvShowtimes.Columns["TenPhim"].Width = (int)(0.2 * totalWidth);
            }

            dgvShowtimes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        public void ExportFile(DataTable dataTable, string sheetName, string title, DateTime date)
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

            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "F1");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Times New Roman";
            head.Font.Size = "20";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range cDate = oSheet.get_Range("E2", "F2");
            cDate.MergeCells = true;
            cDate.Value2 = "Ngày chiếu: " + date.ToString("dd/MM/yyyy");
            cDate.Font.Name = "Times New Roman";
            cDate.Font.Size = "11";
            cDate.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A4", "A4");
            cl1.Value2 = "Mã suất chiếu";
            cl1.ColumnWidth = 13;
            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B4", "B4");
            cl2.Value2 = "Tên phòng";
            cl2.ColumnWidth = 10;
            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C4", "C4");
            cl3.Value2 = "Tên phim";
            cl3.ColumnWidth = 40;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D4", "D4");
            cl4.Value2 = "Giờ bắt đầu";
            cl4.ColumnWidth = 13;
            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E4", "E4");
            cl5.Value2 = "Giờ kết thúc";
            cl5.ColumnWidth = 13;
            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F4", "F4");
            cl6.Value2 = "Số ghế đã đặt";
            cl6.ColumnWidth = 13;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A4", "F4");
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

            Microsoft.Office.Interop.Excel.Range c03 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, colStart + 2];
            Microsoft.Office.Interop.Excel.Range cN3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, colStart + 2];
            oSheet.get_Range(c03, cN3).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
        }
        #endregion

        #region Events
        private void fShowtimes_Load(object sender, EventArgs e)
        {
            LoadRoom();
            CustomizeDataGridView();
            this.SizeChanged += fShowtimes_SizeChanged;
            SetColumnWidthsInPercentage();
        }

        private void fShowtimes_SizeChanged(object sender, EventArgs e)
        {
            SetColumnWidthsInPercentage();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            radioButton.ForeColor = Color.FromArgb(1, 81, 152);

            foreach (Control control in flpRoom.Controls)
            {
                if (control is RadioButton && control != radioButton)
                {
                    RadioButton radioBtn = (RadioButton)control;
                    radioBtn.ForeColor = Color.Black;
                }
            }

            ShowShowtimes();

            if (radioButton == rdbAllRoom && radioButton.Checked)
            {
                dgvShowtimes.Columns["TenPhong"].Visible = true;
                SetColumnWidthsInPercentage();
            }
            else
            {
                dgvShowtimes.Columns["TenPhong"].Visible = false;
                SetColumnWidthsInPercentage();
            }
        }

        private void dgvShowtimes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvShowtimes.Columns[e.ColumnIndex].ValueType == typeof(DateTime))
            {
                if (e.Value != null)
                {
                    DateTime time = (DateTime)e.Value;
                    e.Value = time.ToString("HH:mm");
                    e.FormattingApplied = true;
                }
            }

            if (dgvShowtimes.Columns[e.ColumnIndex].Name == "SoGheDaDat")
            {
                int soGheTrong = Convert.ToInt32(dgvShowtimes.Rows[e.RowIndex].Cells["SoGheTrong"].Value);
                int tongSoGhe = Convert.ToInt32(dgvShowtimes.Rows[e.RowIndex].Cells["TongSoGhe"].Value);
                string soGheDaDat = $"{tongSoGhe - soGheTrong} / {tongSoGhe}";
                e.Value = soGheDaDat;
                e.FormattingApplied = true;
                dgvShowtimes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = soGheDaDat;
            }
        }

        private void dtpNgayChieu_ValueChanged(object sender, EventArgs e)
        {
            ShowShowtimes();
        }

        private void dgvShowtimes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            if (e.ColumnIndex == dgvShowtimes.Columns["EditColumn"].Index)
            {
                fShowtimesDetail f = new fShowtimesDetail();
                f.Text = "Thông tin suất chiếu";
                f.LoadData(dgvShowtimes.Rows[e.RowIndex]);
                f.ShowDialog();
            }

            if (e.ColumnIndex == dgvShowtimes.Columns["DeleteColumn"].Index)
            {
                if (MessageBox.Show("Bạn muốn xóa suất chiếu này? Tất cả thông tin liên quan cũng sẽ bị xóa.\r\n\r\nBạn có thực sự muốn xóa?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    string maSC = dgvShowtimes.Rows[e.RowIndex].Cells["MaSC"].Value.ToString();
                    if (ShowtimesDAO.Instance.DeleteShowtimes(maSC))
                    {
                        MessageBox.Show("Đã xóa suất chiếu thành công.", "Thông báo", MessageBoxButtons.OK);
                        ShowShowtimes();
                    }
                    else
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi xóa suất chiếu.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvShowtimes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fShowtimesDetail f = new fShowtimesDetail();
            f.Text = "Thông tin suất chiếu";
            f.LoadData(dgvShowtimes.Rows[e.RowIndex]);
            f.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShowShowtimes();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            chkMovieName.Checked = false;
            chkMovieTime.Checked = false;
            ShowShowtimes();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            List<BetaCinema.DTO.ShowtimesDTO> list = ShowtimesDAO.Instance.GetShowtimesByDate(dtpDate.Value);
            rptShowtimes r = new rptShowtimes();
            r.SetDataSource(list);
            fReport f = new fReport();
            f.crvReport.ReportSource = r;
            f.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fAddShowtimes f = new fAddShowtimes();
            f.ShowDialog();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            DataColumn col1 = new DataColumn("MaSC");
            DataColumn col2 = new DataColumn("TenPhong");
            DataColumn col3 = new DataColumn("TenPhim");
            DataColumn col4 = new DataColumn("ThoiGianBD");
            DataColumn col5 = new DataColumn("ThoiGianKT");
            DataColumn col6 = new DataColumn("SoGheDaDat");

            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);
            dataTable.Columns.Add(col4);
            dataTable.Columns.Add(col5);
            dataTable.Columns.Add(col6);

            foreach (DataGridViewRow dgvRow in dgvShowtimes.Rows)
            {
                DataRow row = dataTable.NewRow();

                row[0] = dgvRow.Cells["MaSC"].Value;
                row[1] = dgvRow.Cells["TenPhong"].Value;
                row[2] = dgvRow.Cells["TenPhim"].Value;
                row[3] = Convert.ToDateTime(dgvRow.Cells["ThoiGianBD"].Value).ToString("HH:mm");
                row[4] = Convert.ToDateTime(dgvRow.Cells["ThoiGianKT"].Value).ToString("HH:mm");
                row[5] = dgvRow.Cells["SoGheDaDat"].Value;

                dataTable.Rows.Add(row);
            }

            ExportFile(dataTable, "Suất chiếu", "DANH SÁCH SUẤT CHIẾU", dtpDate.Value);
        }
        #endregion
    }
}
