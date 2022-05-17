using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyCovidDHH.Web.Models.SoTheoDoi
{
    public class TaoMoi
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

        /// <summary>
        /// /////////
        /// </summary>
        public Guid IDSinhVien { get; set; }
        public DateTime NgayBatDauDieuTri { get; set; }
        public string NoiDieuTri { get; set; }
        public string BienThe { get; set; }
        public string KhoiBenh { get; set; }
        public string TuVong { get; set; }
        public DateTime NgayKetThucDieuTri { get; set; }
        public string BenhAnDinhKem { get; set; }
        public string TrangThaiDuyet { get; set; }
        public string NguoiDuyet { get; set; }
        public string LyDo { get; set; }
        public string GhiChu { get; set; }
        // sinh vien

        public IFormFile FileBenhAnDinhKem { get; set; }





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


        //tao moi excel
        public string MaSinhVien { get; set; }

        public string NgayKetThuc { get; set; }

    }
}
