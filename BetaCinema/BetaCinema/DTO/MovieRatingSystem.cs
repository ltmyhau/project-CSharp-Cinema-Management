using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetaCinema.DTO
{
    public class MovieRatingSystem
    {
        private string maPL;
        private string moTa;
        private byte[] bieuTuongPL;

        public string MaPL {get => maPL; set => maPL = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public byte[] BieuTuongPL { get => bieuTuongPL; set => bieuTuongPL = value; }

        public MovieRatingSystem(string maPL, string moTa, byte[] bieuTuongPL)
        {
            this.maPL = maPL;
            this.moTa = moTa;
            this.bieuTuongPL = bieuTuongPL;
        }

        public MovieRatingSystem(DataRow row)
        {
            this.maPL = row["maPL"].ToString();
            this.moTa = row["moTa"].ToString();
            this.bieuTuongPL = row["bieuTuongPL"] as byte[];
        }
    }
}
