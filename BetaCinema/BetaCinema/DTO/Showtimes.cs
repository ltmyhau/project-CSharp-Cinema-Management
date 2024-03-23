using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BetaCinema.DTO
{
    public class Showtimes
    {
        private string maSC;
        private string maPhong;
        private string tenPhong;
        private string maPhim;
        private string tenPhim;
        private int thoiLuong;
        private DateTime thoiGianBD;
        private DateTime thoiGianKT;
        private string soGheDaDat;

        public string MaSC { get => maSC; set => maSC = value; }
        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string TenPhong { get => tenPhong; set => tenPhong = value; }
        public string MaPhim { get => maPhim; set => maPhim = value; }
        public string TenPhim { get => tenPhim; set => tenPhim = value; }
        public int ThoiLuong { get => thoiLuong; set => thoiLuong = value; }
        public DateTime ThoiGianBD { get => thoiGianBD; set => thoiGianBD = value; }
        public DateTime ThoiGianKT { get => thoiGianKT; set => thoiGianKT = value; }
        public string SoGheDaDat { get => soGheDaDat; set => soGheDaDat = value; }

        public Showtimes(string maSC, string maPhong, string tenPhong, string maPhim, string tenPhim, int thoiLuong, DateTime thoiGianBD, string soGheDaDat)
        {
            this.maSC = maSC;
            this.maPhong = maPhong;
            this.tenPhong = tenPhong;
            this.maPhim = maPhim;
            this.tenPhim = tenPhim;
            this.thoiLuong = thoiLuong;
            this.thoiGianBD = thoiGianBD;
            this.soGheDaDat = soGheDaDat;
        }

        public Showtimes(DataRow row)
        {
            this.maSC = row["maSC"].ToString();
            this.maPhong = row["maPhong"].ToString();
            this.tenPhong = row["tenPhong"].ToString();
            this.maPhim = row["maPhim"].ToString();
            this.tenPhim = row["tenPhim"].ToString();
            this.thoiLuong = Convert.ToInt32(row["thoiLuong"]);
            this.thoiGianBD = Convert.ToDateTime(row["thoiGian"]);
            this.thoiGianKT = this.thoiGianBD.AddMinutes(thoiLuong);
            this.soGheDaDat = row["soGheDaDat"].ToString();
        }
    }
}
