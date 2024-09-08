namespace QuanLyBenhVien
{
    partial class FormThuoc
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.gridData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbGiaThuoc = new System.Windows.Forms.TextBox();
            this.tbSoLuong = new System.Windows.Forms.TextBox();
            this.tbTenThuoc = new System.Windows.Forms.TextBox();
            this.tbMaThuoc = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.gridData);
            this.groupBox2.Controls.Add(this.tbSearch);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(824, 232);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(614, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(167, 36);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.gridData.Location = new System.Drawing.Point(3, 57);
            this.gridData.Name = "gridData";
            this.gridData.RowHeadersWidth = 51;
            this.gridData.RowTemplate.Height = 24;
            this.gridData.Size = new System.Drawing.Size(818, 172);
            this.gridData.TabIndex = 0;
            this.gridData.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridData_CellEnter);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaThuoc";
            this.Column1.HeaderText = "Mã thuốc";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenThuoc";
            this.Column2.HeaderText = "Tên thuốc";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SoLuong";
            this.Column3.HeaderText = "Số lượng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "GiaThuoc";
            this.Column4.HeaderText = "Giá thuốc";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(377, 21);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(212, 22);
            this.tbSearch.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tìm theo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbGiaThuoc);
            this.groupBox1.Controls.Add(this.tbSoLuong);
            this.groupBox1.Controls.Add(this.tbTenThuoc);
            this.groupBox1.Controls.Add(this.tbMaThuoc);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 181);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(605, 121);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(167, 36);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(422, 121);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(167, 36);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(234, 121);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(167, 36);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(56, 121);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(167, 36);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Giá thuốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên thuốc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã thuốc";
            // 
            // tbGiaThuoc
            // 
            this.tbGiaThuoc.Location = new System.Drawing.Point(463, 77);
            this.tbGiaThuoc.Name = "tbGiaThuoc";
            this.tbGiaThuoc.Size = new System.Drawing.Size(309, 22);
            this.tbGiaThuoc.TabIndex = 0;
            // 
            // tbSoLuong
            // 
            this.tbSoLuong.Location = new System.Drawing.Point(118, 77);
            this.tbSoLuong.Name = "tbSoLuong";
            this.tbSoLuong.Size = new System.Drawing.Size(212, 22);
            this.tbSoLuong.TabIndex = 0;
            // 
            // tbTenThuoc
            // 
            this.tbTenThuoc.Location = new System.Drawing.Point(463, 33);
            this.tbTenThuoc.Name = "tbTenThuoc";
            this.tbTenThuoc.Size = new System.Drawing.Size(309, 22);
            this.tbTenThuoc.TabIndex = 0;
            // 
            // tbMaThuoc
            // 
            this.tbMaThuoc.Location = new System.Drawing.Point(118, 33);
            this.tbMaThuoc.Name = "tbMaThuoc";
            this.tbMaThuoc.Size = new System.Drawing.Size(212, 22);
            this.tbMaThuoc.TabIndex = 0;
            // 
            // FormThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 443);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormThuoc";
            this.Text = "THUỐC";
            this.Load += new System.EventHandler(this.FormThuoc_Load);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbGiaThuoc;
        private System.Windows.Forms.TextBox tbSoLuong;
        private System.Windows.Forms.TextBox tbMaThuoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTenThuoc;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}