﻿using System;

namespace QuanLyCovidDHH.Domain.Request
{
    public class SoTheoDoiRequest
    {
        public Guid IDSoTheoDoi { get; set; }
        public Guid IDBenhAn { get; set; }
        public DateTime NgayTheoDoi { get; set; }
        public float NongDoSpO2 { get; set; }
        public float Sot { get; set; }
        public string Ho { get; set; }
        public string KhoTho { get; set; }
        public string DauHong { get; set; }
        public string MatViGiac { get; set; }
        public string MatKhuuGiac { get; set; }

    }
}
