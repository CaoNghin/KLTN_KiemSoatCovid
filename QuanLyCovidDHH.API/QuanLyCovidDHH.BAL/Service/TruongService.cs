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
    public class TruongService : ITruongService
    {
        private readonly ITruongRepository _TruongRepository;
        public TruongService(ITruongRepository TruongRepository)
        {
            _TruongRepository = TruongRepository;
        }

        public List<TruongResponse> TruongDanhSach()
        {
            return _TruongRepository.TruongDanhSach();
        }

        public TruongResponse TruongLayID(Guid IDTruong)
        {
            return _TruongRepository.TruongLayID(IDTruong);
        }

        public int TruongChinhSua(TruongRequest request)
        {
            return _TruongRepository.TruongChinhSua(request);
        }

        public int TruongTaoMoi(TruongRequest request)
        {
            return _TruongRepository.TruongTaoMoi(request);
        }

        public bool TruongXoaBo(Guid IDTruong)
        {
            return _TruongRepository.TruongXoaBo(IDTruong);
        }

    }
}
