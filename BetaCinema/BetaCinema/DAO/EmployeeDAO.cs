using BetaCinema.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetaCinema.DAO
{
    public class EmployeeDAO
    {
        private static EmployeeDAO instance;

        public static EmployeeDAO Instance
        {
            get => instance == null ? instance = new EmployeeDAO() : instance;
            private set => instance = value;
        }

        private EmployeeDAO() { }

        public bool Login(string userName, string passWord)
        {
            string query = "SELECT * FROM NhanVien WHERE Email = @userName AND MatKhau = @passWord";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });
            return result.Rows.Count > 0;
        }

        public List<EmployeeDTO> GetEmployeeByAccount(string userName, string passWord)
        {
            List<EmployeeDTO> list = new List<EmployeeDTO>();
            string query = "SELECT * FROM NhanVien WHERE Email = @userName AND MatKhau = @passWord";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });
            foreach (DataRow item in data.Rows)
            {
                EmployeeDTO employee = new EmployeeDTO(item);
                list.Add(employee);
            }
            return list;
        }
    }
}
