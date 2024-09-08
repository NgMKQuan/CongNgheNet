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
    public partial class FormDonThuoc : Form
    {
        public FormDonThuoc()
        {
            InitializeComponent();
        }

        DonThuocBUS _bus = new DonThuocBUS();
        CTDonThuocBUS _ctDT = new CTDonThuocBUS();
        BacSiBUS _bsBus = new BacSiBUS();
        BenhNhanBUS _bnBus = new BenhNhanBUS();
        PhongBenhBUS _pbBus = new PhongBenhBUS();
        ThuocBUS _thuocBus = new ThuocBUS();
        BindingSource _srcCT = new BindingSource();
        List<CTDonThuocDTO> dsChiTiet;
        private void FormDonThuoc_Load(object sender, EventArgs e)
        {
            dsChiTiet = new List<CTDonThuocDTO>();
            InitGrid();
            LoadGridData();
            LoadComboBacSi();
            LoadComboBenhNhan();
            LoadComboPhongBenh();
            LoadComboThuoc();
        }

        private void LoadGridData()
        {
            _srcCT.DataSource = dsChiTiet;
            _srcCT.ResetBindings(true);
        }

        private void InitGrid()
        {
            gridDataCT.ReadOnly = true;
            gridDataCT.AllowUserToAddRows = false;
            gridDataCT.DataSource = _srcCT;
        }

        private void LoadComboThuoc()
        {
            cboMaThuoc.DataSource = _thuocBus.GetAll();
            cboMaThuoc.ValueMember = "MaThuoc";
            cboMaThuoc.DisplayMember = "TenThuoc";
        }

        private void LoadComboPhongBenh()
        {
           cboSoPhong.DataSource = _pbBus.GetAll();
            cboSoPhong.ValueMember = "SoPhong";
            cboSoPhong.DisplayMember = "TenPhong";
        }

        private void LoadComboBenhNhan()
        {
            cboBenhNhan.DataSource = _bnBus.GetAll();
            cboBenhNhan.ValueMember = "MaBN";
            cboBenhNhan.DisplayMember = "TenBN";
        }

        private void LoadComboBacSi()
        {
            cboBacSi.DataSource = _bsBus.GetAll();
            cboBacSi.ValueMember = "MaBS";
            cboBacSi.DisplayMember = "TenBS";
        }

        private void btnThemThuoc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbMaDT.Text))
            {
                MessageBox.Show("Mã đơn thuốc không được để trống !");
                return;
            }

            if (cboMaThuoc.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn một mã thuốc !");
                return;
            }

            if (!int.TryParse(tbSoLuong.Text, out int _sl))
            {
                MessageBox.Show("Số lượng phải là kiểu số !");
                return;
            }

            if (_sl <= 0)
            {
                MessageBox.Show("Số lượng thuốc phải lớn hơn 0 !");
                return;
            }

            bool update = false;

            foreach (var item in dsChiTiet)
            {
                if (item.MaThuoc == cboMaThuoc.SelectedValue as string)
                {
                    item.SoLuong += _sl;
                    update = true;
                }
            }

            var obj = cboMaThuoc.SelectedItem as ThuocDTO;

            if (!update)
            {
                dsChiTiet.Add(new CTDonThuocDTO()
                {
                    MaDT = tbMaDT.Text,
                    SoLuong = _sl,
                    MaThuoc = obj.MaThuoc,
                    TenThuoc = obj.TenThuoc
                });
            }

            _srcCT.ResetBindings(true);
        }

        private void btnXoaThuoc_Click(object sender, EventArgs e)
        {
            if (gridDataCT.CurrentRow == null || gridDataCT.CurrentRow.IsNewRow)
                return;
            var obj = gridDataCT.CurrentRow.DataBoundItem as CTDonThuocDTO;
            if (obj != null)
            {
                dsChiTiet.Remove(obj);
                _srcCT.ResetBindings(true);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            tbMaDT.Text = "";
            cboBacSi.SelectedIndex = -1;
            cboBenhNhan.SelectedIndex = -1;
            cboSoPhong.SelectedIndex = -1;
            cboMaThuoc.SelectedIndex = -1;
            tbSoLuong.Text = "0";
            dsChiTiet = new List<CTDonThuocDTO>();
            _srcCT.DataSource = dsChiTiet;
            _srcCT.ResetBindings(true);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbMaDT.Text))
            {
                MessageBox.Show("Mã đơn thuốc không được để trống !");
                return;
            }

            if (_bus.TonTai(tbMaDT.Text)) {
                MessageBox.Show("Mã đơn thuốc đã tồn tại !");
                return;
            }

            if (cboBacSi.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn bác sĩ !");
                return;
            }

            if (cboBenhNhan.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân !");
                return;
            }

            if (cboSoPhong.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn số phòng !");
                return;
            }

            if (dsChiTiet.Count <= 0)
            {
                MessageBox.Show("Vui lòng thêm tối thiểu một loại thuốc trong đơn thuốc !");
                return;
            }


            DonThuocDTO dt = new DonThuocDTO();
            dt.MaDT = tbMaDT.Text;
            dt.MaBS = cboBacSi.SelectedValue as string;
            dt.MaBN = cboBenhNhan.SelectedValue as string;
            dt.SoPhong = cboSoPhong.SelectedValue as string;
            dt.NgayLap = dtNgayLap.Value;

            if (_bus.Them(dt))
            {
                // Thêm chi tiết
                foreach (var item in dsChiTiet)
                {
                    item.MaDT = dt.MaDT;
                    _ctDT.Them(item);
                }

                MessageBox.Show("Thêm mới đơn thuốc thành công !");
                return;
            }

            MessageBox.Show("Thêm mới đơn thuốc không thành công !");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbMaDT.Text))
            {
                MessageBox.Show("Mã đơn thuốc không được để trống !");
                return;
            }

            if (!_bus.TonTai(tbMaDT.Text))
            {
                MessageBox.Show("Không tìm thấy đơn thuốc !");
                return;
            }

            if (cboBacSi.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn bác sĩ !");
                return;
            }

            if (cboBenhNhan.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân !");
                return;
            }

            if (cboSoPhong.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn số phòng !");
                return;
            }

            DonThuocDTO dt = new DonThuocDTO();
            dt.MaDT = tbMaDT.Text;
            dt.MaBS = cboBacSi.SelectedValue as string;
            dt.MaBN = cboBenhNhan.SelectedValue as string;
            dt.SoPhong = cboSoPhong.SelectedValue as string;
            dt.NgayLap = dtNgayLap.Value;

            if (_bus.Sua(dt))
            {
                // Xoá dữ liệu cũ
                _ctDT.Xoa(dt.MaDT);

                // Thêm chi tiết mới
                foreach (var item in dsChiTiet)
                {
                    item.MaDT = dt.MaDT;
                    _ctDT.Them(item);
                }

                MessageBox.Show("Sửa thông tin đơn thuốc thành công !");
                return;
            }

            MessageBox.Show("Sửa thông tin đơn thuốc không thành công !");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!_bus.TonTai(tbMaDT.Text))
            {
                MessageBox.Show("Không tìm thấy đơn thuốc !");
                return;
            }

            if (_bus.DonThuocCoHoaDon(tbMaDT.Text))
            {
                MessageBox.Show("Đơn thuốc được tham chiếu bởi hoá đơn ! Không thể xoá !");
                return;
            }


            _ctDT.Xoa(tbMaDT.Text);
            
            if (_bus.Xoa(tbMaDT.Text))
            {
                MessageBox.Show("Xoá đơn thuốc thành công !");
                return;
            }

            MessageBox.Show("Xoá đơn thuốc không thành công !");

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
                FormTimDonThuoc frm = new FormTimDonThuoc();
                frm.SelectDonThuocHandler += Frm_SelectDonThuocHandler;
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
        }

        private void Frm_SelectDonThuocHandler(DonThuocDTO obj)
        {
            if (obj == null)
                return;

            DisplayData(obj);
        }

        private void DisplayData(DonThuocDTO obj)
        {
            tbMaDT.Text = obj.MaDT;
            cboBacSi.SelectedValue = obj.MaBS;
            cboBenhNhan.SelectedValue = obj.MaBN;
            cboSoPhong.SelectedValue = obj.SoPhong;

            dsChiTiet = _ctDT.GetBy(tbMaDT.Text);
            _srcCT.DataSource = dsChiTiet;
            _srcCT.ResetBindings(true);
        }
    }
}
