using BetaCinema.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetaCinema.DAO
{
    public class GenreDAO
    {
        private static GenreDAO instance;

        public static GenreDAO Instance
        {
            get => instance == null ? instance = new GenreDAO() : instance;
            private set => instance = value;
        }

        private GenreDAO() { }

        public List<Genre> GetListGenre()
        {
            List<Genre> list = new List<Genre> ();
            string query = "SELECT * FROM TheLoai";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Genre genre = new Genre(item);
                list.Add(genre);
            }
            return list;
        }

        public List<Genre> GetListGenreByGenreID(string maTL)
        {
            List<Genre> list = new List<Genre>();
            string query = string.Format("SELECT * FROM TheLoai WHERE MaTL = '{0}'", maTL);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Genre genre = new Genre(item);
                list.Add(genre);
            }
            return list;
        }
    }
}
