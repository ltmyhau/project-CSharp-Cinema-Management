using BetaCinema.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetaCinema.DAO
{
    //public class MovieDAO
    //{
    //    private static MovieDAO instance;

    //    public static MovieDAO Instance 
    //    {
    //        get => instance == null ? instance = new MovieDAO() : instance; 
    //        private set => instance = value; 
    //    }

    //    private MovieDAO() { }

    //    public List<Movie> GetListMoive()
    //    {
    //        List<Movie> list = new List<Movie>();
    //        string query = "SELECT * FROM Phim";
    //        DataTable data = DataProvider.Instance.ExecuteQuery(query);
    //        foreach (DataRow item in data.Rows)
    //        {
    //            Movie movie = new Movie(item);
    //            list.Add(movie);
    //        }
    //        return list;
    //    }
    //}
}
