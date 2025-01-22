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
using BLL;
using QuanLyRapPhimv2.DAO;
using QuanLyRapPhimv2.DTO;

namespace QuanLyRapPhimv2
{
    public partial class NhanVien : Form
    {
        private string connectionString = "Data Source=LAPTOP-DOCKI20T;Initial Catalog=QuanlyRapChieuPhimV2;Integrated Security=True";

        Database db = new Database();

        private QuanLyVe_BLL quanLyVeBLL;

        private Timer suatChieuTimer, nhanVienTimer, gheTimer, giaVeTimer;

        public NhanVien()
        {
            InitializeComponent();
           
            quanLyVeBLL = new QuanLyVe_BLL(new Database().GetDatabase());

            LoadDanhsachVe();

            LoadDanhsachVePhim();

            LoadDataHoaDon();

            suatChieuTimer = new Timer();
            suatChieuTimer.Interval = 1000;
            suatChieuTimer.Tick += (s, e) => LoadDataSuatChieu();
            suatChieuTimer.Start();

            nhanVienTimer = new Timer();
            nhanVienTimer.Interval = 1000;
            nhanVienTimer.Tick += (s, e) => LoadDataNhanVien();
            nhanVienTimer.Start();

            gheTimer = new Timer();
            gheTimer.Interval = 1000;
            gheTimer.Tick += (s, e) => LoadDataGhe();
            gheTimer.Start();

            giaVeTimer = new Timer();
            giaVeTimer.Interval = 1000;
            giaVeTimer.Tick += (s, e) => LoadDataGiave();
            giaVeTimer.Start();

        }

        //----------
        public void LoadDataHoaDon()
        {
            dtg_HoaDon.DataSource = quanLyVeBLL.LoadLisstHoaDon();
        }

        //--------
        public void LoadDataSuatChieu()
        {
            string connectionString = new Database().GetDatabase();
            string query = "SELECT id, gio_bat_dau FROM suat_chieu";


            var selectedValue = cb_suatChieu.SelectedValue;

            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cb_suatChieu.DisplayMember = "gio_bat_dau";
            cb_suatChieu.ValueMember = "id";
            cb_suatChieu.DataSource = dt;


            if (selectedValue != null && dt.AsEnumerable().Any(row => row["id"].ToString() == selectedValue.ToString()))
            {
                cb_suatChieu.SelectedValue = selectedValue;
            }
            else
            {

                cb_suatChieu.SelectedIndex = 0;
            }
        }

        public void LoadDataNhanVien()
        {
            string connectionString = new Database().GetDatabase();
            string query = "SELECT id, ho_ten FROM nhan_vien";


            var selectedValue = cb_NhanVien.SelectedValue;

            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cb_NhanVien.DisplayMember = "ho_ten";
            cb_NhanVien.ValueMember = "id";
            cb_NhanVien.DataSource = dt;


            if (selectedValue != null && dt.AsEnumerable().Any(row => row["id"].ToString() == selectedValue.ToString()))
            {
                cb_NhanVien.SelectedValue = selectedValue;
            }
            else
            {

                cb_NhanVien.SelectedIndex = 0;
            }
        }

        public void LoadDataGhe()
        {
            string connectionString = new Database().GetDatabase();
            string query = "SELECT id, loai_ghe_id FROM ghe_ngoi";


            var selectedValue = cb_Ghe.SelectedValue;

            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cb_Ghe.DisplayMember = "loai_ghe_id";
            cb_Ghe.ValueMember = "id";
            cb_Ghe.DataSource = dt;


            if (selectedValue != null && dt.AsEnumerable().Any(row => row["id"].ToString() == selectedValue.ToString()))
            {
                cb_Ghe.SelectedValue = selectedValue;
            }
            else
            {

                cb_Ghe.SelectedIndex = 0;
            }
        }

        public void LoadDataGiave()
        {
            string connectionString = new Database().GetDatabase();
            string query = "SELECT id, don_gia FROM gia_ve";


            var selectedValue = cb_GiaVe.SelectedValue;

            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cb_GiaVe.DisplayMember = "don_gia";
            cb_GiaVe.ValueMember = "id";
            cb_GiaVe.DataSource = dt;


            if (selectedValue != null && dt.AsEnumerable().Any(row => row["id"].ToString() == selectedValue.ToString()))
            {
                cb_GiaVe.SelectedValue = selectedValue;
            }
            else
            {

                cb_GiaVe.SelectedIndex = 0;
            }
        }


        //-----------
        public void LoadDanhsachVe()
        {
            try
            {
                dtg_main.DataSource = quanLyVeBLL.LoadListVe();

            } catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin" + ex , "Thông báo" , MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }
        }

        public void LoadDanhsachVePhim()
        {
            try
            {
                dtgvGiaVe.DataSource = quanLyVeBLL.LoadGiaVePhim();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin" + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // 
        void LoadLoaiMonAn()
        {
          
        }

        void LoadMonAnList()
        {
           
        }

        void LoadGiaVeList()
        {
           
        }

        void LoadVeBanList()
        {
           
        }



        

        private void btnThemVe_Click_2(object sender, EventArgs e)
        {

        }

        private void btnThemVe1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtMaVe.Text, out int mave))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng mã vé ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime ngayBan = dateNgayban.Value;

