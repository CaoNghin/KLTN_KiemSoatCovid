using QuanLyCovidDHH.BAL.Interface;
using QuanLyCovidDHH.DAL.Interface;
using QuanLyCovidDHH.Domain.Response;
using QuanLyCovidDHH.Domain.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCovidDHH.BAL.Service
{
    public class HauCovidService : IHauCovidService
    {
        private readonly IHauCovidRepository _HauCovidRepository;
        public HauCovidService(IHauCovidRepository HauCovidRepository)
        {
            _HauCovidRepository = HauCovidRepository;
        }

        public IList<HauCovidResponse> HauCovidDanhSach(Guid? IDBenhAn, Guid? IDSinhVien, Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong)
        {
            return _HauCovidRepository.HauCovidDanhSach(IDBenhAn,IDSinhVien, IDKhoaHoc,IDKhoa,IDTruong);
        }

        public HauCovidResponse HauCovidLayID(Guid IDHauCovid)
        {
            return _HauCovidRepository.HauCovidLayID(IDHauCovid);
        }

        public int HauCovidChinhSua(HauCovidRequest request)
        {
            return _HauCovidRepository.HauCovidChinhSua(request);
        }

        public int HauCovidTaoMoi(HauCovidRequest request)
        {
            return _HauCovidRepository.HauCovidTaoMoi(request);
        }

        public bool HauCovidXoaBo(Guid IDHauCovid)
        {
            return _HauCovidRepository.HauCovidXoaBo(IDHauCovid);
        }

    
    }
}
