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
    public partial class FormThuoc : Form
    {
        public FormThuoc()
        {
            InitializeComponent();
        }

        ThuocBUS _bus = new ThuocBUS();
        BindingSource _src = new BindingSource();
        private void FormThuoc_Load(object sender, EventArgs e)
        {
            InitGrid();
            LoadGrid();
        }

        private void LoadGrid()
        {
            _src.DataSource = _bus.GetAll();
            _src.ResetBindings(true);
        }

        private void InitGrid()
        {
            gridData.DataSource = _src;
            gridData.ReadOnly = true;
            gridData.AllowUserToAddRows = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            tbMaThuoc.Text = "";
            tbTenThuoc.Text = "";
            tbSoLuong.Text = "0";
            tbGiaThuoc.Text = "0";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbMaThuoc.Text))
            {
                MessageBox.Show("Mã thuốc không được để trống !");
                return;
            }

            if (_bus.TonTai(tbMaThuoc.Text))
            {
                MessageBox.Show("Mã thuốc đã tồn tại !");
                return;
            }

            if (string.IsNullOrEmpty(tbTenThuoc.Text))
            {
                MessageBox.Show("Tên thuốc không được để trống !");
                return;
            }

            if (!int.TryParse(tbSoLuong.Text, out int soLuong))
            {
                MessageBox.Show("Số lượng thuốc phải là kiểu số !");
                return;
            }

            if (!decimal.TryParse(tbGiaThuoc.Text, out decimal giaThuoc))
            {
                MessageBox.Show("Giá thuốc phải là kiểu số !");
                return;
            }

            ThuocDTO obj = new ThuocDTO();
            obj.MaThuoc = tbMaThuoc.Text;
            obj.TenThuoc = tbTenThuoc.Text;
            obj.SoLuong = soLuong;
            obj.GiaThuoc = giaThuoc;

            if (_bus.Them(obj))
            {
                LoadGrid();
                MessageBox.Show("Thêm mới thuốc thành công !");
                return;
            }

            MessageBox.Show("Thêm mới thuốc không thành công !");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbMaThuoc.Text))
            {
                MessageBox.Show("Mã thuốc không được để trống !");
                return;
            }

            if (!_bus.TonTai(tbMaThuoc.Text))
            {
                MessageBox.Show("Mã thuốc không tồn tại !");
                return;
            }

            if (string.IsNullOrEmpty(tbTenThuoc.Text))
            {
                MessageBox.Show("Tên thuốc không được để trống !");
                return;
            }

            if (!int.TryParse(tbSoLuong.Text, out int soLuong))
            {
                MessageBox.Show("Số lượng thuốc phải là kiểu số !");
                return;
            }

            if (!decimal.TryParse(tbGiaThuoc.Text, out decimal giaThuoc))
            {
                MessageBox.Show("Giá thuốc phải là kiểu số !");
                return;
            }

            ThuocDTO obj = new ThuocDTO();
            obj.MaThuoc = tbMaThuoc.Text;
            obj.TenThuoc = tbTenThuoc.Text;
            obj.SoLuong = soLuong;
            obj.GiaThuoc = giaThuoc;

            if (_bus.Sua(obj))
            {
                LoadGrid();
                MessageBox.Show("Sửa thông tin thuốc thành công !");
                return;
            }

            MessageBox.Show("Sửa thông tin thuốc không thành công !");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!_bus.TonTai(tbMaThuoc.Text))
            {
                MessageBox.Show("Không tìm thấy mã thuốc cần xoá !");
                return;
            }

            if (_bus.Xoa(tbMaThuoc.Text))
            {
                LoadGrid();
                MessageBox.Show("Xoá tin thuốc thành công !");
                return;
            }

            MessageBox.Show("Xoá thông tin thuốc không thành công !");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var w = tbSearch.Text.ToLower();
            var ds = _bus.GetAll()
                .Where(x => x.MaThuoc.ToLower().Contains(w) || x.TenThuoc.ToLower().Contains(w))
                .ToList();
            _src.DataSource = ds;
            _src.ResetBindings(true);
        }

        private void gridData_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (gridData.CurrentRow == null || gridData.CurrentRow.IsNewRow)
                return;
            var obj = gridData.CurrentRow.DataBoundItem as ThuocDTO;
            if (obj == null)
                return;
            DisplayData(obj);
        }

        private void DisplayData(ThuocDTO obj)
        {
            tbMaThuoc.Text = obj.MaThuoc;
            tbTenThuoc.Text = obj.TenThuoc;
            tbSoLuong.Text = obj.SoLuong.ToString();
            tbGiaThuoc.Text = obj.GiaThuoc.ToString("N0");
        }
    }
}
