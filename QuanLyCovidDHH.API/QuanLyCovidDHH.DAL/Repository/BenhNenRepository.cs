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
    public class BenhNenRepository : DataBaseRepository, IBenhNenRepository
    {
        // Danh sách 
        public IList<BenhNenResponse> BenhNenDanhSach(Guid? IDBenhAn, Guid? IDSinhVien, Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDBenhAn", IDBenhAn);
                parameters.Add("@IDSinhVien", IDSinhVien);
                parameters.Add("@IDKhoaHoc", IDKhoaHoc);
                parameters.Add("@IDKhoa", IDKhoa);
                parameters.Add("@IDTruong", IDTruong);
                IList<BenhNenResponse> danhSach = SqlMapper.Query<BenhNenResponse>(connect, "SPBenhNen_DanhSach", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return danhSach;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Lấy mã 
        public BenhNenResponse BenhNenLayID(Guid IDBenhNen)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@IDBenhNen", IDBenhNen);
            BenhNenResponse layBenhNen = SqlMapper.Query<BenhNenResponse>(connect, "SPBenhNen_LayID", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return layBenhNen;
        }

        // Chỉnh sửa 
        public int BenhNenChinhSua(BenhNenRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDBenhNen", request.IDBenhNen);
                parameters.Add("@IDBenhAn", request.IDBenhAn);
                parameters.Add("@TieuDuong", request.TieuDuong);
                parameters.Add("@BenhPhoi", request.BenhPhoi);
                parameters.Add("@UngThu", request.UngThu);
                parameters.Add("@BenhThanManTinh", request.BenhThanManTinh);
                parameters.Add("@GhepTang", request.GhepTang);
                parameters.Add("@BeoPhi", request.BeoPhi);
                parameters.Add("@TimMach", request.TimMach);
                parameters.Add("@MachMauNao", request.MachMauNao);
                parameters.Add("@HoiChungDown", request.HoiChungDown);
                parameters.Add("@HIV_AIDS", request.HIV_AIDS);
                parameters.Add("@ThanKinh", request.ThanKinh);
                parameters.Add("@HongCau", request.HongCau);
                parameters.Add("@HenPheQuan", request.HenPheQuan);
                parameters.Add("@TangHuyetAp", request.TangHuyetAp);
                parameters.Add("@ThieuHutMienDich", request.ThieuHutMienDich);
                parameters.Add("@BenhGan", request.BenhGan);
                parameters.Add("@RoiLoanDoSuDungChatGayNghien", request.RoiLoanDoSuDungChatGayNghien);
                var id = SqlMapper.ExecuteScalar<int>(connect, "SPBenhNen_ChinhSua", param: parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Tạo mới 
        public int BenhNenTaoMoi(BenhNenRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDBenhNen", request.IDBenhNen);
                parameters.Add("@IDBenhAn", request.IDBenhAn);
                parameters.Add("@TieuDuong", request.TieuDuong);
                parameters.Add("@BenhPhoi", request.BenhPhoi);
                parameters.Add("@UngThu", request.UngThu);
                parameters.Add("@BenhThanManTinh", request.BenhThanManTinh);
                parameters.Add("@GhepTang", request.GhepTang);
                parameters.Add("@BeoPhi", request.BeoPhi);
                parameters.Add("@TimMach", request.TimMach);
                parameters.Add("@MachMauNao", request.MachMauNao);
                parameters.Add("@HoiChungDown", request.HoiChungDown);
                parameters.Add("@HIV_AIDS", request.HIV_AIDS);
                parameters.Add("@ThanKinh", request.ThanKinh);
                parameters.Add("@HongCau", request.HongCau);
                parameters.Add("@HenPheQuan", request.HenPheQuan);
                parameters.Add("@TangHuyetAp", request.TangHuyetAp);
                parameters.Add("@ThieuHutMienDich", request.ThieuHutMienDich);
                parameters.Add("@BenhGan", request.BenhGan);
                parameters.Add("@RoiLoanDoSuDungChatGayNghien", request.RoiLoanDoSuDungChatGayNghien);
                var id = SqlMapper.ExecuteScalar<int>(connect, "SPBenhNen_TaoMoi", param: parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool BenhNenXoaBo(Guid IDBenhNen)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDBenhNen", IDBenhNen);
                var result = SqlMapper.ExecuteScalar<bool>(connect, "SPBenhNen_Xoa", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
