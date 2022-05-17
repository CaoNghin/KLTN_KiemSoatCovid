using QuanLyCovidDHH.Domain.Request;
using QuanLyCovidDHH.Domain.Response;
using System;
using System.Collections.Generic;

namespace QuanLyCovidDHH.DAL.Interface
{
    public interface ITruongRepository
    {
        List<TruongResponse> TruongDanhSach();
        TruongResponse TruongLayID(Guid IDTruong);
        int TruongChinhSua(TruongRequest request);
        int TruongTaoMoi(TruongRequest request);
        bool TruongXoaBo(Guid IDTruong);
    }
}
