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
    public class PhongBenhBUS
    {
        KetNoi _db = new KetNoi();

        public List<PhongBenhDTO> GetAll()
        {
            string sql = "SELECT SoPhong, SoGiuong, SoGiuongTrong FROM PhongBenh";
            DataTable tb = _db.DocDuLieu(sql);
            List<PhongBenhDTO> ds = new List<PhongBenhDTO>();

            foreach (DataRow item in tb.Rows)
            {
                ds.Add(CreateObj(item));
            }

            return ds;
        }

        private PhongBenhDTO CreateObj(DataRow item)
        {
            PhongBenhDTO obj = new PhongBenhDTO();
            obj.SoPhong = item.Field<string>("SoPhong");
            obj.SoGiuong = item.Field<int>("SoGiuong");
            obj.SoGiuongTrong = item.Field<int>("SoGiuongTrong");
            return obj;
        }

        public bool Them(PhongBenhDTO obj)
        {
            string sql = $"INSERT INTO PhongBenh(SoPhong, SoGiuong, SoGiuongTrong) VALUES(N'{obj.SoPhong}', {obj.SoGiuong}, {obj.SoGiuongTrong})";
            return _db.ThucThiLenh(sql);
        }

        public bool Xoa(string id)
        {
            string sql = $"DELETE FROM PhongBenh WHERE SoPhong LIKE N'{id}'";
            return _db.ThucThiLenh(sql);
        }

        public bool Sua(PhongBenhDTO obj)
        {
            string sql = $"UPDATE PhongBenh SET SoPhong = N'{obj.SoPhong}', SoGiuong = {obj.SoGiuong}, SoGiuongTrong = {obj.SoGiuongTrong} WHERE SoPhong = N'{obj.SoPhong}'";
            return _db.ThucThiLenh(sql);
        }

        public bool TonTai(string soPhong)
        {
            string sql = $"SELECT SOPHONG FROM PhongBenh WHERE SOPHONG LIKE N'{soPhong}'";
            return _db.KiemTraTonTai(sql);
        }
    }

}
