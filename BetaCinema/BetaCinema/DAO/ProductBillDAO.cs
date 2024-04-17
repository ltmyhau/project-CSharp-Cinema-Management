using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetaCinema.DAO
{
    public class ProductBillDAO
    {
        private static ProductBillDAO instance;

        public static ProductBillDAO Instance
        {
            get => instance == null ? instance = new ProductBillDAO() : instance;
            private set => instance = value;
        }

        private ProductBillDAO() { }

        public bool InsertProductToBill(string maHD, string maSP, int soLuong)
        {
            string query = "INSERT INTO HoaDonBapNuoc(MaHDBN, MaHD, MaSP, SoLuong) VALUES (dbo.f_AutoMaHDBN(), @maHD , @maSP , @soLuong )";
            object[] parameters = new object[]
            {
                maHD,
                maSP,
                soLuong
            };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
    }
}
