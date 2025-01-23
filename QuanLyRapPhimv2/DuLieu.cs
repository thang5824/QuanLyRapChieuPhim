using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using BLL;
using QuanLyRapPhimv2.DAO;
using QuanLyRapPhimv2.DTO;

namespace QuanLyRapPhimv2
{
    public partial class DuLieu : Form
    {
        private string connectionSTR = "Data Source=HUYNHTHANG\\SQLEXPRESS;Initial Catalog=QuanlyRapChieuPhim;Integrated Security=True";

        Database db = new Database();

        public DatVePhim_BLL datVeBLL;

        private Timer PhimTimer, gheTimer, giaVeTimer;


        public DuLieu()
        {
            InitializeComponent();
            LoadPhimList();
            LoadPhongChieuList();
            LoadSuatChieuList();
            LoadDinhDangPhimList();
            LoadMonAnList();
           
            LoadVeBanList();
            LoadGiaVeList();
            LoadGheNgoiList();
            LoadLoaiGhe();
            LoadLoaiPhim();
            LoadNhanVienList();
            LoadKhachHangList();
            LoadLoaiMonAn();


            // code sửa đổi 

            datVeBLL = new DatVePhim_BLL(new Database().GetDatabase());

            LoadDataDatVePhim();

            giaVeTimer = new Timer();
            giaVeTimer.Interval = 1000;
            giaVeTimer.Tick += (s, e) => LoadDataGiave();
            giaVeTimer.Start();

            gheTimer = new Timer();
            gheTimer.Interval = 1000;
            gheTimer.Tick += (s, e) => LoadDataGhe();
            gheTimer.Start();

            PhimTimer = new Timer();
            PhimTimer.Interval = 1000;
            PhimTimer.Tick += (s, e) => LoadDataPhim();
            PhimTimer.Start();



        }
        // Load dữ liệu vào comboBox các thông tin 
        public void LoadDataPhim()
        {
            string connectionString = new Database().GetDatabase();
            string query = "SELECT id, ten FROM phim";


            var selectedValue = cbChonPhim.SelectedValue;

            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cbChonPhim.DisplayMember = "ten";
            cbChonPhim.ValueMember = "id";
            cbChonPhim.DataSource = dt;


            if (selectedValue != null && dt.AsEnumerable().Any(row => row["id"].ToString() == selectedValue.ToString()))
            {
                cbChonPhim.SelectedValue = selectedValue;
            }
            else
            {

                cbChonPhim.SelectedIndex = 0;
            }
        }


        public void LoadDataGhe()
        {
            string connectionString = new Database().GetDatabase();
            string query = "SELECT id, loai_ghe_id FROM ghe_ngoi";


            var selectedValue = cbViTriNgoi.SelectedValue;

            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cbViTriNgoi.DisplayMember = "loai_ghe_id";
            cbViTriNgoi.ValueMember = "id";
            cbViTriNgoi.DataSource = dt;


            if (selectedValue != null && dt.AsEnumerable().Any(row => row["id"].ToString() == selectedValue.ToString()))
            {
                cbViTriNgoi.SelectedValue = selectedValue;
            }
            else
            {

                cbViTriNgoi.SelectedIndex = 0;
            }
        }

        public void LoadDataGiave()
        {
            string connectionString = new Database().GetDatabase();
            string query = "SELECT id, don_gia FROM gia_ve";


            var selectedValue = cbChonGiaVe.SelectedValue;

            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cbChonGiaVe.DisplayMember = "don_gia";
            cbChonGiaVe.ValueMember = "id";
            cbChonGiaVe.DataSource = dt;


            if (selectedValue != null && dt.AsEnumerable().Any(row => row["id"].ToString() == selectedValue.ToString()))
            {
                cbChonGiaVe.SelectedValue = selectedValue;
            }
            else
            {

                cbChonGiaVe.SelectedIndex = 0;
            }
        }


        public void LoadDataDatVePhim()
        {
            try
            {
                data_veDat.DataSource = datVeBLL.LoadDatVe();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin : " + ex, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //----------------------------------------------------------------------------------------------------------------------
        void LoadLoaiMonAn()
        {
            string query = "SELECT * FROM loai_mon_an"; // Truy vấn để lấy dữ liệu từ bảng loai_mon_an
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);

            cbLoaiMonAn.DataSource = data;
            cbLoaiMonAn.DisplayMember = "ten"; // Tên hiển thị trong ComboBox
            cbLoaiMonAn.ValueMember = "id"; // Giá trị của phần tử
        }

        void LoadKhachHangList()
        {
            string query = "SELECT * FROM khach_hang"; // Truy vấn để lấy dữ liệu từ bảng khach_hang
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);
            dtgvKhachHang.DataSource = data;

            // Cấu hình DataGridView
            dtgvKhachHang.Columns["id"].HeaderText = "ID Khách Hàng";
            dtgvKhachHang.Columns["ho_ten"].HeaderText = "Họ Tên";
            dtgvKhachHang.Columns["so_cmnd"].HeaderText = "Số CMND/CCCD";
            dtgvKhachHang.Columns["mat_khau"].HeaderText = "Mật Khẩu";
            dtgvKhachHang.Columns["so_dien_thoai"].HeaderText = "Số Điện Thoại";
            dtgvKhachHang.Columns["email"].HeaderText = "Email";
            dtgvKhachHang.Columns["dia_chi"].HeaderText = "Địa Chỉ";
            dtgvKhachHang.Columns["ngay_dang_ky"].HeaderText = "Ngày Đăng Ký";
            dtgvKhachHang.Columns["ngay_sinh"].HeaderText = "Ngày Sinh";
            dtgvKhachHang.Columns["gioi_tinh"].HeaderText = "Giới Tính";

            // Ẩn cột mật khẩu để bảo mật
            if (dtgvKhachHang.Columns["mat_khau"] != null) dtgvKhachHang.Columns["mat_khau"].Visible = false;

            // Tùy chỉnh hiển thị DataGridView
            dtgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvKhachHang.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dtgvKhachHang.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8F);
            dtgvKhachHang.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            dtgvKhachHang.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
            dtgvKhachHang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        void LoadNhanVienList()
        {
            string query = "SELECT * FROM nhan_vien"; // Truy vấn để lấy dữ liệu từ bảng nhan_vien
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);
            dtgvNhanVien.DataSource = data;

