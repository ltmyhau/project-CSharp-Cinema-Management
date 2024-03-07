using BetaCinema.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetaCinema.DAO
{
    public class GenreMovieDAO
    {
        private static GenreMovieDAO instance;

        public static GenreMovieDAO Instance
        {
            get => instance == null ? instance = new GenreMovieDAO() : instance;
            private set => instance = value;
        }

        private GenreMovieDAO() { }

        public List<GenreMovie> GetListGenreMovieByMovieID(string maPhim)
        {
            List<GenreMovie> list = new List<GenreMovie>();
            string query = string.Format("SELECT * FROM TheLoai_Phim WHERE MaPhim = '{0}'", maPhim);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                GenreMovie genreMovie = new GenreMovie(item);
                list.Add(genreMovie);
            }
            return list;
        }

        public bool InsertGenreMovie(string maPhim, string maTL)
        {
            string query = string.Format("INSERT INTO TheLoai_Phim (MaPhim, MaTL) VALUES (N'{0}', N'{1}')", maPhim, maTL);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteGenreMovie(string maPhim)
        {
            string query = string.Format("DELETE TheLoai_Phim WHERE MaPhim = N'{0}'", maPhim);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
