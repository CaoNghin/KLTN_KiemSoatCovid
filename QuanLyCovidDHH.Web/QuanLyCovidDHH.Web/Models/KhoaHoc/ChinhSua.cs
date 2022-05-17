using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyCovidDHH.Web.Models.KhoaHoc
{
    public class ChinhSua
    {
        public Guid IDKhoaHoc { get; set; }
        public Guid IDKhoa { get; set; }
        public int KhoaHoc { get; set; }
        public int NamTuyenSinh { get; set; }
        public string MaKhoaHoc { get; set; }

        //them de hien thi
        public Guid IDTruong { get; set; }
    }
}
