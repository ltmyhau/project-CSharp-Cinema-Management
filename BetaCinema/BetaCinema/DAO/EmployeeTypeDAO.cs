using BetaCinema.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetaCinema.DAO
{
    public class EmployeeTypeDAO
    {
        private static EmployeeTypeDAO instance;

        public static EmployeeTypeDAO Instance
        {
            get => instance == null ? instance = new EmployeeTypeDAO() : instance;
            private set => instance = value;
        }

        private EmployeeTypeDAO() { }

        public List<EmployeeTypeDTO> GetListEmployeeType()
        {
            List<EmployeeTypeDTO> list = new List<EmployeeTypeDTO>();
            string query = "SELECT * FROM ChucVu";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                EmployeeTypeDTO employeeType = new EmployeeTypeDTO(item);
                list.Add(employeeType);
            }
            return list;
        }
    }
}
