namespace QuanLyBenhVien
{
    partial class FormDonThuoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridDataCT = new System.Windows.Forms.DataGridView();
            this.MaThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboMaThuoc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSoLuong = new System.Windows.Forms.TextBox();
            this.btnXoaThuoc = new System.Windows.Forms.Button();
            this.btnThemThuoc = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtNgayLap = new System.Windows.Forms.DateTimePicker();
            this.cboSoPhong = new System.Windows.Forms.ComboBox();
            this.cboBenhNhan = new System.Windows.Forms.ComboBox();
            this.cboBacSi = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaDT = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataCT)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridDataCT);
            this.groupBox2.Controls.Add(this.cboMaThuoc);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbSoLuong);
            this.groupBox2.Controls.Add(this.btnXoaThuoc);
            this.groupBox2.Controls.Add(this.btnThemThuoc);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(999, 302);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết đơn thuốc";
            // 
            // gridDataCT
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridDataCT.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDataCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDataCT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThuoc,
            this.TenThuoc,
            this.SoLuong});
            this.gridDataCT.Location = new System.Drawing.Point(3, 85);
            this.gridDataCT.Name = "gridDataCT";
            this.gridDataCT.RowHeadersWidth = 51;
            this.gridDataCT.RowTemplate.Height = 24;
            this.gridDataCT.Size = new System.Drawing.Size(993, 214);
            this.gridDataCT.TabIndex = 0;
            // 
            // MaThuoc
            // 
            this.MaThuoc.DataPropertyName = "MaThuoc";
            this.MaThuoc.HeaderText = "Mã Thuốc";
            this.MaThuoc.MinimumWidth = 6;
            this.MaThuoc.Name = "MaThuoc";
            this.MaThuoc.Width = 125;
            // 
            // TenThuoc
            // 
            this.TenThuoc.DataPropertyName = "TenThuoc";
            this.TenThuoc.HeaderText = "Tên Thuốc";
            this.TenThuoc.MinimumWidth = 6;
            this.TenThuoc.Name = "TenThuoc";
            this.TenThuoc.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 125;
            // 
            // cboMaThuoc
            // 
            this.cboMaThuoc.FormattingEnabled = true;
            this.cboMaThuoc.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboMaThuoc.Location = new System.Drawing.Point(156, 28);
            this.cboMaThuoc.Name = "cboMaThuoc";
            this.cboMaThuoc.Size = new System.Drawing.Size(212, 24);
            this.cboMaThuoc.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã Thuốc";
            // 
            // tbSoLuong
            // 
            this.tbSoLuong.Location = new System.Drawing.Point(515, 28);
            this.tbSoLuong.Name = "tbSoLuong";
            this.tbSoLuong.Size = new System.Drawing.Size(212, 22);
            this.tbSoLuong.TabIndex = 0;
            // 
            // btnXoaThuoc
            // 
            this.btnXoaThuoc.Location = new System.Drawing.Point(894, 21);
            this.btnXoaThuoc.Name = "btnXoaThuoc";
            this.btnXoaThuoc.Size = new System.Drawing.Size(85, 36);
            this.btnXoaThuoc.TabIndex = 3;
            this.btnXoaThuoc.Text = "Xoá";
            this.btnXoaThuoc.UseVisualStyleBackColor = true;
            this.btnXoaThuoc.Click += new System.EventHandler(this.btnXoaThuoc_Click);
            // 
            // btnThemThuoc
            // 
            this.btnThemThuoc.Location = new System.Drawing.Point(783, 21);
            this.btnThemThuoc.Name = "btnThemThuoc";
            this.btnThemThuoc.Size = new System.Drawing.Size(84, 36);
            this.btnThemThuoc.TabIndex = 3;
            this.btnThemThuoc.Text = "Thêm";
            this.btnThemThuoc.UseVisualStyleBackColor = true;
            this.btnThemThuoc.Click += new System.EventHandler(this.btnThemThuoc_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(402, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Số Lượng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtNgayLap);
            this.groupBox1.Controls.Add(this.cboSoPhong);
            this.groupBox1.Controls.Add(this.cboBenhNhan);
            this.groupBox1.Controls.Add(this.cboBacSi);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbMaDT);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(999, 179);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dtNgayLap
            // 
            this.dtNgayLap.CustomFormat = "dd/MM/yyyy";
            this.dtNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayLap.Location = new System.Drawing.Point(642, 28);
            this.dtNgayLap.Name = "dtNgayLap";
            this.dtNgayLap.Size = new System.Drawing.Size(337, 22);
            this.dtNgayLap.TabIndex = 5;
            // 
            // cboSoPhong
            // 
            this.cboSoPhong.FormattingEnabled = true;
            this.cboSoPhong.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboSoPhong.Location = new System.Drawing.Point(870, 76);
            this.cboSoPhong.Name = "cboSoPhong";
            this.cboSoPhong.Size = new System.Drawing.Size(109, 24);
            this.cboSoPhong.TabIndex = 4;
            // 
            // cboBenhNhan
            // 
            this.cboBenhNhan.FormattingEnabled = true;
            this.cboBenhNhan.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboBenhNhan.Location = new System.Drawing.Point(503, 76);
            this.cboBenhNhan.Name = "cboBenhNhan";
            this.cboBenhNhan.Size = new System.Drawing.Size(212, 24);
            this.cboBenhNhan.TabIndex = 4;
            // 
            // cboBacSi
            // 
            this.cboBacSi.FormattingEnabled = true;
            this.cboBacSi.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboBacSi.Location = new System.Drawing.Point(144, 76);
            this.cboBacSi.Name = "cboBacSi";
            this.cboBacSi.Size = new System.Drawing.Size(212, 24);
            this.cboBacSi.TabIndex = 4;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(803, 123);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(167, 36);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(620, 123);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(167, 36);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(405, 21);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(84, 36);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(432, 123);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(167, 36);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(254, 123);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(167, 36);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(548, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ngày Lập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(752, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bệnh Nhân";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Bác Sĩ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã ĐT";
            // 
            // tbMaDT
            // 
            this.tbMaDT.Location = new System.Drawing.Point(144, 33);
            this.tbMaDT.Name = "tbMaDT";
            this.tbMaDT.Size = new System.Drawing.Size(212, 22);
            this.tbMaDT.TabIndex = 0;
            // 
            // FormDonThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 526);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormDonThuoc";
            this.Text = "ĐƠN THUỐC";
            this.Load += new System.EventHandler(this.FormDonThuoc_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataCT)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gridDataCT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboBacSi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMaDT;
        private System.Windows.Forms.ComboBox cboSoPhong;
        private System.Windows.Forms.ComboBox cboBenhNhan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboMaThuoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSoLuong;
        private System.Windows.Forms.Button btnXoaThuoc;
        private System.Windows.Forms.Button btnThemThuoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DateTimePicker dtNgayLap;
        private System.Windows.Forms.Label label7;
    }
}