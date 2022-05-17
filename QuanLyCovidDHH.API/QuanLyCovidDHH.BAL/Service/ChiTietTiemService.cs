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
    public class ChiTietTiemService : IChiTietTiemService
    {
        private readonly IChiTietTiemRepository _chiTietTiemRepository;
        public ChiTietTiemService(IChiTietTiemRepository chiTietTiemRepository)
        {
            _chiTietTiemRepository = chiTietTiemRepository;
        }

        public IList<ChiTietTiemResponse> ChiTietTiemDanhSach(Guid? IDVaccine, Guid? IDSinhVien, Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong, string TrieuChungSauTiem, string TrangThaiDuyet)
        {
            return _chiTietTiemRepository.ChiTietTiemDanhSach(IDVaccine,IDSinhVien, IDKhoaHoc,IDKhoa,IDTruong,TrieuChungSauTiem,TrangThaiDuyet);
        }
        public IList<ChiTietTiemResponse> ChiTietTiemThongKe(Guid? IDVaccine, Guid? IDSinhVien, Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong, string TrieuChungSauTiem, string TrangThaiDuyet, int MuiTiemThu, string TuNgay, string DenNgay, string LoaiNhom)
        {
            return _chiTietTiemRepository.ChiTietTiemThongKe(IDVaccine, IDSinhVien, IDKhoaHoc, IDKhoa, IDTruong, TrieuChungSauTiem, TrangThaiDuyet,MuiTiemThu,TuNgay,DenNgay,LoaiNhom);
        }
        public ChiTietTiemResponse ChiTietTiemLayID(Guid IDChiTietTiem)
        {
            return _chiTietTiemRepository.ChiTietTiemLayID(IDChiTietTiem);
        }

        public int ChiTietTiemChinhSua(ChiTietTiemRequest request)
        {
            return _chiTietTiemRepository.ChiTietTiemChinhSua(request);
        }

        public int ChiTietTiemTaoMoi(ChiTietTiemRequest request)
        {
            return _chiTietTiemRepository.ChiTietTiemTaoMoi(request);
        }
        public int ChiTietTiemTaoMoi_Excel(ChiTietTiemRequest request)
        {
            return _chiTietTiemRepository.ChiTietTiemTaoMoi_Excel(request);
        }

        public bool ChiTietTiemXoaBo(Guid IDChiTietTiem)
        {
            return _chiTietTiemRepository.ChiTietTiemXoaBo(IDChiTietTiem);
        }

    
    }
}
