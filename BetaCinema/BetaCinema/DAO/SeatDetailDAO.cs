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

        public List<SeatDetailDTO> GetListSeatDetailByShowtimesID(string maSC)
        {
            List<SeatDetailDTO> list = new List<SeatDetailDTO>();
            string query = string.Format("SELECT ctsc.*, MaLoaiGhe FROM ChiTietSuatChieu ctsc INNER JOIN Ghe g On ctsc.MaGhe = g.MaGhe WHERE MaSC = N'{0}'", maSC);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                SeatDetailDTO seatDetail = new SeatDetailDTO(item);
                list.Add(seatDetail);
            }
            return list;
        }
    }
}
