using BetaCinema.DAO;
using BetaCinema.DTO;
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

namespace BetaCinema.GUI.Employee.Showtimes
{
    public partial class fEShowtimesDetail : Form
    {
        private Dictionary<string, bool> seatStatus = new Dictionary<string, bool>();
        private List<string> selectedSeats = new List<string>();
        private double totalAmount = 0;

        public fEShowtimesDetail()
        {
            InitializeComponent();
        }

        #region Methods
        public void LoadData(DataGridViewRow selectedRow)
        {
            string maSC = selectedRow.Cells["MaSC"].Value?.ToString();
            LoadSeat(maSC);

            string tenPhim = selectedRow.Cells["TenPhim"].Value?.ToString();
            string tenPhong = selectedRow.Cells["TenPhong"].Value?.ToString();
            string ngayChieu = DateTime.Parse(selectedRow.Cells["ThoiGianBD"].Value?.ToString()).ToString("dd/MM/yyyy");
            string gioBD = DateTime.Parse(selectedRow.Cells["ThoiGianBD"].Value?.ToString()).ToString("HH:mm");
            string gioKT = DateTime.Parse(selectedRow.Cells["ThoiGianKT"].Value?.ToString()).ToString("HH:mm");

            txtMovieName.Text = tenPhim;
            txtRoom.Text = tenPhong;
            txtDate.Text = ngayChieu;
            txtTime.Text = $"{gioBD} ~ {gioKT}";
        }

        private void LoadSeat(string maSC)
        {
            List<SeatDetailDTO> seatList = SeatDetailDAO.Instance.GetListSeatDetailByShowtimesID(maSC);

            foreach (SeatDetailDTO seat in seatList)
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
                            seatStatus[seat.MaGhe] = false;
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

                            btn.Click += (sender, e) =>
                            {
                                Button clickedButton = sender as Button;
                                string seatName = clickedButton.Text;
                                if (seatStatus[seatName])
                                {
                                    selectedSeats.Remove(seatName);
                                    totalAmount -= seat.GiaGhe;
                                }
                                else
                                {
                                    selectedSeats.Add(seatName);
                                    totalAmount += seat.GiaGhe;
                                }
                                txtSeats.Text = string.Join(", ", selectedSeats);
                                seatStatus[seatName] = !seatStatus[seatName];
                                UpdateSeatColor(clickedButton, seat);
                                txtTotal.Text = string.Format("{0:N0} đ", totalAmount);
                            };
                        }
                        break;
                    default:
                        btn.BackColor = Color.FromArgb(199, 200, 204);
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
                        btn.Click += (sender, e) =>
                        {
                            MessageBox.Show("Ghế này đã được đặt! Vui lòng chọn ghế khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        };
                        break;
                }
                flpSeat.Controls.Add(btn);
            }
        }

        private void UpdateSeatColor(Button button, SeatDetailDTO seat)
        {
            if (seatStatus[seat.MaGhe])
            {
                button.BackColor = Color.Yellow;
            }
            else
            {
                switch (seat.MaLoaiGhe)
                {
                    case "GTHG":
                        button.BackColor = Color.FromArgb(0, 110, 230);
                        break;
                    case "GVIP":
                        button.BackColor = Color.FromArgb(231, 41, 41);
                        break;
                    default:
                        button.BackColor = Color.FromArgb(255, 113, 205);
                        break;
                }
            }
        }
        #endregion

        #region Events

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (selectedSeats.Count > 0)
            {

            }
            else
            {
                MessageBox.Show("Vui lòng chọn ít nhất một ghế.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
    }
}
