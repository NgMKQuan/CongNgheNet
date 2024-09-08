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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        NguoiDungBUS _bus = new NguoiDungBUS();
        public delegate void DangNhapDelegate(NguoiDungDTO dto);
        public event DangNhapDelegate DangNhap;

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbMaND.Text) || string.IsNullOrEmpty(tbMatKhau.Text))
            {
                MessageBox.Show("Tên người dùng hoặc mật khẩu không được để trống !", "Thông báo");
                return;
            }

            NguoiDungDTO nd = _bus.DangNhap(tbMaND.Text, tbMatKhau.Text);

            if (DangNhap != null)
            {
                DangNhap(nd);
            }

            if (nd != null)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên người dùng hoặc mật khẩu không chính xác !", "Thông báo");
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát ứng dụng ?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
