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
    public class KhoaHocService : IKhoaHocService
    {
        private readonly IKhoaHocRepository _KhoaHocRepository;
        public KhoaHocService(IKhoaHocRepository KhoaHocRepository)
        {
            _KhoaHocRepository = KhoaHocRepository;
        }
        public List<KhoaHocResponse> KhoaHocDanhSach( Guid? IDKhoa, Guid? IDTruong, int TuKhoa)
        {
            return _KhoaHocRepository.KhoaHocDanhSach( IDKhoa,  IDTruong, TuKhoa);
        }
        public KhoaHocResponse KhoaHocLayID(Guid IDKhoaHoc)
        {
            return _KhoaHocRepository.KhoaHocLayID(IDKhoaHoc);
        }

        public int KhoaHocChinhSua(KhoaHocRequest request)
        {
            return _KhoaHocRepository.KhoaHocChinhSua(request);
        }

       
        public int KhoaHocTaoMoi(KhoaHocRequest request)
        {
            return _KhoaHocRepository.KhoaHocTaoMoi(request);
        }

        public bool KhoaHocXoaBo(Guid IDKhoaHoc)
        {
            return _KhoaHocRepository.KhoaHocXoaBo(IDKhoaHoc);
        }
    }
}