            // Cấu hình DataGridView
            if (dtgvNhanVien.Columns["id"] != null) dtgvNhanVien.Columns["id"].HeaderText = "ID Nhân Viên";
            if (dtgvNhanVien.Columns["ho_ten"] != null) dtgvNhanVien.Columns["ho_ten"].HeaderText = "Họ Tên";
            if (dtgvNhanVien.Columns["mat_khau"] != null) dtgvNhanVien.Columns["mat_khau"].HeaderText = "Mật Khẩu";
            if (dtgvNhanVien.Columns["so_cmnd"] != null) dtgvNhanVien.Columns["so_cmnd"].HeaderText = "Số CMND/CCCD";
            if (dtgvNhanVien.Columns["so_dien_thoai"] != null) dtgvNhanVien.Columns["so_dien_thoai"].HeaderText = "Số Điện Thoại";
            if (dtgvNhanVien.Columns["email"] != null) dtgvNhanVien.Columns["email"].HeaderText = "Email";
            if (dtgvNhanVien.Columns["ngay_vao_lam"] != null) dtgvNhanVien.Columns["ngay_vao_lam"].HeaderText = "Ngày Vào Làm";
            if (dtgvNhanVien.Columns["gioi_tinh"] != null) dtgvNhanVien.Columns["gioi_tinh"].HeaderText = "Giới Tính";
            if (dtgvNhanVien.Columns["vai_tro_id"] != null) dtgvNhanVien.Columns["vai_tro_id"].HeaderText = "Vai Trò";

            // Tùy chỉnh hiển thị DataGridView
            dtgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvNhanVien.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dtgvNhanVien.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8F);
            dtgvNhanVien.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            dtgvNhanVien.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.White;

