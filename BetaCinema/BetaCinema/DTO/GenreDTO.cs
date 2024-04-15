using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetaCinema.DTO
{
    public class GenreDTO
    {
        private string maTL;
        private string tenTheLoai;

        public string MaTL { get => maTL; set => maTL = value; }
        public string TenTheLoai { get => tenTheLoai; set => tenTheLoai = value; }

        public GenreDTO(string maTL, string tenTheLoai)
        {
            this.maTL = maTL;
            this.tenTheLoai = tenTheLoai;
        }

        public GenreDTO(DataRow row)
        {
            this.maTL = row["maTL"].ToString();
            this.tenTheLoai = row["tenTheLoai"].ToString();
        }
    }
}
