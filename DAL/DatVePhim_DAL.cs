using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DatVePhim_DAL
    {
        private string connectionString;

        public DatVePhim_DAL(string Dbconnection)
        {
            connectionString = Dbconnection;
        }

        public DataTable LoadDataDatVe()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM dat_ve";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dataTable);
            }
            return dataTable;
        }

        public bool InsertDatVe(string phimId, int gheNgoiId, DateTime thoiGianDat, int giaVeId, string trangThai)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO dat_ve (phim_id, ghe_ngoi_id, thoi_gian_dat, gia_ve_id, trang_thai) VALUES (@phimId, @gheNgoiId, @thoiGianDat, @giaVeId, @trangThai)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@phimId", phimId);
                    command.Parameters.AddWithValue("@gheNgoiId", gheNgoiId);
                    command.Parameters.AddWithValue("@thoiGianDat", thoiGianDat);
                    command.Parameters.AddWithValue("@giaVeId", giaVeId);
                    command.Parameters.AddWithValue("@trangThai", trangThai);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
        public bool UpdateDatVe(int id, string phimId, int gheNgoiId, DateTime thoiGianDat, int giaVeId, string trangThai)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE dat_ve SET phim_id = @phimId, ghe_ngoi_id = @gheNgoiId, thoi_gian_dat = @thoiGianDat, gia_ve_id = @giaVeId, trang_thai = @trangThai WHERE id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@phimId", phimId);
                    command.Parameters.AddWithValue("@gheNgoiId", gheNgoiId);
                    command.Parameters.AddWithValue("@thoiGianDat", thoiGianDat);
                    command.Parameters.AddWithValue("@giaVeId", giaVeId);
                    command.Parameters.AddWithValue("@trangThai", trangThai);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }


        public bool DeleteDatVe(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM dat_ve WHERE id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }






    }
}
