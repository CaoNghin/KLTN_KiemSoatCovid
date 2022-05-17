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
    public class BenhNenService : IBenhNenService
    {
        private readonly IBenhNenRepository _BenhNenRepository;
        public BenhNenService(IBenhNenRepository BenhNenRepository)
        {
            _BenhNenRepository = BenhNenRepository;
        }

        public IList<BenhNenResponse> BenhNenDanhSach(Guid? IDBenhAn, Guid? IDSinhVien, Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong)
        {
            return _BenhNenRepository.BenhNenDanhSach(IDBenhAn,IDSinhVien, IDKhoaHoc,IDKhoa,IDTruong);
        }

        public BenhNenResponse BenhNenLayID(Guid IDBenhNen)
        {
            return _BenhNenRepository.BenhNenLayID(IDBenhNen);
        }

        public int BenhNenChinhSua(BenhNenRequest request)
        {
            return _BenhNenRepository.BenhNenChinhSua(request);
        }

        public int BenhNenTaoMoi(BenhNenRequest request)
        {
            return _BenhNenRepository.BenhNenTaoMoi(request);
        }

        public bool BenhNenXoaBo(Guid IDBenhNen)
        {
            return _BenhNenRepository.BenhNenXoaBo(IDBenhNen);
        }

    
    }
}
