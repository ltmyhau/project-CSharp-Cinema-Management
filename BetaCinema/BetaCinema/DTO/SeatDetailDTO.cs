using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetaCinema.DTO
{
    public class SeatDetailDTO
    {
        private string maSC;
        private string maGhe;
        private string tinhTrang;
        private string maLoaiGhe;
        private double giaGhe;

        public string MaSC { get => maSC; set => maSC = value; }
        public string MaGhe { get => maGhe; set => maGhe = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public string MaLoaiGhe { get => maLoaiGhe; set => maLoaiGhe = value; }
        public double GiaGhe { get => giaGhe; set => giaGhe = value; }

        public SeatDetailDTO(string maSC, string maGhe, string tinhTrang, string maLoaiGhe, double giaGhe)
        {
            this.maSC = maSC;
            this.maGhe = maGhe;
            this.tinhTrang = tinhTrang;
            this.maLoaiGhe = maLoaiGhe;
            this.giaGhe = giaGhe;
        }

        public SeatDetailDTO(DataRow row)
        {
            this.maSC = row["MaSC"].ToString();
            this.maGhe = row["MaGhe"].ToString();
            this.tinhTrang = row["TinhTrang"].ToString();
            this.maLoaiGhe = row["MaLoaiGhe"].ToString();
            this.giaGhe = Convert.ToDouble(row["Gia"]);
        }
    }
}
