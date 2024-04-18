using BetaCinema.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetaCinema.DAO
{
    public class ProductDAO
    {
        private static ProductDAO instance;

        public static ProductDAO Instance
        {
            get => instance == null ? instance = new ProductDAO() : instance;
            private set => instance = value;
        }

        private ProductDAO() { }

        public string GetNextMaSP()
        {
            string query = "SELECT 'SP' + RIGHT('000' + CAST(MAX(RIGHT(MaSP, 3)) + 1 AS VARCHAR(3)), 3) FROM SanPham";
            string maSP = DataProvider.Instance.ExecuteScalar(query)?.ToString();
            return maSP;
        }

        public List<ProductDTO> GetListProduct()
        {
            List<ProductDTO> list = new List<ProductDTO>();
            string query = "SELECT * FROM SanPham";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ProductDTO product = new ProductDTO(item);
                list.Add(product);
            }
            return list;
        }

        public List<ProductDTO> GetListProductByProductID(string productID)
        {
            List<ProductDTO> list = new List<ProductDTO>();
            string query = $"SELECT * FROM SanPham WHERE MaSP = N'{productID}'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ProductDTO product = new ProductDTO(item);
                list.Add(product);
            }
            return list;
        }

        public List<ProductDTO> GetListProductByProductName(string productName)
        {
            List<ProductDTO> list = new List<ProductDTO>();
            string query = $"SELECT * FROM SanPham WHERE TenSP LIKE N'%{productName}%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ProductDTO product = new ProductDTO(item);
                list.Add(product);
            }
            return list;
        }

        public List<ProductDTO> GetListProductByPrice(int fromPrice, int toPrice)
        {
            List<ProductDTO> list = new List<ProductDTO>();
            string query = $"SELECT * FROM SanPham WHERE GiaBan BEtWEEN {fromPrice} AND {toPrice}";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ProductDTO product = new ProductDTO(item);
                list.Add(product);
            }
            return list;
        }

        public bool InsertProduct(string tenSP, string maLSP, int giaBan, int soLuongTon, byte[] hinhAnh)
        {
            string query = "INSERT INTO SanPham(MaSP, TenSP, MaLoaiSP, GiaBan, SoLuongTon, HinhAnh) " +
                "VALUES (dbo.f_AutoMaSP(), @tenSP , @maLSP , @giaBan , @soLuongTon , @hinhAnh )";
            object[] parameters = new object[]
            {
                tenSP,
                maLSP,
                giaBan,
                soLuongTon,
                hinhAnh
            };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        public bool UpdateProduct(string maSP, string tenSP, string maLoaiSP, int giaBan, int soLuongTon, byte[] hinhAnh)
        {
            string query = "UPDATE SanPham SET TenSP = @tenSP , MaLoaiSP = @maLoaiSP , GiaBan = @giaBan , SoLuongTon = @soLuongTon , HinhAnh = @hinhAnh WHERE MaSP = @maSP ";
            object[] parameters = new object[]
            {
                tenSP,
                maLoaiSP,
                giaBan,
                soLuongTon,
                hinhAnh,
                maSP
            };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        public bool DeleteProduct(string maSP)
        {
            string query = $"DELETE SanPham WHERE MaSP = N'{maSP}'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
