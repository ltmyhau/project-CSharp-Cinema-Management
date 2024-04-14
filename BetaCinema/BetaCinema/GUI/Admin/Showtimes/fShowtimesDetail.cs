using BetaCinema.DAO;
using BetaCinema.DTO;
using BetaCinema.GUI.Admin.Showtime;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetaCinema.GUI.Admin.Showtimes
{
    public partial class fShowtimesDetail : Form
    {
        public fShowtimesDetail()
        {
            InitializeComponent();

            LoadRoom();
            LoadMovie();
        }

        #region Methods

        int thoiLuong = 0;
        string maSC;
        string tenPhong;
        string tenPhim;
        DateTime ngayChieu;
        DateTime gioChieu;

        public void LoadData(DataGridViewRow selectedRow)
        {
            thoiLuong = int.Parse(selectedRow.Cells["ThoiLuong"].Value?.ToString());

            maSC = selectedRow.Cells["MaSC"].Value?.ToString();
            txtShowtimesID.Text = maSC;
            LoadSeat(maSC);

            foreach (Room item in cboRoom.Items)
            {
                if (item.MaPhong == selectedRow.Cells["MaPhong"].Value.ToString())
                {
                    cboRoom.SelectedItem = item;
                    tenPhong = item.TenPhong;
                    break;
                }
            }
            foreach (BetaCinema.DTO.Movie item in cboMovie.Items)
            {
                if (item.MaPhim == selectedRow.Cells["MaPhim"].Value.ToString())
                {
                    cboMovie.SelectedItem = item;
                    tenPhim = item.TenPhim;
                    break;
                }
            }
            ngayChieu = DateTime.Parse(selectedRow.Cells["ThoiGianBD"].Value?.ToString());
            dtpDate.Value = ngayChieu;
            gioChieu = DateTime.Parse(selectedRow.Cells["ThoiGianBD"].Value?.ToString());
            dtpStart.Value = gioChieu;
            txtFinish.Text = DateTime.Parse(selectedRow.Cells["ThoiGianKT"].Value?.ToString()).ToString("HH:mm");

            lblEmptySeats.Text = selectedRow.Cells["SoGheTrong"].Value?.ToString();
            lblTotalSeats.Text = selectedRow.Cells["TongSoGhe"].Value?.ToString();
            int soGheDaDat = int.Parse(lblTotalSeats.Text) - int.Parse(lblEmptySeats.Text);
            lblReservedSeats.Text = soGheDaDat.ToString();
        }

        void LoadRoom()
        {
            cboRoom.Items.Clear();
            List<Room> listRoom = RoomDAO.Instance.GetRoomList();
            cboRoom.DataSource = listRoom;
            cboRoom.DisplayMember = "TenPhong";
        }

        void LoadMovie()
        {
            cboMovie.Items.Clear();
            List<BetaCinema.DTO.Movie> listMovie = MovieDAO.Instance.GetMovieList();
            cboMovie.DataSource = listMovie;
            cboMovie.DisplayMember = "TenPhim";
        }

        private void LoadSeat(string maSC)
        {
            List<SeatDetail> seatList = SeatDetailDAO.Instance.GetListSeatDetailByShowtimesID(maSC);

            foreach (SeatDetail seat in seatList)
            {
                Button btn = new Button();
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;

                switch (seat.MaLoaiGhe)
                {
                    case "GDOI":
                        btn.Width = 106;
                        btn.Height = 50;
                        break;
                    default:
                        btn.Width = 50;
                        btn.Height = 50;
                        break;
                }

                btn.Text = seat.MaGhe;

                switch (seat.TinhTrang)
                {
                    case "Trống":
                        {
                            switch (seat.MaLoaiGhe)
                            {
                                case "GTHG":
                                    btn.BackColor = Color.FromArgb(0, 110, 230);
                                    break;
                                case "GVIP":
                                    btn.BackColor = Color.FromArgb(231, 41, 41);
                                    break;
                                default:
                                    btn.BackColor = Color.FromArgb(255, 113, 205);
                                    break;
                            }
                        }
                        break;
                    default:
                        btn.BackColor = Color.FromArgb(199, 200, 204);
                        btn.Enabled = false;
                        switch (seat.MaLoaiGhe)
                        {
                            case "GTHG":
                                btn.FlatAppearance.BorderSize = 1;
                                btn.FlatAppearance.BorderColor = Color.FromArgb(0, 110, 230);
                                break;
                            case "GVIP":
                                btn.FlatAppearance.BorderSize = 1;
                                btn.FlatAppearance.BorderColor = Color.FromArgb(231, 41, 41);
                                break;
                            default:
                                btn.FlatAppearance.BorderSize = 1;
                                btn.FlatAppearance.BorderColor = Color.FromArgb(255, 113, 205);
                                break;
                        }
                        break;
                }

                flpSeat.Controls.Add(btn);
            }
        }

        private bool UpdateShowtimeToDatabase()
        {
            string maSC = txtShowtimesID.Text;
            Room room = (Room)cboRoom.SelectedItem;
            string maPhong = room.MaPhong;
            BetaCinema.DTO.Movie movie = (BetaCinema.DTO.Movie)cboMovie.SelectedItem;
            string maPhim = movie.MaPhim;
            string ngayChieu = dtpDate.Value.ToString("dd/MM/yyyy");
            string gioBD = dtpStart.Value.ToString("HH:mm:ss");
            DateTime ngayGioChieu = DateTime.ParseExact(ngayChieu + " " + gioBD, "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);

            return ShowtimesDAO.Instance.UpdateShowtimes(maSC, maPhong, maPhim, ngayGioChieu);
        }
        #endregion

        #region Events
        private void fShowtimesDetail_Load(object sender, EventArgs e)
        {

        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            DateTime time = dtpStart.Value.AddMinutes(thoiLuong);
            txtFinish.Text = time.ToString("HH:mm");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cboRoom.Enabled = true;
            if (int.Parse(lblReservedSeats.Text) == 0)
            {
                cboMovie.Enabled = true;
                dtpDate.Enabled = true;
                dtpStart.Enabled = true;
            }
            btnSave.Visible = true;
            btnEdit.Visible = false; 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (UpdateShowtimeToDatabase())
            {
                fShowtimes fShowtimes = Application.OpenForms.OfType<fShowtimes>().FirstOrDefault();
                if (fShowtimes != null)
                {
                    fShowtimes.ShowShowtimes();
                }
                MessageBox.Show("Đã chỉnh sửa thông tin suất chiếu thành công.", "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                string message = $"Khoảng thời gian từ {dtpDate.Value.ToString("HH:mm")} đến {txtFinish.Text} đã có phim chiếu tại {cboRoom.Text}";
                MessageBox.Show(message, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboRoom.Text = tenPhong;
                cboMovie.Text = tenPhim;
                dtpDate.Value = ngayChieu;
                dtpStart.Value = gioChieu;
            }
            cboRoom.Enabled = false;
            cboMovie.Enabled = false;
            dtpDate.Enabled = false;
            dtpStart.Enabled = false;
            btnSave.Visible = false;
            btnEdit.Visible = true;
        }
        #endregion
    }
}
