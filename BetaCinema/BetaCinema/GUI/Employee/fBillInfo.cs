using BetaCinema.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetaCinema.GUI.Employee
{
    public partial class fBillInfo : Form
    {
        public fBillInfo()
        {
            InitializeComponent();
        }

        #region Methods
        private bool InsertBillToDatabase()
        {
            //RoomDTO room = (RoomDTO)cboRoom.SelectedItem;
            //string maPhong = room.MaPhong;
            //BetaCinema.DTO.MovieDTO movie = (BetaCinema.DTO.MovieDTO)cboMovie.SelectedItem;
            //string maPhim = movie.MaPhim;
            //string ngayChieu = dtpDate.Value.ToString("dd/MM/yyyy");
            //string gioBD = dtpTime.Value.ToString("HH:mm:ss");
            //DateTime ngayGioChieu = DateTime.ParseExact(ngayChieu + " " + gioBD, "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);

            string maKH = "";
            string maNV = "";
            DateTime ngayTao = DateTime.Now;

            return BillDAO.Instance.InsertBill(maKH, maNV, ngayTao);
        }
        #endregion

        #region Events

        #endregion
    }
}
