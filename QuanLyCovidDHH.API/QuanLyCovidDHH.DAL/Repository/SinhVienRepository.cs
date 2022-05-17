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
    public class SinhVienRepository : DataBaseRepository, ISinhVienRepository
    {
        public List<SinhVienResponse> SinhVienDanhSach(Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong, string TuKhoa)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDKhoaHoc", IDKhoaHoc);
                parameters.Add("@IDKhoa", IDKhoa);
                parameters.Add("@IDTruong", IDTruong);
                parameters.Add("@TuKhoa", TuKhoa);

                List<SinhVienResponse> danhsach = SqlMapper.Query<SinhVienResponse>(connect, "SPSinhVien_DanhSach", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return danhsach;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<SinhVienResponse> SinhVienThongKe(Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong, string DaMacCovid, int TongMuiTiem, string LoaiNhom)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDKhoaHoc", IDKhoaHoc);
                parameters.Add("@IDKhoa", IDKhoa);
                parameters.Add("@IDTruong", IDTruong);
                parameters.Add("@DaMacCovid", DaMacCovid);
                parameters.Add("@TongMuiTiem", TongMuiTiem);
                parameters.Add("@LoaiNhom", LoaiNhom);
                List<SinhVienResponse> danhsach = SqlMapper.Query<SinhVienResponse>(connect, "SPSinhVien_ThongKe", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return danhsach;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public SinhVienResponse SinhVienLayID(Guid IDSinhVien)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@IDSinhVien", IDSinhVien);
            SinhVienResponse getID = SqlMapper.Query<SinhVienResponse>(connect, "SPSinhVien_LayID", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return getID;
        }
        public SinhVienResponse SinhVienLayTenDangNhap(string TenDangNhap)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@TenDangNhap", TenDangNhap);
            SinhVienResponse getID = SqlMapper.Query<SinhVienResponse>(connect, "SPSinhVien_LayTenDangNhap", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return getID;
        }


        public int SinhVienChinhSua(SinhVienRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDSinhVien", request.IDSinhVien);
                parameters.Add("@IDKhoaHoc", request.IDKhoaHoc);
                parameters.Add("@SoCMND_CCCD", request.SoCMND_CCCD);
                parameters.Add("@HoTen", request.HoTen);
                parameters.Add("@DiaChi", request.DiaChi);
                parameters.Add("@SDT", request.SDT);
                parameters.Add("@Email", request.Email);
             
                parameters.Add("@MatKhau", request.MatKhau);
          


                var id = SqlMapper.ExecuteScalar<int>(connect, "SPSinhVien_ChinhSua", param: parameters, commandType: CommandType.StoredProcedure);
                return id;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int SinhVienTaoMoi(SinhVienRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                //parameters.Add("@IDSinhVien", request.IDSinhVien);
                parameters.Add("@IDKhoaHoc", request.IDKhoaHoc);
                parameters.Add("@SoCMND_CCCD", request.SoCMND_CCCD);
                parameters.Add("@HoTen", request.HoTen);
                parameters.Add("@DiaChi", request.DiaChi);
                parameters.Add("@SDT", request.SDT);
                parameters.Add("@Email", request.Email);
             

                var id = SqlMapper.ExecuteScalar<int>(connect, "SPSinhVien_TaoMoi", param: parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int SinhVienTaoMoi_Excel(SinhVienRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@MaTruong", request.MaTruong);
                parameters.Add("@MaKhoa", request.MaKhoa);
                parameters.Add("@MaKhoaHoc ", request.MaKhoaHoc);

                parameters.Add("@SoCMND_CCCD", request.SoCMND_CCCD);
                parameters.Add("@HoTen", request.HoTen);
                parameters.Add("@DiaChi", request.DiaChi);
                parameters.Add("@SDT", request.SDT);
                parameters.Add("@Email", request.Email);


                var id = SqlMapper.ExecuteScalar<int>(connect, "SPSinhVien_TaoMoi_Excel", param: parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool SinhVienXoaBo(Guid ID)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDSinhVien", ID);
                bool result = SqlMapper.ExecuteScalar<bool>(connect, "SPSinhVien_Xoa", parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
