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
            dgvMovie.Columns["EditColumn"].Width = (int)(0.06 * totalWidth);
            dgvMovie.Columns["DeleteColumn"].Width = (int)(0.06 * totalWidth);

            dgvMovie.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
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
            f.Show();
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
            f.Text = "Thêm phim mới";
            f.LoadData(selectedRow);
            f.Show();
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
                f.Show();
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
        #endregion
    }
}
