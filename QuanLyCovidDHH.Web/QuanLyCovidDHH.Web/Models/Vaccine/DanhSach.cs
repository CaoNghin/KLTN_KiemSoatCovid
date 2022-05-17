using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyCovidDHH.Web.Models.Vaccine
{
    public class DanhSach
    {
        public Guid IDVaccine { get; set; }
        public string TenVaccine { get; set; }
        public string LoVaccine { get; set; }
    }
}
