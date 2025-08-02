using System.Windows.Forms;

namespace PresentationLayer
{
    partial class Tours
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbTTTour = new System.Windows.Forms.GroupBox();
            this.lbTGKT = new System.Windows.Forms.Label();
            this.ptbAnhTour = new System.Windows.Forms.PictureBox();
            this.lbPT = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbphuongtien = new System.Windows.Forms.Label();
            this.lbGiaTour = new System.Windows.Forms.Label();
            this.lbDiemXP = new System.Windows.Forms.Label();
            this.lbMaTour = new System.Windows.Forms.Label();
            this.lbxuatphat = new System.Windows.Forms.Label();
            this.lbIDTour = new System.Windows.Forms.Label();
            this.lbthoigian = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.lbTGBatDau = new System.Windows.Forms.Label();
            this.lbMaLoaiTour = new System.Windows.Forms.Label();
            this.lbTenTour = new System.Windows.Forms.Label();
            this.lbTGKetThuc = new System.Windows.Forms.Label();
            this.btnDatTour = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvTTTour = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboLoaiTour = new System.Windows.Forms.ComboBox();
            this.txtTimTour = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.lbTim = new System.Windows.Forms.Label();
            this.grbTTTour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnhTour)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTTour)).BeginInit();
            this.SuspendLayout();
            // 
            // grbTTTour
            // 
            this.grbTTTour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.grbTTTour.Controls.Add(this.lbTGKT);
            this.grbTTTour.Controls.Add(this.ptbAnhTour);
            this.grbTTTour.Controls.Add(this.lbPT);
            this.grbTTTour.Controls.Add(this.lbPrice);
            this.grbTTTour.Controls.Add(this.lbphuongtien);
            this.grbTTTour.Controls.Add(this.lbGiaTour);
            this.grbTTTour.Controls.Add(this.lbDiemXP);
            this.grbTTTour.Controls.Add(this.lbMaTour);
            this.grbTTTour.Controls.Add(this.lbxuatphat);
            this.grbTTTour.Controls.Add(this.lbIDTour);
            this.grbTTTour.Controls.Add(this.lbthoigian);
            this.grbTTTour.Controls.Add(this.lbType);
            this.grbTTTour.Controls.Add(this.lbTGBatDau);
            this.grbTTTour.Controls.Add(this.lbMaLoaiTour);
            this.grbTTTour.Controls.Add(this.lbTenTour);
            this.grbTTTour.Controls.Add(this.lbTGKetThuc);
            this.grbTTTour.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbTTTour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(150)))));
            this.grbTTTour.Location = new System.Drawing.Point(27, 322);
            this.grbTTTour.Name = "grbTTTour";
            this.grbTTTour.Size = new System.Drawing.Size(1233, 354);
            this.grbTTTour.TabIndex = 50;
            this.grbTTTour.TabStop = false;
            this.grbTTTour.Text = "Thông tin tour";
            // 
            // lbTGKT
            // 
            this.lbTGKT.AutoSize = true;
            this.lbTGKT.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTGKT.ForeColor = System.Drawing.Color.Black;
            this.lbTGKT.Location = new System.Drawing.Point(581, 264);
            this.lbTGKT.Name = "lbTGKT";
            this.lbTGKT.Size = new System.Drawing.Size(122, 28);
            this.lbTGKT.TabIndex = 99;
            this.lbTGKT.Text = "TG kết thúc:";
            // 
            // ptbAnhTour
            // 
            this.ptbAnhTour.Location = new System.Drawing.Point(36, 69);
            this.ptbAnhTour.Margin = new System.Windows.Forms.Padding(4);
            this.ptbAnhTour.Name = "ptbAnhTour";
            this.ptbAnhTour.Size = new System.Drawing.Size(501, 271);
            this.ptbAnhTour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAnhTour.TabIndex = 94;
            this.ptbAnhTour.TabStop = false;
            // 
            // lbPT
            // 
            this.lbPT.AutoSize = true;
            this.lbPT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPT.ForeColor = System.Drawing.Color.Black;
            this.lbPT.Location = new System.Drawing.Point(788, 140);
            this.lbPT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPT.Name = "lbPT";
            this.lbPT.Size = new System.Drawing.Size(119, 28);
            this.lbPT.TabIndex = 86;
            this.lbPT.Text = "Phương tiện";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPrice.ForeColor = System.Drawing.Color.Black;
            this.lbPrice.Location = new System.Drawing.Point(581, 305);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(91, 28);
            this.lbPrice.TabIndex = 96;
            this.lbPrice.Text = "Giá tour:";
            // 
            // lbphuongtien
            // 
            this.lbphuongtien.AutoSize = true;
            this.lbphuongtien.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbphuongtien.ForeColor = System.Drawing.Color.Black;
            this.lbphuongtien.Location = new System.Drawing.Point(580, 140);
            this.lbphuongtien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbphuongtien.Name = "lbphuongtien";
            this.lbphuongtien.Size = new System.Drawing.Size(164, 28);
            this.lbphuongtien.TabIndex = 89;
            this.lbphuongtien.Text = "Mã phương tiện:";
            // 
            // lbGiaTour
            // 
            this.lbGiaTour.AutoSize = true;
            this.lbGiaTour.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbGiaTour.ForeColor = System.Drawing.Color.Black;
            this.lbGiaTour.Location = new System.Drawing.Point(788, 305);
            this.lbGiaTour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGiaTour.Name = "lbGiaTour";
            this.lbGiaTour.Size = new System.Drawing.Size(0, 28);
            this.lbGiaTour.TabIndex = 84;
            // 
            // lbDiemXP
            // 
            this.lbDiemXP.AutoSize = true;
            this.lbDiemXP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDiemXP.ForeColor = System.Drawing.Color.Black;
            this.lbDiemXP.Location = new System.Drawing.Point(788, 181);
            this.lbDiemXP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDiemXP.Name = "lbDiemXP";
            this.lbDiemXP.Size = new System.Drawing.Size(97, 28);
            this.lbDiemXP.TabIndex = 87;
            this.lbDiemXP.Text = "Xuất phát";
            // 
            // lbMaTour
            // 
            this.lbMaTour.AutoSize = true;
            this.lbMaTour.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaTour.ForeColor = System.Drawing.Color.Black;
            this.lbMaTour.Location = new System.Drawing.Point(788, 58);
            this.lbMaTour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaTour.Name = "lbMaTour";
            this.lbMaTour.Size = new System.Drawing.Size(82, 28);
            this.lbMaTour.TabIndex = 85;
            this.lbMaTour.Text = "Mã tour";
            // 
            // lbxuatphat
            // 
            this.lbxuatphat.AutoSize = true;
            this.lbxuatphat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbxuatphat.ForeColor = System.Drawing.Color.Black;
            this.lbxuatphat.Location = new System.Drawing.Point(579, 181);
            this.lbxuatphat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbxuatphat.Name = "lbxuatphat";
            this.lbxuatphat.Size = new System.Drawing.Size(163, 28);
            this.lbxuatphat.TabIndex = 88;
            this.lbxuatphat.Text = "Điểm xuất phát: ";
            // 
            // lbIDTour
            // 
            this.lbIDTour.AutoSize = true;
            this.lbIDTour.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbIDTour.ForeColor = System.Drawing.Color.Black;
            this.lbIDTour.Location = new System.Drawing.Point(580, 58);
            this.lbIDTour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIDTour.Name = "lbIDTour";
            this.lbIDTour.Size = new System.Drawing.Size(90, 28);
            this.lbIDTour.TabIndex = 95;
            this.lbIDTour.Text = "Mã tour:";
            // 
            // lbthoigian
            // 
            this.lbthoigian.AutoSize = true;
            this.lbthoigian.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbthoigian.ForeColor = System.Drawing.Color.Black;
            this.lbthoigian.Location = new System.Drawing.Point(581, 220);
            this.lbthoigian.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbthoigian.Name = "lbthoigian";
            this.lbthoigian.Size = new System.Drawing.Size(116, 28);
            this.lbthoigian.TabIndex = 91;
            this.lbthoigian.Text = "TG bắt đầu:";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbType.ForeColor = System.Drawing.Color.Black;
            this.lbType.Location = new System.Drawing.Point(580, 96);
            this.lbType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(130, 28);
            this.lbType.TabIndex = 97;
            this.lbType.Text = "Mã loại Tour:";
            // 
            // lbTGBatDau
            // 
            this.lbTGBatDau.AutoSize = true;
            this.lbTGBatDau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTGBatDau.ForeColor = System.Drawing.Color.Black;
            this.lbTGBatDau.Location = new System.Drawing.Point(788, 220);
            this.lbTGBatDau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTGBatDau.Name = "lbTGBatDau";
            this.lbTGBatDau.Size = new System.Drawing.Size(97, 28);
            this.lbTGBatDau.TabIndex = 90;
            this.lbTGBatDau.Text = "Xuất phát";
            // 
            // lbMaLoaiTour
            // 
            this.lbMaLoaiTour.AutoSize = true;
            this.lbMaLoaiTour.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaLoaiTour.ForeColor = System.Drawing.Color.Black;
            this.lbMaLoaiTour.Location = new System.Drawing.Point(788, 96);
            this.lbMaLoaiTour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaLoaiTour.Name = "lbMaLoaiTour";
            this.lbMaLoaiTour.Size = new System.Drawing.Size(90, 28);
            this.lbMaLoaiTour.TabIndex = 93;
            this.lbMaLoaiTour.Text = "Loại tour";
            // 
            // lbTenTour
            // 
            this.lbTenTour.AutoSize = true;
            this.lbTenTour.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTenTour.ForeColor = System.Drawing.Color.Red;
            this.lbTenTour.Location = new System.Drawing.Point(105, 27);
            this.lbTenTour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenTour.Name = "lbTenTour";
            this.lbTenTour.Size = new System.Drawing.Size(0, 38);
            this.lbTenTour.TabIndex = 83;
            // 
            // lbTGKetThuc
            // 
            this.lbTGKetThuc.AutoSize = true;
            this.lbTGKetThuc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTGKetThuc.ForeColor = System.Drawing.Color.Black;
            this.lbTGKetThuc.Location = new System.Drawing.Point(788, 264);
            this.lbTGKetThuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTGKetThuc.Name = "lbTGKetThuc";
            this.lbTGKetThuc.Size = new System.Drawing.Size(84, 28);
            this.lbTGKetThuc.TabIndex = 92;
            this.lbTGKetThuc.Text = "Kết thúc";
            // 
            // btnDatTour
            // 
            this.btnDatTour.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDatTour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatTour.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDatTour.ForeColor = System.Drawing.Color.White;
            this.btnDatTour.Location = new System.Drawing.Point(1081, 283);
            this.btnDatTour.Margin = new System.Windows.Forms.Padding(4);
            this.btnDatTour.Name = "btnDatTour";
            this.btnDatTour.Size = new System.Drawing.Size(179, 50);
            this.btnDatTour.TabIndex = 100;
            this.btnDatTour.Text = "Đặt Tour";
            this.btnDatTour.UseVisualStyleBackColor = false;
            this.btnDatTour.Click += new System.EventHandler(this.btnDatTour_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnDatTour);
            this.panel1.Controls.Add(this.grbTTTour);
            this.panel1.Controls.Add(this.dgvTTTour);
            this.panel1.Controls.Add(this.cboLoaiTour);
            this.panel1.Controls.Add(this.txtTimTour);
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.lbTim);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1292, 679);
            this.panel1.TabIndex = 15;
            // 
            // dgvTTTour
            // 
            this.dgvTTTour.AllowUserToAddRows = false;
            this.dgvTTTour.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTTTour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTTTour.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTTTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTTour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dgvTTTour.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTTTour.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTTTour.Location = new System.Drawing.Point(27, 79);
            this.dgvTTTour.Name = "dgvTTTour";
            this.dgvTTTour.RowHeadersWidth = 51;
            this.dgvTTTour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTTTour.Size = new System.Drawing.Size(1233, 197);
            this.dgvTTTour.TabIndex = 49;
            this.dgvTTTour.UseWaitCursor = true;
            this.dgvTTTour.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTTTour_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MaTour";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Mã tour";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "TenTour";
            this.Column2.FillWeight = 120F;
            this.Column2.HeaderText = "Tên tour";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "MoTaTour";
            this.Column3.FillWeight = 130F;
            this.Column3.HeaderText = "Mô tả tour";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "AnhTour";
            this.Column4.HeaderText = "Ảnh tour";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "GiaTour";
            this.Column5.HeaderText = "Giá tour";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "TGBatDau";
            this.Column6.FillWeight = 120F;
            this.Column6.HeaderText = "TG  bắt đầu";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "TGKetThuc";
            this.Column7.FillWeight = 120F;
            this.Column7.HeaderText = "TG kết thúc";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.DataPropertyName = "MaLoaiTour";
            this.Column8.HeaderText = "Mã loại tour";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.DataPropertyName = "MaPhuongTien";
            this.Column9.HeaderText = "Mã PT";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column10.DataPropertyName = "MaXP";
            this.Column10.HeaderText = "Mã XP";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "MaDDL";
            this.Column11.HeaderText = "Mã DDL";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 125;
            // 
            // cboLoaiTour
            // 
            this.cboLoaiTour.BackColor = System.Drawing.Color.MidnightBlue;
            this.cboLoaiTour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboLoaiTour.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboLoaiTour.ForeColor = System.Drawing.Color.White;
            this.cboLoaiTour.FormattingEnabled = true;
            this.cboLoaiTour.Items.AddRange(new object[] {
            "Trong Nước",
            "Ngoài Nước"});
            this.cboLoaiTour.Location = new System.Drawing.Point(27, 29);
            this.cboLoaiTour.Margin = new System.Windows.Forms.Padding(4);
            this.cboLoaiTour.Name = "cboLoaiTour";
            this.cboLoaiTour.Size = new System.Drawing.Size(228, 34);
            this.cboLoaiTour.TabIndex = 48;
            this.cboLoaiTour.Text = "Lọc theo loại tour";
            this.cboLoaiTour.SelectedIndexChanged += new System.EventHandler(this.cboLoaiTour_SelectedIndexChanged);
            // 
            // txtTimTour
            // 
            this.txtTimTour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTimTour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtTimTour.Location = new System.Drawing.Point(774, 26);
            this.txtTimTour.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimTour.Name = "txtTimTour";
            this.txtTimTour.Size = new System.Drawing.Size(329, 31);
            this.txtTimTour.TabIndex = 45;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(1135, 22);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(112, 41);
            this.btnTim.TabIndex = 46;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // lbTim
            // 
            this.lbTim.AutoSize = true;
            this.lbTim.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTim.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbTim.Location = new System.Drawing.Point(607, 29);
            this.lbTim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTim.Name = "lbTim";
            this.lbTim.Size = new System.Drawing.Size(147, 28);
            this.lbTim.TabIndex = 47;
            this.lbTim.Text = "Nhập tên tour:";
            // 
            // Tours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 679);
            this.Controls.Add(this.panel1);
            this.Name = "Tours";
            this.Text = "Tour";
            this.Load += new System.EventHandler(this.Tour_Load);
            this.grbTTTour.ResumeLayout(false);
            this.grbTTTour.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnhTour)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTTour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grbTTTour;
        private Button btnDatTour;
        private Label lbTGKT;
        private PictureBox ptbAnhTour;
        private Label lbPT;
        private Label lbPrice;
        private Label lbphuongtien;
        private Label lbGiaTour;
        private Label lbDiemXP;
        private Label lbMaTour;
        private Label lbxuatphat;
        private Label lbIDTour;
        private Label lbthoigian;
        private Label lbType;
        private Label lbTGBatDau;
        private Label lbMaLoaiTour;
        private Label lbTenTour;
        private Label lbTGKetThuc;
        private ImageList imageList1;
        private Panel panel1;
        private DataGridView dgvTTTour;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private ComboBox cboLoaiTour;
        private TextBox txtTimTour;
        private Button btnTim;
        private Label lbTim;
    }
}