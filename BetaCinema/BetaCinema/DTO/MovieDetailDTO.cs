using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetaCinema.DTO
{
    public class MovieDetailDTO
    {
        private string maPhim;
        private string tenPhim;
        private string maPL;
        private byte[] bieuTuongPL;
        private string daoDien;
        private string quocGia;
        private int thoiLuong;
        private DateTime ngayKhoiChieu;
        private string moTa;
        private byte[] poster;
        private string trailer;
        private string theLoaiPhim;

        public string MaPhim { get => maPhim; set => maPhim = value; }
        public string TenPhim { get => tenPhim; set => tenPhim = value; }
        public string MaPL { get => maPL; set => maPL = value; }
        public byte[] BieuTuongPL { get => bieuTuongPL; set => bieuTuongPL = value; }
        public string DaoDien { get => daoDien; set => daoDien = value; }
        public string QuocGia { get => quocGia; set => quocGia = value; }
        public int ThoiLuong { get => thoiLuong; set => thoiLuong = value; }
        public DateTime NgayKhoiChieu { get => ngayKhoiChieu; set => ngayKhoiChieu = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public byte[] Poster { get => poster; set => poster = value; }
        public string Trailer { get => trailer; set => trailer = value; }
        public string TheLoaiPhim { get => theLoaiPhim; set => theLoaiPhim = value; }

        public MovieDetailDTO(string maPhim, string tenPhim, string maPL, byte[] bieuTuongPL, string daoDien, string quocGia, int thoiLuong, DateTime ngayKhoiChieu, string moTa, byte[] poster, string trailer, string theLoaiPhim)
        {
            this.maPhim = maPhim;
            this.tenPhim = tenPhim;
            this.maPL = maPL;
            this.bieuTuongPL = bieuTuongPL;
            this.daoDien = daoDien;
            this.quocGia = quocGia;
            this.thoiLuong = thoiLuong;
            this.ngayKhoiChieu = ngayKhoiChieu;
            this.moTa = moTa;
            this.poster = poster;
            this.trailer = trailer;
            this.theLoaiPhim = theLoaiPhim;
        }

        public MovieDetailDTO(DataRow row)
        {
            this.maPhim = row["maPhim"].ToString();
            this.tenPhim = row["tenPhim"].ToString();
            this.maPL = row["maPL"].ToString();
            this.bieuTuongPL = row["bieuTuongPL"] as byte[];
            this.daoDien = row["daoDien"].ToString();
            this.quocGia = row["quocGia"].ToString();
            this.thoiLuong = Convert.ToInt32(row["thoiLuong"]);
            this.ngayKhoiChieu = Convert.ToDateTime(row["ngayKhoiChieu"]);
            this.moTa = row["moTa"].ToString();
            this.poster = row["poster"] as byte[];
            this.trailer = row["trailer"].ToString();
            this.theLoaiPhim = row["theLoaiPhim"].ToString();
        }
    }
}
