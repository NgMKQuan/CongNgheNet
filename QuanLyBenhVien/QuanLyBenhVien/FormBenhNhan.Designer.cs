namespace QuanLyBenhVien
{
    partial class FormBenhNhan
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
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gridData = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dtNgayXuatVien = new System.Windows.Forms.DateTimePicker();
            this.dtNgayNhapVien = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTenBN = new System.Windows.Forms.TextBox();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.tbTinhTrangSK = new System.Windows.Forms.TextBox();
            this.tbSoDT = new System.Windows.Forms.TextBox();
            this.tbMaBN = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbSearch);
            this.groupBox2.Controls.Add(this.btnTim);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.gridData);
            this.groupBox2.Location = new System.Drawing.Point(12, 344);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(999, 293);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(512, 21);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(212, 22);
            this.tbSearch.TabIndex = 4;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(754, 14);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(167, 36);
            this.btnTim.TabIndex = 6;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tìm theo";
            // 
            // gridData
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.gridData.Location = new System.Drawing.Point(3, 66);
            this.gridData.Name = "gridData";
            this.gridData.RowHeadersWidth = 51;
            this.gridData.RowTemplate.Height = 24;
            this.gridData.Size = new System.Drawing.Size(993, 221);
            this.gridData.TabIndex = 0;
            this.gridData.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridData_CellEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboGioiTinh);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.dtNgayXuatVien);
            this.groupBox1.Controls.Add(this.dtNgayNhapVien);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dtNgaySinh);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbTenBN);
            this.groupBox1.Controls.Add(this.tbDiaChi);
            this.groupBox1.Controls.Add(this.tbTinhTrangSK);
            this.groupBox1.Controls.Add(this.tbSoDT);
            this.groupBox1.Controls.Add(this.tbMaBN);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(999, 316);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinh.Location = new System.Drawing.Point(144, 76);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(212, 24);
            this.cboGioiTinh.TabIndex = 4;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(751, 256);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(167, 36);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(568, 256);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(167, 36);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(380, 256);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(167, 36);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(202, 256);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(167, 36);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // dtNgayXuatVien
            // 
            this.dtNgayXuatVien.CustomFormat = "dd/MM/yyyy";
            this.dtNgayXuatVien.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayXuatVien.Location = new System.Drawing.Point(533, 197);
            this.dtNgayXuatVien.Name = "dtNgayXuatVien";
            this.dtNgayXuatVien.Size = new System.Drawing.Size(248, 22);
            this.dtNgayXuatVien.TabIndex = 2;
            // 
            // dtNgayNhapVien
            // 
            this.dtNgayNhapVien.CustomFormat = "dd/MM/yyyy";
            this.dtNgayNhapVien.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayNhapVien.Location = new System.Drawing.Point(144, 198);
            this.dtNgayNhapVien.Name = "dtNgayNhapVien";
            this.dtNgayNhapVien.Size = new System.Drawing.Size(212, 22);
            this.dtNgayNhapVien.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(409, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Ngày Xuất Viện";
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgaySinh.Location = new System.Drawing.Point(523, 76);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(248, 22);
            this.dtNgaySinh.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Ngày Nhập Viện";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên BN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày Sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Giới Tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Địa Chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(409, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tình Trạng SK";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Số ĐT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã BN";
            // 
            // tbTenBN
            // 
            this.tbTenBN.Location = new System.Drawing.Point(523, 33);
            this.tbTenBN.Name = "tbTenBN";
            this.tbTenBN.Size = new System.Drawing.Size(411, 22);
            this.tbTenBN.TabIndex = 0;
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Location = new System.Drawing.Point(144, 115);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(790, 22);
            this.tbDiaChi.TabIndex = 0;
            // 
            // tbTinhTrangSK
            // 
            this.tbTinhTrangSK.Location = new System.Drawing.Point(533, 154);
            this.tbTinhTrangSK.Name = "tbTinhTrangSK";
            this.tbTinhTrangSK.Size = new System.Drawing.Size(411, 22);
            this.tbTinhTrangSK.TabIndex = 0;
            // 
            // tbSoDT
            // 
            this.tbSoDT.Location = new System.Drawing.Point(144, 154);
            this.tbSoDT.Name = "tbSoDT";
            this.tbSoDT.Size = new System.Drawing.Size(212, 22);
            this.tbSoDT.TabIndex = 0;
            // 
            // tbMaBN
            // 
            this.tbMaBN.Location = new System.Drawing.Point(144, 33);
            this.tbMaBN.Name = "tbMaBN";
            this.tbMaBN.Size = new System.Drawing.Size(212, 22);
            this.tbMaBN.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaBN";
            this.Column1.HeaderText = "Mã BN";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenBN";
            this.Column2.HeaderText = "Tên BN";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "GioiTinhStr";
            this.Column3.HeaderText = "Giới Tính";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NgaySinh";
            this.Column4.HeaderText = "Ngày Sinh";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DiaChi";
            this.Column5.HeaderText = "Địa Chỉ";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SDT";
            this.Column6.HeaderText = "Số DT";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "TinhTrangSK";
            this.Column7.HeaderText = "Tình Trạng SK";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "NgayNhapVien";
            this.Column8.HeaderText = "Ngày NV";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "NgayXuatVien";
            this.Column9.HeaderText = "Ngày XV";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // FormBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 649);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormBenhNhan";
            this.Text = "BỆNH NHÂN";
            this.Load += new System.EventHandler(this.FormBenhNhan_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gridData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTenBN;
        private System.Windows.Forms.TextBox tbMaBN;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.DateTimePicker dtNgayXuatVien;
        private System.Windows.Forms.DateTimePicker dtNgayNhapVien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.TextBox tbTinhTrangSK;
        private System.Windows.Forms.TextBox tbSoDT;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}