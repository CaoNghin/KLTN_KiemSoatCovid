using QuanLyCovidDHH.BAL.Interface;
using QuanLyCovidDHH.DAL.Interface;
using QuanLyCovidDHH.Domain.Request;
using QuanLyCovidDHH.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCovidDHH.BAL.Service
{
    public class VaccineService : IVaccineService
    {
        private readonly IVaccineRepository _VaccineRepository;
        public VaccineService(IVaccineRepository VaccineRepository)
        {
            _VaccineRepository = VaccineRepository;
        }

        public List<VaccineResponse> VaccineDanhSach()
        {
            return _VaccineRepository.VaccineDanhSach();
        }

        public VaccineResponse VaccineLayID(Guid IDVaccine)
        {
            return _VaccineRepository.VaccineLayID(IDVaccine);
        }

        public int VaccineChinhSua(VaccineRequest request)
        {
            return _VaccineRepository.VaccineChinhSua(request);
        }

        public int VaccineTaoMoi(VaccineRequest request)
        {
            return _VaccineRepository.VaccineTaoMoi(request);
        }

        public bool VaccineXoaBo(Guid IDVaccine)
        {
            return _VaccineRepository.VaccineXoaBo(IDVaccine);
        }

    }
}
