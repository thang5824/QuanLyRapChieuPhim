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
    public partial class ThongKeHoaDon : Form
    {
        private string connectionString = "Data Source=HUYNHTHANG\\SQLEXPRESS;Initial Catalog=QuanlyRapChieuPhimV2;Integrated Security=True";

        Database db = new Database();
        public ThongKeHoaDon()
        {
            InitializeComponent();
            DisplayDoanhThuChart();
        }

        private void ThongKeHoaDon_Load(object sender, EventArgs e)
        {
            DisplayDoanhThuChart();
        }
        private void DisplayDoanhThuChart()
        {
            try
            {
              
                DataTable data = GetDoanhThuTheoThang();

               
                chartDoanhThu.Series.Clear();

              
                var series = new System.Windows.Forms.DataVisualization.Charting.Series
                {
                    Name = "Tổng tiền bán vé",
                    IsVisibleInLegend = true,
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column  // Biểu đồ cột
                };

              
                foreach (DataRow row in data.Rows)
                {
                    string ngayLapHoaDon = row["NgayLapHoaDon"].ToString();
                    decimal tongTien = Convert.ToDecimal(row["TongTien"]);

                  
                    series.Points.AddXY(ngayLapHoaDon, tongTien);

                   
                    series.Points[series.Points.Count - 1].Label = tongTien.ToString("N0") + " VNĐ";  // "N0" định dạng không có phần thập phân
                }

               
                chartDoanhThu.Series.Add(series);

             
                chartDoanhThu.ChartAreas[0].AxisX.Title = "Ngày";
                chartDoanhThu.ChartAreas[0].AxisY.Title = "Tổng Tiền (VND)";
                chartDoanhThu.ChartAreas[0].AxisX.LabelStyle.Angle = -45;  

              
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị biểu đồ: " + ex.Message);
            }
        }

        private DataTable GetDoanhThuTheoThang()
        {
            DataTable dt = new DataTable();

           
            int currentMonth = DateTime.Now.Month;
            int currentYear = DateTime.Now.Year;

          
            string query = @"
                SELECT 
                    DAY(ngay_lap_hoa_don) AS NgayLapHoaDon, 
                    SUM(tong_tien) AS TongTien
                FROM hoa_don
                WHERE YEAR(ngay_lap_hoa_don) = @year AND MONTH(ngay_lap_hoa_don) = @month
                GROUP BY DAY(ngay_lap_hoa_don)
                ORDER BY NgayLapHoaDon";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@year", currentYear);
                adapter.SelectCommand.Parameters.AddWithValue("@month", currentMonth);

                // Điền dữ liệu vào DataTable
                adapter.Fill(dt);
            }

            return dt;
        }
    }
}
