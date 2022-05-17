using QuanLyCovidDHH.Domain.Response;
using QuanLyCovidDHH.Domain.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCovidDHH.BAL.Interface
{
    public interface IKhaiBaoXetNghiemService
    {
        IList<KhaiBaoXetNghiemResponse> KhaiBaoXetNghiemDanhSach(Guid? IDSinhVien, Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong, string LoaiXetNghiem, string KetQuaXetNghiem, string Ngay, string TrangThaiDuyet);
        KhaiBaoXetNghiemResponse KhaiBaoXetNghiemLayID(Guid IDIDKhaiBaoXetNghiem);
        int KhaiBaoXetNghiemChinhSua(KhaiBaoXetNghiemRequest request);
        int KhaiBaoXetNghiemTaoMoi(KhaiBaoXetNghiemRequest request);
        bool KhaiBaoXetNghiemXoaBo(Guid IDIDKhaiBaoXetNghiem);

    }
}
