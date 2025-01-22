using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class QuanLyVe_DAL
    {
        private string connectionString;
        public QuanLyVe_DAL(string Dbconnection)
        {
            connectionString = Dbconnection;    
        }

        public DataTable LoadDataVe()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM ve_ban";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dataTable);
            }
            return dataTable;
        }

        public DataTable LoadDataHoaDon()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM hoa_don";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dataTable);
            }
            return dataTable;
        }

        public DataTable LoadDataGiaVePhim()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM gia_ve";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dataTable);
            }
            return dataTable;
        }
      
        public bool AddHoaDon(int maveban, int tongTien)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string AddQuery = "INSERT INTO hoa_don (id_ve, ngay_lap_hoa_don, tong_tien) " +
                                  "VALUES (@idVe, @ngayLapHoaDon, @tongTien)";

                SqlCommand addCommand = new SqlCommand(AddQuery, connection);
                addCommand.Parameters.AddWithValue("@idVe", maveban);
                addCommand.Parameters.AddWithValue("@ngayLapHoaDon", DateTime.Now);  // Ngày lập hóa đơn
                addCommand.Parameters.AddWithValue("@tongTien", tongTien);

                return addCommand.ExecuteNonQuery() > 0 ;
            }
        }


        public bool AddVeMua(int maveban,DateTime ngayBan, int tongTien, string suatChieu, int giaVe, int ghe, string maNhanVien)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string AddQuery = "INSERT INTO ve_ban (id, ngay_ban, tong_tien, suat_chieu_id, gia_ve_id, ghe_id, nhan_vien_id) " +
                                  "VALUES (@id, @ngayban, @tongTien, @suatChieu, @giave, @Ghe, @NhanVien)";

                SqlCommand addcommand = new SqlCommand(AddQuery, connection);
                addcommand.Parameters.AddWithValue("@id", maveban); 
                addcommand.Parameters.AddWithValue("@ngayban", ngayBan);
                addcommand.Parameters.AddWithValue("@tongTien", tongTien);
                addcommand.Parameters.AddWithValue("@suatChieu", suatChieu);
                addcommand.Parameters.AddWithValue("@NhanVien", maNhanVien);
                addcommand.Parameters.AddWithValue("@giave", giaVe);
                addcommand.Parameters.AddWithValue("@Ghe", ghe);

                return addcommand.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateVeBanInDb(int maveBan, DateTime ngayBan, int tongTien, string suatChieu, int giaVe, int ghe, string maNhanVien)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string updateQuery = "UPDATE ve_ban SET ngay_ban = @ngayban, tong_tien = @tongTien, suat_chieu_id = @suatChieu, gia_ve_id = @giave, ghe_id = @Ghe, nhan_vien_id = @NhanVien " +
                                     "WHERE id = @id";

                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);

              
                updateCommand.Parameters.AddWithValue("@id", maveBan);
                updateCommand.Parameters.AddWithValue("@ngayban", ngayBan);
                updateCommand.Parameters.AddWithValue("@tongTien", tongTien);
                updateCommand.Parameters.AddWithValue("@suatChieu", suatChieu);
                updateCommand.Parameters.AddWithValue("@giave", giaVe);
                updateCommand.Parameters.AddWithValue("@Ghe", ghe);
                updateCommand.Parameters.AddWithValue("@NhanVien", maNhanVien);

                return updateCommand.ExecuteNonQuery() > 0; 
            }
        }
        public bool DeleteVeMua(string maVe)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string deleteQuery = "DELETE FROM ve_ban WHERE id = @id";

                SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                deleteCommand.Parameters.AddWithValue("@id", maVe);

                return deleteCommand.ExecuteNonQuery() > 0;
            }
        }




    }
}
