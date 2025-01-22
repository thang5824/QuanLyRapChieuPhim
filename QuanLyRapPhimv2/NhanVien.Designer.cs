namespace QuanLyRapPhimv2
{
    partial class NhanVien
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
            this.dinh_dang_phimTableAdapter1 = new QuanLyRapPhimv2.QuanLyRapDataSet1TableAdapters.dinh_dang_phimTableAdapter();
            this.tbNhanVien = new System.Windows.Forms.TabControl();
            this.tpBanVe = new System.Windows.Forms.TabPage();
            this.btnTimVe = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.dtgvGiaVe = new System.Windows.Forms.DataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtMaVe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_GiaVe = new System.Windows.Forms.ComboBox();
            this.cb_Ghe = new System.Windows.Forms.ComboBox();
            this.cb_NhanVien = new System.Windows.Forms.ComboBox();
            this.cb_suatChieu = new System.Windows.Forms.ComboBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.dateNgayban = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.dtg_main = new System.Windows.Forms.DataGridView();
            this.tpDoAn = new System.Windows.Forms.TabPage();
            this.btnXoaMon1 = new System.Windows.Forms.Button();
            this.btnSuaMon1 = new System.Windows.Forms.Button();
            this.btnThemMon1 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnTimMonAn = new System.Windows.Forms.Button();
            this.txtTimMonAn = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtMaMonAn1 = new System.Windows.Forms.TextBox();
            this.txtTenMonAn1 = new System.Windows.Forms.TextBox();
            this.txtGiaMonAn1 = new System.Windows.Forms.TextBox();
            this.cbLoaiMonAn1 = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dtgvMonAn = new System.Windows.Forms.DataGridView();
            this.tpHoaDon = new System.Windows.Forms.TabPage();
            this.btn_ThongKe = new System.Windows.Forms.Button();
            this.btn_Load = new System.Windows.Forms.Button();
            this.dtg_HoaDon = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNhanVien.SuspendLayout();
            this.tpBanVe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGiaVe)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_main)).BeginInit();
            this.tpDoAn.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMonAn)).BeginInit();
            this.tpHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_HoaDon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dinh_dang_phimTableAdapter1
            // 
            this.dinh_dang_phimTableAdapter1.ClearBeforeFill = true;
            // 
            // tbNhanVien
            // 
            this.tbNhanVien.Controls.Add(this.tpBanVe);
            this.tbNhanVien.Controls.Add(this.tpDoAn);
            this.tbNhanVien.Controls.Add(this.tpHoaDon);
            this.tbNhanVien.Location = new System.Drawing.Point(12, 94);
            this.tbNhanVien.Name = "tbNhanVien";
            this.tbNhanVien.SelectedIndex = 0;
            this.tbNhanVien.Size = new System.Drawing.Size(1179, 550);
            this.tbNhanVien.TabIndex = 32;
            // 
            // tpBanVe
            // 
            this.tpBanVe.Controls.Add(this.btnTimVe);
            this.tpBanVe.Controls.Add(this.txtTimKiem);
            this.tpBanVe.Controls.Add(this.btn_CapNhat);
            this.tpBanVe.Controls.Add(this.btn_Xoa);
            this.tpBanVe.Controls.Add(this.btn_ThanhToan);
            this.tpBanVe.Controls.Add(this.label28);
            this.tpBanVe.Controls.Add(this.dtgvGiaVe);
            this.tpBanVe.Controls.Add(this.panel9);
            this.tpBanVe.Controls.Add(this.dtg_main);
            this.tpBanVe.Location = new System.Drawing.Point(4, 25);
            this.tpBanVe.Name = "tpBanVe";
            this.tpBanVe.Padding = new System.Windows.Forms.Padding(3);
            this.tpBanVe.Size = new System.Drawing.Size(1171, 521);
            this.tpBanVe.TabIndex = 0;
            this.tpBanVe.Text = "Bán vé";
            this.tpBanVe.UseVisualStyleBackColor = true;
            // 
            // btnTimVe
            // 
            this.btnTimVe.BackColor = System.Drawing.Color.Black;
            this.btnTimVe.ForeColor = System.Drawing.Color.White;
            this.btnTimVe.Location = new System.Drawing.Point(1102, 6);
            this.btnTimVe.Name = "btnTimVe";
            this.btnTimVe.Size = new System.Drawing.Size(59, 42);
            this.btnTimVe.TabIndex = 12;
            this.btnTimVe.Text = "Tìm";
            this.btnTimVe.UseVisualStyleBackColor = false;
            this.btnTimVe.Click += new System.EventHandler(this.btnTimVe_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.Location = new System.Drawing.Point(666, 6);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(441, 42);
            this.txtTimKiem.TabIndex = 13;
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.BackColor = System.Drawing.Color.Orange;
            this.btn_CapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhat.ForeColor = System.Drawing.Color.White;
            this.btn_CapNhat.Location = new System.Drawing.Point(227, 8);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(216, 48);
            this.btn_CapNhat.TabIndex = 46;
            this.btn_CapNhat.Text = "Sửa thông tin";
            this.btn_CapNhat.UseVisualStyleBackColor = false;
            this.btn_CapNhat.Click += new System.EventHandler(this.btnSuaVe1_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Red;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(449, 8);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(188, 48);
            this.btn_Xoa.TabIndex = 45;
            this.btn_Xoa.Text = "Xóa vé";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btnXoaVe1_Click);
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.BackColor = System.Drawing.Color.Green;
            this.btn_ThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThanhToan.ForeColor = System.Drawing.Color.White;
            this.btn_ThanhToan.Location = new System.Drawing.Point(6, 8);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(215, 48);
            this.btn_ThanhToan.TabIndex = 44;
            this.btn_ThanhToan.Text = "Thanh toán vé";
            this.btn_ThanhToan.UseVisualStyleBackColor = false;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btnThemVe1_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label28.Location = new System.Drawing.Point(878, 242);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(117, 19);
            this.label28.TabIndex = 38;
            this.label28.Text = "BẢNG GIÁ VÉ";
            // 
            // dtgvGiaVe
            // 
            this.dtgvGiaVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvGiaVe.Location = new System.Drawing.Point(673, 281);
            this.dtgvGiaVe.Name = "dtgvGiaVe";
            this.dtgvGiaVe.RowHeadersWidth = 51;
            this.dtgvGiaVe.RowTemplate.Height = 24;
            this.dtgvGiaVe.Size = new System.Drawing.Size(488, 234);
            this.dtgvGiaVe.TabIndex = 37;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txtMaVe);
            this.panel9.Controls.Add(this.label2);
            this.panel9.Controls.Add(this.cb_GiaVe);
            this.panel9.Controls.Add(this.cb_Ghe);
            this.panel9.Controls.Add(this.cb_NhanVien);
            this.panel9.Controls.Add(this.cb_suatChieu);
            this.panel9.Controls.Add(this.txtTongTien);
            this.panel9.Controls.Add(this.dateNgayban);
            this.panel9.Controls.Add(this.label21);
            this.panel9.Controls.Add(this.label22);
            this.panel9.Controls.Add(this.label23);
            this.panel9.Controls.Add(this.label24);
            this.panel9.Controls.Add(this.label26);
            this.panel9.Controls.Add(this.label27);
            this.panel9.Location = new System.Drawing.Point(666, 62);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(499, 177);
            this.panel9.TabIndex = 36;
            // 
            // txtMaVe
            // 
            this.txtMaVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaVe.Location = new System.Drawing.Point(130, 10);
            this.txtMaVe.Name = "txtMaVe";
            this.txtMaVe.Size = new System.Drawing.Size(121, 24);
            this.txtMaVe.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(14, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 55;
            this.label2.Text = "Mã vé bán : ";
            // 
            // cb_GiaVe
            // 
            this.cb_GiaVe.FormattingEnabled = true;
            this.cb_GiaVe.Location = new System.Drawing.Point(367, 16);
            this.cb_GiaVe.Name = "cb_GiaVe";
            this.cb_GiaVe.Size = new System.Drawing.Size(121, 24);
            this.cb_GiaVe.TabIndex = 54;
            // 
            // cb_Ghe
            // 
            this.cb_Ghe.FormattingEnabled = true;
            this.cb_Ghe.Location = new System.Drawing.Point(367, 60);
            this.cb_Ghe.Name = "cb_Ghe";
            this.cb_Ghe.Size = new System.Drawing.Size(121, 24);
            this.cb_Ghe.TabIndex = 53;
            // 
            // cb_NhanVien
            // 
            this.cb_NhanVien.FormattingEnabled = true;
            this.cb_NhanVien.Location = new System.Drawing.Point(367, 101);
            this.cb_NhanVien.Name = "cb_NhanVien";
            this.cb_NhanVien.Size = new System.Drawing.Size(121, 24);
            this.cb_NhanVien.TabIndex = 52;
            // 
            // cb_suatChieu
            // 
            this.cb_suatChieu.FormattingEnabled = true;
            this.cb_suatChieu.Location = new System.Drawing.Point(130, 141);
            this.cb_suatChieu.Name = "cb_suatChieu";
            this.cb_suatChieu.Size = new System.Drawing.Size(121, 24);
            this.cb_suatChieu.TabIndex = 51;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTongTien.Location = new System.Drawing.Point(130, 97);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(121, 24);
            this.txtTongTien.TabIndex = 46;
            // 
            // dateNgayban
            // 
            this.dateNgayban.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateNgayban.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayban.Location = new System.Drawing.Point(130, 54);
            this.dateNgayban.Name = "dateNgayban";
            this.dateNgayban.Size = new System.Drawing.Size(129, 24);
            this.dateNgayban.TabIndex = 45;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label21.Location = new System.Drawing.Point(271, 16);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(80, 18);
            this.label21.TabIndex = 15;
            this.label21.Text = "Mã giá vé:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label22.Location = new System.Drawing.Point(287, 62);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(64, 18);
            this.label22.TabIndex = 14;
            this.label22.Text = "Mã ghế:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label23.Location = new System.Drawing.Point(254, 103);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(107, 18);
            this.label23.TabIndex = 13;
            this.label23.Text = "Mã nhân viên:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label24.Location = new System.Drawing.Point(14, 147);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(110, 18);
            this.label24.TabIndex = 12;
            this.label24.Text = "Mã suất chiếu:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label26.Location = new System.Drawing.Point(14, 60);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(77, 18);
            this.label26.TabIndex = 5;
            this.label26.Text = "Ngày bán:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label27.Location = new System.Drawing.Point(14, 103);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(80, 18);
            this.label27.TabIndex = 8;
            this.label27.Text = "Tổng tiền:";
            // 
            // dtg_main
            // 
            this.dtg_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_main.Location = new System.Drawing.Point(3, 62);
            this.dtg_main.Name = "dtg_main";
            this.dtg_main.RowHeadersWidth = 51;
            this.dtg_main.RowTemplate.Height = 24;
            this.dtg_main.Size = new System.Drawing.Size(634, 453);
            this.dtg_main.TabIndex = 32;
            this.dtg_main.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_main_CellClick);
            // 
            // tpDoAn
            // 
            this.tpDoAn.Controls.Add(this.btnXoaMon1);
            this.tpDoAn.Controls.Add(this.btnSuaMon1);
            this.tpDoAn.Controls.Add(this.btnThemMon1);
            this.tpDoAn.Controls.Add(this.panel8);
            this.tpDoAn.Controls.Add(this.panel7);
            this.tpDoAn.Controls.Add(this.dtgvMonAn);
            this.tpDoAn.Location = new System.Drawing.Point(4, 25);
            this.tpDoAn.Name = "tpDoAn";
            this.tpDoAn.Padding = new System.Windows.Forms.Padding(3);
            this.tpDoAn.Size = new System.Drawing.Size(1171, 521);
            this.tpDoAn.TabIndex = 1;
            this.tpDoAn.Text = "Bán đồ ăn";
            this.tpDoAn.UseVisualStyleBackColor = true;
            // 
            // btnXoaMon1
            // 
            this.btnXoaMon1.Location = new System.Drawing.Point(379, 6);
            this.btnXoaMon1.Name = "btnXoaMon1";
            this.btnXoaMon1.Size = new System.Drawing.Size(75, 35);
            this.btnXoaMon1.TabIndex = 27;
            this.btnXoaMon1.Text = "Xóa";
            this.btnXoaMon1.UseVisualStyleBackColor = true;
            this.btnXoaMon1.Click += new System.EventHandler(this.btnXoaMon1_Click);
            // 
            // btnSuaMon1
            // 
            this.btnSuaMon1.Location = new System.Drawing.Point(247, 6);
            this.btnSuaMon1.Name = "btnSuaMon1";
            this.btnSuaMon1.Size = new System.Drawing.Size(75, 35);
            this.btnSuaMon1.TabIndex = 26;
            this.btnSuaMon1.Text = "Sửa";
            this.btnSuaMon1.UseVisualStyleBackColor = true;
            this.btnSuaMon1.Click += new System.EventHandler(this.btnSuaMon1_Click);
            // 
            // btnThemMon1
            // 
            this.btnThemMon1.Location = new System.Drawing.Point(113, 5);
            this.btnThemMon1.Name = "btnThemMon1";
            this.btnThemMon1.Size = new System.Drawing.Size(75, 35);
            this.btnThemMon1.TabIndex = 25;
            this.btnThemMon1.Text = "Thêm";
            this.btnThemMon1.UseVisualStyleBackColor = true;
            this.btnThemMon1.Click += new System.EventHandler(this.btnThemMon1_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnTimMonAn);
            this.panel8.Controls.Add(this.txtTimMonAn);
            this.panel8.Location = new System.Drawing.Point(830, 13);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(332, 40);
            this.panel8.TabIndex = 23;
            // 
            // btnTimMonAn
            // 
            this.btnTimMonAn.Location = new System.Drawing.Point(254, 2);
            this.btnTimMonAn.Name = "btnTimMonAn";
            this.btnTimMonAn.Size = new System.Drawing.Size(75, 35);
            this.btnTimMonAn.TabIndex = 12;
            this.btnTimMonAn.Text = "Tìm";
            this.btnTimMonAn.UseVisualStyleBackColor = true;
            this.btnTimMonAn.Click += new System.EventHandler(this.btnTimMonAn_Click);
            // 
            // txtTimMonAn
            // 
            this.txtTimMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimMonAn.Location = new System.Drawing.Point(3, 3);
            this.txtTimMonAn.Name = "txtTimMonAn";
            this.txtTimMonAn.Size = new System.Drawing.Size(221, 30);
            this.txtTimMonAn.TabIndex = 11;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtMaMonAn1);
            this.panel7.Controls.Add(this.txtTenMonAn1);
            this.panel7.Controls.Add(this.txtGiaMonAn1);
            this.panel7.Controls.Add(this.cbLoaiMonAn1);
            this.panel7.Controls.Add(this.label20);
            this.panel7.Controls.Add(this.label19);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Controls.Add(this.label17);
            this.panel7.Controls.Add(this.label18);
            this.panel7.Location = new System.Drawing.Point(681, 59);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(481, 200);
            this.panel7.TabIndex = 22;
            // 
            // txtMaMonAn1
            // 
            this.txtMaMonAn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaMonAn1.Location = new System.Drawing.Point(142, 16);
            this.txtMaMonAn1.Name = "txtMaMonAn1";
            this.txtMaMonAn1.Size = new System.Drawing.Size(319, 27);
            this.txtMaMonAn1.TabIndex = 19;
            // 
            // txtTenMonAn1
            // 
            this.txtTenMonAn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenMonAn1.Location = new System.Drawing.Point(142, 60);
            this.txtTenMonAn1.Name = "txtTenMonAn1";
            this.txtTenMonAn1.Size = new System.Drawing.Size(319, 27);
            this.txtTenMonAn1.TabIndex = 18;
            // 
            // txtGiaMonAn1
            // 
            this.txtGiaMonAn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGiaMonAn1.Location = new System.Drawing.Point(142, 102);
            this.txtGiaMonAn1.Name = "txtGiaMonAn1";
            this.txtGiaMonAn1.Size = new System.Drawing.Size(319, 27);
            this.txtGiaMonAn1.TabIndex = 17;
            // 
            // cbLoaiMonAn1
            // 
            this.cbLoaiMonAn1.DisplayMember = "ten";
            this.cbLoaiMonAn1.FormattingEnabled = true;
            this.cbLoaiMonAn1.Items.AddRange(new object[] {
            "Đồ ăn nhanh"});
            this.cbLoaiMonAn1.Location = new System.Drawing.Point(142, 152);
            this.cbLoaiMonAn1.Name = "cbLoaiMonAn1";
            this.cbLoaiMonAn1.Size = new System.Drawing.Size(309, 24);
            this.cbLoaiMonAn1.TabIndex = 16;
            this.cbLoaiMonAn1.ValueMember = "ten";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label20.Location = new System.Drawing.Point(16, 110);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(104, 19);
            this.label20.TabIndex = 14;
            this.label20.Text = "Giá món ăn:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label19.Location = new System.Drawing.Point(16, 157);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(111, 19);
            this.label19.TabIndex = 13;
            this.label19.Text = "Loại món ăn:";
            // 
            // label16
            // 
            this.label16.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label16.Location = new System.Drawing.Point(16, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 19);
            this.label16.TabIndex = 4;
            this.label16.Text = "Mã món ăn:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label17.Location = new System.Drawing.Point(16, 68);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(107, 19);
            this.label17.TabIndex = 5;
            this.label17.Text = "Tên món ăn:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label18.Location = new System.Drawing.Point(16, 114);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 19);
            this.label18.TabIndex = 8;
            // 
            // dtgvMonAn
            // 
            this.dtgvMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMonAn.Location = new System.Drawing.Point(7, 46);
            this.dtgvMonAn.Name = "dtgvMonAn";
            this.dtgvMonAn.RowHeadersWidth = 51;
            this.dtgvMonAn.RowTemplate.Height = 24;
            this.dtgvMonAn.Size = new System.Drawing.Size(668, 469);
            this.dtgvMonAn.TabIndex = 18;
            // 
            // tpHoaDon
            // 
            this.tpHoaDon.Controls.Add(this.btn_ThongKe);
            this.tpHoaDon.Controls.Add(this.btn_Load);
            this.tpHoaDon.Controls.Add(this.dtg_HoaDon);
            this.tpHoaDon.Location = new System.Drawing.Point(4, 25);
            this.tpHoaDon.Name = "tpHoaDon";
            this.tpHoaDon.Padding = new System.Windows.Forms.Padding(3);
            this.tpHoaDon.Size = new System.Drawing.Size(1171, 521);
            this.tpHoaDon.TabIndex = 2;
            this.tpHoaDon.Text = "Hóa đơn";
            this.tpHoaDon.UseVisualStyleBackColor = true;
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_ThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongKe.ForeColor = System.Drawing.Color.White;
            this.btn_ThongKe.Location = new System.Drawing.Point(6, 22);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Size = new System.Drawing.Size(188, 48);
            this.btn_ThongKe.TabIndex = 48;
            this.btn_ThongKe.Text = "Thống kê hóa đơn";
            this.btn_ThongKe.UseVisualStyleBackColor = false;
            this.btn_ThongKe.Click += new System.EventHandler(this.btn_ThongKe_Click);
            // 
            // btn_Load
            // 
            this.btn_Load.BackColor = System.Drawing.Color.Black;
            this.btn_Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Load.ForeColor = System.Drawing.Color.White;
            this.btn_Load.Location = new System.Drawing.Point(1030, 22);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(135, 48);
            this.btn_Load.TabIndex = 47;
            this.btn_Load.Text = "TẢI LẠI";
            this.btn_Load.UseVisualStyleBackColor = false;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // dtg_HoaDon
            // 
            this.dtg_HoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_HoaDon.Location = new System.Drawing.Point(6, 87);
            this.dtg_HoaDon.Name = "dtg_HoaDon";
            this.dtg_HoaDon.RowHeadersWidth = 51;
            this.dtg_HoaDon.RowTemplate.Height = 24;
            this.dtg_HoaDon.Size = new System.Drawing.Size(1159, 428);
            this.dtg_HoaDon.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1203, 63);
            this.panel1.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 24);
            this.label1.TabIndex = 39;
            this.label1.Text = "THÔNG TIN THANH TOÁN VÉ XEM PHIM";
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 666);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbNhanVien);
            this.Name = "NhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân Viên";
            this.tbNhanVien.ResumeLayout(false);
            this.tpBanVe.ResumeLayout(false);
            this.tpBanVe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGiaVe)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_main)).EndInit();
            this.tpDoAn.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMonAn)).EndInit();
            this.tpHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_HoaDon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private QuanLyRapDataSet1TableAdapters.dinh_dang_phimTableAdapter dinh_dang_phimTableAdapter1;
        private System.Windows.Forms.TabControl tbNhanVien;
        private System.Windows.Forms.TabPage tpBanVe;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.DataGridView dtgvGiaVe;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.DataGridView dtg_main;
        private System.Windows.Forms.TabPage tpDoAn;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dtgvMonAn;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.DateTimePicker dateNgayban;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.Button btnXoaMon1;
        private System.Windows.Forms.Button btnSuaMon1;
        private System.Windows.Forms.Button btnThemMon1;
        private System.Windows.Forms.TextBox txtMaMonAn1;
        private System.Windows.Forms.TextBox txtTenMonAn1;
        private System.Windows.Forms.TextBox txtGiaMonAn1;
        private System.Windows.Forms.ComboBox cbLoaiMonAn1;
        private System.Windows.Forms.Button btnTimVe;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimMonAn;
        private System.Windows.Forms.TextBox txtTimMonAn;
        private System.Windows.Forms.ComboBox cb_NhanVien;
        private System.Windows.Forms.ComboBox cb_suatChieu;
        private System.Windows.Forms.ComboBox cb_Ghe;
        private System.Windows.Forms.ComboBox cb_GiaVe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaVe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tpHoaDon;
        private System.Windows.Forms.DataGridView dtg_HoaDon;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Button btn_ThongKe;
    }
}