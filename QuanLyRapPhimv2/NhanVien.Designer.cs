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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tpHoaDon = new System.Windows.Forms.TabPage();
            this.dtg_HoaDon = new System.Windows.Forms.DataGridView();
            this.btn_Load = new System.Windows.Forms.Button();
            this.btn_ThongKe = new System.Windows.Forms.Button();
            this.tpBanVe = new System.Windows.Forms.TabPage();
            this.dtg_main = new System.Windows.Forms.DataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.dateNgayban = new System.Windows.Forms.DateTimePicker();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.cb_suatChieu = new System.Windows.Forms.ComboBox();
            this.cb_NhanVien = new System.Windows.Forms.ComboBox();
            this.cb_Ghe = new System.Windows.Forms.ComboBox();
            this.cb_GiaVe = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaVe = new System.Windows.Forms.TextBox();
            this.dtgvGiaVe = new System.Windows.Forms.DataGridView();
            this.label28 = new System.Windows.Forms.Label();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimVe = new System.Windows.Forms.Button();
            this.tbNhanVien = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            this.tpHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_HoaDon)).BeginInit();
            this.tpBanVe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_main)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGiaVe)).BeginInit();
            this.tbNhanVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // dinh_dang_phimTableAdapter1
            // 
            this.dinh_dang_phimTableAdapter1.ClearBeforeFill = true;
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
            // dateNgayban
            // 
            this.dateNgayban.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateNgayban.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayban.Location = new System.Drawing.Point(130, 54);
            this.dateNgayban.Name = "dateNgayban";
            this.dateNgayban.Size = new System.Drawing.Size(129, 24);
            this.dateNgayban.TabIndex = 45;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTongTien.Location = new System.Drawing.Point(130, 97);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(121, 24);
            this.txtTongTien.TabIndex = 46;
            // 
            // cb_suatChieu
            // 
            this.cb_suatChieu.FormattingEnabled = true;
            this.cb_suatChieu.Location = new System.Drawing.Point(130, 141);
            this.cb_suatChieu.Name = "cb_suatChieu";
            this.cb_suatChieu.Size = new System.Drawing.Size(121, 24);
            this.cb_suatChieu.TabIndex = 51;
            // 
            // cb_NhanVien
            // 
            this.cb_NhanVien.FormattingEnabled = true;
            this.cb_NhanVien.Location = new System.Drawing.Point(367, 101);
            this.cb_NhanVien.Name = "cb_NhanVien";
            this.cb_NhanVien.Size = new System.Drawing.Size(121, 24);
            this.cb_NhanVien.TabIndex = 52;
            // 
            // cb_Ghe
            // 
            this.cb_Ghe.FormattingEnabled = true;
            this.cb_Ghe.Location = new System.Drawing.Point(367, 60);
            this.cb_Ghe.Name = "cb_Ghe";
            this.cb_Ghe.Size = new System.Drawing.Size(121, 24);
            this.cb_Ghe.TabIndex = 53;
            // 
            // cb_GiaVe
            // 
            this.cb_GiaVe.FormattingEnabled = true;
            this.cb_GiaVe.Location = new System.Drawing.Point(367, 16);
            this.cb_GiaVe.Name = "cb_GiaVe";
            this.cb_GiaVe.Size = new System.Drawing.Size(121, 24);
            this.cb_GiaVe.TabIndex = 54;
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
            // txtMaVe
            // 
            this.txtMaVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaVe.Location = new System.Drawing.Point(130, 10);
            this.txtMaVe.Name = "txtMaVe";
            this.txtMaVe.Size = new System.Drawing.Size(121, 24);
            this.txtMaVe.TabIndex = 56;
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
            // tbNhanVien
            // 
            this.tbNhanVien.Controls.Add(this.tpBanVe);
            this.tbNhanVien.Controls.Add(this.tpHoaDon);
            this.tbNhanVien.Location = new System.Drawing.Point(12, 94);
            this.tbNhanVien.Name = "tbNhanVien";
            this.tbNhanVien.SelectedIndex = 0;
            this.tbNhanVien.Size = new System.Drawing.Size(1179, 550);
            this.tbNhanVien.TabIndex = 32;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tpHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_HoaDon)).EndInit();
            this.tpBanVe.ResumeLayout(false);
            this.tpBanVe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_main)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGiaVe)).EndInit();
            this.tbNhanVien.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private QuanLyRapDataSet1TableAdapters.dinh_dang_phimTableAdapter dinh_dang_phimTableAdapter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpHoaDon;
        private System.Windows.Forms.Button btn_ThongKe;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.DataGridView dtg_HoaDon;
        private System.Windows.Forms.TabPage tpBanVe;
        private System.Windows.Forms.Button btnTimVe;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.DataGridView dtgvGiaVe;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtMaVe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_GiaVe;
        private System.Windows.Forms.ComboBox cb_Ghe;
        private System.Windows.Forms.ComboBox cb_NhanVien;
        private System.Windows.Forms.ComboBox cb_suatChieu;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.DateTimePicker dateNgayban;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.DataGridView dtg_main;
        private System.Windows.Forms.TabControl tbNhanVien;
    }
}