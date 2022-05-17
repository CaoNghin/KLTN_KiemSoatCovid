using System;

namespace QuanLyCovidDHH.Domain.Request
{
    public class BenhAnRequest
    {
        public Guid IDBenhAn { get; set; }
        public Guid IDSinhVien { get; set; }

        public DateTime NgayBatDauDieuTri { get; set; }
        public string NoiDieuTri { get; set; }
        public string BienThe { get; set; }
        public string KhoiBenh { get; set; }
        public string TuVong { get; set; }
        public DateTime NgayKetThucDieuTri { get; set; }
        public string BenhAnDinhKem { get; set; }
        public string TrangThaiDuyet { get; set; }
        public string NguoiDuyet { get; set; }
        public string LyDo { get; set; }
        public string GhiChu { get; set; }
        public string TrangThaiDieuTri { get; set; }
        public string TuNgay { get; set; }
        public string DenNgay { get; set; }
        public string MaSinhVien { get; set; }
        public string NgayKetThuc { get; set; }

    }
}
