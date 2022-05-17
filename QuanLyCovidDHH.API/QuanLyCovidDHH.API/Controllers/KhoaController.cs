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
    public class KhoaController : ControllerBase
    {
        private readonly IKhoaService _khoaService;
        public KhoaController(IKhoaService KhoaService)
        {
            _khoaService = KhoaService;
        }
        [HttpGet]
        public IEnumerable<KhoaResponse> KhoaDanhSach(Guid? IDTruong, string TuKhoa)
        {
            return _khoaService.KhoaDanhSach(IDTruong, TuKhoa);
        }
        [HttpGet("{IDKhoa}")]
        public KhoaResponse KhoaLayID(Guid IDKhoa)
        {
            return _khoaService.KhoaLayID(IDKhoa);
        }
        [HttpPut]
        public int KhoaChinhSua([FromBody] KhoaRequest request)
        {
            return _khoaService.KhoaChinhSua(request);
        }
        [HttpPost]
        public int KhoaTaoMoi([FromBody] KhoaRequest request)
        {
            return _khoaService.KhoaTaoMoi(request);
        }
        [HttpDelete("{IDKhoa}")]
        public bool KhoaXoaBo(Guid IDKhoa)
        {
            return _khoaService.KhoaXoaBo(IDKhoa);
        }
    }
}





