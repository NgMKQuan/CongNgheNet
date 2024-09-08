using QuanLyBenhVien.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhVien
{
    public partial class FormThongKeDonThuoc : Form
    {
        public FormThongKeDonThuoc()
        {
            InitializeComponent();
        }

        KetNoi _db = new KetNoi();
        BindingSource _src = new BindingSource();

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = $"SELECT DonThuoc.MaDT, NgayLap, DonThuoc.MaBN, BenhNhan.TenBN, DonThuoc.MaBS, BacSi.TenBS FROM DonThuoc\r\nINNER JOIN BenhNhan ON BenhNhan.MaBN = DonThuoc.MaBN\r\nINNER JOIN BacSi ON BacSi.MaBS = DonThuoc.MaBS WHERE DonThuoc.NgayLap >= '{dtTuNgay.Value.Date.ToString("yyyy/MM/dd")}' AND DonThuoc.NgayLap <= '{dtDenNgay.Value.Date.ToString("yyyy/MM/dd")}'";
            DataTable tb = _db.DocDuLieu(sql);
            _src.DataSource = tb;
            _src.ResetBindings(true);
        }

        private void FormThongKeDonThuoc_Load(object sender, EventArgs e)
        {
            dtTuNgay.Value = new DateTime(2023,01,01);
            dtDenNgay.Value = DateTime.Now;
            gridData.DataSource = _src;
            gridData.AllowUserToAddRows = false;
            gridData.ReadOnly = true;
        }
    }
}
