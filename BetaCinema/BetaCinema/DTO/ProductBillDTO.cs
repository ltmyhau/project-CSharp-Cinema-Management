using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetaCinema.DTO
{
    public class ProductBillDTO
    {
        private string maHDBN;
        private string maHD;
        private string maSP;
        private int soLuong;

        public string MaHDBN { get => maHDBN; set => maHDBN = value; }
        public string MaHD { get => maHD; set => maHD = value; }
        public string MaSP { get => maSP; set => maSP = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }

        public ProductBillDTO(string maHDBN, string maHD, string maSP, int soLuong)
        {
            this.maHDBN = maHDBN;
            this.maHD = maHD;
            this.maSP = maSP;
            this.soLuong = soLuong;
        }

        public ProductBillDTO(DataRow row)
        {
            this.maHDBN = row["MaHDBN"].ToString();
            this.maHD = row["MaHD"].ToString();
            this.maSP = row["MaSP"].ToString();
            this.soLuong = Convert.ToInt32(row["SoLuong"]);
        }
    }
}
