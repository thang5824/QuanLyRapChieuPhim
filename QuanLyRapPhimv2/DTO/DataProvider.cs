using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhimv2.DAO
{
    public class DataProvider
    {
        private string connectionSTR = "Data Source=HUYNHTHANG\\SQLEXPRESS;Initial Catalog=QuanlyRapChieuPhimV2;Integrated Security=True";



        // Phương thức để thực thi truy vấn trả về dữ liệu
        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();

            // Sử dụng `using` để tự động đóng kết nối
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                // Mở kết nối
                connection.Open();

                // Tạo SqlCommand
                SqlCommand command = new SqlCommand(query, connection);

                // Tạo SqlDataAdapter để điền dữ liệu
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                // Điền dữ liệu vào DataTable
                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        // Phương thức để thực thi truy vấn không trả về dữ liệu
        public int ExecuteNonQuery(string query)
        {
            int result = 0;

            // Sử dụng `using` để tự động đóng kết nối
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                // Mở kết nối
                connection.Open();

                // Tạo SqlCommand
                SqlCommand command = new SqlCommand(query, connection);

                // Thực thi truy vấn và trả về số dòng bị ảnh hưởng
                result = command.ExecuteNonQuery();

                connection.Close();
            }

            return result;
        }
    }
}
