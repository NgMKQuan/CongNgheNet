namespace QuanLyBenhVien
{
    partial class FormNguoiDung
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
            this.gridData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboQuyen = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMatKhau = new System.Windows.Forms.TextBox();
            this.tbMaND = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridData);
            this.groupBox2.Location = new System.Drawing.Point(8, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(824, 209);
            this.groupBox2.TabIndex = 3;
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
            this.Column3});
            this.gridData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridData.Location = new System.Drawing.Point(3, 18);
            this.gridData.Name = "gridData";
            this.gridData.RowHeadersWidth = 51;
            this.gridData.RowTemplate.Height = 24;
            this.gridData.Size = new System.Drawing.Size(818, 188);
            this.gridData.TabIndex = 0;
            this.gridData.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridData_CellEnter);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaND";
            this.Column1.HeaderText = "Mã ND";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MatKhau";
            this.Column2.HeaderText = "Mật Khẩu";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Quyen";
            this.Column3.HeaderText = "Quyền";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboQuyen);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbMatKhau);
            this.groupBox1.Controls.Add(this.tbMaND);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 202);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // cboQuyen
            // 
            this.cboQuyen.FormattingEnabled = true;
            this.cboQuyen.Items.AddRange(new object[] {
            "ADMIN",
            "USER"});
            this.cboQuyen.Location = new System.Drawing.Point(457, 73);
            this.cboQuyen.Name = "cboQuyen";
            this.cboQuyen.Size = new System.Drawing.Size(212, 24);
            this.cboQuyen.TabIndex = 4;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(630, 149);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(167, 36);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(447, 149);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(167, 36);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(259, 149);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(167, 36);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(81, 149);
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
            this.label3.Location = new System.Drawing.Point(379, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Quyền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã ND";
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.Location = new System.Drawing.Point(457, 33);
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.Size = new System.Drawing.Size(212, 22);
            this.tbMatKhau.TabIndex = 0;
            // 
            // tbMaND
            // 
            this.tbMaND.Location = new System.Drawing.Point(118, 33);
            this.tbMaND.Name = "tbMaND";
            this.tbMaND.Size = new System.Drawing.Size(212, 22);
            this.tbMaND.TabIndex = 0;
            // 
            // FormNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 441);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormNguoiDung";
            this.Text = "NGƯỜI DÙNG";
            this.Load += new System.EventHandler(this.FormNguoiDung_Load);
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMaND;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMatKhau;
        private System.Windows.Forms.ComboBox cboQuyen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}