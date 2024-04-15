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

        public List<MovieDetailDTO> GetListMoiveDetail()
        {
            List<MovieDetailDTO> list = new List<MovieDetailDTO>();
            string query = "SELECT * FROM vwDanhSachPhim";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                MovieDetailDTO movie = new MovieDetailDTO(item);
                list.Add(movie);
            }
            return list;
        }

        public List<MovieDetailDTO> GetListMoiveDetailByMovieID(string movieID)
        {
            List<MovieDetailDTO> list = new List<MovieDetailDTO>();
            string query = $"SELECT * FROM vwDanhSachPhim WHERE MaPhim = N'{movieID}'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                MovieDetailDTO movie = new MovieDetailDTO(item);
                list.Add(movie);
            }
            return list;
        }

        public List<MovieDetailDTO> GetListMoiveDetailByMovieName(string movieName)
        {
            List<MovieDetailDTO> list = new List<MovieDetailDTO>();
            string query = $"SELECT * FROM vwDanhSachPhim WHERE TenPhim LIKE N'%{movieName}%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                MovieDetailDTO movie = new MovieDetailDTO(item);
                list.Add(movie);
            }
            return list;
        }
    }
}
