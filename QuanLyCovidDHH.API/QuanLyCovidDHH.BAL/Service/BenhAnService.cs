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
    public class BenhAnService : IBenhAnService
    {
        private readonly IBenhAnRepository _benhAnRepository;
        public BenhAnService(IBenhAnRepository benhAnRepository)
        {
            _benhAnRepository = benhAnRepository;
        }

        public IList<BenhAnResponse> BenhAnDanhSach(Guid? IDSinhVien, Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong, string TuNgay, string DenNgay, string TrangThaiDieuTri, string TrangThaiDuyet)
        {
            return _benhAnRepository.BenhAnDanhSach(IDSinhVien, IDKhoaHoc,IDKhoa,IDTruong,TuNgay,DenNgay,TrangThaiDieuTri,TrangThaiDuyet);
        }
        public IList<BenhAnResponse> BenhAnThongKe(Guid? IDSinhVien, Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong, string NoiDieuTri, string TrangThaiDuyet, int SoLuongBenhNen, string TuNgay, string DenNgay, string LoaiNhom)
        {
            return _benhAnRepository.BenhAnThongKe(IDSinhVien, IDKhoaHoc, IDKhoa, IDTruong, NoiDieuTri, TrangThaiDuyet,SoLuongBenhNen, TuNgay, DenNgay, LoaiNhom );
        }

        public BenhAnResponse BenhAnLayID(Guid IDBenhAn)
        {
            return _benhAnRepository.BenhAnLayID(IDBenhAn);
        }

        public int BenhAnChinhSua(BenhAnRequest request)
        {
            return _benhAnRepository.BenhAnChinhSua(request);
        }

        public int BenhAnTaoMoi(BenhAnRequest request)
        {
            return _benhAnRepository.BenhAnTaoMoi(request);
        }
        public int BenhAnTaoMoi_Excel(BenhAnRequest request)
        {
            return _benhAnRepository.BenhAnTaoMoi_Excel(request);
        }

        public bool BenhAnXoaBo(Guid IDBenhAn)
        {
            return _benhAnRepository.BenhAnXoaBo(IDBenhAn);
        }

    
    }
}
