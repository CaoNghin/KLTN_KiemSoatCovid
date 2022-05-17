using QuanLyCovidDHH.Domain.Request;
using QuanLyCovidDHH.Domain.Response;
using System;
using System.Collections.Generic;

namespace QuanLyCovidDHH.DAL.Interface
{
    public interface IKhoaRepository
    {
        List<KhoaResponse> KhoaDanhSach(Guid? IDTruong, string TuKhoa);
        KhoaResponse KhoaLayID(Guid IDKhoa);
        int KhoaChinhSua(KhoaRequest request);
        int KhoaTaoMoi(KhoaRequest request);
        bool KhoaXoaBo(Guid IDKhoa);
    }
}
