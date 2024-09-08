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
    public class NguoiDungBUS
    {
        KetNoi _db = new KetNoi();

        public List<NguoiDungDTO> GetAll()
        {
            string sql = "SELECT MaND, MatKhau, Quyen FROM NguoiDung";
            DataTable tb = _db.DocDuLieu(sql);
            List<NguoiDungDTO> ds = new List<NguoiDungDTO>();

            foreach (DataRow item in tb.Rows)
            {
                ds.Add(CreateObj(item));
            }

            return ds;
        }

        private NguoiDungDTO CreateObj(DataRow item)
        {
            NguoiDungDTO obj = new NguoiDungDTO();
            obj.MaND = item.Field<string>("MaND");
            obj.MatKhau = item.Field<string>("MatKhau");
            obj.Quyen = item.Field<string>("Quyen");
            return obj;
        }

        public bool Them(NguoiDungDTO obj)
        {
            string sql = $"INSERT INTO NguoiDung(MaND, MatKhau, Quyen) VALUES(N'{obj.MaND}', N'{obj.MatKhau}', N'{obj.Quyen}')";
            return _db.ThucThiLenh(sql);
        }

        public bool Xoa(string id)
        {
            string sql = $"DELETE FROM NguoiDung WHERE MaND LIKE N'{id}'";
            return _db.ThucThiLenh(sql);
        }

        public bool Sua(NguoiDungDTO obj)
        {
            string sql = $"UPDATE NguoiDung SET MaND = N'{obj.MaND}', MatKhau = N'{obj.MatKhau}', Quyen = N'{obj.Quyen}' WHERE MaND = N'{obj.MaND}'";
            return _db.ThucThiLenh(sql);
        }

        public bool TonTai(string mand)
        {
            string sql = $"SELECT MaND FROM NguoiDung WHERE MaND LIKE N'{mand}'";
            return _db.KiemTraTonTai(sql);
        }

        public NguoiDungDTO DangNhap(string user, string pass)
        {
            return GetAll().FirstOrDefault(x => x.MaND == user && x.MatKhau == pass);
        }
    }

}
