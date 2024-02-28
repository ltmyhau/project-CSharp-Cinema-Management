using BetaCinema.DTO;
using System;
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

        public List<MovieRatingSystem> GetListMovieRatingSystem()
        {
            List<MovieRatingSystem> list = new List<MovieRatingSystem> ();
            string query = "SELECT * FROM PhanLoai";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                MovieRatingSystem movieRatingSystem = new MovieRatingSystem(item);
                list.Add(movieRatingSystem);
            }
            return list;
        }
    }
}
