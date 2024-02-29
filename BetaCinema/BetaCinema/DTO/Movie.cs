using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetaCinema.DTO
{
    public class Movie
    {
        private string maPhim;
        private string tenPhim;
        private string maPL;
        private string daoDien;
        private string quocGia;
        private int thoiLuong;
        private DateTime ngayKhoiChieu;
        private string moTa;
        private byte[] poster;
        private string trailer;

        public string MaPhim { get => maPhim; set => maPhim = value; }
        public string TenPhim { get => tenPhim; set => tenPhim = value; }
        public string MaPL { get => maPL; set => maPL = value; }
        public string DaoDien { get => daoDien; set => daoDien = value; }
        public string QuocGia { get => quocGia; set => quocGia = value; }
        public int ThoiLuong { get => thoiLuong; set => thoiLuong = value; }
        public DateTime NgayKhoiChieu { get => ngayKhoiChieu; set => ngayKhoiChieu = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public byte[] Poster { get => poster; set => poster = value; }
        public string Trailer { get => trailer; set => trailer = value; }

        public Movie(string maPhim, string tenPhim, string maPL, string daoDien, string quocGia, int thoiLuong, DateTime ngayKhoiChieu, string moTa, byte[] poster, string trailer)
        {
            this.maPhim = maPhim;
            this.tenPhim = tenPhim;
            this.maPL = maPL;
            this.daoDien = daoDien;
            this.quocGia = quocGia;
            this.thoiLuong = thoiLuong;
            this.ngayKhoiChieu = ngayKhoiChieu;
            this.moTa = moTa;
            this.poster = poster;
            this.trailer = trailer;
        }

        public Movie(DataRow row)
        {
            this.maPhim = row["maPhim"].ToString();
            this.tenPhim = row["tenPhim"].ToString();
            this.maPL = row["maPL"].ToString();
            this.daoDien = row["daoDien"].ToString();
            this.quocGia = row["quocGia"].ToString();
            this.thoiLuong = Convert.ToInt32(row["ThoiLuong"]);
            this.ngayKhoiChieu = Convert.ToDateTime(row["NgayKhoiChieu"]);
            this.moTa = row["moTa"].ToString();
            this.poster = row["poster"] as byte[];
            this.trailer = row["trailer"].ToString();
        }
    }
}
