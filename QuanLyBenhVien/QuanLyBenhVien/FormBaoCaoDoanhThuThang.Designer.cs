namespace QuanLyBenhVien
{
    partial class FormBaoCaoDoanhThuThang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridData = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtTuNgay = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridData);
            this.groupBox2.Controls.Add(this.lblTongDoanhThu);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1154, 520);
            this.groupBox2.TabIndex = 9;
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
            this.gridData.Location = new System.Drawing.Point(3, 18);
            this.gridData.Name = "gridData";
            this.gridData.RowHeadersWidth = 51;
            this.gridData.RowTemplate.Height = 24;
            this.gridData.Size = new System.Drawing.Size(1145, 440);
            this.gridData.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtDenNgay);
            this.groupBox1.Controls.Add(this.dtTuNgay);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1151, 87);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // dtDenNgay
            // 
            this.dtDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDenNgay.Location = new System.Drawing.Point(477, 34);
            this.dtDenNgay.Name = "dtDenNgay";
            this.dtDenNgay.Size = new System.Drawing.Size(200, 22);
            this.dtDenNgay.TabIndex = 4;
            // 
            // dtTuNgay
            // 
            this.dtTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTuNgay.Location = new System.Drawing.Point(105, 33);
            this.dtTuNgay.Name = "dtTuNgay";
            this.dtTuNgay.Size = new System.Drawing.Size(200, 22);
            this.dtTuNgay.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(746, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(167, 36);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đến Ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ Ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(762, 484);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "TỔNG DOANH THU :";
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDoanhThu.ForeColor = System.Drawing.Color.Red;
            this.lblTongDoanhThu.Location = new System.Drawing.Point(942, 484);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(50, 16);
            this.lblTongDoanhThu.TabIndex = 1;
            this.lblTongDoanhThu.Text = "0 VNĐ";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "NgayLap";
            this.Column1.HeaderText = "Ngày";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "SLHoaDon";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "Số lượng HĐ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TongTien";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "#,###";
            dataGridViewCellStyle3.NullValue = "0";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.HeaderText = "Tổng Tiền (VNĐ)";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // FormBaoCaoDoanhThuThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 642);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormBaoCaoDoanhThuThang";
            this.Text = "BÁO CÁO DOANH THU THÁNG";
            this.Load += new System.EventHandler(this.FormBaoCaoDoanhThuThang_Load);
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
        private System.Windows.Forms.DateTimePicker dtDenNgay;
        private System.Windows.Forms.DateTimePicker dtTuNgay;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}