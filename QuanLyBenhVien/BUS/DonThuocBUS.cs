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
    public class DonThuocBUS
    {
        KetNoi _db = new KetNoi();

        public List<DonThuocDTO> GetAll()
        {
            string sql = "SELECT MaDT, BacSi.MaBS, BacSi.TenBS, BenhNhan.MaBN, BenhNhan.TenBN, SoPhong, NgayLap FROM DonThuoc\r\nINNER JOIN BacSi ON BacSi.MaBS = DonThuoc.MaBS\r\nINNER JOIN BenhNhan ON BenhNhan.MaBN = DonThuoc.MaBN";
            DataTable tb = _db.DocDuLieu(sql);
            List<DonThuocDTO> ds = new List<DonThuocDTO>();

            foreach (DataRow item in tb.Rows)
            {
                ds.Add(CreateObj(item));
            }

            return ds;
        }

        private DonThuocDTO CreateObj(DataRow item)
        {
            DonThuocDTO obj = new DonThuocDTO();
            obj.MaDT = item.Field<string>("MaDT");
            obj.MaBS = item.Field<string>("MaBS");
            obj.TenBS = item.Field<string>("TenBS");
            obj.MaBN = item.Field<string>("MaBN");
            obj.TenBN = item.Field<string>("TenBN");
            obj.SoPhong = item.Field<string>("SoPhong");
            obj.NgayLap = item.Field<DateTime>("NgayLap");
            return obj;
        }

        public bool Them(DonThuocDTO obj)
        {
            string sql = $"INSERT INTO DonThuoc(MaDT, MaBS, MaBN, SoPhong, NgayLap) VALUES(N'{obj.MaDT}', N'{obj.MaBS}', N'{obj.MaBN}', N'{obj.SoPhong}', '{obj.NgayLap.ToString("yyyy/MM/dd")}')";
            return _db.ThucThiLenh(sql);
        }

        public bool Xoa(string id)
        {
            string sql = $"DELETE FROM DonThuoc WHERE MaDT LIKE N'{id}'";
            return _db.ThucThiLenh(sql);
        }

        public bool Sua(DonThuocDTO obj)
        {
            string sql = $"UPDATE DonThuoc SET MaDT = N'{obj.MaDT}', MaBS = N'{obj.MaBS}', MaBN = N'{obj.MaBN}', SoPhong = N'{obj.SoPhong}', NgayLap = '{obj.NgayLap.ToString("yyyy/MM/dd")}' WHERE MaDT = N'{obj.MaDT}'";
            return _db.ThucThiLenh(sql);
        }

        public bool TonTai(string madt)
        {
            string sql = $"SELECT MADT FROM DonThuoc WHERE MaDT LIKE N'{madt}'";
            return _db.KiemTraTonTai(sql);
        }

        public DonThuocDTO Single(string madt)
        {
            string sql = $"SELECT MaDT, BacSi.MaBS, BacSi.TenBS, BenhNhan.MaBN, BenhNhan.TenBN, SoPhong, NgayLap FROM DonThuoc\r\nINNER JOIN BacSi ON BacSi.MaBS = DonThuoc.MaBS\r\nINNER JOIN BenhNhan ON BenhNhan.MaBN = DonThuoc.MaBN WHERE DonThuoc.MaDT LIKE N'{madt}'";
            DataTable tb = _db.DocDuLieu(sql);
            if (tb.Rows.Count > 0) {
                return CreateObj(tb.Rows[0]);
            }

            return null;
        }

        public bool DonThuocCoHoaDon(string madt)
        {
            string sql = $"SELECT MADT FROM HoaDon WHERE MaDT = N'{madt}'";
            return _db.KiemTraTonTai(sql);
        }
    }

}
