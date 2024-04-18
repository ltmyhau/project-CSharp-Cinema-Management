using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetaCinema.DTO
{
    public class EmployeeTypeDTO
    {
        private string maCV;
        private string tenCV;

        public string MaCV { get => maCV; set => maCV = value; }
        public string TenCV { get => tenCV; set => tenCV = value; }

        public EmployeeTypeDTO(string maCV, string tenCV)
        {
            this.maCV = maCV;
            this.tenCV = tenCV;
        }

        public EmployeeTypeDTO(DataRow row)
        {
            this.maCV = row["MaCV"].ToString();
            this.tenCV = row["TenCV"].ToString();
        }
    }
}
