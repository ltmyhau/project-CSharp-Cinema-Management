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

        public string GetMaHD(string maKH, string maNV, DateTime ngayTao)
        {
            string query = "SELECT MaHD FROM HoaDon WHERE MaKH = @maKH AND MaNV = @maNV AND NgayTao = @ngayTao ";
            object[] parameters = new object[]
            {
                maKH,
                maNV,
                ngayTao
            };
            string maHD = DataProvider.Instance.ExecuteScalar(query, parameters)?.ToString();
            return maHD;
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