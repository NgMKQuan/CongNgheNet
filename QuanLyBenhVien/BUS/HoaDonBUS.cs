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
    public class HoaDonBUS
    {
        KetNoi _db = new KetNoi();

        public List<HoaDonDTO> GetAll()
        {
            string sql = "SELECT MaHD, HoaDon.MaBN, BenhNhan.TenBN, MaDT, NgayLap, TongTien FROM HoaDon\r\nINNER JOIN BenhNhan ON BenhNhan.MaBN = HoaDon.MaBN\r\n";
            DataTable tb = _db.DocDuLieu(sql);
            List<HoaDonDTO> ds = new List<HoaDonDTO>();

            foreach (DataRow item in tb.Rows)
            {
                ds.Add(CreateObj(item));
            }

            return ds;
        }

        private HoaDonDTO CreateObj(DataRow item)
        {
            HoaDonDTO obj = new HoaDonDTO();
            obj.MaHD = item.Field<string>("MaHD");
            obj.MaBN = item.Field<string>("MaBN");
            obj.TenBN = item.Field<string>("TenBN");
            obj.MaDT = item.Field<string>("MaDT");
            obj.NgayLap = item.Field<DateTime>("NgayLap");
            obj.TongTien = item.Field<decimal>("TongTien");
            return obj;
        }

        public bool Them(HoaDonDTO obj)
        {
            string sql = $"INSERT INTO HoaDon(MaHD, MaBN, MaDT, NgayLap, TongTien) VALUES(N'{obj.MaHD}', N'{obj.MaBN}', N'{obj.MaDT}', '{obj.NgayLap.ToString("yyyy/MM/dd")}', {obj.TongTien})";
            return _db.ThucThiLenh(sql);
        }

        public bool Xoa(string id)
        {
            string sql = $"DELETE FROM HoaDon WHERE MaHD LIKE N'{id}'";
            return _db.ThucThiLenh(sql);
        }

        public bool Sua(HoaDonDTO obj)
        {
            string sql = $"UPDATE HoaDon SET MaHD = N'{obj.MaHD}', MaBN = N'{obj.MaBN}', MaDT = N'{obj.MaDT}', NgayLap = '{obj.NgayLap.ToString("yyyy/MM/dd")}', TongTien = {obj.TongTien} WHERE MaHD = N'{obj.MaHD}'";
            return _db.ThucThiLenh(sql);
        }

        public bool TonTai(string mahd)
        {
            string sql = $"SELECT MaHD FROM HoaDon WHERE MaHD LIKE N'{mahd}'";
            return _db.KiemTraTonTai(sql);
        }
    }

}
