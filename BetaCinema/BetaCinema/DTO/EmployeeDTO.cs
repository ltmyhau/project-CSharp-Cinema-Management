using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetaCinema.DTO
{
    public class EmployeeDTO
    {
        private string maNV;
        private string hoNV;
        private string tenNV;
        private DateTime ngaySinh;
        private string gioiTinh;
        private DateTime ngayVaoLam;
        private string maCV;
        private string dienThoai;
        private string email;
        private string matKhau;
        private string diaChi;

        public string MaNV { get => maNV; set => maNV = value; }
        public string HoNV { get => hoNV; set => hoNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgayVaoLam { get => ngayVaoLam; set => ngayVaoLam = value; }
        public string MaCV { get => maCV; set => maCV = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
        public string Email { get => email; set => email = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }

        public EmployeeDTO(string maNV, string hoNV, string tenNV, DateTime ngaySinh, string gioiTinh, DateTime ngayVaoLam, string maCV, string dienThoai, string email, string matKhau, string diaChi)
        {
            this.maNV = maNV;
            this.hoNV = hoNV;
            this.tenNV = tenNV;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.ngayVaoLam = ngayVaoLam;
            this.maCV = maCV;
            this.dienThoai = dienThoai;
            this.email = email;
            this.matKhau = matKhau;
            this.diaChi = diaChi;
        }

        public EmployeeDTO(DataRow row)
        {
            this.maNV = row["maNV"].ToString();
            this.hoNV = row["hoNV"] != DBNull.Value ? row["hoNV"].ToString() : null;
            this.tenNV = row["tenNV"] != DBNull.Value ? row["tenNV"].ToString() : null;
            this.ngaySinh = row["ngaySinh"] != DBNull.Value ? Convert.ToDateTime(row["ngaySinh"]) : DateTime.MinValue;
            this.gioiTinh = row["gioiTinh"] != DBNull.Value ? row["gioiTinh"].ToString() : null;
            this.ngayVaoLam = row["ngayVaoLam"] != DBNull.Value ? Convert.ToDateTime(row["ngayVaoLam"]) : DateTime.MinValue;
            this.maCV = row["maCV"].ToString();
            this.dienThoai = row["dienThoai"] != DBNull.Value ? row["dienThoai"].ToString() : null;
            this.email = row["email"].ToString();
            this.matKhau = row["matKhau"].ToString();
            this.diaChi = row["diaChi"] != DBNull.Value ? row["diaChi"].ToString() : null;
        }
    }
}
