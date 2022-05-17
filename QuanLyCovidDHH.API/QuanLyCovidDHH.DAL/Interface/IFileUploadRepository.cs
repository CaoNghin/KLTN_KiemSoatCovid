using QuanLyCovidDHH.Domain.Request;
using QuanLyCovidDHH.Domain.Response;
using System;
using System.Collections.Generic;

namespace QuanLyCovidDHH.DAL.Interface
{
    public interface IFileUploadRepository
    {
        IList<FileUploadResponse> FileUpload_LayTheoDoiTuongID(Guid DoiTuongID);
        int FileUpload_ChinhSua(FileUploadRequest request);
        int FileUpload_TaoMoi(FileUploadRequest request);
        bool FileUpload_Xoa(Guid DoiTuongID, string TenTep);
    }
}
