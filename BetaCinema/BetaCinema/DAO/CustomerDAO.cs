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

        public string GetNextMaKH()
        {
            string query = "SELECT 'KH' + RIGHT('000' + CAST(MAX(RIGHT(MaKH, 3)) + 1 AS VARCHAR(3)), 3) FROM KhachHang";
            string maKH = DataProvider.Instance.ExecuteScalar(query)?.ToString();
            return maKH;
        }

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

        public List<CustomerDTO> GetListCustomerByCustomerName(string customerName)
        {
            List<CustomerDTO> list = new List<CustomerDTO>();
            string query = $"SELECT * FROM KhachHang WHERE HoKH + ' ' + TenKH LIKE N'%{customerName}%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                CustomerDTO customer = new CustomerDTO(item);
                list.Add(customer);
            }
            return list;
        }

        public List<CustomerDTO> GetListCustomerByCustomerTypeID(string customerTypeID)
        {
            List<CustomerDTO> list = new List<CustomerDTO>();
            string query = $"SELECT * FROM KhachHang WHERE MaBacTV = N'{customerTypeID}'";
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

        public bool InsertCustomer(string hoHK, string tenHK, DateTime ngaySinh, string gioiTinh, DateTime ngayDangKy, int diemTichLuy, string maBacTV, string dienThoai, string email, string diaChi)
        {
            string query = "INSERT INTO KhachHang(MaKH, HoKH, TenKH, NgaySinh, GioiTinh, NgayDangKy, DiemTichLuy, MaBacTV, DienThoai, Email, DiaChi) " +
                "VALUES (dbo.f_AutoMaKH(), @hoHK , @tenHK , @ngaySinh , @gioiTinh , @ngayDangKy , @diemTichLuy , @maBacTV , @dienThoai , @email , @diaChi )";
            object[] parameters = new object[]
            {
                hoHK,
                tenHK,
                (object)ngaySinh ?? DBNull.Value,
                (object)gioiTinh ?? DBNull.Value,
                (object)ngayDangKy ?? DBNull.Value,
                diemTichLuy,
                maBacTV,
                dienThoai,
                (object)email ?? DBNull.Value,
                (object)diaChi ?? DBNull.Value
            };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        public bool UpdateCustomer(string maKH, string hoHK, string tenHK, DateTime ngaySinh, string gioiTinh, int diemTichLuy, string maBacTV, string dienThoai, string email, string diaChi)
        {
            string query = "UPDATE KhachHang SET HoKH = @hoKH , TenKH = @tenKH , NgaySinh = @ngaySinh , GioiTinh = @gioiTinh , DiemTichLuy = @diemTichLuy , MaBacTV = @maBacTV , DienThoai = @dienThoai , Email = @email , DiaChi = @diaChi WHERE MaKH = @maKH";
            object[] parameters = new object[]
            {
                hoHK,
                tenHK,
                (object)ngaySinh ?? DBNull.Value,
                (object)gioiTinh ?? DBNull.Value,
                diemTichLuy,
                maBacTV,
                dienThoai,
                (object)email ?? DBNull.Value,
                (object)diaChi ?? DBNull.Value,
                maKH
            };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        public bool DeleteCustomer(string maKH)
        {
            string query = string.Format("DELETE KhachHang WHERE MaKH = N'{0}'", maKH);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
