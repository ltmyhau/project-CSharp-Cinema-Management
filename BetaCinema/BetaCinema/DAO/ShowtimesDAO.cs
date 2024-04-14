using BetaCinema.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetaCinema.DAO
{
    public class ShowtimesDAO
    {
        private static ShowtimesDAO instance;

        public static ShowtimesDAO Instance
        {
            get => instance == null ? instance = new ShowtimesDAO() : instance;
            private set => instance = value;
        }

        private ShowtimesDAO() { }

        public List<Showtimes> GetShowtimesByDate(DateTime date)
        {
            List<Showtimes> list = new List<Showtimes>();
            string ngayChieu = date.Date.ToString("yyyy-MM-dd");
            string query = String.Format("SELECT * FROM vwDanhSachLichChieu WHERE CONVERT(DATE, ThoiGian) = '{0}' ORDER BY ThoiGian ASC", ngayChieu);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Showtimes showtimes = new Showtimes(item);
                list.Add(showtimes);
            }
            return list;
        }

        public List<Showtimes> GetShowtimesByDateAndRoomID(DateTime date, string maPhong)
        {
            List<Showtimes> list = new List<Showtimes>();
            string ngayChieu = date.Date.ToString("yyyy-MM-dd");
            string query = String.Format("SELECT * FROM vwDanhSachLichChieu WHERE CONVERT(DATE, ThoiGian) = '{0}' AND MaPhong = N'{1}' ORDER BY ThoiGian ASC", ngayChieu, maPhong);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Showtimes showtimes = new Showtimes(item);
                list.Add(showtimes);
            }
            return list;
        }

        public bool UpdateShowtimes(string maSC, string maPhong, string maPhim, DateTime thoiGian)
        {
            try
            {
                string query = "UPDATE SuatChieu SET MaPhong = @maPhong , MaPhim = @maPhim , ThoiGian = @thoiGian WHERE MaSC = @maSC";
                object[] parameters = new object[]
                {
                    maPhong,
                    maPhim,
                    thoiGian,
                    maSC
                };
                int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
                return result > 0;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Lỗi SQL: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
        }

        public bool DeleteShowtimes(string maSC)
        {
            string query = string.Format("DELETE SuatChieu WHERE MaSC = N'{0}'", maSC);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
