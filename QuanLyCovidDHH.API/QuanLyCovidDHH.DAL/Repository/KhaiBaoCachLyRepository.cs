using Dapper;
using QuanLyCovidDHH.DAL.Interface;
using QuanLyCovidDHH.Domain.Request;
using QuanLyCovidDHH.Domain.Response;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace QuanLyCovidDHH.DAL.Repository
{
    public class KhaiBaoCachLyRepository : DataBaseRepository, IKhaiBaoCachLyRepository
    {
        // Danh sách 
        public IList<KhaiBaoCachLyResponse> KhaiBaoCachLyDanhSach(Guid? IDSinhVien, Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong, string DoiTuongCachLy, string Ngay, string TrangThaiDuyet)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDSinhVien", IDSinhVien);
                parameters.Add("@IDKhoaHoc", IDKhoaHoc);
                parameters.Add("@IDKhoa", IDKhoa);
                parameters.Add("@IDTruong", IDTruong);
                parameters.Add("@DoiTuongCachLy", DoiTuongCachLy);
                parameters.Add("@Ngay", Ngay);
                parameters.Add("@TrangThaiDuyet", TrangThaiDuyet);
                IList<KhaiBaoCachLyResponse> danhSach = SqlMapper.Query<KhaiBaoCachLyResponse>(connect, "SPKhaiBaoCachLy_DanhSach", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return danhSach;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Lấy mã 
        public KhaiBaoCachLyResponse KhaiBaoCachLyLayID(Guid IDKhaiBaoCachLy)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@IDKhaiBaoCachLy", IDKhaiBaoCachLy);
            KhaiBaoCachLyResponse layKhaiBaoCachLy = SqlMapper.Query<KhaiBaoCachLyResponse>(connect, "SPKhaiBaoCachLy_LayID", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return layKhaiBaoCachLy;
        }

        // Chỉnh sửa 
        public int KhaiBaoCachLyChinhSua(KhaiBaoCachLyRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDKhaiBaoCachLy", request.IDKhaiBaoCachLy);
                parameters.Add("@IDSinhVien", request.IDSinhVien);
                parameters.Add("@DoiTuongCachLy", request.DoiTuongCachLy);
                parameters.Add("@NgayBatDauCachLy", request.NgayBatDauCachLy);
                parameters.Add("@NgayKetThucCachLy", request.NgayKetThucCachLy);
                parameters.Add("@QuyetDinhCachLy", request.QuyetDinhCachLy);
                parameters.Add("@TrangThaiDuyet", request.TrangThaiDuyet);
                parameters.Add("@NguoiDuyet", request.NguoiDuyet);
                parameters.Add("@LyDo", request.LyDo);
                parameters.Add("@GhiChu", request.GhiChu);
                var id = SqlMapper.ExecuteScalar<int>(connect, "SPKhaiBaoCachLy_ChinhSua", param: parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Tạo mới 
        public int KhaiBaoCachLyTaoMoi(KhaiBaoCachLyRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDKhaiBaoCachLy", request.IDKhaiBaoCachLy);
                parameters.Add("@IDSinhVien", request.IDSinhVien);
                parameters.Add("@DoiTuongCachLy", request.DoiTuongCachLy);
                parameters.Add("@NgayBatDauCachLy", request.NgayBatDauCachLy);
                parameters.Add("@NgayKetThucCachLy", request.NgayKetThucCachLy);
                parameters.Add("@QuyetDinhCachLy", request.QuyetDinhCachLy);
                parameters.Add("@TrangThaiDuyet", request.TrangThaiDuyet);
                parameters.Add("@NguoiDuyet", request.NguoiDuyet);
                parameters.Add("@LyDo", request.LyDo);
                parameters.Add("@GhiChu", request.GhiChu);
                var id = SqlMapper.ExecuteScalar<int>(connect, "SPKhaiBaoCachLy_TaoMoi", param: parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool KhaiBaoCachLyXoaBo(Guid IDKhaiBaoCachLy)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDKhaiBaoCachLy", IDKhaiBaoCachLy);
                var result = SqlMapper.ExecuteScalar<bool>(connect, "SPKhaiBaoCachLy_Xoa", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
