using Microsoft.AspNetCore.Mvc;
using QuanLyCovidDHH.Domain.Request;
using QuanLyCovidDHH.Domain.Response;
using QuanLyCovidDHH.BAL.Interface;
using System;
using System.Collections.Generic;

namespace QuanLyCovidDHH.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SinhVienController
    {
        private readonly ISinhVienService _SinhVienService;
        public SinhVienController(ISinhVienService SinhVienService)
        {
            _SinhVienService = SinhVienService;
        }
        [HttpGet]
        public IEnumerable<SinhVienResponse> SinhVienDanhSach(Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong, string TuKhoa)
        {

            return _SinhVienService.SinhVienDanhSach(IDKhoaHoc, IDKhoa, IDTruong, TuKhoa);
        }
        [HttpGet("ThongKe")]
        public IEnumerable<SinhVienResponse> SinhVienThongKe(Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong, string DaMacCovid, int TongMuiTiem, string LoaiNhom)
        {

            return _SinhVienService.SinhVienThongKe(IDKhoaHoc, IDKhoa, IDTruong, DaMacCovid, TongMuiTiem, LoaiNhom);
        }
        [HttpGet("{IDSinhVien}")]
        public SinhVienResponse SinhVienLayID(Guid IDSinhVien)
        {
            return _SinhVienService.SinhVienLayID(IDSinhVien);
        }
        [HttpGet("TenDangNhap/{TenDangNhap}")]
        public SinhVienResponse SinhVienLayTenDangNhap(string TenDangNhap)
        {
            return _SinhVienService.SinhVienLayTenDangNhap(TenDangNhap);
        }
        [HttpPut]
        public int SinhVienChinhSua(SinhVienRequest request)
        {
            return _SinhVienService.SinhVienChinhSua(request);
        }
        [HttpPost]
        public int SinhVienTaoMoi(SinhVienRequest request)
        {
     
            return _SinhVienService.SinhVienTaoMoi(request);
        }
        [HttpPost("Excel")]
        public int SinhVienTaoMoi_Excel(SinhVienRequest request)
        {
            //request.IDSinhVien = Guid.NewGuid();
            return _SinhVienService.SinhVienTaoMoi_Excel(request);
        }
        [HttpDelete("{IDSinhVien}")]
        public bool SinhVienXoaBo(Guid IDSinhVien)
        {
            return _SinhVienService.SinhVienXoaBo(IDSinhVien);
        }

    }
}
