using BLL;
using QuanLyRapPhimv2.DTO;
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

namespace QuanLyRapPhimv2
{
    public partial class ManHinhKhachHang : Form
    {
        Database db = new Database();

        public DatVePhim_BLL datVeBLL;

        private Timer PhimTimer, gheTimer, giaVeTimer;
        public ManHinhKhachHang()
        {
            InitializeComponent();

          

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
            } catch(Exception ex)
            {
                MessageBox.Show("Lỗi thông tin : " + ex, "Thông báo " , MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }
        }


        //----------------------------------------------------------------------------------------------------------------------
        private void ManHinhKhachHang_Load(object sender, EventArgs e)
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
                              
            } catch(Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

          
        }


        private void btnXoaVe_Click(object sender, EventArgs e)
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
