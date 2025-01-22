using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyRapPhimv2.DAO;

namespace QuanLyRapPhimv2
{
    public partial class KhachHang : Form
    {
        private string connectionSTR = "Data Source=HuynhThang\\SQLEXPRESS;Initial Catalog=QuanlyRapChieuPhim;Integrated Security=True";
        public KhachHang()
        {
            InitializeComponent();
            LoadPhimList();
            LoadSuatChieuList();
            LoadGheNgoiList();
        }
        void LoadGheNgoiList()
        {
            string query = "SELECT * FROM ghe_ngoi";
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);
            dtgvGheNgoi.DataSource = data;

            // Cấu hình DataGridView
            dtgvGheNgoi.Columns["id"].HeaderText = "Mã Ghế Ngồi";
            dtgvGheNgoi.Columns["vi_tri_day"].HeaderText = "Vị Trí Dãy";
            dtgvGheNgoi.Columns["vi_tri_cot"].HeaderText = "Vị Trí Cột";
            dtgvGheNgoi.Columns["da_chon"].HeaderText = "Đã chọn";
            dtgvGheNgoi.Columns["phong_chieu_id"].HeaderText = "Phòng Chiếu";
            dtgvGheNgoi.Columns["loai_ghe_id"].HeaderText = "Loại Ghế";

            // Thêm cột CheckBox cho "Đã Chọn"
            if (!dtgvGheNgoi.Columns.Contains("da_chon"))
            {
                DataGridViewCheckBoxColumn chkDaChonColumn = new DataGridViewCheckBoxColumn();
                chkDaChonColumn.HeaderText = "Đã Chọn";
                chkDaChonColumn.Name = "da_chon";
                dtgvGheNgoi.Columns.Add(chkDaChonColumn);
            }

            // Hiển thị trạng thái "Đã Chọn" trong cột CheckBox
            foreach (DataGridViewRow row in dtgvGheNgoi.Rows)
            {
                if (row.Cells["da_chon"].Value != DBNull.Value)
                {
                    row.Cells["da_chon"].Value = Convert.ToBoolean(row.Cells["da_chon"].Value);
                }
                else
                {
                    row.Cells["da_chon"].Value = false;
                }
            }

            dtgvGheNgoi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvGheNgoi.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dtgvGheNgoi.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8F);
            dtgvGheNgoi.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            dtgvGheNgoi.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
        }
        void LoadSuatChieuList()
        {
            string query = "SELECT * FROM dbo.suat_chieu";
            DataProvider provider = new DataProvider();
            dtgvSuatChieu.DataSource = provider.ExecuteQuery(query);


            dtgvSuatChieu.Columns["id"].HeaderText = "Mã phòng";
            dtgvSuatChieu.Columns["gio_bat_dau"].HeaderText = "Giờ bắt đầu";
            dtgvSuatChieu.Columns["gio_ket_thuc"].HeaderText = "Giờ kết thúc";
            dtgvSuatChieu.Columns["ngay_chieu"].HeaderText = "Ngày chiếu";
            dtgvSuatChieu.Columns["phim_id"].HeaderText = "Mã phim";
            dtgvSuatChieu.Columns["phong_chieu_id"].HeaderText = "Mã phòng";
            dtgvSuatChieu.Columns["dinh_dang_phim_id"].HeaderText = "Định dạng phim";
            dtgvSuatChieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvSuatChieu.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dtgvSuatChieu.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 6F);
            dtgvSuatChieu.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            dtgvSuatChieu.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.White;


        }
        void LoadPhimList()
        {
            string query = @"
        SELECT p.id, p.ten, p.thoi_luong, lp.ten AS loai_phim
        FROM dbo.phim p
        JOIN dbo.loai_phim lp ON p.loai_phim_id = lp.id";

            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);

            dtgvPhim.DataSource = data;

            // Cấu hình DataGridView
            dtgvPhim.Columns["id"].HeaderText = "Mã phim";
            dtgvPhim.Columns["ten"].HeaderText = "Tên Phim";
            dtgvPhim.Columns["thoi_luong"].HeaderText = "Thời Lượng (phút)";
            dtgvPhim.Columns["loai_phim"].HeaderText = "Loại phim";
            dtgvPhim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvPhim.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dtgvPhim.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8F);
            dtgvPhim.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            dtgvPhim.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {

        }

        private void btnTimKiemPhim_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiemPhim_Click_1(object sender, EventArgs e)
        {

        }
    }
}
