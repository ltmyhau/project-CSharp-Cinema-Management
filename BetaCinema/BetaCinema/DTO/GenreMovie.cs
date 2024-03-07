using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetaCinema.DTO
{
    public class GenreMovie
    {
        private string maPhim;
        private string maTL;

        public string MaPhim { get => maPhim; set => maPhim = value; }
        public string MaTL { get => maTL; set => maTL = value; }

        public GenreMovie(string maPhim, string maTL)
        {
            this.maPhim = maPhim;
            this.maTL = maTL;
        }

        public GenreMovie(DataRow row)
        {
            this.maPhim = row["maPhim"].ToString();
            this.maTL = row["maTL"].ToString();
        }

    }
}
