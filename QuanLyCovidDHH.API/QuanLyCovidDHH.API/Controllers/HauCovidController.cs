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
    public class HauCovidController
    {
        private readonly IHauCovidService _HauCovidService;
        public HauCovidController(IHauCovidService HauCovidService)
        {
            _HauCovidService = HauCovidService;
        }
        // Danh sách  
        [HttpGet]
        public IEnumerable<HauCovidResponse> HauCovidDanhSach(Guid? IDBenhAn, Guid? IDSinhVien, Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong)
        {
            return _HauCovidService.HauCovidDanhSach(IDBenhAn, IDSinhVien, IDKhoaHoc, IDKhoa, IDTruong);
        }
        // Lấy mã 
        [HttpGet("{IDHauCovid}")]
        public HauCovidResponse HauCovidLayID(Guid IDHauCovid)
        {
            return _HauCovidService.HauCovidLayID(IDHauCovid);
        }

        // Chỉnh sửa 
        [HttpPut]
        public int HauCovidChinhSua([FromBody] HauCovidRequest request)
        {
            return _HauCovidService.HauCovidChinhSua(request);
        }
        // Tạo mới 
        [HttpPost]
        public int HauCovidTaoMoi(HauCovidRequest request)
        {
            request.IDHauCovid = Guid.NewGuid();
            return _HauCovidService.HauCovidTaoMoi(request);
        }

        // Xóa bỏ 
        [HttpDelete("{IDHauCovid}")]
        public bool HauCovidXoaBo(Guid IDHauCovid)
        {
            return _HauCovidService.HauCovidXoaBo(IDHauCovid);
        }
    }
}
