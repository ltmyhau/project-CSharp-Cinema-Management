using BetaCinema.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetaCinema.DAO
{
    public class RoomDAO
    {
        private static RoomDAO instance;

        public static int RoomWidth = 237;
        public static int RoomHeight = 40;

        public static RoomDAO Instance
        {
            get => instance == null ? instance = new RoomDAO() : instance;
            private set => instance = value;
        }

        private RoomDAO() { }

        public List<RoomDTO> GetRoomList()
        {
            List<RoomDTO> list = new List<RoomDTO>();
            string query = "SELECT * FROM PhongChieu";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                RoomDTO room = new RoomDTO(item);
                list.Add(room);
            }
            return list;
        }
    }
}
