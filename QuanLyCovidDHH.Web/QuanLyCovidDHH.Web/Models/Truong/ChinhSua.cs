using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyCovidDHH.Web.Models.Truong
{
    public class ChinhSua
    {
        public Guid IDTruong { get; set; }
        public string TenTruong { get; set; }
        public string MaTruong { get; set; }
    }
}