            // Tự động điều chỉnh chiều cao hàng để vừa nội dung
            dtgvNhanVien.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }



        void LoadLoaiPhim()
        {
            string query = "SELECT * FROM loai_phim";
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);

            cbLoaiPhim.DataSource = data;
            cbLoaiPhim.DisplayMember = "ten";
            cbLoaiPhim.ValueMember = "id";
        }

        void LoadLoaiGhe()
        {
            string query = "SELECT * FROM loai_ghe";
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);

            cbLoaiGhe.DataSource = data;
            cbLoaiGhe.DisplayMember = "ten_ghe";
            cbLoaiGhe.ValueMember = "id";
        }






        void LoadGheNgoiList()
        {
            string query = "SELECT id, vi_tri_day, vi_tri_cot, da_chon, phong_chieu_id, loai_ghe_id FROM ghe_ngoi";
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);
            dtgvGheNgoi.DataSource = data;

            dtgvGheNgoi.Columns["id"].HeaderText = "ID Ghế Ngồi";
            dtgvGheNgoi.Columns["vi_tri_day"].HeaderText = "Vị Trí Dãy";
            dtgvGheNgoi.Columns["vi_tri_cot"].HeaderText = "Vị Trí Cột";
            dtgvGheNgoi.Columns["da_chon"].HeaderText = "Đã Chọn";
            dtgvGheNgoi.Columns["phong_chieu_id"].HeaderText = "ID Phòng Chiếu";
            dtgvGheNgoi.Columns["loai_ghe_id"].HeaderText = "ID Loại Ghế";

            dtgvGheNgoi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvGheNgoi.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dtgvGheNgoi.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8F);
            dtgvGheNgoi.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            dtgvGheNgoi.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
            dtgvGheNgoi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }




        void LoadGiaVeList()
        {
          
        }







        void LoadPhimList()
        {
            string query = "SELECT id, ten, thoi_luong, loai_phim_id FROM phim";
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);
            dtgvPhim.DataSource = data;

            dtgvPhim.Columns["id"].HeaderText = "ID Phim";
            dtgvPhim.Columns["ten"].HeaderText = "Tên Phim";
            dtgvPhim.Columns["thoi_luong"].HeaderText = "Thời Lượng";
            dtgvPhim.Columns["loai_phim_id"].HeaderText = "Loại Phim";

            dtgvPhim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvPhim.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dtgvPhim.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8F);
            dtgvPhim.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            dtgvPhim.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
            dtgvPhim.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }


        void LoadPhongChieuList()
        {
            string query = "SELECT id, so_luong_day, so_luong_cot FROM phong_chieu";
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);
            dtgvPhongChieu.DataSource = data;

            dtgvPhongChieu.Columns["id"].HeaderText = "ID Phòng Chiếu";
            dtgvPhongChieu.Columns["so_luong_day"].HeaderText = "Số Lượng Dãy";
            dtgvPhongChieu.Columns["so_luong_cot"].HeaderText = "Số Lượng Cột";

            dtgvPhongChieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvPhongChieu.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dtgvPhongChieu.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8F);
            dtgvPhongChieu.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            dtgvPhongChieu.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
            dtgvPhongChieu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        void LoadSuatChieuList()
        {
            string query = "SELECT id, gio_bat_dau, gio_ket_thuc, ngay_chieu, phim_id, phong_chieu_id, dinh_dang_phim_id FROM suat_chieu";
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);
            dtgvSuatChieu.DataSource = data;

            dtgvSuatChieu.Columns["id"].HeaderText = "ID Suất Chiếu";
            dtgvSuatChieu.Columns["gio_bat_dau"].HeaderText = "Giờ Bắt Đầu";
            dtgvSuatChieu.Columns["gio_ket_thuc"].HeaderText = "Giờ Kết Thúc";
            dtgvSuatChieu.Columns["ngay_chieu"].HeaderText = "Ngày Chiếu";
            dtgvSuatChieu.Columns["phim_id"].HeaderText = "ID Phim";
            dtgvSuatChieu.Columns["phong_chieu_id"].HeaderText = "ID Phòng Chiếu";
            dtgvSuatChieu.Columns["dinh_dang_phim_id"].HeaderText = "ID Định Dạng Phim";

            dtgvSuatChieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvSuatChieu.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dtgvSuatChieu.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8F);
            dtgvSuatChieu.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            dtgvSuatChieu.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
            dtgvSuatChieu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }


        void LoadDinhDangPhimList()
        {
            string query = "SELECT id, ten, phu_thu FROM dinh_dang_phim";
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);
            dtgvDinhDangPhim.DataSource = data;

            dtgvDinhDangPhim.Columns["id"].HeaderText = "ID Định Dạng Phim";
            dtgvDinhDangPhim.Columns["ten"].HeaderText = "Tên Định Dạng Phim";
            dtgvDinhDangPhim.Columns["phu_thu"].HeaderText = "Phụ Thu";

            dtgvDinhDangPhim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvDinhDangPhim.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dtgvDinhDangPhim.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8F);
            dtgvDinhDangPhim.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            dtgvDinhDangPhim.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
            dtgvDinhDangPhim.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }


        void LoadMonAnList()
        {
            string query = "SELECT id, ten, gia, loai_mon_an_id FROM mon_an";
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);
            dtgvMonAn.DataSource = data;

            dtgvMonAn.Columns["id"].HeaderText = "ID Món Ăn";
            dtgvMonAn.Columns["ten"].HeaderText = "Tên Món Ăn";
            dtgvMonAn.Columns["gia"].HeaderText = "Giá";
            dtgvMonAn.Columns["loai_mon_an_id"].HeaderText = "ID Loại Món Ăn";

            dtgvMonAn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvMonAn.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dtgvMonAn.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8F);
            dtgvMonAn.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            dtgvMonAn.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
            dtgvMonAn.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }













        private void btnSua1_Click(object sender, EventArgs e)
        {
            string idPhongChieu = txtMaPhong.Text;
            int soLuongDay = int.Parse(txtSoLuongDay.Text);
            int soLuongCot = int.Parse(txtSoLuongCot.Text);

            string connectionSTR = "Data Source=HUYNHTHANG\\SQLEXPRESS;Initial Catalog=QuanlyRapChieuPhimV2;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                string query = "UPDATE phong_chieu SET so_luong_day = @SoLuongDay, so_luong_cot = @SoLuongCot WHERE id = @IDPhongChieu";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IDPhongChieu", idPhongChieu);
                    command.Parameters.AddWithValue("@SoLuongDay", soLuongDay);
                    command.Parameters.AddWithValue("@SoLuongCot", soLuongCot);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật phòng chiếu thành công!");

                        // Refresh the DataGridView
                        LoadPhongChieuList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi cập nhật phòng chiếu: " + ex.Message);
                    }
                }
            }
        }



        private void btnXoa1_Click(object sender, EventArgs e)
        {
            string idPhongChieu = txtMaPhong.Text;

            string connectionSTR = "Data Source=HUYNHTHANG\\SQLEXPRESS;Initial Catalog=QuanlyRapChieuPhimV2;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                string query = "DELETE FROM phong_chieu WHERE id = @IDPhongChieu";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IDPhongChieu", idPhongChieu);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Xóa phòng chiếu thành công!");

                        // Refresh the DataGridView
                        LoadPhongChieuList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa phòng chiếu: " + ex.Message);
                    }
                }
            }
        }



        private void btnTim_Click(object sender, EventArgs e)
        {
            string keyword = txtTim.Text;

            string query = $"SELECT * FROM dbo.phim WHERE ten LIKE '%{keyword}%' OR thoi_luong LIKE '%{keyword}%'";
            DataProvider provider = new DataProvider();
            dtgvPhim.DataSource = provider.ExecuteQuery(query);

            query = $"SELECT * FROM dbo.phong_chieu WHERE id LIKE '%{keyword}%' OR so_luong_day LIKE '%{keyword}%'";
            dtgvPhongChieu.DataSource = provider.ExecuteQuery(query);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            // Add event logic here if needed
        }

        private void DuLieu_Load(object sender, EventArgs e)
        {
            // Add initialization logic here if needed
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Add logic here if needed
        }

        private void btnTim1_Click(object sender, EventArgs e)
        {
            string searchKeyword = txtTim1.Text.Trim();

            string connectionSTR = "Data Source=HUYNHTHANG\\SQLEXPRESS;Initial Catalog=QuanlyRapChieuPhimV2;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                string query = "SELECT id, so_luong_day, so_luong_cot FROM phong_chieu WHERE id LIKE '%' + @SearchKeyword + '%'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SearchKeyword", searchKeyword);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dtgvPhongChieu.DataSource = dataTable;

                    // Customize DataGridView appearance (optional)
                    dtgvPhongChieu.Columns["id"].HeaderText = "ID Phòng Chiếu";
                    dtgvPhongChieu.Columns["so_luong_day"].HeaderText = "Số Lượng Dãy";
                    dtgvPhongChieu.Columns["so_luong_cot"].HeaderText = "Số Lượng Cột";

                    dtgvPhongChieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dtgvPhongChieu.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    dtgvPhongChieu.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8F);
                    dtgvPhongChieu.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
                    dtgvPhongChieu.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
                    dtgvPhongChieu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                }
            }
        }






        private void dtgvPhim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Add logic here if needed
        }

        private void btnThem2_Click(object sender, EventArgs e)
        {
            string id = txtMaSuatChieu.Text;
            TimeSpan gio_bat_dau = dtpGioBatDau.Value.TimeOfDay; // DateTimePicker for start time
            TimeSpan gio_ket_thuc = dtpGioKetThuc.Value.TimeOfDay; // DateTimePicker for end time
            DateTime ngay_chieu = dtpNgayChieu.Value.Date; // DateTimePicker for show date
            string phim_id = txtMaPhim1.Text;
            int phong_chieu_id = int.Parse(txtMaPhong2.Text);
            string dinh_dang_phim_id = txtMaDinhDang.Text;

            string connectionSTR = "Data Source=HUYNHTHANG\\SQLEXPRESS;Initial Catalog=QuanlyRapChieuPhimV2;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                string sqlInsert = "INSERT INTO suat_chieu (id, gio_bat_dau, gio_ket_thuc, ngay_chieu, phim_id, phong_chieu_id, dinh_dang_phim_id) " +
                                   "VALUES (@id, @gio_bat_dau, @gio_ket_thuc, @ngay_chieu, @phim_id, @phong_chieu_id, @dinh_dang_phim_id)";

                using (SqlCommand cmd = new SqlCommand(sqlInsert, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@gio_bat_dau", gio_bat_dau);
                    cmd.Parameters.AddWithValue("@gio_ket_thuc", gio_ket_thuc);
                    cmd.Parameters.AddWithValue("@ngay_chieu", ngay_chieu);
                    cmd.Parameters.AddWithValue("@phim_id", phim_id);
                    cmd.Parameters.AddWithValue("@phong_chieu_id", phong_chieu_id);
                    cmd.Parameters.AddWithValue("@dinh_dang_phim_id", dinh_dang_phim_id);

                    try
                    {
                        int count = cmd.ExecuteNonQuery();
                        MessageBox.Show($"{count} suất chiếu đã được thêm thành công!");
                        LoadSuatChieuList(); // Refresh the showtime list
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Xảy ra lỗi: {ex.Message}");
                    }
                }
            }
        }


        private void btnSua2_Click(object sender, EventArgs e)
        {
            string id = txtMaSuatChieu.Text;
            TimeSpan gio_bat_dau = dtpGioBatDau.Value.TimeOfDay; // DateTimePicker for start time
            TimeSpan gio_ket_thuc = dtpGioKetThuc.Value.TimeOfDay; // DateTimePicker for end time
            DateTime ngay_chieu = dtpNgayChieu.Value.Date; // DateTimePicker for show date
            string phim_id = txtMaPhim1.Text;
            int phong_chieu_id = int.Parse(txtMaPhong2.Text);
            string dinh_dang_phim_id = txtMaDinhDang.Text;

            string connectionSTR = "Data Source=HUYNHTHANG\\SQLEXPRESS;Initial Catalog=QuanlyRapChieuPhimV2;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                string sqlUpdate = "UPDATE suat_chieu SET gio_bat_dau = @gio_bat_dau, gio_ket_thuc = @gio_ket_thuc, ngay_chieu = @ngay_chieu, " +
                                   "phim_id = @phim_id, phong_chieu_id = @phong_chieu_id, dinh_dang_phim_id = @dinh_dang_phim_id WHERE id = @id";

                using (SqlCommand cmd = new SqlCommand(sqlUpdate, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@gio_bat_dau", gio_bat_dau);
                    cmd.Parameters.AddWithValue("@gio_ket_thuc", gio_ket_thuc);
                    cmd.Parameters.AddWithValue("@ngay_chieu", ngay_chieu);
                    cmd.Parameters.AddWithValue("@phim_id", phim_id);
                    cmd.Parameters.AddWithValue("@phong_chieu_id", phong_chieu_id);
                    cmd.Parameters.AddWithValue("@dinh_dang_phim_id", dinh_dang_phim_id);

                    try
                    {
                        int count = cmd.ExecuteNonQuery();
                        MessageBox.Show($"{count} suất chiếu đã được cập nhật thành công!");
                        LoadSuatChieuList(); // Refresh the showtime list
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Xảy ra lỗi: {ex.Message}");
                    }
                }
            }
        }


        private void btnXoa2_Click(object sender, EventArgs e)
        {
            string id = txtMaSuatChieu.Text;

            string connectionSTR = "Data Source=HUYNHTHANG\\SQLEXPRESS;Initial Catalog=QuanlyRapChieuPhimV2;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                string sqlDelete = "DELETE FROM suat_chieu WHERE id = @id";

                using (SqlCommand cmd = new SqlCommand(sqlDelete, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    try
                    {
                        int count = cmd.ExecuteNonQuery();
                        MessageBox.Show($"{count} suất chiếu đã được xóa thành công!");
                        LoadSuatChieuList(); // Refresh the showtime list
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Xảy ra lỗi: {ex.Message}");
                    }
                }
            }
        }


        private void tpPhim_Click(object sender, EventArgs e)
        {

        }

        private void tpVe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        void LoadVeBanList()
        {
            string query = "SELECT * FROM dbo.ve_ban";
            DataProvider provider = new DataProvider();
            DataTable data = provider.ExecuteQuery(query);

            this.data_veDat.DataSource = data;

            // Cấu hình DataGridView
            this.data_veDat.Columns["id"].HeaderText = "ID Vé Bán";
            this.data_veDat.Columns["ngay_ban"].HeaderText = "Ngày Bán";
            this.data_veDat.Columns["tong_tien"].HeaderText = "Tổng Tiền";
            this.data_veDat.Columns["suat_chieu_id"].HeaderText = "Suất Chiếu";
            this.data_veDat.Columns["gia_ve_id"].HeaderText = "Giá Vé";
            this.data_veDat.Columns["ghe_id"].HeaderText = "Ghế";
            this.data_veDat.Columns["nhan_vien_id"].HeaderText = "Nhân Viên";
            this.data_veDat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.data_veDat.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_veDat.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8F);
            this.data_veDat.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            this.data_veDat.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
        }






        private void DuLieu_Load_1(object sender, EventArgs e)
        {


        }

        private void btnTim3_Click(object sender, EventArgs e)
        {
            string searchKeyword = txtTim3.Text.Trim();

            string connectionSTR = "Data Source=HUYNHTHANG\\SQLEXPRESS;Initial Catalog=QuanlyRapChieuPhimV2;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
               
                string sqlSearch = "SELECT id, ten, gia, loai_mon_an_id FROM mon_an WHERE ten LIKE '%' + @searchKeyword + '%'";

                using (SqlCommand cmd = new SqlCommand(sqlSearch, connection))
                {
                    cmd.Parameters.AddWithValue("@searchKeyword", searchKeyword);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dtgvMonAn.DataSource = dataTable;

                    // Customize DataGridView appearance (optional)
                    dtgvMonAn.Columns["id"].HeaderText = "ID Món Ăn";
                    dtgvMonAn.Columns["ten"].HeaderText = "Tên Món Ăn";
                    dtgvMonAn.Columns["gia"].HeaderText = "Giá";
                    dtgvMonAn.Columns["loai_mon_an_id"].HeaderText = "Loại Món Ăn";

                    dtgvMonAn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dtgvMonAn.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    dtgvMonAn.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8F);
                    dtgvMonAn.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
                    dtgvMonAn.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
                    dtgvMonAn.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                }
            }
        }




        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.loai_mon_anTableAdapter.FillBy(this.quanLyRapDataSet.loai_mon_an);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        
       

        private void btnThemVe_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                string sqlInsert = @"
            INSERT INTO ve_ban (id, ngay_ban, tong_tien, suat_chieu_id, gia_ve_id, ghe_id, nhan_vien_id)
            VALUES (@id, @ngay_ban, @tong_tien, @suat_chieu_id, @gia_ve_id, @ghe_id, @nhan_vien_id)";

                using (SqlCommand cmd = new SqlCommand(sqlInsert, connection))
                {
                    try
                    {
                        string id = txtMaVe.Text;
                        DateTime ngayBan = dtpNgayBan.Value;
                        int tongTien = int.Parse(txtTongTien.Text);
                        string suatChieuID = txtMaSuatChieu1.Text;
                        int giaVeID = int.Parse(txtMaGia.Text);
                        int gheID = int.Parse(txtMaGhe.Text);
                        string nhanVienID = txtMaNhanVien.Text;

                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@ngay_ban", ngayBan);
                        cmd.Parameters.AddWithValue("@tong_tien", tongTien);
                        cmd.Parameters.AddWithValue("@suat_chieu_id", suatChieuID);
                        cmd.Parameters.AddWithValue("@gia_ve_id", giaVeID);
                        cmd.Parameters.AddWithValue("@ghe_id", gheID);
                        cmd.Parameters.AddWithValue("@nhan_vien_id", nhanVienID);

                        int count = cmd.ExecuteNonQuery();
                        MessageBox.Show($"{count} vé đã được thêm thành công!");
                        LoadVeBanList(); // Làm mới danh sách vé bán
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Xảy ra lỗi khi thêm vé: {ex.Message}");
                    }
                }
            }
        }

        private void btnSuaVe_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                string sqlUpdate = @"
            UPDATE ve_ban 
            SET ngay_ban = @ngay_ban, tong_tien = @tong_tien, suat_chieu_id = @suat_chieu_id, gia_ve_id = @gia_ve_id, ghe_id = @ghe_id, nhan_vien_id = @nhan_vien_id 
            WHERE id = @id";

                using (SqlCommand cmd = new SqlCommand(sqlUpdate, connection))
                {
                    try
                    {
                        string id = txtMaVe.Text;
                        DateTime ngayBan = dtpNgayBan.Value;
                        int tongTien = int.Parse(txtTongTien.Text);
                        string suatChieuID = txtMaSuatChieu1.Text;
                        int giaVeID = int.Parse(txtMaGia.Text);
                        int gheID = int.Parse(txtMaGhe.Text);
                        string nhanVienID = txtMaNhanVien.Text;

                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@ngay_ban", ngayBan);
                        cmd.Parameters.AddWithValue("@tong_tien", tongTien);
                        cmd.Parameters.AddWithValue("@suat_chieu_id", suatChieuID);
                        cmd.Parameters.AddWithValue("@gia_ve_id", giaVeID);
                        cmd.Parameters.AddWithValue("@ghe_id", gheID);
                        cmd.Parameters.AddWithValue("@nhan_vien_id", nhanVienID);

                        int count = cmd.ExecuteNonQuery();
                        MessageBox.Show($"{count} vé đã được cập nhật thành công!");
                        LoadVeBanList(); // Làm mới danh sách vé bán
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Xảy ra lỗi khi cập nhật vé: {ex.Message}");
                    }
                }
            }
        }

        private void btnXoaVe_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                string sqlDelete = "DELETE FROM ve_ban WHERE id = @id";

                using (SqlCommand cmd = new SqlCommand(sqlDelete, connection))
                {
                    try
                    {
                        string id = txtMaVe.Text;

                        cmd.Parameters.AddWithValue("@id", id);

                        int count = cmd.ExecuteNonQuery();
                        MessageBox.Show($"{count} vé đã được xóa thành công!");
                        LoadVeBanList(); // Làm mới danh sách vé bán
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Xảy ra lỗi khi xóa vé: {ex.Message}");
                    }
                }
            }
        }

        private void dtgvGiaVe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnTim4_Click(object sender, EventArgs e)
        {
            string keyword = txtTim4.Text.Trim();

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                string query = @"
            SELECT * FROM ve_ban
            WHERE id LIKE @keyword OR CONVERT(VARCHAR, ngay_ban) LIKE @keyword OR suat_chieu_id LIKE @keyword OR gia_ve_id LIKE @keyword OR ghe_id LIKE @keyword OR nhan_vien_id LIKE @keyword";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                        DataTable data = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(data);

                        this.data_veDat.DataSource = data;

                        // Cấu hình DataGridView
                        this.data_veDat.Columns["id"].HeaderText = "ID Vé";
                        this.data_veDat.Columns["ngay_ban"].HeaderText = "Ngày Bán";
                        this.data_veDat.Columns["tong_tien"].HeaderText = "Tổng Tiền";
                        this.data_veDat.Columns["suat_chieu_id"].HeaderText = "Suất Chiếu";
                        this.data_veDat.Columns["gia_ve_id"].HeaderText = "Giá Vé";
                        this.data_veDat.Columns["ghe_id"].HeaderText = "Ghế";
                        this.data_veDat.Columns["nhan_vien_id"].HeaderText = "Nhân Viên";
                        this.data_veDat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        this.data_veDat.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.data_veDat.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8F);
                        this.data_veDat.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
                        this.data_veDat.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Xảy ra lỗi khi tìm kiếm: {ex.Message}");
                    }
                }
            }
        }

        private void btnThemGhe_Click(object sender, EventArgs e)
        {
            string idGhe = txtMaGhe1.Text;
            int viTriDay = int.Parse(txtViTriDay.Text);
            int viTriCot = int.Parse(txtViTriCot.Text);
            bool daChon = chkDaChon.Checked;
            int phongChieuID = int.Parse(txtMaPhongChieu1.Text);
            int loaiGheID = (int)cbLoaiGhe.SelectedValue;

            string connectionSTR = "Data Source=HUYNHTHANG\\SQLEXPRESS;Initial Catalog=QuanlyRapChieuPhimV2;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                string sqlInsert = "INSERT INTO ghe_ngoi (id, vi_tri_day, vi_tri_cot, da_chon, phong_chieu_id, loai_ghe_id) VALUES (@id, @vi_tri_day, @vi_tri_cot, @da_chon, @phong_chieu_id, @loai_ghe_id)";

                using (SqlCommand cmd = new SqlCommand(sqlInsert, connection))
                {
                    cmd.Parameters.AddWithValue("@id", idGhe);
                    cmd.Parameters.AddWithValue("@vi_tri_day", viTriDay);
                    cmd.Parameters.AddWithValue("@vi_tri_cot", viTriCot);
                    cmd.Parameters.AddWithValue("@da_chon", daChon);
                    cmd.Parameters.AddWithValue("@phong_chieu_id", phongChieuID);
                    cmd.Parameters.AddWithValue("@loai_ghe_id", loaiGheID);

                    try
                    {
                        int count = cmd.ExecuteNonQuery();
                        MessageBox.Show($"{count} ghế ngồi đã được thêm thành công!");
                        LoadGheNgoiList(); // Làm mới danh sách ghế ngồi
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Xảy ra lỗi khi thêm ghế ngồi: {ex.Message}");
                    }
                }
            }
        }



        private void btnTim_Click_1(object sender, EventArgs e)
{
    string searchKeyword = txtTim.Text.Trim();

    string connectionSTR = "Data Source=HUYNHTHANG\\SQLEXPRESS;Initial Catalog=QuanlyRapChieuPhimV2;Integrated Security=True";

    using (SqlConnection connection = new SqlConnection(connectionSTR))
    {
        connection.Open();
        string query = "SELECT id, ten, thoi_luong, loai_phim_id FROM phim WHERE ten LIKE '%' + @SearchKeyword + '%'";

        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@SearchKeyword", searchKeyword);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dtgvPhim.DataSource = dataTable;

            // Customize DataGridView appearance (optional)
            dtgvPhim.Columns["id"].HeaderText = "ID Phim";
            dtgvPhim.Columns["ten"].HeaderText = "Tên Phim";
            dtgvPhim.Columns["thoi_luong"].HeaderText = "Thời Lượng";
            dtgvPhim.Columns["loai_phim_id"].HeaderText = "Loại Phim";

            dtgvPhim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvPhim.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dtgvPhim.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8F);
            dtgvPhim.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            dtgvPhim.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
            dtgvPhim.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
    }
}


        private void btnSuaGhe_Click(object sender, EventArgs e)
        {
            string idGhe = txtMaGhe1.Text;
            int viTriDay = int.Parse(txtViTriDay.Text);
            int viTriCot = int.Parse(txtViTriCot.Text);
            bool daChon = chkDaChon.Checked;
            int phongChieuID = int.Parse(txtMaPhongChieu1.Text);
            int loaiGheID = (int)cbLoaiGhe.SelectedValue;

            string connectionSTR = "Data Source=HUYNHTHANG\\SQLEXPRESS;Initial Catalog=QuanlyRapChieuPhimV2;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                string sqlUpdate = "UPDATE ghe_ngoi SET vi_tri_day = @vi_tri_day, vi_tri_cot = @vi_tri_cot, da_chon = @da_chon, phong_chieu_id = @phong_chieu_id, loai_ghe_id = @loai_ghe_id WHERE id = @id";

                using (SqlCommand cmd = new SqlCommand(sqlUpdate, connection))
                {
                    cmd.Parameters.AddWithValue("@id", idGhe);
                    cmd.Parameters.AddWithValue("@vi_tri_day", viTriDay);
                    cmd.Parameters.AddWithValue("@vi_tri_cot", viTriCot);
                    cmd.Parameters.AddWithValue("@da_chon", daChon);
                    cmd.Parameters.AddWithValue("@phong_chieu_id", phongChieuID);
                    cmd.Parameters.AddWithValue("@loai_ghe_id", loaiGheID);

                    try
                    {
                        int count = cmd.ExecuteNonQuery();
                        MessageBox.Show($"{count} ghế ngồi đã được cập nhật thành công!");
                        LoadGheNgoiList(); // Làm mới danh sách ghế ngồi
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Xảy ra lỗi khi cập nhật ghế ngồi: {ex.Message}");
                    }
                }
            }
        }


        private void btnXoaGhe_Click(object sender, EventArgs e)
        {
            string idGhe = txtMaGhe1.Text;

            string connectionSTR = "Data Source=HUYNHTHANG\\SQLEXPRESS;Initial Catalog=QuanlyRapChieuPhimV2;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                string sqlDelete = "DELETE FROM ghe_ngoi WHERE id = @id";

                using (SqlCommand cmd = new SqlCommand(sqlDelete, connection))
                {
                    cmd.Parameters.AddWithValue("@id", idGhe);

                    try
                    {
                        int count = cmd.ExecuteNonQuery();
                        MessageBox.Show($"{count} ghế ngồi đã được xóa thành công!");
                        LoadGheNgoiList(); // Làm mới danh sách ghế ngồi
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Xảy ra lỗi khi xóa ghế ngồi: {ex.Message}");
                    }
                }
            }
        }






        private void btnTim5_TextChanged(object sender, EventArgs e)
        {
            // Logic xử lý sự kiện khi nội dung TextBox thay đổi
            string keyword = txtTim5.Text.Trim();

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                string query = @"
            SELECT * FROM phim
            WHERE id LIKE @keyword OR ten LIKE @keyword OR thoi_luong LIKE @keyword OR loai_phim_id LIKE @keyword";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                        DataTable data = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(data);

                        dtgvPhim.DataSource = data;

                        // Cấu hình DataGridView
                        if (dtgvPhim.Columns["id"] != null) dtgvPhim.Columns["id"].HeaderText = "ID Phim";
                        if (dtgvPhim.Columns["ten"] != null) dtgvPhim.Columns["ten"].HeaderText = "Tên Phim";
                        if (dtgvPhim.Columns["thoi_luong"] != null) dtgvPhim.Columns["thoi_luong"].HeaderText = "Thời Lượng";
                        if (dtgvPhim.Columns["loai_phim_id"] != null) dtgvPhim.Columns["loai_phim_id"].HeaderText = "Loại Phim";

                        // Tùy chỉnh hiển thị DataGridView
                        dtgvPhim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dtgvPhim.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        dtgvPhim.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8F);
                        dtgvPhim.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
                        dtgvPhim.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
                        dtgvPhim.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Xảy ra lỗi khi tìm kiếm: {ex.Message}");
                    }
                }
            }
        }








        private void dpNgayVaoLam_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SuaNhanVien_Click(object sender, EventArgs e)
        {

        }

       

       

        private void btnTimNhanVien_Click(object sender, EventArgs e)
        {
            string keyword = txtTimNhanVien.Text.Trim();

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                string query = @"
            SELECT nv.id, nv.ho_ten, nv.mat_khau, nv.so_cmnd, nv.so_dien_thoai, nv.email, nv.ngay_vao_lam, nv.gioi_tinh, vt.ten AS vai_tro
            FROM nhan_vien nv
            LEFT JOIN vai_tro vt ON nv.vai_tro_id = vt.id
            WHERE nv.id LIKE @keyword OR nv.ho_ten LIKE @keyword OR nv.so_cmnd LIKE @keyword OR nv.so_dien_thoai LIKE @keyword OR nv.email LIKE @keyword";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                        DataTable data = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(data);

                        dtgvNhanVien.DataSource = data;

                        // Cấu hình DataGridView
                        dtgvNhanVien.Columns["id"].HeaderText = "ID Nhân Viên";
                        dtgvNhanVien.Columns["ho_ten"].HeaderText = "Họ Tên";
                        dtgvNhanVien.Columns["mat_khau"].HeaderText = "Mật Khẩu";
                        dtgvNhanVien.Columns["so_cmnd"].HeaderText = "Số CMND/CCCD";
                        dtgvNhanVien.Columns["so_dien_thoai"].HeaderText = "Số Điện Thoại";
                        dtgvNhanVien.Columns["email"].HeaderText = "Email";
                        dtgvNhanVien.Columns["ngay_vao_lam"].HeaderText = "Ngày Vào Làm";
                        dtgvNhanVien.Columns["gioi_tinh"].HeaderText = "Giới Tính";
                        dtgvNhanVien.Columns["vai_tro"].HeaderText = "Vai Trò"; // Hiển thị tên vai trò thay vì ID

                        // Ẩn cột mật khẩu để bảo mật
                        if (dtgvNhanVien.Columns["mat_khau"] != null) dtgvNhanVien.Columns["mat_khau"].Visible = false;

                        // Tùy chỉnh hiển thị DataGridView
                        dtgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dtgvNhanVien.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        dtgvNhanVien.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8F);
                        dtgvNhanVien.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
                        dtgvNhanVien.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.White;

                        // Tự động điều chỉnh chiều cao hàng để vừa nội dung
                        dtgvNhanVien.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Xảy ra lỗi khi tìm kiếm: {ex.Message}");
                    }
                }
            }
        }

        

       
        




        private void btnTimKhachHang_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKhachHang.Text.Trim();

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                string query = @"
            SELECT * FROM khach_hang
            WHERE id LIKE @keyword OR ho_ten LIKE @keyword OR so_cmnd LIKE @keyword OR so_dien_thoai LIKE @keyword OR email LIKE @keyword";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                        DataTable data = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(data);

                        dtgvKhachHang.DataSource = data;

                        // Cấu hình DataGridView
                        dtgvKhachHang.Columns["id"].HeaderText = "ID Khách Hàng";
                        dtgvKhachHang.Columns["ho_ten"].HeaderText = "Họ Tên";
                        dtgvKhachHang.Columns["so_cmnd"].HeaderText = "Số CMND/CCCD";
                        dtgvKhachHang.Columns["mat_khau"].HeaderText = "Mật Khẩu";
                        dtgvKhachHang.Columns["so_dien_thoai"].HeaderText = "Số Điện Thoại";
                        dtgvKhachHang.Columns["email"].HeaderText = "Email";
                        dtgvKhachHang.Columns["dia_chi"].HeaderText = "Địa Chỉ";
                        dtgvKhachHang.Columns["ngay_dang_ky"].HeaderText = "Ngày Đăng Ký";
                        dtgvKhachHang.Columns["ngay_sinh"].HeaderText = "Ngày Sinh";
                        dtgvKhachHang.Columns["gioi_tinh"].HeaderText = "Giới Tính";

                        // Ẩn cột mật khẩu để bảo mật
                        if (dtgvKhachHang.Columns["mat_khau"] != null) dtgvKhachHang.Columns["mat_khau"].Visible = false;

                        // Tùy chỉnh hiển thị DataGridView
                        dtgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dtgvKhachHang.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        dtgvKhachHang.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8F);
                        dtgvKhachHang.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
                        dtgvKhachHang.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
                        dtgvKhachHang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Xảy ra lỗi khi tìm kiếm: {ex.Message}");
                    }
                }
            }
        }

        private void dtgvPhongChieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnXoa3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtMaMonAn.Text.Trim());

            string connectionSTR = "Data Source=HUYNHTHANG\\SQLEXPRESS;Initial Catalog=QuanlyRapChieuPhimV2;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                string sqlDelete = "DELETE FROM mon_an WHERE id = @id";

                using (SqlCommand cmd = new SqlCommand(sqlDelete, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    try
                    {
                        int count = cmd.ExecuteNonQuery();
                        MessageBox.Show($"{count} món ăn đã được xóa thành công!");
                        LoadMonAnList(); // Refresh the food list
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Xảy ra lỗi khi xóa món ăn: {ex.Message}");
                    }
                }
            }
        }





        private void btnThem5_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                string sqlInsert = @"
            INSERT INTO mon_an (id, ten, gia, loai_mon_an_id)
            VALUES (@id, @ten, @gia, @loai_mon_an_id)";

                using (SqlCommand cmd = new SqlCommand(sqlInsert, connection))
                {
                    try
                    {
                        // Kiểm tra dữ liệu nhập liệu
                        int id = int.Parse(txtMaMonAn.Text.Trim());
                        string ten = txtTenMonAn.Text.Trim();
                        decimal gia = decimal.Parse(txtGiaMonAn.Text.Trim());
                        int loaiMonAnID = (int)cbLoaiMonAn.SelectedValue;

                        // Kiểm tra nếu có trường nào bị rỗng
                        if (string.IsNullOrEmpty(ten) || gia <= 0)
                        {
                            MessageBox.Show("Vui lòng nhập đầy đủ thông tin và đảm bảo thông tin hợp lệ.");
                            return;
                        }

                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@ten", ten);
                        cmd.Parameters.AddWithValue("@gia", gia);
                        cmd.Parameters.AddWithValue("@loai_mon_an_id", loaiMonAnID);

                        int count = cmd.ExecuteNonQuery();
                        MessageBox.Show($"{count} món ăn đã được thêm thành công!");
                        LoadMonAnList(); // Làm mới danh sách món ăn
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Xảy ra lỗi khi thêm món ăn: {ex.Message}");
                    }
                }
            }
        }

        private void btnThem3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtMaMonAn.Text.Trim());
            string ten = txtTenMonAn.Text.Trim();
            decimal gia = decimal.Parse(txtGiaMonAn.Text.Trim());
            int loaiMonAnID = (int)cbLoaiMonAn.SelectedValue;

            string connectionSTR = "Data Source=HUYNHTHANG\\SQLEXPRESS;Initial Catalog=QuanlyRapChieuPhimV2;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                string sqlInsert = "INSERT INTO mon_an (id, ten, gia, loai_mon_an_id) VALUES (@id, @ten, @gia, @loai_mon_an_id)";

                using (SqlCommand cmd = new SqlCommand(sqlInsert, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@ten", ten);
                    cmd.Parameters.AddWithValue("@gia", gia);
                    cmd.Parameters.AddWithValue("@loai_mon_an_id", loaiMonAnID);

                    try
                    {
                        int count = cmd.ExecuteNonQuery();
                        MessageBox.Show($"{count} món ăn đã được thêm thành công!");
                        LoadMonAnList(); // Refresh the food list
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Xảy ra lỗi khi thêm món ăn: {ex.Message}");
                    }
                }
            }
        }



        private void btnSua3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtMaMonAn.Text.Trim());
            string ten = txtTenMonAn.Text.Trim();
            decimal gia = decimal.Parse(txtGiaMonAn.Text.Trim());
            int loaiMonAnID = (int)cbLoaiMonAn.SelectedValue;

            string connectionSTR = "Data Source=HUYNHTHANG\\SQLEXPRESS;Initial Catalog=QuanlyRapChieuPhimV2;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                string sqlUpdate = "UPDATE mon_an SET ten = @ten, gia = @gia, loai_mon_an_id = @loai_mon_an_id WHERE id = @id";

                using (SqlCommand cmd = new SqlCommand(sqlUpdate, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@ten", ten);
                    cmd.Parameters.AddWithValue("@gia", gia);
                    cmd.Parameters.AddWithValue("@loai_mon_an_id", loaiMonAnID);

                    try
                    {
                        int count = cmd.ExecuteNonQuery();
                        MessageBox.Show($"{count} món ăn đã được cập nhật thành công!");
                        LoadMonAnList(); // Refresh the food list
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Xảy ra lỗi khi cập nhật món ăn: {ex.Message}");
                    }
                }
            }
        }






        private void tpMonAn_Click(object sender, EventArgs e)
        {

        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            string phimId = cbChonPhim.SelectedValue.ToString();
            int gheNgoiId = int.Parse(cbViTriNgoi.SelectedValue.ToString());
            int giaVeId = int.Parse(cbChonGiaVe.SelectedValue.ToString());
            DateTime thoiGianDat = DateTime.Now;
            string trangThai = cbTrangThaiVe.Text;

            if (datVeBLL.AddDatVe(phimId, gheNgoiId, thoiGianDat, giaVeId, trangThai))
            {
                MessageBox.Show("Thêm vé đặt thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataDatVePhim();
            }
            else
            {
                MessageBox.Show("Thêm vé thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (data_veDat.CurrentRow == null || data_veDat.CurrentRow.Index == -1)
            {
                MessageBox.Show("Vui lòng chọn một vé để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn cập nhật thay đổi vé này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int id = int.Parse(data_veDat.CurrentRow.Cells["id"].Value.ToString());
                    string phimId = cbChonPhim.SelectedValue.ToString();
                    int gheNgoiId = int.Parse(cbViTriNgoi.SelectedValue.ToString());
                    int giaVeId = int.Parse(cbChonGiaVe.SelectedValue.ToString());
                    DateTime thoiGianDat = DateTime.Now;
                    string trangThai = cbTrangThaiVe.Text;

                    if (datVeBLL.EditDatVe(id, phimId, gheNgoiId, thoiGianDat, giaVeId, trangThai))
                    {
                        MessageBox.Show("Cập nhật vé thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataDatVePhim();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật vé thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnXoaVe_Click_1(object sender, EventArgs e)
        {

            try
            {

                if (data_veDat.CurrentRow == null || data_veDat.CurrentRow.Index == -1)
                {
                    MessageBox.Show("Vui lòng chọn một vé để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                int id = int.Parse(data_veDat.CurrentRow.Cells["id"].Value.ToString());



                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa vé này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {

                    bool isDeleted = datVeBLL.RemoveDatVe(id);

                    if (isDeleted)
                    {

                        MessageBox.Show("Xóa vé đặt thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataDatVePhim();
                    }
                    else
                    {

                        MessageBox.Show("Xóa vé thất bại. Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maPhim = txtMaPhim.Text;
            string tenPhim = txtTenPhim.Text;
            string thoiLuong = txtThoiLuong.Text;
            int idLoaiPhim = int.Parse(cbLoaiPhim.SelectedValue.ToString());

            string connectionSTR = "Data Source=HUYNHTHANG\\SQLEXPRESS;Initial Catalog=QuanlyRapChieuPhimV2;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                string query = "INSERT INTO dbo.Phim (id, ten, thoi_luong, loai_phim_id) VALUES (@MaPhim, @TenPhim, @ThoiLuong, @IDLoaiPhim)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaPhim", maPhim);
                    command.Parameters.AddWithValue("@TenPhim", tenPhim);
                    command.Parameters.AddWithValue("@ThoiLuong", thoiLuong);
                    command.Parameters.AddWithValue("@IDLoaiPhim", idLoaiPhim);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Thêm phim thành công!");

                        
                        LoadPhimList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi thêm phim: " + ex.Message);
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maPhim = txtMaPhim.Text;
            string tenPhim = txtTenPhim.Text;
            string thoiLuong = txtThoiLuong.Text;
            int idLoaiPhim = int.Parse(cbLoaiPhim.SelectedValue.ToString());

            string connectionSTR = "Data Source=HUYNHTHANG\\SQLEXPRESS;Initial Catalog=QuanlyRapChieuPhimV2;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                string query = "UPDATE dbo.Phim SET ten = @TenPhim, thoi_luong = @ThoiLuong, loai_phim_id = @IDLoaiPhim WHERE id = @MaPhim";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaPhim", maPhim);
                    command.Parameters.AddWithValue("@TenPhim", tenPhim);
                    command.Parameters.AddWithValue("@ThoiLuong", thoiLuong);
                    command.Parameters.AddWithValue("@IDLoaiPhim", idLoaiPhim);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật phim thành công!");

                        // Refresh the DataGridView
                        LoadPhimList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi cập nhật phim: " + ex.Message);
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maPhim = txtMaPhim.Text;

            string connectionSTR = "Data Source=HUYNHTHANG\\SQLEXPRESS;Initial Catalog=QuanlyRapChieuPhimV2;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                string query = "DELETE FROM dbo.Phim WHERE id = @MaPhim";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaPhim", maPhim);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Xóa phim thành công!");

                        // Refresh the DataGridView
                        LoadPhimList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa phim: " + ex.Message);
                    }
                }
            }
        }

        private void btnThem1_Click(object sender, EventArgs e)
        {
            string idPhongChieu = txtMaPhong.Text;
            int soLuongDay = int.Parse(txtSoLuongDay.Text);
            int soLuongCot = int.Parse(txtSoLuongCot.Text);

            string connectionSTR = "Data Source=HUYNHTHANG\\SQLEXPRESS;Initial Catalog=QuanlyRapChieuPhimV2;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                string query = "INSERT INTO dbo.phong_chieu (id, so_luong_day, so_luong_cot) VALUES (@IDPhongChieu, @SoLuongDay, @SoLuongCot)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IDPhongChieu", idPhongChieu);
                    command.Parameters.AddWithValue("@SoLuongDay", soLuongDay);
                    command.Parameters.AddWithValue("@SoLuongCot", soLuongCot);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Thêm phòng chiếu thành công!");

                        // Refresh the DataGridView
                        LoadPhongChieuList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi thêm phòng chiếu: " + ex.Message);
                    }
                }
            }
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            ThongKeHoaDon thongKeHoaDon = new ThongKeHoaDon();
            thongKeHoaDon.ShowDialog();
        }

        private void btnTim5_Click(object sender, EventArgs e)
        {
            string searchKeyword = txtTim5.Text.Trim();

            string connectionSTR = "Data Source=HUYNHTHANG\\SQLEXPRESS;Initial Catalog=QuanlyRapChieuPhimV2;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                string sqlSearch = "SELECT id, vi_tri_day, vi_tri_cot, da_chon, phong_chieu_id, loai_ghe_id FROM ghe_ngoi WHERE id LIKE '%' + @searchKeyword + '%'";

                using (SqlCommand cmd = new SqlCommand(sqlSearch, connection))
                {
                    cmd.Parameters.AddWithValue("@searchKeyword", searchKeyword);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dtgvGheNgoi.DataSource = dataTable;

                    // Customize DataGridView appearance (optional)
                    dtgvGheNgoi.Columns["id"].HeaderText = "ID Ghế Ngồi";
                    dtgvGheNgoi.Columns["vi_tri_day"].HeaderText = "Vị Trí Dãy";
                    dtgvGheNgoi.Columns["vi_tri_cot"].HeaderText = "Vị Trí Cột";
                    dtgvGheNgoi.Columns["da_chon"].HeaderText = "Đã Chọn";
                    dtgvGheNgoi.Columns["phong_chieu_id"].HeaderText = "ID Phòng Chiếu";
                    dtgvGheNgoi.Columns["loai_ghe_id"].HeaderText = "ID Loại Ghế";

                    dtgvGheNgoi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dtgvGheNgoi.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    dtgvGheNgoi.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8F);
                    dtgvGheNgoi.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
                    dtgvGheNgoi.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
                    dtgvGheNgoi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                }
            }
        }


        private void data_veDat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = data_veDat.Rows[e.RowIndex];


                if (row.Cells["phim_id"].Value != DBNull.Value && row.Cells["phim_id"].Value != null)
                {
                    cbChonPhim.SelectedValue = row.Cells["phim_id"].Value.ToString();
                }
                else
                {
                    cbChonPhim.SelectedIndex = -1;
                }


                if (row.Cells["ghe_ngoi_id"].Value != DBNull.Value && row.Cells["ghe_ngoi_id"].Value != null)
                {
                    cbViTriNgoi.SelectedValue = row.Cells["ghe_ngoi_id"].Value.ToString();
                }
                else
                {
                    cbViTriNgoi.SelectedIndex = -1;
                }


                if (row.Cells["gia_ve_id"].Value != DBNull.Value && row.Cells["gia_ve_id"].Value != null)
                {
                    cbChonGiaVe.SelectedValue = row.Cells["gia_ve_id"].Value.ToString();
                }
                else
                {
                    cbChonGiaVe.SelectedIndex = -1;
                }
            }
        }
    }
}




