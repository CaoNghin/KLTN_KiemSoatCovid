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
    public class KhoaService : IKhoaService
    {
        private readonly IKhoaRepository _KhoaRepository;
        public KhoaService(IKhoaRepository KhoaRepository)
        {
            _KhoaRepository = KhoaRepository;
        }
        public List<KhoaResponse> KhoaDanhSach( Guid? IDTruong, string TuKhoa)
        {
            return _KhoaRepository.KhoaDanhSach(IDTruong, TuKhoa);
        }
        public KhoaResponse KhoaLayID(Guid IDKhoa)
        {
            return _KhoaRepository.KhoaLayID(IDKhoa);
        }

        public int KhoaChinhSua(KhoaRequest request)
        {
            return _KhoaRepository.KhoaChinhSua(request);
        }

       
        public int KhoaTaoMoi(KhoaRequest request)
        {
            return _KhoaRepository.KhoaTaoMoi(request);
        }

        public bool KhoaXoaBo(Guid IDKhoa)
        {
            return _KhoaRepository.KhoaXoaBo(IDKhoa);
        }
    }
}
