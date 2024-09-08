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
    public class ThuocBUS
    {
        KetNoi _db = new KetNoi();

        public List<ThuocDTO> GetAll()
        {
            string sql = "SELECT MaThuoc, TenThuoc, SoLuong, GiaThuoc FROM Thuoc";
            DataTable tb = _db.DocDuLieu(sql);
            List<ThuocDTO> ds = new List<ThuocDTO>();

            foreach (DataRow item in tb.Rows)
            {
                ds.Add(CreateObj(item));
            }

            return ds;
        }

        private ThuocDTO CreateObj(DataRow item)
        {
            ThuocDTO obj = new ThuocDTO();
            obj.MaThuoc = item.Field<string>("MaThuoc");
            obj.TenThuoc = item.Field<string>("TenThuoc");
            obj.SoLuong = item.Field<int>("SoLuong");
            obj.GiaThuoc = item.Field<decimal>("GiaThuoc");
            return obj;
        }

        public bool Them(ThuocDTO obj)
        {
            string sql = $"INSERT INTO Thuoc(MaThuoc, TenThuoc, SoLuong, GiaThuoc) VALUES(N'{obj.MaThuoc}', N'{obj.TenThuoc}', {obj.SoLuong}, {obj.GiaThuoc})";
            return _db.ThucThiLenh(sql);
        }

        public bool Xoa(string id)
        {
            string sql = $"DELETE FROM Thuoc WHERE MaThuoc LIKE N'{id}'";
            return _db.ThucThiLenh(sql);
        }

        public bool Sua(ThuocDTO obj)
        {
            string sql = $"UPDATE Thuoc SET MaThuoc = N'{obj.MaThuoc}', TenThuoc = N'{obj.TenThuoc}', SoLuong = {obj.SoLuong}, GiaThuoc = {obj.GiaThuoc} WHERE MaThuoc = N'{obj.MaThuoc}'";
            return _db.ThucThiLenh(sql);
        }

        public bool TonTai(string maThuoc)
        {
            string sql = $"SELECT MATHUOC FROM THUOC WHERE MaThuoc LIKE N'{maThuoc}'";
            return _db.KiemTraTonTai(sql);
        }
    }

}
