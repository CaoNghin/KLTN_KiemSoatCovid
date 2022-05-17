using Microsoft.AspNetCore.Mvc;
using QuanLyCovidDHH.BAL.Interface;
using QuanLyCovidDHH.Domain.Request;
using QuanLyCovidDHH.Domain.Response;
using System;
using System.Collections.Generic;

namespace QuanLyCovidDHH.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhoaHocController : ControllerBase
    {
        private readonly IKhoaHocService _KhoaHocService;
        public KhoaHocController(IKhoaHocService KhoaHocService)
        {
            _KhoaHocService = KhoaHocService;
        }
        [HttpGet]
        public IEnumerable<KhoaHocResponse> KhoaHocDanhSach(Guid? IDKhoa, Guid? IDTruong, int TuKhoa)
        {
            return _KhoaHocService.KhoaHocDanhSach(IDKhoa, IDTruong, TuKhoa);
        }
        [HttpGet("{IDKhoaHoc}")]
        public KhoaHocResponse KhoaHocLayID(Guid IDKhoaHoc)
        {
            return _KhoaHocService.KhoaHocLayID(IDKhoaHoc);
        }
        [HttpPut]
        public int KhoaHocChinhSua([FromBody] KhoaHocRequest request)
        {
            return _KhoaHocService.KhoaHocChinhSua(request);
        }
        [HttpPost]
        public int KhoaHocTaoMoi([FromBody] KhoaHocRequest request)
        {
            return _KhoaHocService.KhoaHocTaoMoi(request);
        }
        [HttpDelete("{IDKhoaHoc}")]
        public bool KhoaHocXoaBo(Guid IDKhoaHoc)
        {
            return _KhoaHocService.KhoaHocXoaBo(IDKhoaHoc);
        }
    }
}





