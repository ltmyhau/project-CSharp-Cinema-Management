using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetaCinema.DTO
{
    public class SeatDetail
    {
        private string maSC;
        private string maGhe;
        private string tinhTrang;

        public string MaSC { get => maSC; set => maSC = value; }
        public string MaGhe { get => maGhe; set => maGhe = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }

        public SeatDetail(string maSC, string maGhe, string tinhTrang)
        {
            this.maSC = maSC;
            this.maGhe = maGhe;
            this.tinhTrang = tinhTrang;
        }

        public SeatDetail(DataRow row)
        {
            this.maSC = row["maSC"].ToString();
            this.maGhe = row["maGhe"].ToString();
            this.tinhTrang = row["tinhTrang"].ToString();
        }
    }
}
