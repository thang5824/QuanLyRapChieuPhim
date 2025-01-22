using QuanLyRapPhimv2.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapPhimv2
{
    public partial class fLogin : Form
    {

        Database db = new Database();
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }


        // code xử lý nút đăng nhập theo phân quyền --------------------------------------------------------------------------------------------------------
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text) || string.IsNullOrWhiteSpace(txtDangNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin để đăng nhập !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string connectionString = db.GetDatabase();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectData = "SELECT * FROM khach_hang WHERE email = @Email AND mat_khau = @matkhau";

                    using (SqlCommand cmd = new SqlCommand(selectData, connection))
                    {
                        cmd.Parameters.AddWithValue("@Email", txtDangNhap.Text.Trim());
                        cmd.Parameters.AddWithValue("@matkhau", txtMatKhau.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count == 1)
                        {
                          
                            int maPQ = Convert.ToInt32(table.Rows[0]["MaPQ"]);

                            if (maPQ == 1)
                            {
                                MessageBox.Show("Đăng nhập thành công !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                fManager manHinhChinh = new fManager();
                                manHinhChinh.Show();
                                this.Hide();
                            }
                            else if (maPQ == 3)
                            {
                                MessageBox.Show("Đăng nhập thành công!", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                ManHinhKhachHang khachhang = new ManHinhKhachHang();
                                khachhang.Show();
                                this.Hide();
                            } else if (maPQ == 2)
                            {
                                MessageBox.Show("Đăng nhập thành công!", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                NhanVien nhanvien = new NhanVien(); 
                                nhanvien.Show();
                                this.Hide();
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("Đăng nhập thất bại: Sai tên tài khoản hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối : " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        // --------------------------------------------------------------------------------------------------------
        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txtDangNhap_TextChanged(object sender, EventArgs e)
        {

        }
       
    }
}
