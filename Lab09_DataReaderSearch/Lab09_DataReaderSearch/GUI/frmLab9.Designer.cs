namespace Lab09_DataReaderSearch.GUI
{
    partial class frmLab9
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.btnKetNoi = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnCaiDat = new System.Windows.Forms.Button();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.btnLopHoc = new System.Windows.Forms.Button();
            this.btnSinhVien = new System.Windows.Forms.Button();
            this.btnTongQuan = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblNgay = new System.Windows.Forms.Label();
            this.pnlCard1 = new System.Windows.Forms.Panel();
            this.pnlCard2 = new System.Windows.Forms.Panel();
            this.pnlCard3 = new System.Windows.Forms.Panel();
            this.pnlCard4 = new System.Windows.Forms.Panel();
            this.lblSoSinhVien = new System.Windows.Forms.Label();
            this.lblGiaTriSinhVien = new System.Windows.Forms.Label();
            this.lblSoLop = new System.Windows.Forms.Label();
            this.lblGiaTriLop = new System.Windows.Forms.Label();
            this.lblSoNam = new System.Windows.Forms.Label();
            this.lblGiaTriNam = new System.Windows.Forms.Label();
            this.lblSoNu = new System.Windows.Forms.Label();
            this.lblGiaTriNu = new System.Windows.Forms.Label();
            this.pnlTimKiem = new System.Windows.Forms.Panel();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.pnlChiTiet = new System.Windows.Forms.Panel();
            this.lblTieuDeChiTiet = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.txtDiemTB = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnTrangTruoc = new System.Windows.Forms.Button();
            this.btnTrangSau = new System.Windows.Forms.Button();
            this.lblTrang = new System.Windows.Forms.Label();
            this.lblDiemTu = new System.Windows.Forms.Label();
            this.lblDiemDen = new System.Windows.Forms.Label();
            this.txtDiemTu = new System.Windows.Forms.TextBox();
            this.txtDiemDen = new System.Windows.Forms.TextBox();
            this.pnlHeader.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlCard1.SuspendLayout();
            this.pnlCard2.SuspendLayout();
            this.pnlCard3.SuspendLayout();
            this.pnlCard4.SuspendLayout();
            this.pnlTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.pnlChiTiet.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblTieuDe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTieuDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTieuDe.Location = new System.Drawing.Point(898, 9);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(272, 22);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "KIỂM TRA KẾT NỐI SQL SERVER";
            this.lblTieuDe.Click += new System.EventHandler(this.lblTieuDe_Click);
            // 
            // btnKetNoi
            // 
            this.btnKetNoi.BackColor = System.Drawing.SystemColors.Control;
            this.btnKetNoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKetNoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetNoi.ForeColor = System.Drawing.Color.Navy;
            this.btnKetNoi.Location = new System.Drawing.Point(944, 35);
            this.btnKetNoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKetNoi.Name = "btnKetNoi";
            this.btnKetNoi.Size = new System.Drawing.Size(180, 40);
            this.btnKetNoi.TabIndex = 1;
            this.btnKetNoi.Text = "Kiểm tra kết nối";
            this.btnKetNoi.UseVisualStyleBackColor = false;
            this.btnKetNoi.Click += new System.EventHandler(this.btnKetNoi_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Navy;
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.btnKetNoi);
            this.pnlHeader.Controls.Add(this.lbl);
            this.pnlHeader.Controls.Add(this.lblTieuDe);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1439, 80);
            this.pnlHeader.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "HỆ THỐNG QUẢN LÍ SINH VIÊN";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Navy;
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Location = new System.Drawing.Point(3, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(382, 41);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "STUDENT MANAGEMENT";
            this.lbl.Click += new System.EventHandler(this.lbl_Click);
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.Navy;
            this.pnlSidebar.Controls.Add(this.btnCaiDat);
            this.pnlSidebar.Controls.Add(this.btnTraCuu);
            this.pnlSidebar.Controls.Add(this.btnLopHoc);
            this.pnlSidebar.Controls.Add(this.btnSinhVien);
            this.pnlSidebar.Controls.Add(this.btnTongQuan);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 80);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(230, 811);
            this.pnlSidebar.TabIndex = 3;
            // 
            // btnCaiDat
            // 
            this.btnCaiDat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.btnCaiDat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaiDat.ForeColor = System.Drawing.Color.White;
            this.btnCaiDat.Location = new System.Drawing.Point(10, 345);
            this.btnCaiDat.Name = "btnCaiDat";
            this.btnCaiDat.Size = new System.Drawing.Size(210, 45);
            this.btnCaiDat.TabIndex = 8;
            this.btnCaiDat.Text = "Cài đặt";
            this.btnCaiDat.UseVisualStyleBackColor = false;
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.btnTraCuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuu.ForeColor = System.Drawing.Color.White;
            this.btnTraCuu.Location = new System.Drawing.Point(10, 290);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(210, 45);
            this.btnTraCuu.TabIndex = 7;
            this.btnTraCuu.Text = "\tTra cứu sinh viên";
            this.btnTraCuu.UseVisualStyleBackColor = false;
            // 
            // btnLopHoc
            // 
            this.btnLopHoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.btnLopHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLopHoc.ForeColor = System.Drawing.Color.White;
            this.btnLopHoc.Location = new System.Drawing.Point(10, 235);
            this.btnLopHoc.Name = "btnLopHoc";
            this.btnLopHoc.Size = new System.Drawing.Size(210, 45);
            this.btnLopHoc.TabIndex = 6;
            this.btnLopHoc.Text = "Quản lý lớp học";
            this.btnLopHoc.UseVisualStyleBackColor = false;
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.btnSinhVien.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSinhVien.FlatAppearance.BorderSize = 0;
            this.btnSinhVien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSinhVien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSinhVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinhVien.ForeColor = System.Drawing.Color.White;
            this.btnSinhVien.Location = new System.Drawing.Point(10, 180);
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.Size = new System.Drawing.Size(210, 45);
            this.btnSinhVien.TabIndex = 5;
            this.btnSinhVien.Text = "\tQuản lý sinh viên";
            this.btnSinhVien.UseVisualStyleBackColor = false;
            // 
            // btnTongQuan
            // 
            this.btnTongQuan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.btnTongQuan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTongQuan.FlatAppearance.BorderSize = 0;
            this.btnTongQuan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnTongQuan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTongQuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTongQuan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTongQuan.ForeColor = System.Drawing.Color.White;
            this.btnTongQuan.Location = new System.Drawing.Point(10, 125);
            this.btnTongQuan.Name = "btnTongQuan";
            this.btnTongQuan.Size = new System.Drawing.Size(210, 45);
            this.btnTongQuan.TabIndex = 4;
            this.btnTongQuan.Text = "Tổng quan";
            this.btnTongQuan.UseVisualStyleBackColor = false;
            this.btnTongQuan.Click += new System.EventHandler(this.btnTongQuan_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(251)))));
            this.pnlMain.Controls.Add(this.lblTrang);
            this.pnlMain.Controls.Add(this.btnTrangSau);
            this.pnlMain.Controls.Add(this.btnTrangTruoc);
            this.pnlMain.Controls.Add(this.pnlChiTiet);
            this.pnlMain.Controls.Add(this.dgvSinhVien);
            this.pnlMain.Controls.Add(this.pnlTimKiem);
            this.pnlMain.Controls.Add(this.pnlCard4);
            this.pnlMain.Controls.Add(this.pnlCard3);
            this.pnlMain.Controls.Add(this.pnlCard2);
            this.pnlMain.Controls.Add(this.pnlCard1);
            this.pnlMain.Controls.Add(this.pnlTop);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.ForeColor = System.Drawing.Color.Gray;
            this.pnlMain.Location = new System.Drawing.Point(230, 80);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1209, 811);
            this.pnlMain.TabIndex = 4;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.lblNgay);
            this.pnlTop.Controls.Add(this.lblWelcome);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1209, 85);
            this.pnlTop.TabIndex = 0;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.lblWelcome.Location = new System.Drawing.Point(25, 15);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(306, 38);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "\tXin chào, Quản trị viên!";
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Location = new System.Drawing.Point(27, 48);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(221, 20);
            this.lblNgay.TabIndex = 1;
            this.lblNgay.Text = "HỆ THỐNG QUẢN LÝ SINH VIÊN";
            // 
            // pnlCard1
            // 
            this.pnlCard1.BackColor = System.Drawing.Color.White;
            this.pnlCard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard1.Controls.Add(this.lblGiaTriSinhVien);
            this.pnlCard1.Controls.Add(this.lblSoSinhVien);
            this.pnlCard1.Location = new System.Drawing.Point(25, 115);
            this.pnlCard1.Name = "pnlCard1";
            this.pnlCard1.Size = new System.Drawing.Size(200, 130);
            this.pnlCard1.TabIndex = 1;
            // 
            // pnlCard2
            // 
            this.pnlCard2.BackColor = System.Drawing.Color.White;
            this.pnlCard2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard2.Controls.Add(this.lblGiaTriLop);
            this.pnlCard2.Controls.Add(this.lblSoLop);
            this.pnlCard2.Location = new System.Drawing.Point(245, 115);
            this.pnlCard2.Name = "pnlCard2";
            this.pnlCard2.Size = new System.Drawing.Size(200, 130);
            this.pnlCard2.TabIndex = 2;
            // 
            // pnlCard3
            // 
            this.pnlCard3.BackColor = System.Drawing.Color.White;
            this.pnlCard3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard3.Controls.Add(this.lblGiaTriNam);
            this.pnlCard3.Controls.Add(this.lblSoNam);
            this.pnlCard3.Location = new System.Drawing.Point(465, 115);
            this.pnlCard3.Name = "pnlCard3";
            this.pnlCard3.Size = new System.Drawing.Size(200, 130);
            this.pnlCard3.TabIndex = 3;
            // 
            // pnlCard4
            // 
            this.pnlCard4.BackColor = System.Drawing.Color.White;
            this.pnlCard4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard4.Controls.Add(this.lblGiaTriNu);
            this.pnlCard4.Controls.Add(this.lblSoNu);
            this.pnlCard4.Location = new System.Drawing.Point(685, 115);
            this.pnlCard4.Name = "pnlCard4";
            this.pnlCard4.Size = new System.Drawing.Size(200, 130);
            this.pnlCard4.TabIndex = 4;
            // 
            // lblSoSinhVien
            // 
            this.lblSoSinhVien.AutoSize = true;
            this.lblSoSinhVien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSoSinhVien.Location = new System.Drawing.Point(15, 15);
            this.lblSoSinhVien.Name = "lblSoSinhVien";
            this.lblSoSinhVien.Size = new System.Drawing.Size(147, 23);
            this.lblSoSinhVien.TabIndex = 0;
            this.lblSoSinhVien.Text = "\tTỔNG SINH VIÊN";
            // 
            // lblGiaTriSinhVien
            // 
            this.lblGiaTriSinhVien.AutoSize = true;
            this.lblGiaTriSinhVien.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaTriSinhVien.ForeColor = System.Drawing.Color.Navy;
            this.lblGiaTriSinhVien.Location = new System.Drawing.Point(15, 50);
            this.lblGiaTriSinhVien.Name = "lblGiaTriSinhVien";
            this.lblGiaTriSinhVien.Size = new System.Drawing.Size(92, 54);
            this.lblGiaTriSinhVien.TabIndex = 1;
            this.lblGiaTriSinhVien.Text = "120";
            // 
            // lblSoLop
            // 
            this.lblSoLop.AutoSize = true;
            this.lblSoLop.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLop.Location = new System.Drawing.Point(15, 15);
            this.lblSoLop.Name = "lblSoLop";
            this.lblSoLop.Size = new System.Drawing.Size(123, 23);
            this.lblSoLop.TabIndex = 0;
            this.lblSoLop.Text = "TỔNG SỐ LỚP";
            // 
            // lblGiaTriLop
            // 
            this.lblGiaTriLop.AutoSize = true;
            this.lblGiaTriLop.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaTriLop.ForeColor = System.Drawing.Color.Navy;
            this.lblGiaTriLop.Location = new System.Drawing.Point(15, 50);
            this.lblGiaTriLop.Name = "lblGiaTriLop";
            this.lblGiaTriLop.Size = new System.Drawing.Size(69, 54);
            this.lblGiaTriLop.TabIndex = 1;
            this.lblGiaTriLop.Text = "04";
            // 
            // lblSoNam
            // 
            this.lblSoNam.AutoSize = true;
            this.lblSoNam.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoNam.Location = new System.Drawing.Point(15, 15);
            this.lblSoNam.Name = "lblSoNam";
            this.lblSoNam.Size = new System.Drawing.Size(140, 23);
            this.lblSoNam.TabIndex = 0;
            this.lblSoNam.Text = "SINH VIÊN NAM";
            // 
            // lblGiaTriNam
            // 
            this.lblGiaTriNam.AutoSize = true;
            this.lblGiaTriNam.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaTriNam.ForeColor = System.Drawing.Color.Navy;
            this.lblGiaTriNam.Location = new System.Drawing.Point(15, 50);
            this.lblGiaTriNam.Name = "lblGiaTriNam";
            this.lblGiaTriNam.Size = new System.Drawing.Size(69, 54);
            this.lblGiaTriNam.TabIndex = 1;
            this.lblGiaTriNam.Text = "85";
            // 
            // lblSoNu
            // 
            this.lblSoNu.AutoSize = true;
            this.lblSoNu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoNu.Location = new System.Drawing.Point(15, 15);
            this.lblSoNu.Name = "lblSoNu";
            this.lblSoNu.Size = new System.Drawing.Size(125, 23);
            this.lblSoNu.TabIndex = 0;
            this.lblSoNu.Text = "\tSINH VIÊN NỮ";
            // 
            // lblGiaTriNu
            // 
            this.lblGiaTriNu.AutoSize = true;
            this.lblGiaTriNu.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaTriNu.ForeColor = System.Drawing.Color.Navy;
            this.lblGiaTriNu.Location = new System.Drawing.Point(15, 50);
            this.lblGiaTriNu.Name = "lblGiaTriNu";
            this.lblGiaTriNu.Size = new System.Drawing.Size(69, 54);
            this.lblGiaTriNu.TabIndex = 1;
            this.lblGiaTriNu.Text = "35";
            // 
            // pnlTimKiem
            // 
            this.pnlTimKiem.BackColor = System.Drawing.Color.White;
            this.pnlTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTimKiem.Controls.Add(this.txtDiemDen);
            this.pnlTimKiem.Controls.Add(this.txtDiemTu);
            this.pnlTimKiem.Controls.Add(this.lblDiemDen);
            this.pnlTimKiem.Controls.Add(this.lblDiemTu);
            this.pnlTimKiem.Controls.Add(this.btnLamMoi);
            this.pnlTimKiem.Controls.Add(this.cboKhoa);
            this.pnlTimKiem.Controls.Add(this.cboGioiTinh);
            this.pnlTimKiem.Controls.Add(this.btnTimKiem);
            this.pnlTimKiem.Controls.Add(this.txtTuKhoa);
            this.pnlTimKiem.Location = new System.Drawing.Point(25, 270);
            this.pnlTimKiem.Name = "pnlTimKiem";
            this.pnlTimKiem.Size = new System.Drawing.Size(900, 90);
            this.pnlTimKiem.TabIndex = 5;
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(15, 17);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(250, 27);
            this.txtTuKhoa.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(280, 15);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 32);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "\tTìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Location = new System.Drawing.Point(400, 15);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(130, 28);
            this.cboGioiTinh.TabIndex = 2;
            this.cboGioiTinh.SelectedIndexChanged += new System.EventHandler(this.cboGioiTinh_SelectedIndexChanged);
            // 
            // cboKhoa
            // 
            this.cboKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Location = new System.Drawing.Point(550, 15);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(121, 28);
            this.cboKhoa.TabIndex = 3;
            this.cboKhoa.SelectedIndexChanged += new System.EventHandler(this.cboKhoa_SelectedIndexChanged);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(720, 15);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 32);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AllowUserToAddRows = false;
            this.dgvSinhVien.AllowUserToDeleteRows = false;
            this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvSinhVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Location = new System.Drawing.Point(25, 366);
            this.dgvSinhVien.MultiSelect = false;
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.ReadOnly = true;
            this.dgvSinhVien.RowHeadersVisible = false;
            this.dgvSinhVien.RowHeadersWidth = 51;
            this.dgvSinhVien.RowTemplate.Height = 24;
            this.dgvSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSinhVien.Size = new System.Drawing.Size(900, 284);
            this.dgvSinhVien.TabIndex = 6;
            this.dgvSinhVien.SelectionChanged += new System.EventHandler(this.dgvSinhVien_SelectionChanged);
            // 
            // pnlChiTiet
            // 
            this.pnlChiTiet.BackColor = System.Drawing.Color.White;
            this.pnlChiTiet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChiTiet.Controls.Add(this.txtEmail);
            this.pnlChiTiet.Controls.Add(this.txtDiemTB);
            this.pnlChiTiet.Controls.Add(this.txtGioiTinh);
            this.pnlChiTiet.Controls.Add(this.txtHoTen);
            this.pnlChiTiet.Controls.Add(this.txtMaSV);
            this.pnlChiTiet.Controls.Add(this.label6);
            this.pnlChiTiet.Controls.Add(this.label5);
            this.pnlChiTiet.Controls.Add(this.label4);
            this.pnlChiTiet.Controls.Add(this.label3);
            this.pnlChiTiet.Controls.Add(this.label2);
            this.pnlChiTiet.Controls.Add(this.lblTieuDeChiTiet);
            this.pnlChiTiet.Location = new System.Drawing.Point(950, 115);
            this.pnlChiTiet.Name = "pnlChiTiet";
            this.pnlChiTiet.Size = new System.Drawing.Size(280, 535);
            this.pnlChiTiet.TabIndex = 7;
            // 
            // lblTieuDeChiTiet
            // 
            this.lblTieuDeChiTiet.AutoSize = true;
            this.lblTieuDeChiTiet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDeChiTiet.Location = new System.Drawing.Point(15, 15);
            this.lblTieuDeChiTiet.Name = "lblTieuDeChiTiet";
            this.lblTieuDeChiTiet.Size = new System.Drawing.Size(230, 28);
            this.lblTieuDeChiTiet.TabIndex = 0;
            this.lblTieuDeChiTiet.Text = "THÔNG TIN SINH VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sinh viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới tính";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Điểm trung bình";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(15, 75);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.ReadOnly = true;
            this.txtMaSV.Size = new System.Drawing.Size(245, 27);
            this.txtMaSV.TabIndex = 6;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(15, 155);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(245, 27);
            this.txtHoTen.TabIndex = 7;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Location = new System.Drawing.Point(15, 235);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.ReadOnly = true;
            this.txtGioiTinh.Size = new System.Drawing.Size(245, 27);
            this.txtGioiTinh.TabIndex = 8;
            // 
            // txtDiemTB
            // 
            this.txtDiemTB.Location = new System.Drawing.Point(15, 315);
            this.txtDiemTB.Name = "txtDiemTB";
            this.txtDiemTB.ReadOnly = true;
            this.txtDiemTB.Size = new System.Drawing.Size(245, 27);
            this.txtDiemTB.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(15, 395);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(345, 27);
            this.txtEmail.TabIndex = 10;
            // 
            // btnTrangTruoc
            // 
            this.btnTrangTruoc.Location = new System.Drawing.Point(25, 656);
            this.btnTrangTruoc.Name = "btnTrangTruoc";
            this.btnTrangTruoc.Size = new System.Drawing.Size(100, 35);
            this.btnTrangTruoc.TabIndex = 8;
            this.btnTrangTruoc.Text = "Trang trước";
            this.btnTrangTruoc.UseVisualStyleBackColor = true;
            this.btnTrangTruoc.Click += new System.EventHandler(this.btnTrangTruoc_Click);
            // 
            // btnTrangSau
            // 
            this.btnTrangSau.Location = new System.Drawing.Point(131, 656);
            this.btnTrangSau.Name = "btnTrangSau";
            this.btnTrangSau.Size = new System.Drawing.Size(100, 35);
            this.btnTrangSau.TabIndex = 9;
            this.btnTrangSau.Text = "Trang sau";
            this.btnTrangSau.UseVisualStyleBackColor = true;
            this.btnTrangSau.Click += new System.EventHandler(this.btnTrangSau_Click);
            // 
            // lblTrang
            // 
            this.lblTrang.AutoSize = true;
            this.lblTrang.Location = new System.Drawing.Point(445, 663);
            this.lblTrang.Name = "lblTrang";
            this.lblTrang.Size = new System.Drawing.Size(58, 20);
            this.lblTrang.TabIndex = 10;
            this.lblTrang.Text = "Trang 1";
            // 
            // lblDiemTu
            // 
            this.lblDiemTu.AutoSize = true;
            this.lblDiemTu.Location = new System.Drawing.Point(15, 57);
            this.lblDiemTu.Name = "lblDiemTu";
            this.lblDiemTu.Size = new System.Drawing.Size(63, 20);
            this.lblDiemTu.TabIndex = 5;
            this.lblDiemTu.Text = "Điểm từ";
            // 
            // lblDiemDen
            // 
            this.lblDiemDen.AutoSize = true;
            this.lblDiemDen.Location = new System.Drawing.Point(163, 60);
            this.lblDiemDen.Name = "lblDiemDen";
            this.lblDiemDen.Size = new System.Drawing.Size(36, 20);
            this.lblDiemDen.TabIndex = 6;
            this.lblDiemDen.Text = "Đến";
            // 
            // txtDiemTu
            // 
            this.txtDiemTu.Location = new System.Drawing.Point(84, 57);
            this.txtDiemTu.Name = "txtDiemTu";
            this.txtDiemTu.Size = new System.Drawing.Size(55, 27);
            this.txtDiemTu.TabIndex = 7;
            this.txtDiemTu.Text = "\t0";
            this.txtDiemTu.TextChanged += new System.EventHandler(this.txtDiemTu_TextChanged);
            // 
            // txtDiemDen
            // 
            this.txtDiemDen.Location = new System.Drawing.Point(204, 57);
            this.txtDiemDen.Name = "txtDiemDen";
            this.txtDiemDen.Size = new System.Drawing.Size(55, 27);
            this.txtDiemDen.TabIndex = 8;
            this.txtDiemDen.Text = "10";
            // 
            // frmLab9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1439, 891);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlHeader);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLab9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STUDENT MANAGEMENT - LAB 09";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlCard1.ResumeLayout(false);
            this.pnlCard1.PerformLayout();
            this.pnlCard2.ResumeLayout(false);
            this.pnlCard2.PerformLayout();
            this.pnlCard3.ResumeLayout(false);
            this.pnlCard3.PerformLayout();
            this.pnlCard4.ResumeLayout(false);
            this.pnlCard4.PerformLayout();
            this.pnlTimKiem.ResumeLayout(false);
            this.pnlTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.pnlChiTiet.ResumeLayout(false);
            this.pnlChiTiet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Button btnKetNoi;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnCaiDat;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Button btnLopHoc;
        private System.Windows.Forms.Button btnSinhVien;
        private System.Windows.Forms.Button btnTongQuan;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlCard4;
        private System.Windows.Forms.Panel pnlCard3;
        private System.Windows.Forms.Panel pnlCard2;
        private System.Windows.Forms.Panel pnlCard1;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.Label lblGiaTriSinhVien;
        private System.Windows.Forms.Label lblSoSinhVien;
        private System.Windows.Forms.Label lblGiaTriLop;
        private System.Windows.Forms.Label lblSoLop;
        private System.Windows.Forms.Label lblGiaTriNu;
        private System.Windows.Forms.Label lblSoNu;
        private System.Windows.Forms.Label lblGiaTriNam;
        private System.Windows.Forms.Label lblSoNam;
        private System.Windows.Forms.Panel pnlTimKiem;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.Panel pnlChiTiet;
        private System.Windows.Forms.Label lblTieuDeChiTiet;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDiemTB;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTrangSau;
        private System.Windows.Forms.Button btnTrangTruoc;
        private System.Windows.Forms.Label lblTrang;
        private System.Windows.Forms.Label lblDiemDen;
        private System.Windows.Forms.Label lblDiemTu;
        private System.Windows.Forms.TextBox txtDiemDen;
        private System.Windows.Forms.TextBox txtDiemTu;
    }
}