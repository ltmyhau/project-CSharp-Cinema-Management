using BetaCinema.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetaCinema.DAO
{
    public class CustomerDAO
    {
        private static CustomerDAO instance;

        public static CustomerDAO Instance
        {
            get => instance == null ? instance = new CustomerDAO() : instance;
            private set => instance = value;
        }

        private CustomerDAO() { }

        public List<CustomerDTO> GetListCustomer()
        {
            List<CustomerDTO> list = new List<CustomerDTO>();
            string query = "SELECT * FROM KhachHang";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                CustomerDTO customer = new CustomerDTO(item);
                list.Add(customer);
            }
            return list;
        }

        public List<CustomerDTO> GetListCustomerByPhoneNumber(string phoneNumber)
        {
            List<CustomerDTO> list = new List<CustomerDTO>();
            string query = $"SELECT * FROM KhachHang WHERE DienThoai = N'{phoneNumber}'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                CustomerDTO customer = new CustomerDTO(item);
                list.Add(customer);
            }
            return list;
        }

        public bool InsertCustomer(string hoKH, string tenKH, string gioiTinh, string dienThoai)
        {
            DateTime ngayDangKy = DateTime.Now;
            string query = "INSERT INTO KhachHang(MaKH, HoKH, TenKH, GioiTinh, NgayDangKy, DiemTichLuy, MaBacTV, DienThoai) " +
                "VALUES (dbo.f_AutoMaKH(), @hoHK , @tenKH , @gioiTinh , @ngayDangKy , 0, N'THG', @dienThoai )";
            object[] parameters = new object[]
            {
                hoKH,
                tenKH,
                gioiTinh,
                ngayDangKy,
                dienThoai
            };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
    }
}
