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
    public class SoTheoDoiService : ISoTheoDoiService
    {
        private readonly ISoTheoDoiRepository _SoTheoDoiRepository;
        public SoTheoDoiService(ISoTheoDoiRepository SoTheoDoiRepository)
        {
            _SoTheoDoiRepository = SoTheoDoiRepository;
        }

        public IList<SoTheoDoiResponse> SoTheoDoiDanhSach(Guid? IDBenhAn, Guid? IDSinhVien, Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong, string NgayTheoDoi)
        {
            return _SoTheoDoiRepository.SoTheoDoiDanhSach(IDBenhAn,IDSinhVien, IDKhoaHoc,IDKhoa,IDTruong,NgayTheoDoi);
        }

        public SoTheoDoiResponse SoTheoDoiLayID(Guid IDSoTheoDoi)
        {
            return _SoTheoDoiRepository.SoTheoDoiLayID(IDSoTheoDoi);
        }

        public int SoTheoDoiChinhSua(SoTheoDoiRequest request)
        {
            return _SoTheoDoiRepository.SoTheoDoiChinhSua(request);
        }

        public int SoTheoDoiTaoMoi(SoTheoDoiRequest request)
        {
            return _SoTheoDoiRepository.SoTheoDoiTaoMoi(request);
        }

        public bool SoTheoDoiXoaBo(Guid IDSoTheoDoi)
        {
            return _SoTheoDoiRepository.SoTheoDoiXoaBo(IDSoTheoDoi);
        }

    
    }
}
