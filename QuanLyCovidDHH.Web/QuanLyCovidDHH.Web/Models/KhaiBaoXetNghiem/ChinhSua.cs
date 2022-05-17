using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyCovidDHH.Web.Models.KhaiBaoXetNghiem
{
    public class ChinhSua
    {

        public Guid IDKhaiBaoXetNghiem { get; set; }
        public Guid IDSinhVien { get; set; }
        public string LoaiXetNghiem { get; set; }
        public string KetQuaXetNghiem { get; set; }
        public DateTime NgayXetNghiem { get; set; }
        public string HinhAnhXetNghiem { get; set; }
        public string TrangThaiDuyet { get; set; }
        public string NguoiDuyet { get; set; }
        public string LyDo { get; set; }
        public string GhiChu { get; set; }

        // sinh vien

        public IFormFile FileHinhAnhXetNghiem { get; set; }

        public string SoCMND_CCCD { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public int TongMuiTiem { get; set; }
        public string DaMacCovid { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public int MaSo { get; set; }
    }
}
