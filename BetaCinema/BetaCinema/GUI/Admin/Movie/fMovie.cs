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

        private void fMovie_Load(object sender, EventArgs e)
        {
            LoadListMovie();
            CustomizeDataGridView();
            this.SizeChanged += fMovie_SizeChanged;
            SetColumnWidthsInPercentage();
        }

        private void LoadListMovie()
        {
            dgvMovie.DataSource = MovieDetailDAO.Instance.GetListMoiveDetail();
        }

        private void CustomizeDataGridView()
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
            dgvMovie.Columns["DaoDien"].HeaderText = "Đạo diễn";
            dgvMovie.Columns["QuocGia"].HeaderText = "Quốc gia";
            dgvMovie.Columns["ThoiLuong"].HeaderText = "Thời lượng";
            dgvMovie.Columns["NgayKhoiChieu"].HeaderText = "Ngày khởi chiếu";
            dgvMovie.Columns["TheLoaiPhim"].HeaderText = "Thể loại";

            dgvMovie.Columns["MaPhim"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMovie.Columns["QuocGia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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

            dgvMovie.Columns["MaPhim"].Width = (int)(0.1 * totalWidth);
            dgvMovie.Columns["TenPhim"].Width = (int)(0.2 * totalWidth);
            dgvMovie.Columns["BieuTuongPL"].Width = (int)(0.1 * totalWidth);
            dgvMovie.Columns["DaoDien"].Width = (int)(0.1 * totalWidth);
            dgvMovie.Columns["QuocGia"].Width = (int)(0.1 * totalWidth);
            dgvMovie.Columns["ThoiLuong"].Width = (int)(0.1 * totalWidth);
            dgvMovie.Columns["NgayKhoiChieu"].Width = (int)(0.15 * totalWidth);
            dgvMovie.Columns["TheLoaiPhim"].Width = (int)(0.15 * totalWidth);

            dgvMovie.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fAddMovie f = new fAddMovie();
            f.Show();
        }

        private void dgvMovie_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            DataGridViewRow selectedRow = dgvMovie.CurrentRow;
            fMovieDetail fMovieDetail = new fMovieDetail();
            fMovieDetail.LoadData(selectedRow);
            fMovieDetail.Show();
        }

        private void fMovie_SizeChanged(object sender, EventArgs e)
        {
            SetColumnWidthsInPercentage();
        }
    }
}
