using System;

namespace QuanLyCovidDHH.Domain.Request
{
    public class HauCovidRequest
    {
        public Guid IDHauCovid { get; set; }
        public Guid IDBenhAn { get; set; }
        public DateTime NgayTheoDoi { get; set; }
        public float NongDoSpO2 { get; set; }
        public float Sot { get; set; }
        public string Ho { get; set; }
        public string KhoTho { get; set; }
        public string MetMoi { get; set; }
        public string DauCoKhop { get; set; }
        public string RoiLoanTieuHoa { get; set; }
    }
}
