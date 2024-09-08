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
    public partial class FormBenhNhan : Form
    {
        public FormBenhNhan()
        {
            InitializeComponent();
        }

        BenhNhanBUS _bus = new BenhNhanBUS();
        BindingSource _src = new BindingSource();
        private void FormBenhNhan_Load(object sender, EventArgs e)
        {
            gridData.DataSource = _src;
            gridData.AutoGenerateColumns = false;
            gridData.AllowUserToAddRows = false;
            gridData.ReadOnly = true;

            LoadData();
            cboGioiTinh.SelectedIndex = 0;

        }

        private void LoadData()
        {
            _src.DataSource = _bus.GetAll();
            _src.ResetBindings(true);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            tbMaBN.Text = "";
            tbTenBN.Text = "";
            cboGioiTinh.SelectedItem = "Nam";
            dtNgaySinh.Value = new DateTime(1970, 01, 01);
            tbDiaChi.Text = "";
            tbSoDT.Text = "";
            tbTinhTrangSK.Text = "";
            dtNgayNhapVien.Value = DateTime.Now.Date;
            dtNgayXuatVien.Value = DateTime.Now.Date;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbMaBN.Text))
            {
                MessageBox.Show("Mã bệnh nhân không được để trống !");
                return;
            }

            if (_bus.TonTai(tbMaBN.Text))
            {
                MessageBox.Show("Mã bệnh nhân đã tồn tại !");
                return;
            }

            if (string.IsNullOrEmpty(tbTenBN.Text))
            {
                MessageBox.Show("Tên bệnh nhân không được để trống !");
                return;
            }

            if (cboGioiTinh.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn giới tính !");
                return;
            }

            if (dtNgaySinh.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Ngày sinh phải nhỏ hơn ngày hiện tại !");
                return;
            }

            BenhNhanDTO obj = new BenhNhanDTO();
            obj.MaBN = tbMaBN.Text;
            obj.TenBN = tbTenBN.Text;
            obj.GioiTinh = (cboGioiTinh.SelectedItem as string) == "Nam" ? true : false;
            obj.NgaySinh = dtNgaySinh.Value.Date;
            obj.DiaChi = tbDiaChi.Text;
            obj.SDT = tbSoDT.Text;
            obj.TinhTrangSK = tbTinhTrangSK.Text;
            obj.NgayNhapVien = dtNgayNhapVien.Value.Date;
            obj.NgayXuatVien = dtNgayXuatVien.Value.Date;

            if (_bus.Them(obj))
            {
                LoadData();
                MessageBox.Show("Thêm bênh nhân thành công !");
                return;
            }
            MessageBox.Show("Thêm bệnh nhân không thành công !");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbMaBN.Text))
            {
                MessageBox.Show("Mã bệnh nhân không được để trống !");
                return;
            }

            if (!_bus.TonTai(tbMaBN.Text))
            {
                MessageBox.Show("Không tìm thấy mã bệnh nhân cần sửa !");
                return;
            }

            if (string.IsNullOrEmpty(tbTenBN.Text))
            {
                MessageBox.Show("Tên bệnh nhân không được để trống !");
                return;
            }

            if (cboGioiTinh.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn giới tính !");
                return;
            }

            if (dtNgaySinh.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Ngày sinh phải nhỏ hơn ngày hiện tại !");
                return;
            }

            BenhNhanDTO obj = new BenhNhanDTO();
            obj.MaBN = tbMaBN.Text;
            obj.TenBN = tbTenBN.Text;
            obj.GioiTinh = (cboGioiTinh.SelectedItem as string) == "Nam" ? true : false;
            obj.NgaySinh = dtNgaySinh.Value.Date;
            obj.DiaChi = tbDiaChi.Text;
            obj.SDT = tbSoDT.Text;
            obj.TinhTrangSK = tbTinhTrangSK.Text;
            obj.NgayNhapVien = dtNgayNhapVien.Value.Date;
            obj.NgayXuatVien = dtNgayXuatVien.Value.Date;

            if (_bus.Sua(obj))
            {
                LoadData();
                MessageBox.Show("Thay đổi thông tin bênh nhân thành công !");
                return;
            }
            MessageBox.Show("Thay đổi thông tin bệnh nhân không thành công !");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắc muốn xóa ? ", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (!_bus.TonTai(tbMaBN.Text))
                {
                    MessageBox.Show("Không tìm thấy mã bệnh nhân cần xoá !");
                    return;
                }

                if (_bus.Xoa(tbMaBN.Text))
                {
                    LoadData();
                    MessageBox.Show("Xoá thông tin bênh nhân thành công !");
                    return;
                }
                MessageBox.Show("Xoá thông tin bệnh nhân không thành công !");
            }
           
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            var w = tbSearch.Text.ToLower();

            if (string.IsNullOrEmpty(w))
            {
                LoadData();
                MessageBox.Show("Vui lòng nhập vào nội dung tìm kiếm !");
                return;
            }

            var ds = _bus.GetAll()
                .Where(x => x.MaBN.ToLower().Contains(w)
                ||x.TenBN.ToLower().Contains(w)
                || x.DiaChi.ToLower().Contains(w)
                || x.SDT.ToLower().Contains(w))
                .ToList();
            _src.DataSource = ds;
            _src.ResetBindings(true);

        }

        private void gridData_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (gridData.CurrentRow == null || gridData.CurrentRow.IsNewRow)
                return;
            var obj = gridData.CurrentRow.DataBoundItem as BenhNhanDTO;
            if (obj == null)
                return;
            DisplayData(obj);
        }

        private void DisplayData(BenhNhanDTO obj)
        {
            tbMaBN.Text = obj.MaBN;
            tbTenBN.Text = obj.TenBN;
            cboGioiTinh.SelectedItem = obj.GioiTinh ? "Nam" : "Nữ";
            dtNgaySinh.Value = obj.NgaySinh;
            tbDiaChi.Text = obj.DiaChi;
            tbSoDT.Text = obj.SDT;
            tbTinhTrangSK.Text = obj.TinhTrangSK;
            dtNgayNhapVien.Value = obj.NgayNhapVien;
            dtNgayXuatVien.Value = obj.NgayXuatVien;
        }
    }
}
