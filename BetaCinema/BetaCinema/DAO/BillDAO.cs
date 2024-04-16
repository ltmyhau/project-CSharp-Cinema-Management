using BetaCinema.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetaCinema.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get => instance == null ? instance = new BillDAO() : instance;
            private set => instance = value;
        }

        private BillDAO() { }

        public string GetNextMaHD()
        {
            string query = "SELECT 'HD' + RIGHT('000' + CAST(MAX(RIGHT(MaHD, 3)) + 1 AS VARCHAR(3)), 3) FROM HoaDon";
            string maTL = DataProvider.Instance.ExecuteScalar(query)?.ToString();
            return maTL;
        }

        public bool InsertBill(string maKH, string maNV, DateTime ngayTao)
        {
            string query = "INSERT INTO HoaDon(MaHD, MaKH, MaNV, NgayTao) VALUES (dbo.f_AutoMaHD(), @maKH , @maNV , @ngayTao )";
            object[] parameters = new object[]
            {
                maKH,
                maNV,
                ngayTao
            };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
    }
}
