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
    public class KhaiBaoXetNghiemService : IKhaiBaoXetNghiemService
    {
        private readonly IKhaiBaoXetNghiemRepository _khaiBaoXetNghiemRepository;
        public KhaiBaoXetNghiemService(IKhaiBaoXetNghiemRepository khaiBaoXetNghiemRepository)
        {
            _khaiBaoXetNghiemRepository = khaiBaoXetNghiemRepository;
        }

        public IList<KhaiBaoXetNghiemResponse> KhaiBaoXetNghiemDanhSach(Guid? IDSinhVien, Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong, string LoaiXetNghiem, string KetQuaXetNghiem, string Ngay, string TrangThaiDuyet)
        {
            return _khaiBaoXetNghiemRepository.KhaiBaoXetNghiemDanhSach(IDSinhVien, IDKhoaHoc,IDKhoa,IDTruong, LoaiXetNghiem,KetQuaXetNghiem ,Ngay,TrangThaiDuyet);
        }

        public KhaiBaoXetNghiemResponse KhaiBaoXetNghiemLayID(Guid IDKhaiBaoXetNghiem)
        {
            return _khaiBaoXetNghiemRepository.KhaiBaoXetNghiemLayID(IDKhaiBaoXetNghiem);
        }

        public int KhaiBaoXetNghiemChinhSua(KhaiBaoXetNghiemRequest request)
        {
            return _khaiBaoXetNghiemRepository.KhaiBaoXetNghiemChinhSua(request);
        }

        public int KhaiBaoXetNghiemTaoMoi(KhaiBaoXetNghiemRequest request)
        {
            return _khaiBaoXetNghiemRepository.KhaiBaoXetNghiemTaoMoi(request);
        }

        public bool KhaiBaoXetNghiemXoaBo(Guid IDKhaiBaoXetNghiem)
        {
            return _khaiBaoXetNghiemRepository.KhaiBaoXetNghiemXoaBo(IDKhaiBaoXetNghiem);
        }

    
    }
}
