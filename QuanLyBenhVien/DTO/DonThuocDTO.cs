using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBenhVien.DTO
{
    public class DonThuocDTO
    {
        public string MaDT { get; set; }
        public string MaBS { get; set; }
        public string MaBN { get; set; }
        public string SoPhong { get; set; }
        public string TenBS { get; internal set; }
        public string TenBN { get; internal set; }
        public DateTime NgayLap { get;set;}
    }

}
