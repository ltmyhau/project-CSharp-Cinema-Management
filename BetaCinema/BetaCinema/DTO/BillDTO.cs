using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetaCinema.DTO
{
    public class BillDTO
    {
        private string maHD;
        private string maKH;
        private string maNV;
        private DateTime ngayTao;

        public string MaHD { get => maHD; set => maHD = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public DateTime NgayTao { get => ngayTao; set => ngayTao = value; }

        public BillDTO(string maHD, string maKH, string maNV, DateTime ngayTao)
        {
            this.maHD = maHD;
            this.maKH = maKH;
            this.maNV = maNV;
            this.ngayTao = ngayTao;
        }

        public BillDTO(DataRow row)
        {
            this.maHD = row["MaHD"].ToString();
            this.maKH = row["MaKH"].ToString();
            this.maNV = row["MaNV"].ToString();
            this.ngayTao = Convert.ToDateTime(row["NgayTao"]);
        }
    }
}
