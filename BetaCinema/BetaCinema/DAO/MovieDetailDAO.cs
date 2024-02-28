using BetaCinema.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetaCinema.DAO
{
    public class MovieDetailDAO
    {
        private static MovieDetailDAO instance;

        public static MovieDetailDAO Instance
        {
            get => instance == null ? instance = new MovieDetailDAO() : instance;
            private set => instance = value;
        }

        private MovieDetailDAO() { }

        public List<MovieDetail> GetListMoiveDetail()
        {
            List<MovieDetail> list = new List<MovieDetail>();
            string query = "SELECT p.MaPhim, p.TenPhim, p.MaPL,\tpl.BieuTuongPL, p.DaoDien, p.QuocGia, p.ThoiLuong, p.NgayKhoiChieu, p.MoTa, p.Poster, p.Trailer,\r\n(SELECT STRING_AGG(tl.TenTheLoai, ', ')\r\nFROM TheLoai_Phim AS tlp INNER JOIN TheLoai AS tl ON tlp.MaTL = tl.MaTL\r\nWHERE tlp.MaPhim = p.MaPhim) AS 'TheLoaiPhim'\r\nFROM Phim AS p LEFT JOIN PhanLoai AS pl ON p.MaPL = pl.MaPL";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                MovieDetail movie = new MovieDetail(item);
                list.Add(movie);
            }
            return list;
        }
    }
}
