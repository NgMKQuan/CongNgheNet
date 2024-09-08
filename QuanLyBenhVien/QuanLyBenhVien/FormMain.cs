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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void bệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBenhNhan frm = new FormBenhNhan();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.MdiParent = this;
            frm.Show();
        }

        private void bácSĩToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBacSi frm = new FormBacSi();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.MdiParent = this;
            frm.Show();
        }

        private void phòngBệnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPhongBenh frm = new FormPhongBenh();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.MdiParent = this;
            frm.Show();
        }

        private void thuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThuoc frm = new FormThuoc();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.MdiParent = this;
            frm.Show();
        }

        private void ngườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNguoiDung frm = new FormNguoiDung();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.MdiParent = this;
            frm.Show();
        }

       
        private void đơnThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDonThuoc frm = new FormDonThuoc();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.MdiParent = this;
            frm.Show();
        }

        private void hoáĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHoaDon frm = new FormHoaDon();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.MdiParent = this;
            frm.Show();
        }

        private void thốngKêĐơnThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongKeDonThuoc frm = new FormThongKeDonThuoc();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.MdiParent = this;
            frm.Show();
        }

        private void thốngKêBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongKeBenhNhanThang frm = new FormThongKeBenhNhanThang();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.MdiParent = this;
            frm.Show();
        }

        private void thốngKêThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongKeThuocThang frm = new FormThongKeThuocThang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void thốngKêDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBaoCaoDoanhThuThang frm = new FormBaoCaoDoanhThuThang();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.MdiParent = this;
            frm.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            FormDangNhap frm = new FormDangNhap(); 
            frm.DangNhap += Frm_DangNhap;
            frm.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NguoiDungHienTai = null;
            FormDangNhap frm = new FormDangNhap();
            frm.DangNhap += Frm_DangNhap;
            frm.ShowDialog();
        }

        public static NguoiDungDTO NguoiDungHienTai;
        private void Frm_DangNhap(DTO.NguoiDungDTO dto)
        {
            if (dto != null)
            {
                NguoiDungHienTai = dto;
                PhanQuyenMenu();
            }
        }

        private void PhanQuyenMenu()
        {
            mnuDanhMuc.Enabled = false;
            mnuQuanLy.Enabled = false;
            mnuThongKe.Enabled = false;

            if (NguoiDungHienTai != null)
            {
                if (NguoiDungHienTai.Quyen == "ADMIN")
                {
                    mnuDanhMuc.Enabled = true;
                    mnuQuanLy.Enabled = true;
                    mnuThongKe.Enabled = true;
                }

                if (NguoiDungHienTai.Quyen == "USER")
                {
                    mnuDanhMuc.Enabled = false;
                    mnuQuanLy.Enabled = true;
                    mnuThongKe.Enabled = false;
                }
            }

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn muốn thoát ứng dụng?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTroGiup frm = new FormTroGiup();
            frm.ShowDialog();
        }
    }
}
