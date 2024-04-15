using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BetaCinema.DTO
{
    public class ShowtimesDTO
    {
        private string maSC;
        private string maPhong;
        private string tenPhong;
        private string maPhim;
        private string tenPhim;
        private int thoiLuong;
        private DateTime thoiGianBD;
        private DateTime thoiGianKT;
        private int soGheTrong;
        private int tongSoGhe;

        public string MaSC { get => maSC; set => maSC = value; }
        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string TenPhong { get => tenPhong; set => tenPhong = value; }
        public string MaPhim { get => maPhim; set => maPhim = value; }
        public string TenPhim { get => tenPhim; set => tenPhim = value; }
        public int ThoiLuong { get => thoiLuong; set => thoiLuong = value; }
        public DateTime ThoiGianBD { get => thoiGianBD; set => thoiGianBD = value; }
        public DateTime ThoiGianKT { get => thoiGianKT; set => thoiGianKT = value; }
        public int SoGheTrong { get => soGheTrong; set => soGheTrong = value; }
        public int TongSoGhe { get => tongSoGhe; set => tongSoGhe = value; }

        public ShowtimesDTO(string maSC, string maPhong, string tenPhong, string maPhim, string tenPhim, int thoiLuong, DateTime thoiGianBD, int soGheTrong, int tongSoGhe)
        {
            this.maSC = maSC;
            this.maPhong = maPhong;
            this.tenPhong = tenPhong;
            this.maPhim = maPhim;
            this.tenPhim = tenPhim;
            this.thoiLuong = thoiLuong;
            this.thoiGianBD = thoiGianBD;
            this.soGheTrong = soGheTrong;
            this.tongSoGhe = tongSoGhe;
        }

        public ShowtimesDTO(DataRow row)
        {
            this.maSC = row["maSC"].ToString();
            this.maPhong = row["maPhong"].ToString();
            this.tenPhong = row["tenPhong"].ToString();
            this.maPhim = row["maPhim"].ToString();
            this.tenPhim = row["tenPhim"].ToString();
            this.thoiLuong = Convert.ToInt32(row["thoiLuong"]);
            this.thoiGianBD = Convert.ToDateTime(row["thoiGian"]);
            this.thoiGianKT = this.thoiGianBD.AddMinutes(thoiLuong);
            this.soGheTrong = Convert.ToInt32(row["soGheTrong"]);
            this.tongSoGhe = Convert.ToInt32(row["tongSoGhe"]);
        }
    }
}
