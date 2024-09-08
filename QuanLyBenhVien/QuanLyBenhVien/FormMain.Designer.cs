namespace QuanLyBenhVien
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.bệnhNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bácSĩToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngBệnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thuốcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ngườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.đơnThuốcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hoáĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêĐơnThuốcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêBệnhNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêThuốcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêDoanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem,
            this.mnuDanhMuc,
            this.mnuQuanLy,
            this.mnuThongKe,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1065, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thoátToolStripMenuItem.Image")));
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // mnuDanhMuc
            // 
            this.mnuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bệnhNhânToolStripMenuItem,
            this.bácSĩToolStripMenuItem,
            this.phòngBệnhToolStripMenuItem,
            this.thuốcToolStripMenuItem,
            this.ngườiDùngToolStripMenuItem});
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Size = new System.Drawing.Size(74, 20);
            this.mnuDanhMuc.Text = "Danh mục";
            // 
            // bệnhNhânToolStripMenuItem
            // 
            this.bệnhNhânToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bệnhNhânToolStripMenuItem.Image")));
            this.bệnhNhânToolStripMenuItem.Name = "bệnhNhânToolStripMenuItem";
            this.bệnhNhânToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.bệnhNhânToolStripMenuItem.Text = "Bệnh Nhân";
            this.bệnhNhânToolStripMenuItem.Click += new System.EventHandler(this.bệnhNhânToolStripMenuItem_Click);
            // 
            // bácSĩToolStripMenuItem
            // 
            this.bácSĩToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bácSĩToolStripMenuItem.Image")));
            this.bácSĩToolStripMenuItem.Name = "bácSĩToolStripMenuItem";
            this.bácSĩToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.bácSĩToolStripMenuItem.Text = "Bác Sĩ";
            this.bácSĩToolStripMenuItem.Click += new System.EventHandler(this.bácSĩToolStripMenuItem_Click);
            // 
            // phòngBệnhToolStripMenuItem
            // 
            this.phòngBệnhToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("phòngBệnhToolStripMenuItem.Image")));
            this.phòngBệnhToolStripMenuItem.Name = "phòngBệnhToolStripMenuItem";
            this.phòngBệnhToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.phòngBệnhToolStripMenuItem.Text = "Phòng Bệnh";
            this.phòngBệnhToolStripMenuItem.Click += new System.EventHandler(this.phòngBệnhToolStripMenuItem_Click);
            // 
            // thuốcToolStripMenuItem
            // 
            this.thuốcToolStripMenuItem.Name = "thuốcToolStripMenuItem";
            this.thuốcToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.thuốcToolStripMenuItem.Text = "Thuốc";
            this.thuốcToolStripMenuItem.Click += new System.EventHandler(this.thuốcToolStripMenuItem_Click);
            // 
            // ngườiDùngToolStripMenuItem
            // 
            this.ngườiDùngToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ngườiDùngToolStripMenuItem.Image")));
            this.ngườiDùngToolStripMenuItem.Name = "ngườiDùngToolStripMenuItem";
            this.ngườiDùngToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.ngườiDùngToolStripMenuItem.Text = "Người dùng";
            this.ngườiDùngToolStripMenuItem.Click += new System.EventHandler(this.ngườiDùngToolStripMenuItem_Click);
            // 
            // mnuQuanLy
            // 
            this.mnuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đơnThuốcToolStripMenuItem,
            this.hoáĐơnToolStripMenuItem});
            this.mnuQuanLy.Name = "mnuQuanLy";
            this.mnuQuanLy.Size = new System.Drawing.Size(60, 20);
            this.mnuQuanLy.Text = "Quản lý";
            // 
            // đơnThuốcToolStripMenuItem
            // 
            this.đơnThuốcToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("đơnThuốcToolStripMenuItem.Image")));
            this.đơnThuốcToolStripMenuItem.Name = "đơnThuốcToolStripMenuItem";
            this.đơnThuốcToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.đơnThuốcToolStripMenuItem.Text = "Đơn Thuốc";
            this.đơnThuốcToolStripMenuItem.Click += new System.EventHandler(this.đơnThuốcToolStripMenuItem_Click);
            // 
            // hoáĐơnToolStripMenuItem
            // 
            this.hoáĐơnToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hoáĐơnToolStripMenuItem.Image")));
            this.hoáĐơnToolStripMenuItem.Name = "hoáĐơnToolStripMenuItem";
            this.hoáĐơnToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.hoáĐơnToolStripMenuItem.Text = "Hoá Đơn";
            this.hoáĐơnToolStripMenuItem.Click += new System.EventHandler(this.hoáĐơnToolStripMenuItem_Click);
            // 
            // mnuThongKe
            // 
            this.mnuThongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thốngKêĐơnThuốcToolStripMenuItem,
            this.thốngKêBệnhNhânToolStripMenuItem,
            this.thốngKêThuốcToolStripMenuItem,
            this.thốngKêDoanhThuToolStripMenuItem});
            this.mnuThongKe.Name = "mnuThongKe";
            this.mnuThongKe.Size = new System.Drawing.Size(68, 20);
            this.mnuThongKe.Text = "Thống kê";
            // 
            // thốngKêĐơnThuốcToolStripMenuItem
            // 
            this.thốngKêĐơnThuốcToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thốngKêĐơnThuốcToolStripMenuItem.Image")));
            this.thốngKêĐơnThuốcToolStripMenuItem.Name = "thốngKêĐơnThuốcToolStripMenuItem";
            this.thốngKêĐơnThuốcToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.thốngKêĐơnThuốcToolStripMenuItem.Text = "Thống kê đơn thuốc";
            this.thốngKêĐơnThuốcToolStripMenuItem.Click += new System.EventHandler(this.thốngKêĐơnThuốcToolStripMenuItem_Click);
            // 
            // thốngKêBệnhNhânToolStripMenuItem
            // 
            this.thốngKêBệnhNhânToolStripMenuItem.Name = "thốngKêBệnhNhânToolStripMenuItem";
            this.thốngKêBệnhNhânToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.thốngKêBệnhNhânToolStripMenuItem.Text = "Thống kê bệnh nhân";
            this.thốngKêBệnhNhânToolStripMenuItem.Click += new System.EventHandler(this.thốngKêBệnhNhânToolStripMenuItem_Click);
            // 
            // thốngKêThuốcToolStripMenuItem
            // 
            this.thốngKêThuốcToolStripMenuItem.Name = "thốngKêThuốcToolStripMenuItem";
            this.thốngKêThuốcToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.thốngKêThuốcToolStripMenuItem.Text = "Thống kê thuốc";
            this.thốngKêThuốcToolStripMenuItem.Click += new System.EventHandler(this.thốngKêThuốcToolStripMenuItem_Click);
            // 
            // thốngKêDoanhThuToolStripMenuItem
            // 
            this.thốngKêDoanhThuToolStripMenuItem.Name = "thốngKêDoanhThuToolStripMenuItem";
            this.thốngKêDoanhThuToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.thốngKêDoanhThuToolStripMenuItem.Text = "Thống kê doanh thu";
            this.thốngKêDoanhThuToolStripMenuItem.Click += new System.EventHandler(this.thốngKêDoanhThuToolStripMenuItem_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            this.trợGiúpToolStripMenuItem.Click += new System.EventHandler(this.trợGiúpToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1065, 586);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ BỆNH VIỆN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem mnuThongKe;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bệnhNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bácSĩToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phòngBệnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thuốcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ngườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đơnThuốcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hoáĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêĐơnThuốcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêBệnhNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêThuốcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêDoanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
    }
}

