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
    public class KhaiBaoXetNghiemRepository : DataBaseRepository, IKhaiBaoXetNghiemRepository
    {
        // Danh sách 
        public IList<KhaiBaoXetNghiemResponse> KhaiBaoXetNghiemDanhSach(Guid? IDSinhVien, Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong, string LoaiXetNghiem, string KetQuaXetNghiem, string Ngay, string TrangThaiDuyet)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDSinhVien", IDSinhVien);
                parameters.Add("@IDKhoaHoc", IDKhoaHoc);
                parameters.Add("@IDKhoa", IDKhoa);
                parameters.Add("@IDTruong", IDTruong);
                parameters.Add("@LoaiXetNghiem", LoaiXetNghiem);
                parameters.Add("@KetQuaXetNghiem", KetQuaXetNghiem);
                parameters.Add("@Ngay", Ngay);
                parameters.Add("@TrangThaiDuyet", TrangThaiDuyet);

                IList<KhaiBaoXetNghiemResponse> danhSach = SqlMapper.Query<KhaiBaoXetNghiemResponse>(connect, "SPKhaiBaoXetNghiem_DanhSach", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return danhSach;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Lấy mã 
        public KhaiBaoXetNghiemResponse KhaiBaoXetNghiemLayID(Guid IDKhaiBaoXetNghiem)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@IDKhaiBaoXetNghiem", IDKhaiBaoXetNghiem);
            KhaiBaoXetNghiemResponse layKhaiBaoXetNghiem = SqlMapper.Query<KhaiBaoXetNghiemResponse>(connect, "SPKhaiBaoXetNghiem_LayID", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return layKhaiBaoXetNghiem;
        }

        // Chỉnh sửa 
        public int KhaiBaoXetNghiemChinhSua(KhaiBaoXetNghiemRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDKhaiBaoXetNghiem", request.IDKhaiBaoXetNghiem);
                parameters.Add("@IDSinhVien", request.IDSinhVien);
                parameters.Add("@LoaiXetNghiem", request.LoaiXetNghiem);
                parameters.Add("@KetQuaXetNghiem", request.KetQuaXetNghiem);
                parameters.Add("@NgayXetNghiem", request.NgayXetNghiem);
                parameters.Add("@HinhAnhXetNghiem", request.HinhAnhXetNghiem);
                parameters.Add("@TrangThaiDuyet", request.TrangThaiDuyet);
                parameters.Add("@NguoiDuyet", request.NguoiDuyet);
                parameters.Add("@LyDo", request.LyDo);
                parameters.Add("@GhiChu", request.GhiChu);
                var id = SqlMapper.ExecuteScalar<int>(connect, "SPKhaiBaoXetNghiem_ChinhSua", param: parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Tạo mới 
        public int KhaiBaoXetNghiemTaoMoi(KhaiBaoXetNghiemRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDKhaiBaoXetNghiem", request.IDKhaiBaoXetNghiem);
                parameters.Add("@IDSinhVien", request.IDSinhVien);
                parameters.Add("@LoaiXetNghiem", request.LoaiXetNghiem);
                parameters.Add("@KetQuaXetNghiem", request.KetQuaXetNghiem);
                parameters.Add("@NgayXetNghiem", request.NgayXetNghiem);
                parameters.Add("@HinhAnhXetNghiem", request.HinhAnhXetNghiem);
                parameters.Add("@TrangThaiDuyet", request.TrangThaiDuyet);
                parameters.Add("@NguoiDuyet", request.NguoiDuyet);
                parameters.Add("@LyDo", request.LyDo);
                parameters.Add("@GhiChu", request.GhiChu);
                var id = SqlMapper.ExecuteScalar<int>(connect, "SPKhaiBaoXetNghiem_TaoMoi", param: parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool KhaiBaoXetNghiemXoaBo(Guid IDKhaiBaoXetNghiem)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDKhaiBaoXetNghiem", IDKhaiBaoXetNghiem);
                var result = SqlMapper.ExecuteScalar<bool>(connect, "SPKhaiBaoXetNghiem_Xoa", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
