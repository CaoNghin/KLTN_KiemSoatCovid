using System;

namespace QuanLyCovidDHH.Domain.Request
{
    public class KhoaHocRequest
    {
        public Guid IDKhoaHoc { get; set; }
        public Guid IDKhoa { get; set; }
        public int KhoaHoc { get; set; }
        public int NamTuyenSinh { get; set; }
        public string MaKhoaHoc { get; set; }


    }
}
