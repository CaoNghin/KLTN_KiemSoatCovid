using System;

namespace QuanLyCovidDHH.Domain.Response
{
    public class KhaiBaoXetNghiemResponse
    {
        public Guid IDKhaiBaoXetNghiem { get; set; }
        public Guid IDSinhVien { get; set; }

        public string LoaiXetNghiem { get; set; }
        public string KetQuaXetNghiem { get; set; }
        public DateTime NgayXetNghiem { get; set; }
        public string HinhAnhXetNghiem { get; set; }
        public string TrangThaiDuyet { get; set; }
        public string NguoiDuyet { get; set; }
        public string LyDo { get; set; }
        public string GhiChu { get; set; }

        public Guid IDKhoa { get; set; }
        public int KhoaHoc { get; set; }
        public int NamTuyenSinh { get; set; }
        public string MaKhoaHoc { get; set; }

        public Guid IDTruong { get; set; }
        public string TenKhoa { get; set; }
        public string MaKhoa { get; set; }
        public string TenTruong { get; set; }
        public string MaTruong { get; set; }
        public string MaSinhVien { get; set; }
        public string HoTen { get; set; }
        public string Ngay { get; set; }
    }
}
