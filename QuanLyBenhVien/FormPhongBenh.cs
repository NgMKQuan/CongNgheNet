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
    public partial class FormPhongBenh : Form
    {
        public FormPhongBenh()
        {
            InitializeComponent();
        }

        PhongBenhBUS _bus = new PhongBenhBUS();
        BindingSource _src = new BindingSource();
        private void FormPhongBenh_Load(object sender, EventArgs e)
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
            gridData.ReadOnly= true;
            gridData.AllowUserToAddRows = false;
            gridData.AllowUserToResizeRows = false;
            gridData.DataSource = _src;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            tbSoPhong.Text = "";
            tbSoGiuong.Text = "0";
            tbSoGiuongTrong.Text = "0";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty( tbSoPhong.Text))
            {
                MessageBox.Show("Số phòng không được để trống !");
                return;
            }

            if (_bus.TonTai(tbSoPhong.Text))
            {
                MessageBox.Show("Số phòng đã tồn tại !");
                return;
            }

            if (!int.TryParse(tbSoGiuong.Text, out int soGiuong))
            {
                MessageBox.Show("Số giường phải là kiểu số !");
                return;
            }

            if (!int.TryParse(tbSoGiuongTrong.Text, out int soGiuongTrong))
            {
                MessageBox.Show("Số giường trống phải là kiểu số !");
                return;
            }

            PhongBenhDTO obj = new PhongBenhDTO();
            obj.SoPhong = tbSoPhong.Text;
            obj.SoGiuong = soGiuong;
            obj.SoGiuongTrong =soGiuongTrong;

            if (_bus.Them(obj))
            {
                LoadGrid();
                MessageBox.Show("Thêm phòng mới thành công !");
                return;
            }

            MessageBox.Show("Thêm phòng mới không thành công !");

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSoPhong.Text))
            {
                MessageBox.Show("Số phòng không được để trống !");
                return;
            }

            if (!_bus.TonTai(tbSoPhong.Text))
            {
                MessageBox.Show("Số phòng không tồn tại !");
                return;
            }

            if (!int.TryParse(tbSoGiuong.Text, out int soGiuong))
            {
                MessageBox.Show("Số giường phải là kiểu số !");
                return;
            }

            if (!int.TryParse(tbSoGiuongTrong.Text, out int soGiuongTrong))
            {
                MessageBox.Show("Số giường trống phải là kiểu số !");
                return;
            }

            PhongBenhDTO obj = new PhongBenhDTO();
            obj.SoPhong = tbSoPhong.Text;
            obj.SoGiuong = soGiuong;
            obj.SoGiuongTrong = soGiuongTrong;

            if (_bus.Sua(obj))
            {
                LoadGrid();
                MessageBox.Show("Sửa phòng mới thành công !");
                return;
            }

            MessageBox.Show("Sửa phòng mới không thành công !");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!_bus.TonTai(tbSoPhong.Text))
            {
                MessageBox.Show("Số phòng không tìm thấy !");
                return;
            }

            if (_bus.Xoa(tbSoPhong.Text))
            {
                LoadGrid();
                MessageBox.Show("Xoá phòng thành công !");
                return;
            }

            MessageBox.Show("Xoá phòng không thành công !");

        }

        private void gridData_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (gridData.CurrentRow == null || gridData.CurrentRow.IsNewRow)
                return;
            var obj = gridData.CurrentRow.DataBoundItem as PhongBenhDTO;
            if (obj == null) return;
            DisplayData(obj);
        }

        private void DisplayData(PhongBenhDTO obj)
        {
            tbSoPhong.Text = obj.SoPhong;
            tbSoGiuong.Text = obj.SoGiuong.ToString();
            tbSoGiuongTrong.Text = obj.SoGiuongTrong.ToString();
        }
    }
}
