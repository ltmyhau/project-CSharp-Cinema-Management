using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetaCinema.DTO
{
    public class CustomerDTO
    {
        private string maKH;
        private string hoKH;
        private string tenKH;
        private DateTime ngaySinh;
        private string gioiTinh;
        private DateTime ngayDangKy;
        private int diemTichLuy;
        private string maBacTV;
        private string dienThoai;
        private string email;
        private string diaChi;

        public string MaKH { get => maKH; set => maKH = value; }
        public string HoKH { get => hoKH; set => hoKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgayDangKy { get => ngayDangKy; set => ngayDangKy = value; }
        public int DiemTichLuy { get => diemTichLuy; set => diemTichLuy = value; }
        public string MaBacTV { get => maBacTV; set => maBacTV = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
        public string Email { get => email; set => email = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }

        public CustomerDTO(string maKH, string hoKH, string tenKH, DateTime ngaySinh, string gioiTinh, DateTime ngayDangKy, int diemTichLuy, string maBacTV, string dienThoai, string email, string diaChi)
        {
            this.maKH = maKH;
            this.hoKH = hoKH;
            this.tenKH = tenKH;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.ngayDangKy = ngayDangKy;
            this.diemTichLuy = diemTichLuy;
            this.maBacTV = maBacTV;
            this.dienThoai = dienThoai;
            this.email = email;
            this.diaChi = diaChi;
        }

        public CustomerDTO(DataRow row)
        {
            this.maKH = row["maKH"].ToString();
            this.hoKH = row["hoKH"].ToString();
            this.tenKH = row["tenKH"].ToString();
            this.ngaySinh = row["ngaySinh"] != DBNull.Value ? Convert.ToDateTime(row["ngaySinh"]) : DateTime.MinValue;
            this.gioiTinh = row["gioiTinh"] != DBNull.Value ? row["gioiTinh"].ToString() : null;
            this.ngayDangKy = row["ngayDangKy"] != DBNull.Value ? Convert.ToDateTime(row["ngayDangKy"]) : DateTime.MinValue;
            this.diemTichLuy = Convert.ToInt32(row["diemTichLuy"]);
            this.maBacTV = row["maBacTV"] != DBNull.Value ? row["maBacTV"].ToString() : null;
            this.dienThoai = row["dienThoai"].ToString();
            this.email = row["email"] != DBNull.Value ? row["email"].ToString() : null;
            this.diaChi = row["diaChi"] != DBNull.Value ? row["diaChi"].ToString() : null;
        }
    }
}