                if (!int.TryParse(txtTongTien.Text, out int tongTien))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng số cho tổng tiền!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string suatChieu = cb_suatChieu.Text;
                if (string.IsNullOrEmpty(suatChieu))
                {
                    MessageBox.Show("Vui lòng nhập mã suất chiếu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(cb_GiaVe.Text, out int giaVe))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng số cho giá vé!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(cb_Ghe.Text, out int ghe))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng số cho ghế!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string maNhanVien = cb_NhanVien.Text;
                if (string.IsNullOrEmpty(maNhanVien))
                {
                    MessageBox.Show("Vui lòng nhập mã nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Thêm vé vào bảng 've_ban'
                bool isAdded = quanLyVeBLL.AddNewVeBan(mave, ngayBan, tongTien, suatChieu, giaVe, ghe, maNhanVien);

                if (isAdded)
                {
                    // Lưu vào bảng hóa đơn nếu thêm vé thành công
                    bool isInvoiceAdded = quanLyVeBLL.AddHoaDon(mave, tongTien);

                    if (isInvoiceAdded)
                    {
                        MessageBox.Show("Thêm vé và hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhsachVe();
                    }
                    else
                    {
                        MessageBox.Show("Thêm vé thành công nhưng không thể tạo hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Thêm vé thất bại. Vui lòng kiểm tra lại thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


       


        private void btnSuaVe1_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (!int.TryParse(txtMaVe.Text, out int mave))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng mã vé", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                DateTime ngayBan = dateNgayban.Value;

               
                if (!int.TryParse(txtTongTien.Text, out int tongTien))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng số cho tổng tiền!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

               
                string suatChieu = cb_suatChieu.Text;
                if (string.IsNullOrEmpty(suatChieu))
                {
                    MessageBox.Show("Vui lòng nhập mã suất chiếu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

               
                if (!int.TryParse(cb_GiaVe.Text, out int giaVe))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng số cho giá vé!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

              
                if (!int.TryParse(cb_Ghe.Text, out int ghe))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng số cho ghế!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

              
                string maNhanVien = cb_NhanVien.Text;
                if (string.IsNullOrEmpty(maNhanVien))
                {
                    MessageBox.Show("Vui lòng nhập mã nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

             
                bool isUpdated = quanLyVeBLL.UpdateVeBan(mave, ngayBan, tongTien, suatChieu, giaVe, ghe, maNhanVien);

              
                if (isUpdated)
                {
                    MessageBox.Show("Cập nhật vé thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhsachVe(); 
                }
                else
                {
                    MessageBox.Show("Cập nhật vé thất bại. Vui lòng kiểm tra lại thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnXoaVe1_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (dtg_main.CurrentRow == null || dtg_main.CurrentRow.Index == -1)
                {
                    MessageBox.Show("Vui lòng chọn một vé để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            
                string maVe = dtg_main.CurrentRow.Cells["id"].Value.ToString();

               
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa vé này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                   
                    bool isDeleted = quanLyVeBLL.DeleteVeBan(maVe);

                    if (isDeleted)
                    {
                      
                        MessageBox.Show("Xóa vé thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhsachVe();  // Hàm này tải lại dữ liệu từ cơ sở dữ liệu và cập nhật DataGridView
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



        private void btnThemMon1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSuaMon1_Click(object sender, EventArgs e)
        {
           
        }

        private void dtg_main_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
              
                if (e.RowIndex >= 0)
                {
                  
                    DataGridViewRow row = dtg_main.Rows[e.RowIndex];

                   
                    txtMaVe.Text = row.Cells["id"].Value != DBNull.Value ? row.Cells["id"].Value.ToString() : string.Empty;

                    dateNgayban.Value = row.Cells["ngay_ban"].Value != DBNull.Value ? Convert.ToDateTime(row.Cells["ngay_ban"].Value) : DateTime.Now;

                    txtTongTien.Text = row.Cells["tong_tien"].Value != DBNull.Value ? row.Cells["tong_tien"].Value.ToString() : string.Empty;

                    cb_suatChieu.Text = row.Cells["suat_chieu_id"].Value != DBNull.Value ? row.Cells["suat_chieu_id"].Value.ToString() : string.Empty;

                    cb_GiaVe.Text = row.Cells["gia_ve_id"].Value != DBNull.Value ? row.Cells["gia_ve_id"].Value.ToString() : string.Empty;

                    cb_Ghe.Text = row.Cells["ghe_id"].Value != DBNull.Value ? row.Cells["ghe_id"].Value.ToString() : string.Empty;

                    cb_NhanVien.Text = row.Cells["nhan_vien_id"].Value != DBNull.Value ? row.Cells["nhan_vien_id"].Value.ToString() : string.Empty;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            LoadDataHoaDon();
            MessageBox.Show( "Đã tải lại thông tin hóa đơn ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            ThongKeHoaDon thongKeHoaDon = new ThongKeHoaDon();
            thongKeHoaDon.ShowDialog();
        }

      

        private void btnXoaMon1_Click(object sender, EventArgs e)
        {
          
        }

       
            private void btnTimVe_Click(object sender, EventArgs e)
           {
          
        }

        private void btnTimMonAn_Click(object sender, EventArgs e)
        {
           
        }

    }
}


