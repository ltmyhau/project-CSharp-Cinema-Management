using BetaCinema.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetaCinema.DAO
{
    public class ProductTypeDAO
    {
        private static ProductTypeDAO instance;

        public static ProductTypeDAO Instance
        {
            get => instance == null ? instance = new ProductTypeDAO() : instance;
            private set => instance = value;
        }

        private ProductTypeDAO() { }

        public List<ProductTypeDTO> GetListProductType()
        {
            List<ProductTypeDTO> list = new List<ProductTypeDTO>();
            string query = "SELECT * FROM LoaiSanPham";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ProductTypeDTO productType = new ProductTypeDTO(item);
                list.Add(productType);
            }
            return list;
        }

        public ProductTypeDTO GetProductTypeByID(string productTypeID)
        {
            ProductTypeDTO productType = null;
            string query = $"SELECT * FROM LoaiSanPham WHERE MaLoaiSP = N'{productTypeID}'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                productType = new ProductTypeDTO(item);
                return productType;
            }
            return productType;
        }
    }
}
