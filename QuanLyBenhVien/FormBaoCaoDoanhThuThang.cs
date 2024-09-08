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
    public partial class FormBaoCaoDoanhThuThang : Form
    {
        public FormBaoCaoDoanhThuThang()
        {
            InitializeComponent();
        }

        KetNoi _db = new KetNoi();
        BindingSource _src = new BindingSource();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = $"SELECT CAST(NgayLap AS DATE) AS NgayLap, COUNT(MaHD) AS SLHoaDon, SUM(TongTien) AS TongTien\r\nFROM HoaDon WHERE NgayLap >= '{dtTuNgay.Value.Date.ToString("yyyy/MM/dd")}' AND NgayLap <= '{dtDenNgay.Value.Date.ToString("yyyy/MM/dd")}' GROUP BY CAST(NgayLap AS DATE)";
            
            DataTable tb = _db.DocDuLieu(sql);

            decimal tongDoanhThu = 0;

            foreach(DataRow r in tb.Rows)
            {
                tongDoanhThu += (r.Field<decimal?>("TongTien") ?? 0);
            }
            lblTongDoanhThu.Text = tongDoanhThu.ToString("0");
            _src.DataSource = tb;
            _src.ResetBindings(true);
        }

        private void FormBaoCaoDoanhThuThang_Load(object sender, EventArgs e)
        {
            gridData.DataSource = _src;
            gridData.ReadOnly = true;
            gridData.AllowUserToAddRows = false;
            dtTuNgay.Value = new DateTime(2023,01,01);
            dtDenNgay.Value = DateTime.Now;
        }
    }
}
