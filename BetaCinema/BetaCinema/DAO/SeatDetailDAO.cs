using BetaCinema.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetaCinema.DAO
{
    public class SeatDetailDAO
    {
        private static SeatDetailDAO instance;
        public static int SeatWidth = 50;
        public static int SeatHeight = 50;

        public static SeatDetailDAO Instance
        {
            get => instance == null ? instance = new SeatDetailDAO() : instance;
            private set => instance = value;
        }

        private SeatDetailDAO() { }

        public List<SeatDetail> GetListSeatDetailByShowtimesID(string maSC)
        {
            List<SeatDetail> list = new List<SeatDetail>();
            string query = string.Format("SELECT * FROM ChiTietSuatChieu WHERE MaSC = '{0}'", maSC);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                SeatDetail seatDetail = new SeatDetail(item);
                list.Add(seatDetail);
            }
            return list;
        }
    }
}
