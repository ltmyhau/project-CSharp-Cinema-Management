using BetaCinema.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetaCinema.DAO
{
    public class CustomerTypeDAO
    {
        private static CustomerTypeDAO instance;

        public static CustomerTypeDAO Instance
        {
            get => instance == null ? instance = new CustomerTypeDAO() : instance;
            private set => instance = value;
        }

        private CustomerTypeDAO() { }

        public List<CustomerTypeDTO> GetListCustomerType()
        {
            List<CustomerTypeDTO> list = new List<CustomerTypeDTO>();
            string query = "SELECT * FROM BacThanhVien";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                CustomerTypeDTO customerType = new CustomerTypeDTO(item);
                list.Add(customerType);
            }
            return list;
        }

        public List<CustomerTypeDTO> GetListCustomerTypeByCustomerTypeID(string id)
        {
            List<CustomerTypeDTO> list = new List<CustomerTypeDTO>();
            string query = $"SELECT * FROM BacThanhVien WHERE MaBacTV = N'{id}'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                CustomerTypeDTO customerType = new CustomerTypeDTO(item);
                list.Add(customerType);
            }
            return list;
        }
    }
}
