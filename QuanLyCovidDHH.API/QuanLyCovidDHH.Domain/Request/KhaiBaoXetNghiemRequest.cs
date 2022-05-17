using System;

namespace QuanLyCovidDHH.Domain.Request
{
    public class KhaiBaoXetNghiemRequest
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
    }
}
