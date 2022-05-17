using System;

namespace QuanLyCovidDHH.Domain.Response
{
    public class KhoaHocResponse
    {
        public Guid IDKhoaHoc { get; set; }
        public Guid IDKhoa { get; set; }
        public Guid IDTruong { get; set; }
        public int KhoaHoc { get; set; }
        public int NamTuyenSinh { get; set; }
        public string MaKhoaHoc { get; set; }
        public string TenKhoa { get; set; }
        public string MaKhoa { get; set; }
        public string TenTruong { get; set; }
        public string MaTruong { get; set; }




    }
}
