using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetaCinema.DTO
{
    public class ProductDTO
    {
        private string maSP;
        private string tenSP;
        private string maLoaiSP;
        private int giaBan;
        private int soLuongTon;
        private byte[] hinhAnh;

        public string MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public string MaLoaiSP { get => maLoaiSP; set => maLoaiSP = value; }
        public int GiaBan { get => giaBan; set => giaBan = value; }
        public int SoLuongTon { get => soLuongTon; set => soLuongTon = value; }
        public byte[] HinhAnh { get => hinhAnh; set => hinhAnh = value; }


        public ProductDTO(string maSP, string tenSP, string maLoaiSP, int giaBan, int soLuongTon, byte[] hinhAnh)
        {
            this.maSP = maSP;
            this.tenSP = tenSP;
            this.maLoaiSP = maLoaiSP;
            this.giaBan = giaBan;
            this.soLuongTon = soLuongTon;
            this.hinhAnh = hinhAnh;
        }

        public ProductDTO(DataRow row)
        {
            this.maSP = row["MaSP"].ToString();
            this.tenSP = row["TenSP"].ToString();
            this.maLoaiSP = row["MaLoaiSP"].ToString();
            this.giaBan = Convert.ToInt32(row["GiaBan"]);
            this.soLuongTon = Convert.ToInt32(row["SoLuongTon"]);
            this.hinhAnh = row["HinhAnh"] as byte[];
        }
    }
}
