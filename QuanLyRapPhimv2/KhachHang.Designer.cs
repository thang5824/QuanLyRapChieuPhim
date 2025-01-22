namespace QuanLyRapPhimv2
{
    partial class KhachHang
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
            this.dtgvPhim = new System.Windows.Forms.DataGridView();
            this.dtgvSuatChieu = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvGheNgoi = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSuatChieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGheNgoi)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvPhim
            // 
            this.dtgvPhim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPhim.Location = new System.Drawing.Point(12, 55);
            this.dtgvPhim.Name = "dtgvPhim";
            this.dtgvPhim.RowHeadersWidth = 51;
            this.dtgvPhim.RowTemplate.Height = 24;
            this.dtgvPhim.Size = new System.Drawing.Size(721, 527);
            this.dtgvPhim.TabIndex = 1;
            // 
            // dtgvSuatChieu
            // 
            this.dtgvSuatChieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSuatChieu.Location = new System.Drawing.Point(763, 52);
            this.dtgvSuatChieu.Name = "dtgvSuatChieu";
            this.dtgvSuatChieu.RowHeadersWidth = 51;
            this.dtgvSuatChieu.RowTemplate.Height = 24;
            this.dtgvSuatChieu.Size = new System.Drawing.Size(437, 250);
            this.dtgvSuatChieu.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(759, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "DANH SÁCH SUẤT CHIẾU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(8, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "DANH SÁCH PHIM";
            // 
            // dtgvGheNgoi
            // 
            this.dtgvGheNgoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvGheNgoi.Location = new System.Drawing.Point(763, 365);
            this.dtgvGheNgoi.Name = "dtgvGheNgoi";
            this.dtgvGheNgoi.RowHeadersWidth = 51;
            this.dtgvGheNgoi.RowTemplate.Height = 24;
            this.dtgvGheNgoi.Size = new System.Drawing.Size(437, 217);
            this.dtgvGheNgoi.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(759, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "DANH SÁCH GHẾ NGỒI";
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 594);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgvGheNgoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgvSuatChieu);
            this.Controls.Add(this.dtgvPhim);
            this.Name = "KhachHang";
            this.Text = "Khách hàng";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSuatChieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGheNgoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvPhim;
        private System.Windows.Forms.DataGridView dtgvSuatChieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvGheNgoi;
        private System.Windows.Forms.Label label3;
    }
}