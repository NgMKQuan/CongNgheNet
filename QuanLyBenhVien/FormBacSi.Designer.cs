namespace QuanLyBenhVien
{
    partial class FormBacSi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboChuyenKhoa = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dtNgayVaoLam = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTenBS = new System.Windows.Forms.TextBox();
            this.tbMaBS = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.gridData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboChuyenKhoa);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.dtNgayVaoLam);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbTenBS);
            this.groupBox1.Controls.Add(this.tbMaBS);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(999, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cboChuyenKhoa
            // 
            this.cboChuyenKhoa.FormattingEnabled = true;
            this.cboChuyenKhoa.Items.AddRange(new object[] {
            "Thần Kinh",
            "Lâm Sàng",
            "Y Học Cổ Truyền",
            "Ngoại Khoa"});
            this.cboChuyenKhoa.Location = new System.Drawing.Point(118, 75);
            this.cboChuyenKhoa.Name = "cboChuyenKhoa";
            this.cboChuyenKhoa.Size = new System.Drawing.Size(212, 24);
            this.cboChuyenKhoa.TabIndex = 4;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(741, 121);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(167, 36);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(558, 121);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(167, 36);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(370, 121);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(167, 36);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(192, 121);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(167, 36);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // dtNgayVaoLam
            // 
            this.dtNgayVaoLam.CustomFormat = "dd/MM/yyyy";
            this.dtNgayVaoLam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayVaoLam.Location = new System.Drawing.Point(497, 78);
            this.dtNgayVaoLam.Name = "dtNgayVaoLam";
            this.dtNgayVaoLam.Size = new System.Drawing.Size(248, 22);
            this.dtNgayVaoLam.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên BS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày Vào Làm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Chuyên Khoa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã BS";
            // 
            // tbTenBS
            // 
            this.tbTenBS.Location = new System.Drawing.Point(497, 33);
            this.tbTenBS.Name = "tbTenBS";
            this.tbTenBS.Size = new System.Drawing.Size(411, 22);
            this.tbTenBS.TabIndex = 0;
            // 
            // tbMaBS
            // 
            this.tbMaBS.Location = new System.Drawing.Point(118, 33);
            this.tbMaBS.Name = "tbMaBS";
            this.tbMaBS.Size = new System.Drawing.Size(212, 22);
            this.tbMaBS.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbSearch);
            this.groupBox2.Controls.Add(this.btnTim);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.gridData);
            this.groupBox2.Location = new System.Drawing.Point(12, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(999, 279);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(497, 21);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(212, 22);
            this.tbSearch.TabIndex = 4;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(739, 14);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(167, 36);
            this.btnTim.TabIndex = 6;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(410, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tìm theo";
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
            this.Column4});
            this.gridData.Location = new System.Drawing.Point(3, 71);
            this.gridData.Name = "gridData";
            this.gridData.RowHeadersWidth = 51;
            this.gridData.RowTemplate.Height = 24;
            this.gridData.Size = new System.Drawing.Size(993, 205);
            this.gridData.TabIndex = 0;
            this.gridData.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridData_CellEnter);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaBS";
            this.Column1.HeaderText = "Mã BS";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenBS";
            this.Column2.HeaderText = "Họ Tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ChuyenKhoa";
            this.Column3.HeaderText = "Chuyên Khoa";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NgayVaoLam";
            this.Column4.HeaderText = "Ngày Vào Lam";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // FormBacSi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 511);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormBacSi";
            this.Text = "BÁC SĨ";
            this.Load += new System.EventHandler(this.FormBacSi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbMaBS;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboChuyenKhoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker dtNgayVaoLam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTenBS;
        private System.Windows.Forms.DataGridView gridData;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}