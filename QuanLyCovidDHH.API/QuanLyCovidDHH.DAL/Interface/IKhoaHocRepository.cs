using QuanLyCovidDHH.Domain.Request;
using QuanLyCovidDHH.Domain.Response;
using System;
using System.Collections.Generic;

namespace QuanLyCovidDHH.DAL.Interface
{
    public interface IKhoaHocRepository
    {
        List<KhoaHocResponse> KhoaHocDanhSach(Guid? IDKhoa, Guid? IDTruong, int TuKhoa);
        KhoaHocResponse KhoaHocLayID(Guid IDKhoaHoc);
        int KhoaHocChinhSua(KhoaHocRequest request);
        int KhoaHocTaoMoi(KhoaHocRequest request);
        bool KhoaHocXoaBo(Guid IDKhoaHoc);
    }
}
