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

        public List<GenreDTO> GetListGenre()
        {
            List<GenreDTO> list = new List<GenreDTO>();
            string query = "SELECT * FROM TheLoai";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                GenreDTO genre = new GenreDTO(item);
                list.Add(genre);
            }
            return list;
        }

        public List<GenreDTO> GetListGenreByGenreID(string maTL)
        {
            List<GenreDTO> list = new List<GenreDTO>();
            string query = string.Format("SELECT * FROM TheLoai WHERE MaTL = '{0}'", maTL);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                GenreDTO genre = new GenreDTO(item);
                list.Add(genre);
            }
            return list;
        }
    }
}
