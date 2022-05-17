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
    public class BenhAnRepository : DataBaseRepository, IBenhAnRepository
    {
        // Danh sách 
        public IList<BenhAnResponse> BenhAnDanhSach(Guid? IDSinhVien, Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong, string TuNgay, string DenNgay, string TrangThaiDieuTri, string TrangThaiDuyet)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDSinhVien", IDSinhVien);
                parameters.Add("@IDKhoaHoc", IDKhoaHoc);
                parameters.Add("@IDKhoa", IDKhoa);
                parameters.Add("@IDTruong", IDTruong);
                parameters.Add("@TuNgay", TuNgay);
                parameters.Add("@DenNgay", DenNgay);
                parameters.Add("@TrangThaiDieuTri", TrangThaiDieuTri);
                parameters.Add("@TrangThaiDuyet", TrangThaiDuyet);
                IList<BenhAnResponse> danhSach = SqlMapper.Query<BenhAnResponse>(connect, "SPBenhAn_DanhSach", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return danhSach;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Lấy mã       
        public IList<BenhAnResponse> BenhAnThongKe(Guid? IDSinhVien, Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong, string NoiDieuTri, string TrangThaiDuyet, int SoLuongBenhNen, string TuNgay, string DenNgay, string LoaiNhom)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDSinhVien", IDSinhVien);
                parameters.Add("@IDKhoaHoc", IDKhoaHoc);
                parameters.Add("@IDKhoa", IDKhoa);
                parameters.Add("@IDTruong", IDTruong);
                parameters.Add("@NoiDieuTri", NoiDieuTri);
                parameters.Add("@TrangThaiDuyet", TrangThaiDuyet);
                parameters.Add("@SoLuongBenhNen", SoLuongBenhNen);
                parameters.Add("@TuNgay", TuNgay);
                parameters.Add("@DenNgay", DenNgay);
          

                parameters.Add("@LoaiNhom", LoaiNhom);
                IList<BenhAnResponse> danhSach = SqlMapper.Query<BenhAnResponse>(connect, "SPBenhAn_ThongKe", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return danhSach;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public BenhAnResponse BenhAnLayID(Guid IDBenhAn)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@IDBenhAn", IDBenhAn);
            BenhAnResponse layBenhAn = SqlMapper.Query<BenhAnResponse>(connect, "SPBenhAn_LayID", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return layBenhAn;
        }

        // Chỉnh sửa 
        public int BenhAnChinhSua(BenhAnRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDBenhAn", request.IDBenhAn);
                parameters.Add("@IDSinhVien", request.IDSinhVien);
                parameters.Add("@NgayBatDauDieuTri", request.NgayBatDauDieuTri);
                parameters.Add("@NoiDieuTri", request.NoiDieuTri);
                parameters.Add("@BienThe", request.BienThe);
                parameters.Add("@KhoiBenh", request.KhoiBenh);
                parameters.Add("@TuVong", request.TuVong);
                parameters.Add("@NgayKetThucDieuTri", request.NgayKetThucDieuTri);
                parameters.Add("@BenhAnDinhKem", request.BenhAnDinhKem);
                parameters.Add("@TrangThaiDuyet", request.TrangThaiDuyet);
                parameters.Add("@NguoiDuyet", request.NguoiDuyet);
                parameters.Add("@LyDo", request.LyDo);
                parameters.Add("@GhiChu", request.GhiChu);
                var id = SqlMapper.ExecuteScalar<int>(connect, "SPBenhAn_ChinhSua", param: parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Tạo mới 
        public int BenhAnTaoMoi(BenhAnRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
            
                parameters.Add("@IDSinhVien", request.IDSinhVien);
                parameters.Add("@NgayBatDauDieuTri", request.NgayBatDauDieuTri);
                parameters.Add("@NoiDieuTri", request.NoiDieuTri);
                parameters.Add("@BienThe", request.BienThe);
                parameters.Add("@KhoiBenh", request.KhoiBenh);
                parameters.Add("@TuVong", request.TuVong);
                parameters.Add("@NgayKetThucDieuTri", request.NgayKetThucDieuTri);
                parameters.Add("@BenhAnDinhKem", request.BenhAnDinhKem);
                parameters.Add("@TrangThaiDuyet", request.TrangThaiDuyet);
                parameters.Add("@NguoiDuyet", request.NguoiDuyet);
                parameters.Add("@LyDo", request.LyDo);
                parameters.Add("@GhiChu", request.GhiChu);
                var id = SqlMapper.ExecuteScalar<int>(connect, "SPBenhAn_TaoMoi", param: parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int BenhAnTaoMoi_Excel(BenhAnRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();

                parameters.Add("@MaSinhVien", request.MaSinhVien);
                parameters.Add("@NgayKetThucDieuTri", request.NgayKetThuc);
                parameters.Add("@NgayBatDauDieuTri", request.NgayBatDauDieuTri);
                parameters.Add("@NoiDieuTri", request.NoiDieuTri);
                parameters.Add("@BienThe", request.BienThe);
                parameters.Add("@KhoiBenh", request.KhoiBenh);
                parameters.Add("@TuVong", request.TuVong);


                parameters.Add("@GhiChu", request.GhiChu);/// mã bênh án
                var id = SqlMapper.ExecuteScalar<int>(connect, "SPBenhAn_TaoMoi_Excel", param: parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool BenhAnXoaBo(Guid IDBenhAn)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDBenhAn", IDBenhAn);
                var result = SqlMapper.ExecuteScalar<bool>(connect, "SPBenhAn_Xoa", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
