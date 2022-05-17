using System;

namespace QuanLyCovidDHH.Domain.Request
{
    public class SinhVienRequest
    {
        public Guid IDSinhVien { get; set; }
        public Guid IDKhoaHoc { get; set; }
        public string SoCMND_CCCD { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public int TongMuiTiem { get; set; }
        public string DaMacCovid { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public int MaSo { get; set; }


        //NHAPEXCEL
        public string MaKhoaHoc { get; set; }

        public string MaKhoa { get; set; }

        public string MaTruong { get; set; }

        //thong ke
        public string LoaiNhom { get; set; }


    }
}
