using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBenhVien.DTO
{
    public class BenhNhanDTO
    {
        public string MaBN { get; set; }
        public string TenBN { get; set; }
        public bool GioiTinh { get; set; }
        public string GioiTinhStr { get { 
                    return GioiTinh ? "Nam" : "Nữ";
                }
        }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string TinhTrangSK { get; set; }
        public DateTime NgayNhapVien { get; set; }
        public DateTime NgayXuatVien { get; set; }
    }

}
