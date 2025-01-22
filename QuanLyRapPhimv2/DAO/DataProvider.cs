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
        private string connectionSTR = "Data Source=HuynhThang\\SQLEXPRESS;Initial Catalog=QuanLyRap;Integrated Security=True";

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
    }
}
