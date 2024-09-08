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
    public class BacSiBUS
    {
        KetNoi _db = new KetNoi();

        public List<BacSiDTO> GetAll()
        {
            string sql = "SELECT MaBS, TenBS, ChuyenKhoa, NgayVaoLam FROM BacSi";
            DataTable tb = _db.DocDuLieu(sql);
            List<BacSiDTO> ds = new List<BacSiDTO>();

            foreach (DataRow item in tb.Rows)
            {
                ds.Add(CreateObj(item));
            }

            return ds;
        }

        private BacSiDTO CreateObj(DataRow item)
        {
            BacSiDTO obj = new BacSiDTO();
            obj.MaBS = item.Field<string>("MaBS");
            obj.TenBS = item.Field<string>("TenBS");
            obj.ChuyenKhoa = item.Field<string>("ChuyenKhoa");
            obj.NgayVaoLam = item.Field<DateTime>("NgayVaoLam");
            return obj;
        }

        public bool Them(BacSiDTO obj)
        {
            string sql = $"INSERT INTO BacSi(MaBS, TenBS, ChuyenKhoa, NgayVaoLam) VALUES(N'{obj.MaBS}', N'{obj.TenBS}', N'{obj.ChuyenKhoa}', '{obj.NgayVaoLam.ToString("yyyy/MM/dd")}')";
            return _db.ThucThiLenh(sql);
        }

        public bool Xoa(string id)
        {
            string sql = $"DELETE FROM BacSi WHERE MaBS LIKE N'{id}'";
            return _db.ThucThiLenh(sql);
        }

        public bool Sua(BacSiDTO obj)
        {
            string sql = $"UPDATE BacSi SET MaBS = N'{obj.MaBS}', TenBS = N'{obj.TenBS}', ChuyenKhoa = N'{obj.ChuyenKhoa}', NgayVaoLam = '{obj.NgayVaoLam.ToString("yyyy/MM/dd")}' WHERE MaBS = N'{obj.MaBS}'";
            return _db.ThucThiLenh(sql);
        }

        public bool TonTai(string mabs)
        {
            string sql = $"SELECT MaBS FROM BacSi WHERE MABS = N'{mabs}'";
            return _db.KiemTraTonTai(sql);
        }
    }
}
