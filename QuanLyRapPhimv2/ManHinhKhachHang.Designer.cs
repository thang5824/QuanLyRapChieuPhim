namespace QuanLyRapPhimv2
{
    partial class ManHinhKhachHang
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
            this.data_veDat = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbChonPhim = new System.Windows.Forms.ComboBox();
            this.dateDatVe = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbViTriNgoi = new System.Windows.Forms.ComboBox();
            this.cbChonGiaVe = new System.Windows.Forms.ComboBox();
            this.cbTrangThaiVe = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoaVe = new System.Windows.Forms.Button();
            this.btnDatVe = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_veDat)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_veDat
            // 
            this.data_veDat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_veDat.BackgroundColor = System.Drawing.Color.White;
            this.data_veDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_veDat.Location = new System.Drawing.Point(0, 464);
            this.data_veDat.Name = "data_veDat";
            this.data_veDat.RowHeadersWidth = 51;
            this.data_veDat.RowTemplate.Height = 24;
            this.data_veDat.Size = new System.Drawing.Size(1358, 354);
            this.data_veDat.TabIndex = 0;
            this.data_veDat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_veDat_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1360, 63);
            this.panel1.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 24);
            this.label1.TabIndex = 39;
            this.label1.Text = "THÔNG TIN KHÁCH HÀNG ĐẶT VÉ XEM PHIM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(281, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 69;
            this.label2.Text = "Chọn phim xem";
            // 
            // cbChonPhim
            // 
            this.cbChonPhim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbChonPhim.FormattingEnabled = true;
            this.cbChonPhim.Location = new System.Drawing.Point(427, 116);
            this.cbChonPhim.Name = "cbChonPhim";
            this.cbChonPhim.Size = new System.Drawing.Size(225, 24);
            this.cbChonPhim.TabIndex = 65;
            // 
            // dateDatVe
            // 
            this.dateDatVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateDatVe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDatVe.Location = new System.Drawing.Point(427, 223);
            this.dateDatVe.Name = "dateDatVe";
            this.dateDatVe.Size = new System.Drawing.Size(225, 24);
            this.dateDatVe.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(281, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 73;
            this.label3.Text = "Chọn vị trí ngồi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(296, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 18);
            this.label4.TabIndex = 75;
            this.label4.Text = "Thời gian đặt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(753, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 18);
            this.label5.TabIndex = 76;
            this.label5.Text = "Chọn giá vé";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(753, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 18);
            this.label6.TabIndex = 78;
            this.label6.Text = "Trạng thái vé";
            // 
            // cbViTriNgoi
            // 
            this.cbViTriNgoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbViTriNgoi.FormattingEnabled = true;
            this.cbViTriNgoi.Location = new System.Drawing.Point(427, 172);
            this.cbViTriNgoi.Name = "cbViTriNgoi";
            this.cbViTriNgoi.Size = new System.Drawing.Size(225, 24);
            this.cbViTriNgoi.TabIndex = 80;
            // 
            // cbChonGiaVe
            // 
            this.cbChonGiaVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbChonGiaVe.FormattingEnabled = true;
            this.cbChonGiaVe.Location = new System.Drawing.Point(878, 110);
            this.cbChonGiaVe.Name = "cbChonGiaVe";
            this.cbChonGiaVe.Size = new System.Drawing.Size(225, 24);
            this.cbChonGiaVe.TabIndex = 81;
            // 
            // cbTrangThaiVe
            // 
            this.cbTrangThaiVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTrangThaiVe.FormattingEnabled = true;
            this.cbTrangThaiVe.Items.AddRange(new object[] {
            "Đặt vé",
            "Hủy vé"});
            this.cbTrangThaiVe.Location = new System.Drawing.Point(878, 162);
            this.cbTrangThaiVe.Name = "cbTrangThaiVe";
            this.cbTrangThaiVe.Size = new System.Drawing.Size(225, 24);
            this.cbTrangThaiVe.TabIndex = 82;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.btnCapNhat);
            this.panel2.Controls.Add(this.btnXoaVe);
            this.panel2.Controls.Add(this.btnDatVe);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(0, 279);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1358, 87);
            this.panel2.TabIndex = 83;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.Orange;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(928, 19);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(216, 48);
            this.btnCapNhat.TabIndex = 88;
            this.btnCapNhat.Text = "SỬA THÔNG TIN";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoaVe
            // 
            this.btnXoaVe.BackColor = System.Drawing.Color.Red;
            this.btnXoaVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaVe.ForeColor = System.Drawing.Color.White;
            this.btnXoaVe.Location = new System.Drawing.Point(1150, 19);
            this.btnXoaVe.Name = "btnXoaVe";
            this.btnXoaVe.Size = new System.Drawing.Size(188, 48);
            this.btnXoaVe.TabIndex = 87;
            this.btnXoaVe.Text = "XÓA VÉ";
            this.btnXoaVe.UseVisualStyleBackColor = false;
            this.btnXoaVe.Click += new System.EventHandler(this.btnXoaVe_Click);
            // 
            // btnDatVe
            // 
            this.btnDatVe.BackColor = System.Drawing.Color.Green;
            this.btnDatVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatVe.ForeColor = System.Drawing.Color.White;
            this.btnDatVe.Location = new System.Drawing.Point(707, 19);
            this.btnDatVe.Name = "btnDatVe";
            this.btnDatVe.Size = new System.Drawing.Size(215, 48);
            this.btnDatVe.TabIndex = 86;
            this.btnDatVe.Text = "ĐẶT VÉ NGAY";
            this.btnDatVe.UseVisualStyleBackColor = false;
            this.btnDatVe.Click += new System.EventHandler(this.btnDatVe_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(18, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 23);
            this.label8.TabIndex = 85;
            this.label8.Text = "THAO TÁC ĐẶT VÉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(18, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(297, 24);
            this.label7.TabIndex = 84;
            this.label7.Text = "DANH SÁCH VÉ ĐẶT CỦA BẠN";
            // 
            // ManHinhKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 819);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cbTrangThaiVe);
            this.Controls.Add(this.cbChonGiaVe);
            this.Controls.Add(this.cbViTriNgoi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbChonPhim);
            this.Controls.Add(this.dateDatVe);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.data_veDat);
            this.Name = "ManHinhKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManHinhKhachHang";
            this.Load += new System.EventHandler(this.ManHinhKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_veDat)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_veDat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbChonPhim;
        private System.Windows.Forms.DateTimePicker dateDatVe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbViTriNgoi;
        private System.Windows.Forms.ComboBox cbChonGiaVe;
        private System.Windows.Forms.ComboBox cbTrangThaiVe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoaVe;
        private System.Windows.Forms.Button btnDatVe;
    }
}