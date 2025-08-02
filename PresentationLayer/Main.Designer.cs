using System.Drawing;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnTke = new System.Windows.Forms.Button();
            this.btnQLHoaDon = new System.Windows.Forms.Button();
            this.btnTour = new System.Windows.Forms.Button();
            this.btnQLKHang = new System.Windows.Forms.Button();
            this.btnQLNV = new System.Windows.Forms.Button();
            this.btnQLTour = new System.Windows.Forms.Button();
            this.btnQLDVu = new System.Windows.Forms.Button();
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(224)))), ((int)(((byte)(254)))));
            this.pnlSidebar.Controls.Add(this.btnTke);
            this.pnlSidebar.Controls.Add(this.btnQLHoaDon);
            this.pnlSidebar.Controls.Add(this.btnTour);
            this.pnlSidebar.Controls.Add(this.btnQLKHang);
            this.pnlSidebar.Controls.Add(this.btnQLNV);
            this.pnlSidebar.Controls.Add(this.btnQLTour);
            this.pnlSidebar.Controls.Add(this.btnQLDVu);
            this.pnlSidebar.Controls.Add(this.btnTrangChu);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(200, 850);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnTke
            // 
            this.btnTke.BackColor = System.Drawing.Color.Transparent;
            this.btnTke.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTke.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTke.FlatAppearance.BorderSize = 0;
            this.btnTke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTke.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTke.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))));
            this.btnTke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTke.Location = new System.Drawing.Point(0, 555);
            this.btnTke.Name = "btnTke";
            this.btnTke.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnTke.Size = new System.Drawing.Size(200, 73);
            this.btnTke.TabIndex = 12;
            this.btnTke.Text = "📊  Báo cáo thống kê";
            this.btnTke.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTke.UseVisualStyleBackColor = false;
            this.btnTke.Click += new System.EventHandler(this.btnTke_Click);
            // 
            // btnQLHoaDon
            // 
            this.btnQLHoaDon.BackColor = System.Drawing.Color.Transparent;
            this.btnQLHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLHoaDon.FlatAppearance.BorderSize = 0;
            this.btnQLHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLHoaDon.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))));
            this.btnQLHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLHoaDon.Location = new System.Drawing.Point(0, 482);
            this.btnQLHoaDon.Name = "btnQLHoaDon";
            this.btnQLHoaDon.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnQLHoaDon.Size = new System.Drawing.Size(200, 73);
            this.btnQLHoaDon.TabIndex = 11;
            this.btnQLHoaDon.Text = "🧾 Quản lý Hóa đơn";
            this.btnQLHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLHoaDon.UseVisualStyleBackColor = false;
            this.btnQLHoaDon.Click += new System.EventHandler(this.btnQLHoaDon_Click);
            // 
            // btnTour
            // 
            this.btnTour.BackColor = System.Drawing.Color.Transparent;
            this.btnTour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTour.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTour.FlatAppearance.BorderSize = 0;
            this.btnTour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTour.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))));
            this.btnTour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTour.Location = new System.Drawing.Point(0, 406);
            this.btnTour.Name = "btnTour";
            this.btnTour.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnTour.Size = new System.Drawing.Size(200, 76);
            this.btnTour.TabIndex = 10;
            this.btnTour.Text = "✈ Tour";
            this.btnTour.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTour.UseVisualStyleBackColor = false;
            this.btnTour.Click += new System.EventHandler(this.btnTour_Click);
            // 
            // btnQLKHang
            // 
            this.btnQLKHang.BackColor = System.Drawing.Color.Transparent;
            this.btnQLKHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLKHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLKHang.FlatAppearance.BorderSize = 0;
            this.btnQLKHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLKHang.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLKHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))));
            this.btnQLKHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLKHang.Location = new System.Drawing.Point(0, 330);
            this.btnQLKHang.Name = "btnQLKHang";
            this.btnQLKHang.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnQLKHang.Size = new System.Drawing.Size(200, 76);
            this.btnQLKHang.TabIndex = 8;
            this.btnQLKHang.Text = "🧍 Quản lý Khách hàng";
            this.btnQLKHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLKHang.UseVisualStyleBackColor = false;
            this.btnQLKHang.Click += new System.EventHandler(this.btnQLKHang_Click);
            // 
            // btnQLNV
            // 
            this.btnQLNV.BackColor = System.Drawing.Color.Transparent;
            this.btnQLNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLNV.FlatAppearance.BorderSize = 0;
            this.btnQLNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLNV.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))));
            this.btnQLNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNV.Location = new System.Drawing.Point(0, 254);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnQLNV.Size = new System.Drawing.Size(200, 76);
            this.btnQLNV.TabIndex = 7;
            this.btnQLNV.Text = "👥 Quản lý Nhân viên";
            this.btnQLNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLNV.UseVisualStyleBackColor = false;
            this.btnQLNV.Click += new System.EventHandler(this.btnQLNV_Click);
            // 
            // btnQLTour
            // 
            this.btnQLTour.BackColor = System.Drawing.Color.Transparent;
            this.btnQLTour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLTour.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLTour.FlatAppearance.BorderSize = 0;
            this.btnQLTour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLTour.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLTour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))));
            this.btnQLTour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLTour.Location = new System.Drawing.Point(0, 178);
            this.btnQLTour.Name = "btnQLTour";
            this.btnQLTour.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnQLTour.Size = new System.Drawing.Size(200, 76);
            this.btnQLTour.TabIndex = 4;
            this.btnQLTour.Text = "🌍 Quản lý Tour";
            this.btnQLTour.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLTour.UseVisualStyleBackColor = false;
            this.btnQLTour.Click += new System.EventHandler(this.btnQLTour_Click);
            // 
            // btnQLDVu
            // 
            this.btnQLDVu.BackColor = System.Drawing.Color.Transparent;
            this.btnQLDVu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLDVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLDVu.FlatAppearance.BorderSize = 0;
            this.btnQLDVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLDVu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLDVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))));
            this.btnQLDVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLDVu.Location = new System.Drawing.Point(0, 102);
            this.btnQLDVu.Name = "btnQLDVu";
            this.btnQLDVu.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnQLDVu.Size = new System.Drawing.Size(200, 76);
            this.btnQLDVu.TabIndex = 2;
            this.btnQLDVu.Text = "🗺 Quản lý Dịch vụ";
            this.btnQLDVu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLDVu.UseVisualStyleBackColor = false;
            this.btnQLDVu.Click += new System.EventHandler(this.btnQLDVu_Click);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.BackColor = System.Drawing.Color.Transparent;
            this.btnTrangChu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrangChu.BackgroundImage")));
            this.btnTrangChu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTrangChu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrangChu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrangChu.FlatAppearance.BorderSize = 0;
            this.btnTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangChu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChu.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnTrangChu.Location = new System.Drawing.Point(0, 0);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnTrangChu.Size = new System.Drawing.Size(200, 102);
            this.btnTrangChu.TabIndex = 1;
            this.btnTrangChu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrangChu.UseVisualStyleBackColor = false;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDangXuat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))));
            this.btnDangXuat.Location = new System.Drawing.Point(1129, 33);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(140, 40);
            this.btnDangXuat.TabIndex = 6;
            this.btnDangXuat.Text = "🚪 ĐĂNG XUẤT";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblUserInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUserInfo.Location = new System.Drawing.Point(821, 26);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(271, 47);
            this.lblUserInfo.TabIndex = 5;
            this.lblUserInfo.Text = "Xin chào, [Tên người dùng]";
            this.lblUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlContent
            // 
            this.pnlContent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlContent.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlContent.Location = new System.Drawing.Point(200, 94);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1310, 726);
            this.pnlContent.TabIndex = 2;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(224)))), ((int)(((byte)(254)))));
            this.pnlTop.Controls.Add(this.btnDangXuat);
            this.pnlTop.Controls.Add(this.lblUserInfo);
            this.pnlTop.Location = new System.Drawing.Point(200, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1310, 96);
            this.pnlTop.TabIndex = 0;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.pnlFooter.Controls.Add(this.lblCopyright);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(200, 820);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1310, 30);
            this.pnlFooter.TabIndex = 3;
            // 
            // lblCopyright
            // 
            this.lblCopyright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(224)))), ((int)(((byte)(254)))));
            this.lblCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCopyright.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCopyright.Location = new System.Drawing.Point(0, 0);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(1310, 30);
            this.lblCopyright.TabIndex = 0;
            this.lblCopyright.Text = "© 2025 Tour Management System. All rights reserved.";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1510, 850);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tour Management System";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.Button btnQLDVu;
        private System.Windows.Forms.Button btnQLTour;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblCopyright;
        private Button btnQLKHang;
        private Button btnQLNV;
        private Label lblUserInfo;
        private Button btnTour;
        private Button btnTke;
        private Button btnQLHoaDon;
        private Panel pnlTop;
    }
}