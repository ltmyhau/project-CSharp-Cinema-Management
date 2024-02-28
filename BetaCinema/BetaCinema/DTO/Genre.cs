using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetaCinema.DTO
{
    public class Genre
    {
        private string maTL;
        private string tenTheLoai;

        public string MaTL { get => maTL; set => maTL = value; }
        public string TenTheLoai { get => tenTheLoai; set => tenTheLoai = value; }

        public Genre(string maTL, string tenTheLoai)
        {
            this.maTL = maTL;
            this.tenTheLoai = tenTheLoai;
        }

        public Genre(DataRow row)
        {
            this.maTL = row["maTL"].ToString();
            this.tenTheLoai = row["tenTheLoai"].ToString();
        }
    }
}
