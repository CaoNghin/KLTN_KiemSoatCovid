using System;

namespace QuanLyCovidDHH.Domain.Request
{
    public class VaccineRequest
    {
        public Guid IDVaccine { get; set; }
        public string TenVaccine { get; set; }
        public string LoVaccine { get; set; }
    }
}
