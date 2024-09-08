using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBenhVien.DTO
{
    public class CTDonThuocDTO
    {
        public string MaDT { get; set; }
        public string MaThuoc { get; set; }
        public int SoLuong { get; set; }
        public string TenThuoc { get; internal set; }
    }

}
