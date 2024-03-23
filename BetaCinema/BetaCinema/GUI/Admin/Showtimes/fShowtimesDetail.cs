using BetaCinema.DAO;
using BetaCinema.DTO;
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
        }

        public void LoadData(DataGridViewRow selectedRow)
        {
            txtTenPhim.Text = selectedRow.Cells["TenPhim"].Value?.ToString();
            txtPhongChieu.Text = selectedRow.Cells["TenPhong"].Value?.ToString();
            txtNgayChieu.Text = DateTime.Parse(selectedRow.Cells["ThoiGianBD"].Value?.ToString()).ToString("dd/MM/yyyy");
            string gioChieu = DateTime.Parse(selectedRow.Cells["ThoiGianBD"].Value?.ToString()).ToString("HH:mm");
            gioChieu += " ~ ";
            gioChieu += DateTime.Parse(selectedRow.Cells["ThoiGianKT"].Value?.ToString()).ToString("HH:mm");
            txtGioChieu.Text = gioChieu;

            string maSC = selectedRow.Cells["MaSC"].Value?.ToString();
            LoadSeat(maSC);
        }

        private void LoadSeat(string maSC)
        {
            List<SeatDetail> seatList = SeatDetailDAO.Instance.GetListSeatDetailByShowtimesID(maSC);

            foreach (SeatDetail seat in seatList)
            {
                int btnWidth = 50;
                int btnHeight = 50;

                Button btn = new Button()
                {
                    Width = 50,
                    Height = 50
                };
                btn.Text = seat.MaGhe;

                switch (seat.TinhTrang)
                {
                    case "Trống":
                        //{
                        //    switch()
                        //    {
                        //        case 0:
                        //            Console.WriteLine("InnerValue is 1");
                        //            break;
                        //    }    
                        //}
                        break;
                    default:
                        btn.BackColor = SystemColors.Control;
                        break;
                }

                flpSeat.Controls.Add(btn);
            }
        }
    }
}
