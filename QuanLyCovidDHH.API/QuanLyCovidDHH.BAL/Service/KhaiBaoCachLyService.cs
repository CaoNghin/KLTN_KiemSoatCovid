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
    public class KhaiBaoCachLyService : IKhaiBaoCachLyService
    {
        private readonly IKhaiBaoCachLyRepository _khaiBaoCachLyRepository;
        public KhaiBaoCachLyService(IKhaiBaoCachLyRepository khaiBaoCachLyRepository)
        {
            _khaiBaoCachLyRepository = khaiBaoCachLyRepository;
        }

        public IList<KhaiBaoCachLyResponse> KhaiBaoCachLyDanhSach(Guid? IDSinhVien, Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong, string DoiTuongCachLy, string Ngay, string TrangThaiDuyet)
        {
            return _khaiBaoCachLyRepository.KhaiBaoCachLyDanhSach(IDSinhVien, IDKhoaHoc,IDKhoa,IDTruong,  DoiTuongCachLy,  Ngay,  TrangThaiDuyet);
        }

        public KhaiBaoCachLyResponse KhaiBaoCachLyLayID(Guid IDKhaiBaoCachLy)
        {
            return _khaiBaoCachLyRepository.KhaiBaoCachLyLayID(IDKhaiBaoCachLy);
        }

        public int KhaiBaoCachLyChinhSua(KhaiBaoCachLyRequest request)
        {
            return _khaiBaoCachLyRepository.KhaiBaoCachLyChinhSua(request);
        }

        public int KhaiBaoCachLyTaoMoi(KhaiBaoCachLyRequest request)
        {
            return _khaiBaoCachLyRepository.KhaiBaoCachLyTaoMoi(request);
        }

        public bool KhaiBaoCachLyXoaBo(Guid IDKhaiBaoCachLy)
        {
            return _khaiBaoCachLyRepository.KhaiBaoCachLyXoaBo(IDKhaiBaoCachLy);
        }

    
    }
}
