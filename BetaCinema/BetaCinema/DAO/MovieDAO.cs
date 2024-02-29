using BetaCinema.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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

        //public List<Movie> GetListMoive()
        //{
        //    List<Movie> list = new List<Movie>();
        //    string query = "SELECT * FROM Phim";
        //    DataTable data = DataProvider.Instance.ExecuteQuery(query);
        //    foreach (DataRow item in data.Rows)
        //    {
        //        Movie movie = new Movie(item);
        //        list.Add(movie);
        //    }
        //    return list;
        //}

        public bool InsertMovie(string tenPhim, string maPL, string quocGia, int thoiLuong, DateTime ngayKhoiChieu, byte[] poster, string trailer, string moTa)
        {
            //string query = String.Format("INSERT INTO Phim (MaPhim, TenPhim, MaPL, DaoDien, QuocGia, ThoiLuong, NgayKhoiChieu, Poster, Trailer, MoTa) VALUES " +
            //    "(dbo.f_AutoMaPhim(), N'{tenPhim}', '{maPL}', NULL, NULL, 99, CONVERT(DATETIME, '02/28/2024'), NULL, NULL, NULL)");
            //int result = DataProvider.Instance.ExecuteNonQuery(query);
            //return result > 0;

            string query = "INSERT INTO Phim (MaPhim, TenPhim, MaPL, QuocGia, ThoiLuong, NgayKhoiChieu, Poster, Trailer, MoTa) " +
                   "VALUES (dbo.f_AutoMaPhim(), @tenPhim, @maPL, @quocGia, @thoiLuong, @ngayKhoiChieu, @poster, @trailer, @moTa)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@tenPhim", SqlDbType.NVarChar) { Value = tenPhim },
                new SqlParameter("@maPL", SqlDbType.NVarChar) { Value = maPL },
                new SqlParameter("@quocGia", SqlDbType.NVarChar) { Value = quocGia },
                new SqlParameter("@thoiLuong", SqlDbType.Int) { Value = thoiLuong },
                new SqlParameter("@ngayKhoiChieu", SqlDbType.DateTime) { Value = ngayKhoiChieu },
                new SqlParameter("@poster", SqlDbType.Image) { Value = poster },
                new SqlParameter("@trailer", SqlDbType.NVarChar) { Value = trailer },
                new SqlParameter("@moTa", SqlDbType.NText) { Value = moTa }
            };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
    }
}
