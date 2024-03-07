using BetaCinema.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BetaCinema.DAO
{
    public class MovieDAO
    {
        private static MovieDAO instance;

        public static MovieDAO Instance
        {
            get => instance == null ? instance = new MovieDAO() : instance;
            private set => instance = value;
        }

        private MovieDAO() { }

        public bool InsertMovie(string tenPhim, string maPL, string daoDien, string quocGia, int thoiLuong, DateTime ngayKhoiChieu, byte[] poster, string trailer, string moTa)
        {
            string query = "INSERT INTO Phim (MaPhim, TenPhim, MaPL, DaoDien, QuocGia, ThoiLuong, NgayKhoiChieu, Poster, Trailer, MoTa) " +
                "VALUES (dbo.f_AutoMaPhim(), @tenPhim , @maPL , @daoDien , @quocGia , @thoiLuong , @ngayKhoiChieu , @poster , @trailer , @moTa )";
            object[] parameters = new object[]
            {
                tenPhim,
                maPL,
                (object)daoDien ?? DBNull.Value,
                (object)quocGia ?? DBNull.Value,
                thoiLuong,
                ngayKhoiChieu,
                poster,
                (object)trailer ?? DBNull.Value,
                (object)moTa ?? DBNull.Value
            };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        public string GetNextMaPhim()
        {
            string query = "SELECT 'P' + RIGHT('000' + CAST(MAX(RIGHT(MaPhim, 3)) + 1 AS VARCHAR(3)), 3) FROM Phim";
            string maPhim = DataProvider.Instance.ExecuteScalar(query)?.ToString();
            return maPhim;
        }

        public bool UpdateMovie(string maPhim, string tenPhim, string maPL, string daoDien, string quocGia, int thoiLuong, DateTime ngayKhoiChieu, byte[] poster, string trailer, string moTa)
        {
            string query = "UPDATE Phim SET TenPhim = @tenPhim , MaPL = @maPL , DaoDien = @daoDien , QuocGia = @quocGia , ThoiLuong = @thoiLuong , NgayKhoiChieu = @ngayKhoiChieu , Poster = @poster , Trailer = @trailer , MoTa = @moTa WHERE MaPhim = @maPhim";
            object[] parameters = new object[]
            {
                tenPhim,
                maPL,
                (object)daoDien ?? DBNull.Value,
                (object)quocGia ?? DBNull.Value,
                thoiLuong,
                ngayKhoiChieu,
                poster,
                (object)trailer ?? DBNull.Value,
                (object)moTa ?? DBNull.Value,
                maPhim
            };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        public bool DeleteMovie(string maPhim)
        {
            string query = string.Format("DELETE Phim WHERE MaPhim = N'{0}'", maPhim);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
