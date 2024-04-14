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
            string query = "SELECT * FROM vwDanhSachPhim";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                MovieDetail movie = new MovieDetail(item);
                list.Add(movie);
            }
            return list;
        }

        public List<MovieDetail> GetListMoiveDetailByMovieID(string movieID)
        {
            List<MovieDetail> list = new List<MovieDetail>();
            string query = $"SELECT * FROM vwDanhSachPhim WHERE MaPhim = N'{movieID}'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                MovieDetail movie = new MovieDetail(item);
                list.Add(movie);
            }
            return list;
        }

        public List<MovieDetail> GetListMoiveDetailByMovieName(string movieName)
        {
            List<MovieDetail> list = new List<MovieDetail>();
            string query = $"SELECT * FROM vwDanhSachPhim WHERE TenPhim LIKE N'%{movieName}%'";
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
