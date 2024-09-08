namespace QuanLyBenhVien
{
    partial class FormHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridData = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboMaDT = new System.Windows.Forms.ComboBox();
            this.cboMaBN = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dtNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTongTien = new System.Windows.Forms.TextBox();
            this.tbMaHD = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridData);
            this.groupBox2.Controls.Add(this.tbSearch);
            this.groupBox2.Controls.Add(this.btnTim);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(824, 209);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
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
            this.Column6});
            this.gridData.Location = new System.Drawing.Point(3, 71);
            this.gridData.Name = "gridData";
            this.gridData.RowHeadersWidth = 51;
            this.gridData.RowTemplate.Height = 24;
            this.gridData.Size = new System.Drawing.Size(818, 135);
            this.gridData.TabIndex = 0;
            this.gridData.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridData_CellEnter);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(381, 24);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(212, 22);
            this.tbSearch.TabIndex = 0;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(623, 17);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(167, 36);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tìm theo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboMaDT);
            this.groupBox1.Controls.Add(this.cboMaBN);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.dtNgayLap);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbTongTien);
            this.groupBox1.Controls.Add(this.tbMaHD);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 243);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // cboMaDT
            // 
            this.cboMaDT.FormattingEnabled = true;
            this.cboMaDT.Location = new System.Drawing.Point(469, 75);
            this.cboMaDT.Name = "cboMaDT";
            this.cboMaDT.Size = new System.Drawing.Size(212, 24);
            this.cboMaDT.TabIndex = 4;
            // 
            // cboMaBN
            // 
            this.cboMaBN.FormattingEnabled = true;
            this.cboMaBN.Location = new System.Drawing.Point(118, 75);
            this.cboMaBN.Name = "cboMaBN";
            this.cboMaBN.Size = new System.Drawing.Size(212, 24);
            this.cboMaBN.TabIndex = 4;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(596, 170);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(167, 36);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(413, 170);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(167, 36);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(225, 170);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(167, 36);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(47, 170);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(167, 36);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // dtNgayLap
            // 
            this.dtNgayLap.CustomFormat = "dd/MM/yyyy";
            this.dtNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayLap.Location = new System.Drawing.Point(118, 122);
            this.dtNgayLap.Name = "dtNgayLap";
            this.dtNgayLap.Size = new System.Drawing.Size(212, 22);
            this.dtNgayLap.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã ĐT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày Lập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã BN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tổng Tiền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã HĐ";
            // 
            // tbTongTien
            // 
            this.tbTongTien.Location = new System.Drawing.Point(469, 121);
            this.tbTongTien.Name = "tbTongTien";
            this.tbTongTien.Size = new System.Drawing.Size(212, 22);
            this.tbTongTien.TabIndex = 0;
            // 
            // tbMaHD
            // 
            this.tbMaHD.Location = new System.Drawing.Point(118, 33);
            this.tbMaHD.Name = "tbMaHD";
            this.tbMaHD.Size = new System.Drawing.Size(212, 22);
            this.tbMaHD.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaHD";
            this.Column1.HeaderText = "Mã HĐ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaBN";
            this.Column2.HeaderText = "Mã BN";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TenBN";
            this.Column3.HeaderText = "Tên BN";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MaDT";
            this.Column4.HeaderText = "Mã ĐT";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NgayLap";
            this.Column5.HeaderText = "Ngày Lập";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TongTien";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "#,###";
            dataGridViewCellStyle2.NullValue = "0";
            this.Column6.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column6.HeaderText = "Tổng Tiền (VNĐ)";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 479);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormHoaDon";
            this.Text = "HOÁ ĐƠN";
            this.Load += new System.EventHandler(this.FormHoaDon_Load);
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
        private System.Windows.Forms.ComboBox cboMaBN;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DateTimePicker dtNgayLap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMaHD;
        private System.Windows.Forms.ComboBox cboMaDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTongTien;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}