using System;

namespace QuanLyCovidDHH.Domain.Request
{
    public class KhaiBaoCachLyRequest
    {
        public Guid IDKhaiBaoCachLy { get; set; }
        public Guid IDSinhVien { get; set; }
        public string DoiTuongCachLy { get; set; }
        public DateTime NgayBatDauCachLy { get; set; }
        public DateTime NgayKetThucCachLy { get; set; }
        public string QuyetDinhCachLy { get; set; }
        public string TrangThaiDuyet { get; set; }
        public string NguoiDuyet { get; set; }
        public string LyDo { get; set; }
        public string GhiChu { get; set; }
    }
}
