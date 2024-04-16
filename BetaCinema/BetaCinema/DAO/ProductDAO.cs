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
    }
}
