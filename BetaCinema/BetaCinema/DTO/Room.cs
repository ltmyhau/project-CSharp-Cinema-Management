using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetaCinema.DTO
{
    public class Room
    {
        private string maPhong;
        private string tenPhong;
        private string viTri;
        private int sucChua;

        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string TenPhong { get => tenPhong; set => tenPhong = value; }
        public string ViTri { get => viTri; set => viTri = value; }
        public int SucChua { get => sucChua; set => sucChua = value; }

        public Room(string maPhong, string tenPhong, string viTri, int sucChua)
        {
            this.maPhong = maPhong;
            this.tenPhong = tenPhong;
            this.viTri = viTri;
            this.sucChua = sucChua;
        }

        public Room(DataRow row)
        {
            this.maPhong = row["maPhong"].ToString();
            this.tenPhong = row["tenPhong"].ToString();
            this.viTri = row["viTri"].ToString();
            if (row["sucChua"] != DBNull.Value)
            {
                this.sucChua = Convert.ToInt32(row["sucChua"]);
            }
            else
            {
                this.sucChua = 0;
            }
        }
    }
}
