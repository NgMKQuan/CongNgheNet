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
    public partial class FormNguoiDung : Form
    {
        public FormNguoiDung()
        {
            InitializeComponent();
        }

        NguoiDungBUS _bus = new NguoiDungBUS();
        BindingSource _src = new BindingSource();
        private void FormNguoiDung_Load(object sender, EventArgs e)
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
            gridData.DataSource = _src;
            gridData.ReadOnly = true;
            gridData.AllowUserToAddRows = false;
            gridData.AllowUserToResizeRows = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            tbMaND.Text = "";
            tbMatKhau.Text = "";
            cboQuyen.SelectedItem = "USER";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbMaND.Text))
            {
                MessageBox.Show("Mã người dùng không được để trống !");
                return;
            }

            if (_bus.TonTai(tbMaND.Text))
            {
                MessageBox.Show("Mã người dùng đã tồn tại !");
                return;
            }

            if (string.IsNullOrEmpty(tbMaND.Text))
            {
                MessageBox.Show("Mật khẩu không được để trống !");
                return;
            }

            if (cboQuyen.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn quyền !");
                return;
            }

            NguoiDungDTO obj = new NguoiDungDTO();
            obj.MaND = tbMaND.Text;
            obj.MatKhau = tbMatKhau.Text;
            obj.Quyen = cboQuyen.SelectedItem as string;

            if (_bus.Them(obj))
            {
                LoadGridData();
                MessageBox.Show("Thêm mới người dùng thành công !");
                return;
            }
            MessageBox.Show("Thêm mới người dùng không thành công !");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbMaND.Text))
            {
                MessageBox.Show("Mã người dùng không được để trống !");
                return;
            }

            if (!_bus.TonTai(tbMaND.Text))
            {
                MessageBox.Show("Không tồn tại người dùng cần sửa thông tin!");
                return;
            }

            if (string.IsNullOrEmpty(tbMaND.Text))
            {
                MessageBox.Show("Mật khẩu không được để trống !");
                return;
            }

            if (cboQuyen.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn quyền !");
                return;
            }

            NguoiDungDTO obj = new NguoiDungDTO();
            obj.MaND = tbMaND.Text;
            obj.MatKhau = tbMatKhau.Text;
            obj.Quyen = cboQuyen.SelectedItem as string;

            if (_bus.Sua(obj))
            {
                LoadGridData();
                MessageBox.Show("Thay đổi thông tin người dùng thành công !");
                return;
            }
            MessageBox.Show("Thay đổi thông tin người dùng không thành công !");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbMaND.Text))
            {
                MessageBox.Show("Mã người dùng không được để trống !");
                return;
            }

            if (!_bus.TonTai(tbMaND.Text))
            {
                MessageBox.Show("Không tồn tại người dùng cần xoá !");
                return;
            }

            if (FormMain.NguoiDungHienTai != null)
            {
                if (FormMain.NguoiDungHienTai.MaND == tbMaND.Text)
                {
                    MessageBox.Show("Không thể xoá người dùng hiện đang đăng nhập !");
                    return;
                }
            }

            if (_bus.Xoa(tbMaND.Text))
            {
                LoadGridData();
                MessageBox.Show("Xoá thông tin người dùng thành công !");
                return;
            } 

            MessageBox.Show("Xoá thông tin người dùng không thành công !");

        }

        private void gridData_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (gridData.CurrentRow == null || gridData.CurrentRow.IsNewRow) 
                return;
            var obj = gridData.CurrentRow.DataBoundItem as NguoiDungDTO;
            if (obj == null)
                return;
            Display(obj);
        }

        private void Display(NguoiDungDTO obj)
        {
            tbMaND.Text = obj.MaND;
            tbMatKhau.Text = obj.MatKhau;
            cboQuyen.SelectedItem = obj.Quyen;
        }
    }
}
