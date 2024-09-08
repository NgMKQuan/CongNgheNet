using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBenhVien.DTO
{
    public class HoaDonDTO
    {
        public string MaHD { get; set; }
        public string MaBN { get; set; }
        public string MaDT { get; set; }
        public DateTime NgayLap { get; set; }
        public decimal TongTien { get; set; }
        public string TenBN { get; internal set; }
    }

}
