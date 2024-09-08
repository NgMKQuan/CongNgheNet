using QuanLyBenhVien.DAL;
using QuanLyBenhVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBenhVien.BUS
{
    public class BenhNhanBUS
    {
        KetNoi _db = new KetNoi();

        public List<BenhNhanDTO> GetAll()
        {
            string sql = "SELECT MaBN, TenBN, GioiTinh, NgaySinh, DiaChi, SDT, TinhTrangSK, NgayNhapVien, NgayXuatVien FROM BenhNhan";
            DataTable tb = _db.DocDuLieu(sql);
            List<BenhNhanDTO> ds = new List<BenhNhanDTO>();

            foreach (DataRow item in tb.Rows)
            {
                ds.Add(CreateObj(item));
            }

            return ds;
        }

        private BenhNhanDTO CreateObj(DataRow item)
        {
            BenhNhanDTO obj = new BenhNhanDTO();
            obj.MaBN = item.Field<string>("MaBN");
            obj.TenBN = item.Field<string>("TenBN");
            obj.GioiTinh = item.Field<bool>("GioiTinh");
            obj.NgaySinh = item.Field<DateTime>("NgaySinh");
            obj.DiaChi = item.Field<string>("DiaChi");
            obj.SDT = item.Field<string>("SDT");
            obj.TinhTrangSK = item.Field<string>("TinhTrangSK");
            obj.NgayNhapVien = item.Field<DateTime>("NgayNhapVien");
            obj.NgayXuatVien = item.Field<DateTime>("NgayXuatVien");
            return obj;
        }

        public bool Them(BenhNhanDTO obj)
        {
            int gt = obj.GioiTinh ? 1 : 0;

            string sql = $"INSERT INTO BenhNhan(MaBN, TenBN, GioiTinh, NgaySinh, DiaChi, SDT, TinhTrangSK, NgayNhapVien, NgayXuatVien) VALUES(N'{obj.MaBN}', N'{obj.TenBN}', {gt}, '{obj.NgaySinh.ToString("yyyy/MM/dd")}', N'{obj.DiaChi}', N'{obj.SDT}', N'{obj.TinhTrangSK}', N'{obj.NgayNhapVien.ToString("yyyy/MM/dd")}', N'{obj.NgayXuatVien.ToString("yyyy/MM/dd")}')";
            return _db.ThucThiLenh(sql);
        }

        public bool Xoa(string id)
        {
            string sql = $"DELETE FROM BenhNhan WHERE MaBN LIKE N'{id}'";
            return _db.ThucThiLenh(sql);
        }

        public bool Sua(BenhNhanDTO obj)
        {
            int gt = obj.GioiTinh ? 1 : 0;

            string sql = $"UPDATE BenNhan SET MaBN = N'{obj.MaBN}', TenBN = N'{obj.TenBN}', GioiTinh = {gt}, NgaySinh = '{obj.NgaySinh.ToString("yyyy/MM/dd")}', DiaChi = N'{obj.DiaChi}', SDT = N'{obj.SDT}', TinhTrangSK = N'{obj.TinhTrangSK}', NgayNhapVien = '{obj.NgayNhapVien.ToString("yyyy/MM/dd")}', NgayXuatVien = '{obj.NgayXuatVien.ToString("yyyy/MM/dd")}' WHERE MaBN = N'{obj.MaBN}'";
            return _db.ThucThiLenh(sql);
        }

        public bool TonTai(string mabn)
        {
            string sql = $"SELECT MaBN FROM BenhNhan WHERE MABN = N'{mabn}'";
            return _db.KiemTraTonTai(sql);
        }
    }

}
