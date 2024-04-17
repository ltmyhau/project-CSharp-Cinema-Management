using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetaCinema.DAO
{
    public class TicketDAO
    {
        private static TicketDAO instance;

        public static TicketDAO Instance
        {
            get => instance == null ? instance = new TicketDAO() : instance;
            private set => instance = value;
        }

        private TicketDAO() { }

        public bool InsertTicketToBill(string maHD, string maGhe, string maSC)
        {
            string query = "INSERT INTO Ve(MaVe, MaHD, MaGhe, MaSC) VALUES (dbo.f_AutoMaVe(), @maHD , @maGhe , @maSC )";
            object[] parameters = new object[]
            {
                maHD,
                maGhe,
                maSC
            };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
    }
}
