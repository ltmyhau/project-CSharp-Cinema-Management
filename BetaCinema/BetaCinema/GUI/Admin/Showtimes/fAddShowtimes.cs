using BetaCinema.DAO;
using BetaCinema.DTO;
using BetaCinema.GUI.Admin.Showtime;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetaCinema.GUI.Admin.Showtimes
{
    public partial class fAddShowtimes : Form
    {
        public fAddShowtimes()
        {
            InitializeComponent();

            LoadRoom();
            LoadMovie();
            txtShowtimesID.Text = ShowtimesDAO.Instance.GetNextShowtimesID();
            dtpTime.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 00, 00, 00);
        }

        #region Methods
        void LoadRoom()
        {
            cboRoom.Items.Clear();
            List<RoomDTO> listRoom = RoomDAO.Instance.GetRoomList();
            cboRoom.DataSource = listRoom;
            cboRoom.DisplayMember = "TenPhong";
        }

        void LoadMovie()
        {
            cboMovie.Items.Clear();
            List<BetaCinema.DTO.MovieDTO> listMovie = MovieDAO.Instance.GetMovieList();
            cboMovie.DataSource = listMovie;
            cboMovie.DisplayMember = "TenPhim";
        }

        private bool InsertShowtimeToDatabase()
        {
            RoomDTO room = (RoomDTO)cboRoom.SelectedItem;
            string maPhong = room.MaPhong;
            BetaCinema.DTO.MovieDTO movie = (BetaCinema.DTO.MovieDTO)cboMovie.SelectedItem;
            string maPhim = movie.MaPhim;
            string ngayChieu = dtpDate.Value.ToString("dd/MM/yyyy");
            string gioBD = dtpTime.Value.ToString("HH:mm:ss");
            DateTime ngayGioChieu = DateTime.ParseExact(ngayChieu + " " + gioBD, "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);

            return ShowtimesDAO.Instance.InsertShowtimes(maPhong, maPhim, ngayGioChieu);
        }

        void showtimesInfo()
        {
            lblMovieName.Text = cboMovie.Text;
            lblDate.Text = dtpDate.Value.ToString("dd/MM/yyyy");
            lblTime.Text = dtpTime.Value.ToString("HH:mm") + " ~ " + dtpTime.Value.AddMinutes(thoiLuong).ToString("HH:mm");
            lblRoom.Text = cboRoom.Text;
        }
        #endregion

        #region Events
        private void fAddShowtimes_Load(object sender, EventArgs e)
        {
            showtimesInfo();
        }

        int thoiLuong = 0;
        private void cboMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            showtimesInfo();

            BetaCinema.DTO.MovieDTO movie = (BetaCinema.DTO.MovieDTO)cboMovie.SelectedItem;
            string maPhim = movie.MaPhim;
            List<MovieDetailDTO> movieList = MovieDetailDAO.Instance.GetListMoiveDetailByMovieID(maPhim);
            if (movieList != null && movieList.Count > 0)
            {
                MovieDetailDTO movieDetail = movieList[0];
                thoiLuong = movieDetail.ThoiLuong;
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
            }
        }

        private void cboRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            showtimesInfo();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            showtimesInfo();
        }

        private void dtpTime_ValueChanged(object sender, EventArgs e)
        {
            showtimesInfo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (InsertShowtimeToDatabase())
            {
                fShowtimes fShowtimes = Application.OpenForms.OfType<fShowtimes>().FirstOrDefault();
                if (fShowtimes != null)
                {
                    fShowtimes.ShowShowtimes();
                }
                MessageBox.Show("Đã thêm suất chiếu thành công.", "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                string finish = dtpTime.Value.AddMinutes(thoiLuong).ToString("HH:mm");
                string message = $"Khoảng thời gian từ {dtpTime.Value.ToString("HH:mm")} đến {finish} đã có phim chiếu tại {cboRoom.Text}";
                MessageBox.Show(message, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
