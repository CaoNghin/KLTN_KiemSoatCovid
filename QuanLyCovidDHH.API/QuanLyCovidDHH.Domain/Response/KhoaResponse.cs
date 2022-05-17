using System;

namespace QuanLyCovidDHH.Domain.Response
{
    public class KhoaResponse
    {
        public Guid IDKhoa { get; set; }
        public Guid IDTruong { get; set; }
        public string TenKhoa { get; set; }
        public string MaKhoa { get; set; }
        public string TenTruong { get; set; }
        public string MaTruong { get; set; }


    }
}
