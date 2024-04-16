using BetaCinema.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetaCinema.DAO
{
    public class MovieRatingSystemDAO
    {
        private static MovieRatingSystemDAO instance;

        public static MovieRatingSystemDAO Instance
        {
            get => instance == null ? instance = new MovieRatingSystemDAO() : instance;
            private set => instance = value;
        }

        private MovieRatingSystemDAO() { }

        public List<MovieRatingSystemDTO> GetListMovieRatingSystem()
        {
            List<MovieRatingSystemDTO> list = new List<MovieRatingSystemDTO> ();
            string query = "SELECT * FROM PhanLoai";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                MovieRatingSystemDTO movieRatingSystem = new MovieRatingSystemDTO(item);
                list.Add(movieRatingSystem);
            }
            return list;
        }

        public List<MovieRatingSystemDTO> GetListMovieRatingSystemByID(string id)
        {
            List<MovieRatingSystemDTO> list = new List<MovieRatingSystemDTO>();
            string query = $"SELECT * FROM PhanLoai WHERE MaPL = N'{id}'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                MovieRatingSystemDTO movieRatingSystem = new MovieRatingSystemDTO(item);
                list.Add(movieRatingSystem);
            }
            return list;
        }
    }
}
