using QuanLyBenhVien.BUS;
using QuanLyBenhVien.DTO;
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
    public partial class FormHoaDon : Form
    {
        public FormHoaDon()
        {
            InitializeComponent();
        }

        HoaDonBUS _bus = new HoaDonBUS();
        BenhNhanBUS _bnBus = new BenhNhanBUS();
        DonThuocBUS _dtBus = new DonThuocBUS();
        BindingSource _src = new BindingSource();
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbMaHD.Text))
            {
                MessageBox.Show("Mã hoá đơn không được để trống !");
                return;
            }

            if (cboMaBN.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn mã bệnh nhân !");
                return;
            }

            if (cboMaDT.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn mã đơn thuốc !");
                return;
            }

            if (!decimal.TryParse(tbTongTien.Text, out decimal _tongTien))
            {
                MessageBox.Show("Tổng tiền phải là dạng số !");
                return;
            }

            HoaDonDTO obj = new HoaDonDTO();
            obj.MaHD = tbMaHD.Text;
            obj.MaBN = cboMaBN.SelectedValue.ToString();
            obj.MaDT = cboMaDT.SelectedValue.ToString();
            obj.NgayLap = dtNgayLap.Value.Date;
            obj.TongTien = _tongTien;

            if (_bus.Sua(obj))
            {
                LoadGrid();
                MessageBox.Show("Sửa thông tin thành công !");
                return;
            }

            MessageBox.Show("Sửa thông tin không thành công !");
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            InitGrid();
            LoadGrid();
            LoadComboBoxBenhNhan();
            LoadComboBoxDonThuoc();
        }

        private void LoadGrid()
        {
            _src.DataSource = _bus.GetAll();
            _src.ResetBindings(true);
        }

        private void InitGrid()
        {
            gridData.ReadOnly = true;
            gridData.AllowUserToAddRows = false;
            gridData.DataSource = _src;
        }

        private void LoadComboBoxDonThuoc()
        {
            cboMaDT.DataSource = _dtBus.GetAll();
            cboMaDT.ValueMember = "MaDT";
            cboMaDT.DisplayMember = "MaDT";
        }

        private void LoadComboBoxBenhNhan()
        {
            cboMaBN.DataSource = _bnBus.GetAll();
            cboMaBN.ValueMember = "MaBN";
            cboMaBN.DisplayMember = "TenBN";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            tbMaHD.Text = "";
            cboMaBN.SelectedIndex = -1;
            cboMaDT.SelectedIndex = -1;
            dtNgayLap.Value = DateTime.Now.Date;
            tbTongTien.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbMaHD.Text))
            {
                MessageBox.Show("Mã hoá đơn không được để trống !");
                return;
            }

            if (cboMaBN.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn mã bệnh nhân !");
                return;
            }

            if (cboMaDT.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn mã đơn thuốc !");
                return;
            }

            if (!decimal.TryParse(tbTongTien.Text, out decimal _tongTien))
            {
                MessageBox.Show("Tổng tiền phải là dạng số !");
                return;
            }

            HoaDonDTO obj = new HoaDonDTO();
            obj.MaHD = tbMaHD.Text;
            obj.MaBN = cboMaBN.SelectedValue.ToString();
            obj.MaDT = cboMaDT.SelectedValue.ToString();
            obj.NgayLap = dtNgayLap.Value.Date;
            obj.TongTien = _tongTien;

            if (_bus.Them(obj))
            {
                LoadGrid();
                MessageBox.Show("Thêm mới thành công !");
                return;
            }

            MessageBox.Show("Thêm mới không thành công !");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_bus.Xoa(tbMaHD.Text))
            {
                LoadGrid();
                MessageBox.Show("Xoá thành công !");
                return;
            }

            MessageBox.Show("Xoá không thành công !");
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            var nd = tbSearch.Text.ToLower();
            var kq = _bus.GetAll()
                .Where(x => x.MaHD.ToLower().Contains(nd)).ToList();
            _src.DataSource = kq;
            _src.ResetBindings(true);
        }

        private void gridData_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (gridData.CurrentRow == null || gridData.CurrentRow.IsNewRow)
                return;
            var obj = gridData.CurrentRow.DataBoundItem as HoaDonDTO;
            if (obj == null) return;
            DisplayData(obj);
        }

        private void DisplayData(HoaDonDTO obj)
        {
            tbMaHD.Text = obj.MaHD;
            cboMaBN.SelectedValue = obj.MaBN;
            cboMaDT.SelectedValue = obj.MaDT;
            dtNgayLap.Value = obj.NgayLap.Date;
            tbTongTien.Text = obj.TongTien.ToString("0");
        }
    }
}
