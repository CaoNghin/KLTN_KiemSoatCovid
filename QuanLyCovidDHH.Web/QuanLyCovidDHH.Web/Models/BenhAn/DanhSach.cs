using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyCovidDHH.Web.Models.BenhAn

{
    public class DanhSach
    {
        public Guid IDBenhAn { get; set; }
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

        public Guid IDKhoaHoc { get; set; }
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

        public Guid IDKhoa { get; set; }
        public int KhoaHoc { get; set; }
        public int NamTuyenSinh { get; set; }
        public string MaKhoaHoc { get; set; }

        public Guid IDTruong { get; set; }
        public string TenKhoa { get; set; }
        public string MaKhoa { get; set; }
        public string TenTruong { get; set; }
        public string MaTruong { get; set; }
        public string Ngay { get; set; }
        public int Dem { get; set; }
        public string TenVaccine { get; set; }
    }
}
