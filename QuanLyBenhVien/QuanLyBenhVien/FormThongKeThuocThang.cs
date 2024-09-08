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
    public partial class FormThongKeThuocThang : Form
    {
        public FormThongKeThuocThang()
        {
            InitializeComponent();
        }

        KetNoi _db = new KetNoi();
        BindingSource _src = new BindingSource();

        private void FormThongKeThuocThang_Load(object sender, EventArgs e)
        {
            gridData.ReadOnly = true;
            gridData.DataSource = _src;
            gridData.AllowUserToAddRows = false;
            gridData.AllowUserToResizeRows = false;
            dtTuNgay.Value = new DateTime(2023,01,01);
            dtDenNgay.Value = DateTime.Now;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = $"SELECT thuoc.MaThuoc, thuoc.TenThuoc, SUM(ISNULL(CTDonThuoc.SoLuong, 0)) AS SLXuat FROM Thuoc LEFT JOIN CTDonThuoc\r\nON CTDonThuoc.MaThuoc = Thuoc.MaThuoc\r\nLEFT join DonThuoc ON DonThuoc.MaDT = CTDonThuoc.MaDT\r\nWHERE DonThuoc.NgayLap >= '{dtTuNgay.Value.Date.ToString("yyyy/MM/dd")}' AND DonThuoc.NgayLap <= '{dtDenNgay.Value.Date.ToString("yyyy/MM/dd")}'\r\nGROUP BY thuoc.MaThuoc, thuoc.TenThuoc";
            DataTable tb = _db.DocDuLieu(sql);
            _src.DataSource = tb;
            _src.ResetBindings(true);
        }
    }
}
