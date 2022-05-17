using System;

namespace QuanLyCovidDHH.Domain.Request
{
    public class KhoaRequest
    {
        public Guid IDKhoa { get; set; }
        public Guid IDTruong { get; set; }
        public string TenKhoa { get; set; }
        public string MaKhoa { get; set; }
    }
}
