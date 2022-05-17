using QuanLyCovidDHH.Domain.Request;
using QuanLyCovidDHH.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCovidDHH.BAL.Interface
{
    public interface IVaccineService
    {
        List<VaccineResponse> VaccineDanhSach();
        VaccineResponse VaccineLayID(Guid IDVaccine);
        int VaccineChinhSua(VaccineRequest request);
        int VaccineTaoMoi(VaccineRequest request);
        bool VaccineXoaBo(Guid IDVaccine);
    }
}
