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

        public string GetNextMaVe()
        {
            string query = "SELECT 'V' + RIGHT('000' + CAST(MAX(RIGHT(MaVe, 3)) + 1 AS VARCHAR(3)), 3) FROM Ve";
            string maTL = DataProvider.Instance.ExecuteScalar(query)?.ToString();
            return maTL;
        }

        public bool InsertBill(string maHD, string maGhe, string maSC)
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
