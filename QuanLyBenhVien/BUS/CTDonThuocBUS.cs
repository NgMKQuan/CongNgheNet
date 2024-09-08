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
    public class CTDonThuocBUS
    {
        KetNoi _db = new KetNoi();

        public List<CTDonThuocDTO> GetAll()
        {
            string sql = "SELECT MaDT, Thuoc.MaThuoc, Thuoc.TenThuoc, SoLuong FROM CTDonThuoc INNER JOIN Thuoc ON Thuoc.MaThuoc = CTDonThuoc.MaThuoc";
            DataTable tb = _db.DocDuLieu(sql);
            List<CTDonThuocDTO> ds = new List<CTDonThuocDTO>();

            foreach (DataRow item in tb.Rows)
            {
                ds.Add(CreateObj(item));
            }

            return ds;
        }

        public List<CTDonThuocDTO> GetBy(string madt)
        {
            string sql = $"SELECT MaDT, Thuoc.MaThuoc, Thuoc.TenThuoc, CTDonThuoc.SoLuong FROM CTDonThuoc INNER JOIN Thuoc ON Thuoc.MaThuoc = CTDonThuoc.MaThuoc WHERE CTDonThuoc.MaDT = N'{madt}'";
            DataTable tb = _db.DocDuLieu(sql);
            List<CTDonThuocDTO> ds = new List<CTDonThuocDTO>();

            foreach (DataRow item in tb.Rows)
            {
                ds.Add(CreateObj(item));
            }

            return ds;
        }


        private CTDonThuocDTO CreateObj(DataRow item)
        {
            CTDonThuocDTO obj = new CTDonThuocDTO();
            obj.MaDT = item.Field<string>("MaDT");
            obj.MaThuoc = item.Field<string>("MaThuoc");
            obj.TenThuoc = item.Field<string>("TenThuoc");
            obj.SoLuong = item.Field<int>("SoLuong");
            return obj;
        }

        public bool Them(CTDonThuocDTO obj)
        {
            string sql = $"INSERT INTO CTDonThuoc(MaDT, MaThuoc, SoLuong) VALUES(N'{obj.MaDT}', N'{obj.MaThuoc}', {obj.SoLuong})";
            return _db.ThucThiLenh(sql);
        }

        public bool Xoa(string madt, string mathuoc)
        {
            string sql = $"DELETE FROM CTDonThuoc WHERE MaDT LIKE N'{madt}' AND MaThuoc LIKE N'{mathuoc}'";
            return _db.ThucThiLenh(sql);
        }

        public bool Xoa(string madt)
        {
            string sql = $"DELETE FROM CTDonThuoc WHERE MaDT LIKE N'{madt}'";
            return _db.ThucThiLenh(sql);
        }

        public bool Sua(CTDonThuocDTO obj)
        {
            string sql = $"UPDATE CTDonThuoc SET MaDT = N'{obj.MaDT}', MaThuoc = N'{obj.MaThuoc}', SoLuong = {obj.SoLuong} WHERE MaDT = N'{obj.MaDT}' AND MaThuoc = N'{obj.MaThuoc}'";
            return _db.ThucThiLenh(sql);
        }

        public bool TonTai(string madt, string mathuoc)
        {
            string sql = $"SELECT MADT, MaThuoc FROM CTDonThuoc WHERE MaDT LIKE N'{madt}' AND MaThuoc LIKE N'{mathuoc}'";
            return _db.KiemTraTonTai(sql);
        }

    }
}
