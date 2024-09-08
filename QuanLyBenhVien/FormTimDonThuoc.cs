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
    public partial class FormTimDonThuoc : Form
    {
        public FormTimDonThuoc()
        {
            InitializeComponent();
        }

        public delegate void SelectDonThuoc(DonThuocDTO obj);
        public event SelectDonThuoc SelectDonThuocHandler;

        DonThuocBUS _bus = new DonThuocBUS();
        BindingSource _src = new BindingSource();
        private void FormTimDonThuoc_Load(object sender, EventArgs e)
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

        private void gridData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridData.CurrentRow == null || gridData.CurrentRow.IsNewRow)
                return;
            
            var obj = gridData.CurrentRow.DataBoundItem as DonThuocDTO;
            
            if (obj == null)
                return;

            if (SelectDonThuocHandler != null)
            {
                SelectDonThuocHandler(obj);
                this.Close();
            }
        }
    }
}
