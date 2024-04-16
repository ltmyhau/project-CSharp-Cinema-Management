using BetaCinema.DAO;
using BetaCinema.DTO;
using BetaCinema.GUI.Admin.Showtimes;
using BetaCinema.GUI.Employee.Showtimes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetaCinema.GUI.Employee.Movie
{
    public partial class fEShowtimes : Form
    {
        private DataGridViewRow selectedRow;
        int soGheTrong = 0;

        public fEShowtimes()
        {
            InitializeComponent();

        }

        #region Methods
        void LoadShowtimes()
        {
            DateTime ngayChieu = dtpDate.Value;
            dgvShowtimes.DataSource = ShowtimesDAO.Instance.GetShowtimesByDate(ngayChieu);
        }

        private void CustomizeDataGridView()
        {
            DataGridViewTextBoxColumn gheTrongTongGheColumn = new DataGridViewTextBoxColumn();
            gheTrongTongGheColumn.Name = "GheTrongTongGhe";
            gheTrongTongGheColumn.HeaderText = "Số ghế trống";
            dgvShowtimes.Columns.Add(gheTrongTongGheColumn);

            dgvShowtimes.EnableHeadersVisualStyles = false;
            dgvShowtimes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(1, 81, 152);
            dgvShowtimes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvShowtimes.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvShowtimes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvShowtimes.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvShowtimes.RowTemplate.Height = 30;

            dgvShowtimes.Columns["ThoiGianBD"].HeaderText = "Giờ bắt đầu";
            dgvShowtimes.Columns["ThoiGianKT"].HeaderText = "Giờ kết thúc";
            dgvShowtimes.Columns["TenPhong"].HeaderText = "Phòng chiếu";
            dgvShowtimes.Columns["TenPhim"].HeaderText = "Tên phim";

            dgvShowtimes.Columns["ThoiGianBD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvShowtimes.Columns["ThoiGianKT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvShowtimes.Columns["TenPhong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvShowtimes.Columns["GheTrongTongGhe"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvShowtimes.Columns["MaSC"].Visible = false;
            dgvShowtimes.Columns["MaPhong"].Visible = false;
            dgvShowtimes.Columns["MaPhim"].Visible = false;
            dgvShowtimes.Columns["ThoiLuong"].Visible = false;
            dgvShowtimes.Columns["SoGheTrong"].Visible = false;
            dgvShowtimes.Columns["TongSoGhe"].Visible = false;
        }

        private void SetColumnWidthsInPercentage()
        {
            int totalWidth = dgvShowtimes.Width;
            if (dgvShowtimes.Columns.Contains("GheTrongTongGhe"))
            {
                dgvShowtimes.Columns["GheTrongTongGhe"].Width = (int)(0.2 * totalWidth);
            }
            dgvShowtimes.Columns["ThoiGianBD"].Width = (int)(0.15 * totalWidth);
            dgvShowtimes.Columns["ThoiGianKT"].Width = (int)(0.15 * totalWidth);
            dgvShowtimes.Columns["TenPhong"].Width = (int)(0.15 * totalWidth);
            dgvShowtimes.Columns["TenPhim"].Width = (int)(0.35 * totalWidth);
            dgvShowtimes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }
        private void OpenShowtimesDetail(DataGridViewRow selectedRow)
        {
            fEShowtimesDetail f = new fEShowtimesDetail();
            f.Text = "Chọn ghế";
            f.LoadData(selectedRow);
            f.ShowDialog();
        }
        #endregion

        #region Events
        private void fEMovie_Load(object sender, EventArgs e)
        {
            LoadShowtimes();
            CustomizeDataGridView();
            this.SizeChanged += fShowtimes_SizeChanged;
            SetColumnWidthsInPercentage();
        }

        private void fShowtimes_SizeChanged(object sender, EventArgs e)
        {
            SetColumnWidthsInPercentage();
        }
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            LoadShowtimes();
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

            if (dgvShowtimes.Columns[e.ColumnIndex].Name == "GheTrongTongGhe")
            {
                int soGheTrong = Convert.ToInt32(dgvShowtimes.Rows[e.RowIndex].Cells["SoGheTrong"].Value);
                int tongSoGhe = Convert.ToInt32(dgvShowtimes.Rows[e.RowIndex].Cells["TongSoGhe"].Value);
                string soGheDaDat = $"{soGheTrong} / {tongSoGhe}";
                e.Value = soGheDaDat;
                e.FormattingApplied = true;
                dgvShowtimes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = soGheDaDat;
            }
        }

        private void dgvShowtimes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = dgvShowtimes.Rows[e.RowIndex];
            soGheTrong = Convert.ToInt32(dgvShowtimes.Rows[e.RowIndex].Cells["SoGheTrong"].Value);

            pnlMoiveInfo.Visible = true;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string gioBD = DateTime.Parse(dgvShowtimes.Rows[e.RowIndex].Cells["ThoiGianBD"].Value?.ToString()).ToString("HH:mm");
                string gioKT = DateTime.Parse(dgvShowtimes.Rows[e.RowIndex].Cells["ThoiGianKT"].Value?.ToString()).ToString("HH:mm");
                txtDatetime.Text = $"{dtpDate.Value.ToString("dd/MM/yyyy")} {gioBD} ~ {gioKT}";

                string movieID = dgvShowtimes.Rows[e.RowIndex].Cells["MaPhim"].Value.ToString();

                List<MovieDetailDTO> movieDetailsList = MovieDetailDAO.Instance.GetListMoiveDetailByMovieID(movieID);
                if (movieDetailsList != null && movieDetailsList.Count > 0)
                {
                    MovieDetailDTO movieDetail = movieDetailsList[0];
                    txtMovieName.Text = movieDetail.TenPhim;
                    lblCountry.Text = movieDetail.QuocGia;
                    lblDuration.Text = movieDetail.ThoiLuong.ToString() + " phút";
                    lblGenre.Text = movieDetail.TheLoaiPhim;

                    if (movieDetail.Poster != null)
                    {
                        byte[] posterData = (byte[])movieDetail.Poster;
                        using (MemoryStream ms = new MemoryStream(posterData))
                        {
                            picPoster.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        picPoster.Image = Properties.Resources.poster;
                    }

                    List<MovieRatingSystemDTO> phanLoaiList = MovieRatingSystemDAO.Instance.GetListMovieRatingSystemByID(movieDetail.MaPL);
                    if (phanLoaiList != null && phanLoaiList.Count > 0)
                    {
                        MovieRatingSystemDTO phanLoai = phanLoaiList[0];
                        lblMovieRating.Text = phanLoai.TenPL;
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvShowtimes.DataSource = ShowtimesDAO.Instance.GetShowtimesByDateAndMovieName(dtpDate.Value, txtSearch.Text);
        }

        private void dgvShowtimes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenShowtimesDetail(dgvShowtimes.Rows[e.RowIndex]);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (soGheTrong >= 0)
            {
                OpenShowtimesDetail(selectedRow);
            }
            else
            {
                MessageBox.Show("Suất chiếu này đã hết! Vui lòng chọn suất chiếu khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
