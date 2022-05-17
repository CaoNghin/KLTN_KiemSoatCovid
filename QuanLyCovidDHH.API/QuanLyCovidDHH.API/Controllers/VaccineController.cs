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
    public class VaccineController
    {
        private readonly IVaccineService _VaccineService;
        public VaccineController(IVaccineService VaccineService)
        {
            _VaccineService = VaccineService;
        }
        [HttpGet]
        public IEnumerable<VaccineResponse> VaccineDanhSach()
        {
            return _VaccineService.VaccineDanhSach();
        }
        [HttpGet("{IDVaccine}")]
        public VaccineResponse VaccineLayID(Guid IDVaccine)
        {
            return _VaccineService.VaccineLayID(IDVaccine);
        }
        [HttpPut]
        public int VaccineChinhSua([FromBody] VaccineRequest request)
        {
            return _VaccineService.VaccineChinhSua(request);
        }
        [HttpPost]
        public int VaccineTaoMoi([FromBody] VaccineRequest request)
        {
            return _VaccineService.VaccineTaoMoi(request);
        }
        [HttpDelete("{IDVaccine}")]
        public bool VaccineXoaBo(Guid IDVaccine)
        {
            return _VaccineService.VaccineXoaBo(IDVaccine);
        }

    }
}
