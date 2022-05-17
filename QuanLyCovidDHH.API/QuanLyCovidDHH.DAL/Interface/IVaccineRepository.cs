using QuanLyCovidDHH.Domain.Request;
using QuanLyCovidDHH.Domain.Response;
using System;
using System.Collections.Generic;

namespace QuanLyCovidDHH.DAL.Interface
{
    public interface IVaccineRepository
    {
        List<VaccineResponse> VaccineDanhSach();
        VaccineResponse VaccineLayID(Guid IDVaccine);
        int VaccineChinhSua(VaccineRequest request);
        int VaccineTaoMoi(VaccineRequest request);
        bool VaccineXoaBo(Guid IDVaccine);
    }
}
