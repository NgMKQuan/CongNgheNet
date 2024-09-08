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
    public partial class FormBacSi : Form
    {
        public FormBacSi()
        {
            InitializeComponent();
        }

        BacSiBUS _bus = new BacSiBUS();
        BindingSource _src = new BindingSource();

        private void FormBacSi_Load(object sender, EventArgs e)
        {
            InitGrid();
            LoadGridData();
        }

        private void LoadGridData()
        {
            _src.DataSource = _bus.GetAll();
            _src.ResetBindings(true);
        }

        private void InitGrid()
        {
            gridData.ReadOnly = true;
            gridData.AllowUserToAddRows = false;
            gridData.AllowUserToDeleteRows = false;
            gridData.AllowUserToResizeRows = false;
            gridData.DataSource = _src;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            tbMaBS.Text = "";
            tbTenBS.Text = "";
            cboChuyenKhoa.SelectedIndex = 0;
            dtNgayVaoLam.Value = DateTime.Now.Date;
            tbSearch.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbMaBS.Text))
            {
                MessageBox.Show("Mã bác sĩ không được để trống !");
                return;
            }

            if (_bus.TonTai(tbMaBS.Text))
            {
                MessageBox.Show("Mã bác sĩ đã tồn tại !");
                return;
            }

            if(string.IsNullOrEmpty(tbTenBS.Text))
            {
                MessageBox.Show("Tên bác sĩ không được để trống !");
                return;
            }

            if (cboChuyenKhoa.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn chuyên khoa !");
                return;
            }

            BacSiDTO obj = new BacSiDTO();
            obj.MaBS = tbMaBS.Text;
            obj.TenBS = tbTenBS.Text;
            obj.ChuyenKhoa = cboChuyenKhoa.SelectedItem as string;
            obj.NgayVaoLam = dtNgayVaoLam.Value.Date;

            if (_bus.Them(obj))
            {
                LoadGridData();
                MessageBox.Show("Thêm mới bác sĩ thành công !");
                return;
            }

            MessageBox.Show("Thêm mới bác sĩ không thành công !");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbMaBS.Text))
            {
                MessageBox.Show("Mã bác sĩ không được để trống !");
                return;
            }

            if (!_bus.TonTai(tbMaBS.Text))
            {
                MessageBox.Show("Mã bác sĩ không tồn tại !");
                return;
            }

            if (string.IsNullOrEmpty(tbTenBS.Text))
            {
                MessageBox.Show("Tên bác sĩ không được để trống !");
                return;
            }

            if (cboChuyenKhoa.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn chuyên khoa !");
                return;
            }

            BacSiDTO obj = new BacSiDTO();
            obj.MaBS = tbMaBS.Text;
            obj.TenBS = tbTenBS.Text;
            obj.ChuyenKhoa = cboChuyenKhoa.SelectedItem as string;
            obj.NgayVaoLam = dtNgayVaoLam.Value.Date;

            if (_bus.Sua(obj))
            {
                LoadGridData();
                MessageBox.Show("Sửa đổi thông tin bác sĩ thành công !");
                return;
            }

            MessageBox.Show("Sửa đổi thông tin bác sĩ không thành công !");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (!_bus.TonTai(tbMaBS.Text))
            {
                MessageBox.Show("Không tồn tại mã bác sĩ cần xoá !");
                return;
            }

            if (_bus.Xoa(tbMaBS.Text))
            {
                LoadGridData();
                MessageBox.Show("Xoá thông tin bác sĩ thành công !");
                return;
            }

            MessageBox.Show("Xoá thông tin bác sĩ không thành công !");
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            var nd = tbSearch.Text.ToLower();

            if (string.IsNullOrEmpty(nd))
            {
                MessageBox.Show("Vui lòng nhập vào nội dung tìm kiếm !");
                return;
            }

            var ds = _bus.GetAll()
                .Where(x => x.MaBS.ToLower().Contains(nd) || x.TenBS.ToLower().Contains(nd))
                .ToList();
            _src.DataSource = ds;
            _src.ResetBindings(true);
        }

        private void gridData_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (gridData.CurrentRow == null || gridData.CurrentRow.IsNewRow)
                return;
            var obj = gridData.CurrentRow.DataBoundItem as BacSiDTO;
            if (obj == null)
                return;
            DisplayData(obj);
        }

        private void DisplayData(BacSiDTO obj)
        {
            tbMaBS.Text = obj.MaBS;
            tbTenBS.Text = obj.TenBS;
            cboChuyenKhoa.SelectedItem = obj.ChuyenKhoa;
            dtNgayVaoLam.Value = obj.NgayVaoLam;
        }
    }
}
