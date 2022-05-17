using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyCovidDHH.Web.Models.Khoa
{
    public class TaoMoi
    {
        [Required(ErrorMessage = "Phải nhập {0}")]
        public Guid IDTruong { get; set; }

        [Required(ErrorMessage = "Phải nhập {0}")]
        [StringLength(250, MinimumLength = 1, ErrorMessage = "{0} phải dài chỉ từ {2}-{1} kí tự")]
        public string TenKhoa { get; set; }

        [Required(ErrorMessage = "Phải nhập {0}")]
        [StringLength(25, MinimumLength = 1, ErrorMessage = "{0} phải dài chỉ từ {2}-{1} kí tự")]
        public string MaKhoa { get; set; }

    }
}
