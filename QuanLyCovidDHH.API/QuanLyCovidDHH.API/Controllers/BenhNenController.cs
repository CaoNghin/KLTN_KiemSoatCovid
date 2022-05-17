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
    public class BenhNenController
    {
        private readonly IBenhNenService _BenhNenService;
        public BenhNenController(IBenhNenService BenhNenService)
        {
            _BenhNenService = BenhNenService;
        }
        // Danh sách  
        [HttpGet]
        public IEnumerable<BenhNenResponse> BenhNenDanhSach(Guid? IDBenhAn, Guid? IDSinhVien, Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong)
        {
            return _BenhNenService.BenhNenDanhSach(IDBenhAn, IDSinhVien, IDKhoaHoc, IDKhoa, IDTruong);
        }
        // Lấy mã 
        [HttpGet("{IDBenhNen}")]
        public BenhNenResponse BenhNenLayID(Guid IDBenhNen)
        {
            return _BenhNenService.BenhNenLayID(IDBenhNen);
        }

        // Chỉnh sửa 
        [HttpPut]
        public int BenhNenChinhSua([FromBody] BenhNenRequest request)
        {
            return _BenhNenService.BenhNenChinhSua(request);
        }
        // Tạo mới 
        [HttpPost]
        public int BenhNenTaoMoi(BenhNenRequest request)
        {
            request.IDBenhNen = Guid.NewGuid();
            return _BenhNenService.BenhNenTaoMoi(request);
        }

        // Xóa bỏ 
        [HttpDelete("{IDBenhNen}")]
        public bool BenhNenXoaBo(Guid IDBenhNen)
        {
            return _BenhNenService.BenhNenXoaBo(IDBenhNen);
        }
    }
}
