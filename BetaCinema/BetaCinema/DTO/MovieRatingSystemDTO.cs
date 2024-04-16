using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetaCinema.DTO
{
    public class MovieRatingSystemDTO
    {
        private string maPL;
        private string tenPL;
        private string moTa;
        private byte[] bieuTuongPL;

        public string MaPL {get => maPL; set => maPL = value; }
        public string TenPL {get => tenPL; set => tenPL = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public byte[] BieuTuongPL { get => bieuTuongPL; set => bieuTuongPL = value; }

        public MovieRatingSystemDTO(string maPL, string tenPL, string moTa, byte[] bieuTuongPL)
        {
            this.maPL = maPL;
            this.tenPL = tenPL;
            this.moTa = moTa;
            this.bieuTuongPL = bieuTuongPL;
        }

        public MovieRatingSystemDTO(DataRow row)
        {
            this.maPL = row["maPL"].ToString();
            this.tenPL = row["tenPL"].ToString();
            this.moTa = row["moTa"].ToString();
            this.bieuTuongPL = row["bieuTuongPL"] as byte[];
        }
    }
}
