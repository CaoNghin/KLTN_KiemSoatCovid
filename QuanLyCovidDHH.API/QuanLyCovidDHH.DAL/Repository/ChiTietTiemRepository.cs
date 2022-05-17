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
    public class ChiTietTiemRepository : DataBaseRepository, IChiTietTiemRepository
    {
        // Danh sách 
        public IList<ChiTietTiemResponse> ChiTietTiemDanhSach(Guid? IDVaccine, Guid? IDSinhVien, Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong, string TrieuChungSauTiem, string TrangThaiDuyet)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDVaccine", IDVaccine);
                parameters.Add("@IDSinhVien", IDSinhVien);
                parameters.Add("@IDKhoaHoc", IDKhoaHoc);
                parameters.Add("@IDKhoa", IDKhoa);
                parameters.Add("@IDTruong", IDTruong);
                parameters.Add("@TrieuChungSauTiem", TrieuChungSauTiem);
                parameters.Add("@TrangThaiDuyet", TrangThaiDuyet);
                IList<ChiTietTiemResponse> danhSach = SqlMapper.Query<ChiTietTiemResponse>(connect, "SPChiTietTiem_DanhSach", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return danhSach;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IList<ChiTietTiemResponse> ChiTietTiemThongKe(Guid? IDVaccine, Guid? IDSinhVien, Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong, string TrieuChungSauTiem, string TrangThaiDuyet, int MuiTiemThu, string TuNgay, string DenNgay, string LoaiNhom)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDVaccine", IDVaccine);
                parameters.Add("@IDSinhVien", IDSinhVien);
                parameters.Add("@IDKhoaHoc", IDKhoaHoc);
                parameters.Add("@IDKhoa", IDKhoa);
                parameters.Add("@IDTruong", IDTruong);
                parameters.Add("@TrieuChungSauTiem", TrieuChungSauTiem);
                parameters.Add("@TrangThaiDuyet", TrangThaiDuyet);
                parameters.Add("@MuiTiemThu", MuiTiemThu);
                parameters.Add("@TuNgay", TuNgay);
                parameters.Add("@DenNgay", DenNgay);
                parameters.Add("@LoaiNhom", LoaiNhom);
                IList<ChiTietTiemResponse> danhSach = SqlMapper.Query<ChiTietTiemResponse>(connect, "SPChiTietTiem_ThongKe", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return danhSach;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Lấy mã 
        public ChiTietTiemResponse ChiTietTiemLayID(Guid IDChiTietTiem)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@IDChiTietTiem", IDChiTietTiem);
            ChiTietTiemResponse layChiTietTiem = SqlMapper.Query<ChiTietTiemResponse>(connect, "SPChiTietTiem_LayID", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return layChiTietTiem;
        }

        // Chỉnh sửa 
        public int ChiTietTiemChinhSua(ChiTietTiemRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDChiTietTiem", request.IDChiTietTiem);
                parameters.Add("@IDSinhVien", request.IDSinhVien);
                parameters.Add("@IDVaccine", request.IDVaccine);
                parameters.Add("@DiaChiTiem", request.DiaChiTiem);
                parameters.Add("@TrieuChungSauTiem", request.TrieuChungSauTiem);
                parameters.Add("@NgayGioTiem", request.NgayGioTiem);
                parameters.Add("@MuiTiemThu", request.MuiTiemThu);
                parameters.Add("@ChiTietTiemDinhKem", request.ChiTietTiemDinhKem);
                parameters.Add("@TrangThaiDuyet", request.TrangThaiDuyet);
                parameters.Add("@NguoiDuyet", request.NguoiDuyet);
                parameters.Add("@LyDo", request.LyDo);
                parameters.Add("@GhiChu", request.GhiChu);
                var id = SqlMapper.ExecuteScalar<int>(connect, "SPChiTietTiem_ChinhSua", param: parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Tạo mới 
        public int ChiTietTiemTaoMoi(ChiTietTiemRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDChiTietTiem", request.IDChiTietTiem);
                parameters.Add("@IDSinhVien", request.IDSinhVien);
                parameters.Add("@IDVaccine", request.IDVaccine);
                parameters.Add("@DiaChiTiem", request.DiaChiTiem);
                parameters.Add("@TrieuChungSauTiem", request.TrieuChungSauTiem);
                parameters.Add("@NgayGioTiem", request.NgayGioTiem);
                parameters.Add("@MuiTiemThu", request.MuiTiemThu);
                parameters.Add("@ChiTietTiemDinhKem", request.ChiTietTiemDinhKem);
                parameters.Add("@TrangThaiDuyet", request.TrangThaiDuyet);
                parameters.Add("@NguoiDuyet", request.NguoiDuyet);
                parameters.Add("@LyDo", request.LyDo);
                parameters.Add("@GhiChu", request.GhiChu);
                var id = SqlMapper.ExecuteScalar<int>(connect, "SPChiTietTiem_TaoMoi", param: parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int ChiTietTiemTaoMoi_Excel(ChiTietTiemRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
    
                parameters.Add("@MaSinhVien", request.MaSinhVien);
                parameters.Add("@TenVaccine", request.TenVaccine);
                parameters.Add("@DiaChiTiem", request.DiaChiTiem);
                parameters.Add("@TrieuChungSauTiem", request.TrieuChungSauTiem);
                parameters.Add("@NgayGioTiem", request.NgayGioTiem);
                parameters.Add("@MuiTiemThu", request.MuiTiemThu);
              
                var id = SqlMapper.ExecuteScalar<int>(connect, "SPChiTietTiem_TaoMoi_Excel", param: parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ChiTietTiemXoaBo(Guid IDChiTietTiem)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDChiTietTiem", IDChiTietTiem);
                var result = SqlMapper.ExecuteScalar<bool>(connect, "SPChiTietTiem_Xoa", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
