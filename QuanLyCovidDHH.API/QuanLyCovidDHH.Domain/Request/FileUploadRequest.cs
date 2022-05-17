using System;

namespace QuanLyCovidDHH.Domain.Request
{
    public class FileUploadRequest
    {
        public int ID { get; set; }
        public string TenTep { get; set; }
        public string NoiLuuTru { get; set; }
        public Guid DoiTuongID { get; set; }
        public int STTTep { get; set; }
    }
}
