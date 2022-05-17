using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyCovidDHH.Web.Models.SinhVien
{
    public class TaoMoi
    {

        [Required(ErrorMessage = "Phải nhập {0}")]
        public Guid IDKhoaHoc { get; set; }

        public string SoCMND_CCCD { get; set; }

        [Required(ErrorMessage = "Phải nhập {0}")]
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public int TongMuiTiem { get; set; }
        public string DaMacCovid { get; set; }
       
        public string TenDangNhap { get; set; }
      
        public string MatKhau { get; set; }
        public int MaSo { get; set; }

        public string MaTruong { get; set; }

        public string MaKhoa { get; set; }
        public string MaKhoaHoc { get; set; }



    }
}
