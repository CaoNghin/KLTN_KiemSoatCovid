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
    public class TruongController
    {
        private readonly ITruongService _TruongService;
        public TruongController(ITruongService TruongService)
        {
            _TruongService = TruongService;
        }
        [HttpGet]
        public IEnumerable<TruongResponse> TruongDanhSach()
        {
            return _TruongService.TruongDanhSach();
        }
        [HttpGet("{IDTruong}")]
        public TruongResponse TruongLayID(Guid IDTruong)
        {
            return _TruongService.TruongLayID(IDTruong);
        }
        [HttpPut]
        public int TruongChinhSua([FromBody] TruongRequest request)
        {
            return _TruongService.TruongChinhSua(request);
        }
        [HttpPost]
        public int TruongTaoMoi([FromBody] TruongRequest request)
        {
            return _TruongService.TruongTaoMoi(request);
        }
        [HttpDelete("{IDTruong}")]
        public bool TruongXoaBo(Guid IDTruong)
        {
            return _TruongService.TruongXoaBo(IDTruong);
        }

    }
}
