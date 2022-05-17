using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyCovidDHH.Web.Models.ChiTietTiem
{
    public class TaoMoi
    {
        public Guid IDChiTietTiem { get; set; }
        public Guid IDSinhVien { get; set; }
        public Guid IDVaccine { get; set; }
        public string DiaChiTiem { get; set; }
        public string TrieuChungSauTiem { get; set; }
        public DateTime NgayGioTiem { get; set; }
        public int MuiTiemThu { get; set; }
        public string ChiTietTiemDinhKem { get; set; }
        public IFormFile FileChiTietTiemDinhKem { get; set; }
        public string TrangThaiDuyet { get; set; }
        public string NguoiDuyet { get; set; }
        public string LyDo { get; set; }
        public string GhiChu { get; set; }
                public string TenVaccine { get; set; }
        public string MaSinhVien { get; set; }





        [Required(ErrorMessage = "Phải nhập {0}")]
        public Guid IDKhoa { get; set; }

        public string SoCMND_CCCD { get; set; }

        [Required(ErrorMessage = "Phải nhập {0}")]
        public string HoTen { get; set; }

        public string SDT { get; set; }
        public string Email { get; set; }
        public int TongMuiTiem { get; set; }
        public string DaMacCovid { get; set; }
        [Required(ErrorMessage = "Phải nhập {0}")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "{0} phải dài chỉ từ {2}-{1} kí tự")]
        public string TenDangNhap { get; set; }
        [Required(ErrorMessage = "Phải nhập {0}")]
        [StringLength(25, MinimumLength = 6, ErrorMessage = "{0} phải dài chỉ từ {2}-{1} kí tự")]
        public string MatKhau { get; set; }
        public int MaSo { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public string MaTruong { get; set; }

        public string MaKhoa { get; set; }
        public string MaKhoaHoc { get; set; }



    }
}
