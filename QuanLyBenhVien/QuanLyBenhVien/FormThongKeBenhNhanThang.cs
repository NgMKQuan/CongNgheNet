using QuanLyBenhVien.BUS;
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
    public partial class FormThongKeBenhNhanThang : Form
    {
        public FormThongKeBenhNhanThang()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var ds = _bus.GetAll()
                .Where(x => x.NgayNhapVien.Date >= dtTuNgay.Value.Date && x.NgayNhapVien.Date <= dtDenNgay.Value.Date)
                .ToList();
            _src.DataSource = ds;
            _src.ResetBindings(true);
        }

        BenhNhanBUS _bus = new BenhNhanBUS();
        BindingSource _src = new BindingSource();

        private void FormThongKeBenhNhanThang_Load(object sender, EventArgs e)
        {
            gridData.DataSource = _src;
            gridData.AutoGenerateColumns = false;
            gridData.AllowUserToAddRows = false;
            gridData.AllowUserToResizeRows = false;
            dtTuNgay.Value = new DateTime(2023, 01, 01);
            dtDenNgay.Value = DateTime.Now;
        }
    }
}
