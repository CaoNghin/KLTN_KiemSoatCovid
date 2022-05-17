using System;

namespace QuanLyCovidDHH.Domain.Request
{
    public class ChiTietTiemRequest
    {
        public Guid IDChiTietTiem { get; set; }
        public Guid IDSinhVien { get; set; }
        public Guid IDVaccine { get; set; }
        public string DiaChiTiem { get; set; }
        public string TrieuChungSauTiem { get; set; }
        public DateTime NgayGioTiem { get; set; }
        public int MuiTiemThu { get; set; }
        public string ChiTietTiemDinhKem { get; set; }
        public string TrangThaiDuyet { get; set; }
        public string NguoiDuyet { get; set; }
        public string LyDo { get; set; }
        public string GhiChu { get; set; }
        public string TenVaccine { get; set; }
        public string MaSinhVien { get; set; }
    }
}
